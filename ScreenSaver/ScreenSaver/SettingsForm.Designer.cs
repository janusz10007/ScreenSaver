namespace ScreenSaver
{
    partial class SettingsForm
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.buttonBackground = new System.Windows.Forms.Button();
            this.buttonFont = new System.Windows.Forms.Button();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkTime = new System.Windows.Forms.CheckBox();
            this.checkWeather = new System.Windows.Forms.CheckBox();
            this.checkQuote = new System.Windows.Forms.CheckBox();
            this.checkNote = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(20, 63);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(190, 20);
            this.textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Smart Screensaver";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lokalizacja:";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(20, 446);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(135, 446);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Jednostki:";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("imperial");
            this.domainUpDown1.Items.Add("metric");
            this.domainUpDown1.Location = new System.Drawing.Point(20, 115);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(193, 20);
            this.domainUpDown1.TabIndex = 8;
            // 
            // buttonBackground
            // 
            this.buttonBackground.Location = new System.Drawing.Point(20, 291);
            this.buttonBackground.Name = "buttonBackground";
            this.buttonBackground.Size = new System.Drawing.Size(81, 23);
            this.buttonBackground.TabIndex = 9;
            this.buttonBackground.Text = "kolor tła";
            this.buttonBackground.UseVisualStyleBackColor = true;
            this.buttonBackground.Click += new System.EventHandler(this.buttonBackground_Click);
            // 
            // buttonFont
            // 
            this.buttonFont.Location = new System.Drawing.Point(129, 291);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(81, 23);
            this.buttonFont.TabIndex = 10;
            this.buttonFont.Text = "kolor czcionki";
            this.buttonFont.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(20, 166);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(190, 101);
            this.noteTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "treść notatki:";
            // 
            // checkTime
            // 
            this.checkTime.AutoSize = true;
            this.checkTime.Location = new System.Drawing.Point(6, 25);
            this.checkTime.Name = "checkTime";
            this.checkTime.Size = new System.Drawing.Size(63, 17);
            this.checkTime.TabIndex = 13;
            this.checkTime.Text = "godzina";
            this.checkTime.UseVisualStyleBackColor = true;
            // 
            // checkWeather
            // 
            this.checkWeather.AutoSize = true;
            this.checkWeather.Location = new System.Drawing.Point(114, 25);
            this.checkWeather.Name = "checkWeather";
            this.checkWeather.Size = new System.Drawing.Size(62, 17);
            this.checkWeather.TabIndex = 14;
            this.checkWeather.Text = "pogoda";
            this.checkWeather.UseVisualStyleBackColor = true;
            // 
            // checkQuote
            // 
            this.checkQuote.AutoSize = true;
            this.checkQuote.Location = new System.Drawing.Point(6, 65);
            this.checkQuote.Name = "checkQuote";
            this.checkQuote.Size = new System.Drawing.Size(49, 17);
            this.checkQuote.TabIndex = 15;
            this.checkQuote.Text = "cytat";
            this.checkQuote.UseVisualStyleBackColor = true;
            // 
            // checkNote
            // 
            this.checkNote.AutoSize = true;
            this.checkNote.Location = new System.Drawing.Point(114, 65);
            this.checkNote.Name = "checkNote";
            this.checkNote.Size = new System.Drawing.Size(62, 17);
            this.checkNote.TabIndex = 16;
            this.checkNote.Text = "notatka";
            this.checkNote.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkTime);
            this.groupBox1.Controls.Add(this.checkNote);
            this.groupBox1.Controls.Add(this.checkQuote);
            this.groupBox1.Controls.Add(this.checkWeather);
            this.groupBox1.Location = new System.Drawing.Point(20, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "wyświetlanie";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 481);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.buttonFont);
            this.Controls.Add(this.buttonBackground);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "ScreenSaver Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Button buttonBackground;
        private System.Windows.Forms.Button buttonFont;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkTime;
        private System.Windows.Forms.CheckBox checkWeather;
        private System.Windows.Forms.CheckBox checkQuote;
        private System.Windows.Forms.CheckBox checkNote;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}