namespace ScreenSaver
{
    partial class ScreenSaverForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.textLabel = new System.Windows.Forms.Label();
            this.quote = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.temperature = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.weatherType = new System.Windows.Forms.PictureBox();
            this.Note = new System.Windows.Forms.Label();
            this.weatherTimer = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherType)).BeginInit();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textLabel.ForeColor = System.Drawing.Color.White;
            this.textLabel.Location = new System.Drawing.Point(3, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(652, 59);
            this.textLabel.TabIndex = 0;
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quote
            // 
            this.quote.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.quote.ForeColor = System.Drawing.Color.White;
            this.quote.Location = new System.Drawing.Point(3, 195);
            this.quote.Name = "quote";
            this.quote.Size = new System.Drawing.Size(652, 114);
            this.quote.TabIndex = 1;
            this.quote.Text = "quote";
            this.quote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // author
            // 
            this.author.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.author.ForeColor = System.Drawing.Color.White;
            this.author.Location = new System.Drawing.Point(3, 309);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(652, 50);
            this.author.TabIndex = 2;
            this.author.Text = "author";
            this.author.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temperature
            // 
            this.temperature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.temperature.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.temperature.ForeColor = System.Drawing.Color.White;
            this.temperature.Location = new System.Drawing.Point(3, 83);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(327, 87);
            this.temperature.TabIndex = 4;
            this.temperature.Text = "temperature";
            this.temperature.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.textLabel);
            this.flowLayoutPanel1.Controls.Add(this.temperature);
            this.flowLayoutPanel1.Controls.Add(this.weatherType);
            this.flowLayoutPanel1.Controls.Add(this.quote);
            this.flowLayoutPanel1.Controls.Add(this.author);
            this.flowLayoutPanel1.Controls.Add(this.Note);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(124, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(655, 499);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // weatherType
            // 
            this.weatherType.Image = global::ScreenSaver.Properties.Resources._01d;
            this.weatherType.Location = new System.Drawing.Point(336, 62);
            this.weatherType.Name = "weatherType";
            this.weatherType.Size = new System.Drawing.Size(158, 130);
            this.weatherType.TabIndex = 5;
            this.weatherType.TabStop = false;
            // 
            // Note
            // 
            this.Note.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Note.ForeColor = System.Drawing.Color.White;
            this.Note.Location = new System.Drawing.Point(3, 359);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(652, 114);
            this.Note.TabIndex = 6;
            this.Note.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ScreenSaverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(836, 554);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenSaverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ScreenSaverForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ScreenSaverForm_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ScreenSaverForm_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScreenSaverForm_MouseMove);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.weatherType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.Label temperature;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label quote;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox weatherType;
        private System.Windows.Forms.Timer weatherTimer;
        private System.Windows.Forms.Label Note;
    }
}

