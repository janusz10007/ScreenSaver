using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security.Permissions;
using System.Net;
using Newtonsoft.Json;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json.Linq;
using System.IO;

namespace ScreenSaver
{
    public partial class SettingsForm : Form
    {

        String Dir;

        public SettingsForm()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\SmartScreensaver");
            setDirectory();

            if (key == null)
            {
                textBox.Text = "Lodz";
                domainUpDown1.Text = "metric";
                buttonFont.BackColor = Color.White;
                buttonBackground.BackColor = Color.Black;
                checkNote.Checked = true;
                checkQuote.Checked = true;
                checkTime.Checked = true;
                checkWeather.Checked = true;
            }

            else
            {
                textBox.Text = (string)key.GetValue("text");
                domainUpDown1.Text = (string)key.GetValue("units");
                buttonFont.BackColor = Color.FromName((string)key.GetValue("fontColor"));
                buttonBackground.BackColor = Color.FromName((string)key.GetValue("backColor"));
                checkNote.Checked = bool.Parse((string)key.GetValue("showNote"));
                checkQuote.Checked = bool.Parse((string)key.GetValue("showQuote"));
                checkTime.Checked = bool.Parse((string)key.GetValue("showTime"));
                checkWeather.Checked = bool.Parse((string)key.GetValue("showWeather"));
                if (File.Exists(Dir + "\\ScreenSaver\\note.txt"))
                {
                    GetNoteData();
                }

                else
                {
                    Directory.CreateDirectory(Dir + "\\ScreenSaver");
                    File.Create(Dir + "\\ScreenSaver\\note.txt");
                }

            }
        }

        private void setDirectory()
        {
            Dir = Directory.GetCurrentDirectory();
            Dir.Substring(0, Dir.Length - 7);
            Dir = Dir + "Program Files";
        }

        private void GetNoteData()
        {
            string note;
            StreamReader sr = new StreamReader(Dir + "\\ScreenSaver\\note.txt");
            note = sr.ReadLine();
            while (note != null)
            {
                noteTextBox.Text += note;
                note = sr.ReadLine();
            }
            sr.Close();
        }

        private void SaveSettings()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\SmartScreensaver");

            key.SetValue("text", textBox.Text);
            key.SetValue("units", domainUpDown1.Text);
            key.SetValue("fontColor", buttonFont.BackColor.Name.ToString());
            key.SetValue("backColor", buttonBackground.BackColor.Name.ToString());
            key.SetValue("showTime", checkTime.Checked.ToString());
            key.SetValue("showWeather", checkWeather.Checked.ToString());
            key.SetValue("showQuote", checkQuote.Checked.ToString());
            key.SetValue("showNote", checkNote.Checked.ToString());
            setNoteData();
        }

        private void setNoteData()
        {
            File.WriteAllText(Dir + "\\ScreenSaver\\note.txt", noteTextBox.Text);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonBackground_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AllowFullOpen = false;
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;
            colorDlg.Color = Color.Black;

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                buttonBackground.BackColor = colorDlg.Color;
            }
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AllowFullOpen = false;
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;
            colorDlg.Color = Color.White;

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                buttonFont.BackColor = colorDlg.Color;
            }
        }

    }
}
