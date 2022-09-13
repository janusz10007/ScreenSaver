using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Resources;
using ScreenSaver.Properties;
using System.IO;

namespace ScreenSaver
{
    public partial class ScreenSaverForm : Form
    {
        #region Win32 API functions

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);

        #endregion


        private Point mouseLocation;
        private bool previewMode = false;
        private Random rand = new Random();
        Quote quote_ = new Quote();
        WeatherParameters par_ = new WeatherParameters();
        private string weatherAPI = Resources.WeatherApi;
        private string location = "";
        private string units = "metric";
        private string unitString = "°C";
        private string CurrentUrl = "";

        public ScreenSaverForm()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
        }

        public ScreenSaverForm(Rectangle Bounds)
        {
            InitializeComponent();
            this.Bounds = Bounds;
        }

        public ScreenSaverForm(IntPtr PreviewWndHandle)
        {
            InitializeComponent();

            // Set the preview window as the parent of this window
            SetParent(this.Handle, PreviewWndHandle);

            // Make this a child window so it will close when the parent dialog closes
            SetWindowLong(this.Handle, -16, new IntPtr(GetWindowLong(this.Handle, -16) | 0x40000000));

            // Place our window inside the parent
            Rectangle ParentRect;
            GetClientRect(PreviewWndHandle, out ParentRect);
            Size = ParentRect.Size;
            Location = new Point(0, 0);

            // Make text smaller
            textLabel.Font = new System.Drawing.Font("Arial", 6);

            previewMode = false;

        }

        public class Quote
        {
            public string Description { get; set; }
            public string Author { get; set; }
        }

        public class WeatherParameters
        {
            public string weather { get; set; }
            public int temp { get; set; }
        }

        private void setQuote()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            var json = "";
            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString("https://zenquotes.io/api/today");
            }

            dynamic data = JArray.Parse(json);
            dynamic data1 = JObject.Parse(data[0].ToString());
            quote_.Author = data1.a;
            quote_.Description = data1.q;

            quote.Text = '"' + quote_.Description + '"';
            author.Text = quote_.Author;

        }

        private void setWeather()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            var json = "";

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString(CurrentUrl);
            }

            dynamic data1 = JObject.Parse(json);
            dynamic data = JArray.Parse(data1.weather.ToString());
            dynamic data_ = JObject.Parse(data[0].ToString());

            par_.weather = data_.icon;
            par_.temp = (int)data1.main.temp;

            if (units == "metric")
                unitString = "°C";
            else
                unitString = "°F";

            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            string resourceName = asm.GetName().Name + ".Properties.Resources";
            var rm = new ResourceManager(resourceName, asm);
            weatherType.Image = (Bitmap)rm.GetObject(par_.weather);

            temperature.Text = par_.temp.ToString() + unitString;
        }

        private void setWeatherAPI()
        {
            CurrentUrl = "http://api.openweathermap.org/data/2.5/weather?" +
            "q=" + location + "&mode=json&units=" + units + "&APPID=" + weatherAPI;
        }

        private void setFlowLayoutPanel()
        {
            flowLayoutPanel1.Left = (Bounds.Width / 2) - (flowLayoutPanel1.Width / 2);
            flowLayoutPanel1.Top = (Bounds.Height / 2) - (flowLayoutPanel1.Height / 2);
        }

        private void ScreenSaverForm_Load(object sender, EventArgs e)
        {
            LoadSettings();

            textLabel.Text = DateTime.Now.ToLongTimeString();

            setFlowLayoutPanel();
            setQuote();
            setWeatherAPI();
            setWeather();
            setNote();

            weatherTimer.Interval = 50000;
            weatherTimer.Tick += new EventHandler(updateWeather);
            weatherTimer.Start();

            Cursor.Hide();
            TopMost = true;

            moveTimer.Interval = 1000;
            moveTimer.Tick += new EventHandler(moveTimer_Tick);
            moveTimer.Start();
        }

        private void updateWeather(object sender, System.EventArgs e)
        {
            setWeather();
        }

        private void moveTimer_Tick(object sender, System.EventArgs e)
        {
            textLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void LoadSettings()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\SmartScreensaver");
            if (key == null)
            {
                location = "Lodz";
                units = "metric";
                setFontColor(Color.White);
                BackColor = Color.Black;
                ShowNote(false);
                ShowQuote(true);
                ShowTime(true);
                ShowWeather(true);
            }
            else
            {
                location = (string)key.GetValue("text");
                units = (string)key.GetValue("units");
                setFontColor(Color.FromName((string)key.GetValue("fontColor")));
                BackColor = Color.FromName((string)key.GetValue("backColor"));
                setVisibility();
            }
        }

        private void setVisibility()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\SmartScreensaver");
            if (key != null)
            {
                ShowNote(bool.Parse((string)key.GetValue("showNote")));
                ShowQuote(bool.Parse((string)key.GetValue("showQuote")));
                ShowTime(bool.Parse((string)key.GetValue("showTime")));
                ShowWeather(bool.Parse((string)key.GetValue("showWeather")));
            }
        }

        private void setFontColor(Color c)
        {
            textLabel.ForeColor = c;
            temperature.ForeColor = c;
            quote.ForeColor = c;
            author.ForeColor = c;
            Note.ForeColor = c;
        }

        void ShowNote(bool par)
        {
            if (par)
                Note.Visible = true;

            else
                Note.Visible = false;
        }

        private void ShowTime(bool par)
        {
            if (par)
                textLabel.Visible = true;

            else
                textLabel.Visible = false;
        }

        private void ShowWeather(bool par)
        {
            if (par)
            {
                temperature.Visible = true;
                weatherType.Visible = true;
            }

            else
            {
                temperature.Visible = false;
                weatherType.Visible = false;
            }
        }

        private void ShowQuote(bool par)
        {
            if (par)
            {
                quote.Visible = true;
                author.Visible = true;
            }

            else
            {
                quote.Visible = false;
                author.Visible = false;
            }

        }

        private void setNote()
        {
            string note;
            StreamReader sr = new StreamReader("C:\\ScreenSaver\\note.txt");
            note = sr.ReadLine();
            while (note != null)
            {
                Note.Text += note;
                note = sr.ReadLine();
            }
            sr.Close();
        }

        private void ScreenSaverForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!previewMode)
            {
                if (!mouseLocation.IsEmpty)
                {
                    if (Math.Abs(mouseLocation.X - e.X) > 5 ||
                        Math.Abs(mouseLocation.Y - e.Y) > 5)
                        Application.Exit();
                }
                mouseLocation = e.Location;
            }
        }

        private void ScreenSaverForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!previewMode)
                Application.Exit();
        }

        private void ScreenSaverForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (!previewMode)
                Application.Exit();
        }
    }
}
