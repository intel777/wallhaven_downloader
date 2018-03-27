namespace Wallhaven.cc_Downloader___Windows_Edition
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.logGroupBox = new System.Windows.Forms.GroupBox();
            this.downloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.controlGroupBox = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.settingsGroupBox.SuspendLayout();
            this.logGroupBox.SuspendLayout();
            this.controlGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(152, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(6, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(91, 13);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Amount of pictures:";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(6, 16);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(270, 151);
            this.logBox.TabIndex = 7;
            this.logBox.Text = "wallhaven.cc downloader\nVersion: 0.6 Public Beta\nDefault save folder: /wallhaven";
            this.logBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "From start",
            "From user uploads",
            "From user favourites",
            "Random"});
            this.comboBox1.Location = new System.Drawing.Point(152, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox4.Location = new System.Drawing.Point(6, 45);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(91, 13);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "Picture selection:";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox5.Location = new System.Drawing.Point(6, 72);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(68, 13);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "Save folder:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 12;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.textBox8);
            this.settingsGroupBox.Controls.Add(this.textBox7);
            this.settingsGroupBox.Controls.Add(this.textBox6);
            this.settingsGroupBox.Controls.Add(this.textBox3);
            this.settingsGroupBox.Controls.Add(this.checkBox1);
            this.settingsGroupBox.Controls.Add(this.button4);
            this.settingsGroupBox.Controls.Add(this.button3);
            this.settingsGroupBox.Controls.Add(this.textBox2);
            this.settingsGroupBox.Controls.Add(this.textBox1);
            this.settingsGroupBox.Controls.Add(this.comboBox1);
            this.settingsGroupBox.Controls.Add(this.textBox5);
            this.settingsGroupBox.Controls.Add(this.textBox4);
            this.settingsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(258, 140);
            this.settingsGroupBox.TabIndex = 13;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Settings";
            this.settingsGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox8
            // 
            this.textBox8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox8.Location = new System.Drawing.Point(177, 101);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(75, 20);
            this.textBox8.TabIndex = 17;
            this.textBox8.Text = "Collection ID";
            this.textBox8.Visible = false;
            this.textBox8.Enter += new System.EventHandler(this.textBox8_enter);
            // 
            // textBox7
            // 
            this.textBox7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox7.Location = new System.Drawing.Point(80, 101);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(91, 20);
            this.textBox7.TabIndex = 16;
            this.textBox7.Text = "Amount of Pictures";
            this.textBox7.Visible = false;
            this.textBox7.Enter += new System.EventHandler(this.textBox7_enter);
            // 
            // textBox6
            // 
            this.textBox6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox6.Location = new System.Drawing.Point(6, 101);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(68, 20);
            this.textBox6.TabIndex = 15;
            this.textBox6.Text = "Username";
            this.textBox6.Visible = false;
            this.textBox6.Enter += new System.EventHandler(this.textBox6_enter);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 114);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(91, 20);
            this.textBox3.TabIndex = 14;
            this.textBox3.Visible = false;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_keyPress);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 91);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Manual Start ID:";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Image = global::Wallhaven.cc_Downloader___Windows_Edition.Properties.Resources.folder_4_256x256_converted1;
            this.button4.Location = new System.Drawing.Point(218, 67);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 23);
            this.button4.TabIndex = 12;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(151, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Select...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // logGroupBox
            // 
            this.logGroupBox.Controls.Add(this.downloadProgressBar);
            this.logGroupBox.Controls.Add(this.logBox);
            this.logGroupBox.Location = new System.Drawing.Point(276, 12);
            this.logGroupBox.Name = "logGroupBox";
            this.logGroupBox.Size = new System.Drawing.Size(282, 204);
            this.logGroupBox.TabIndex = 14;
            this.logGroupBox.TabStop = false;
            this.logGroupBox.Text = "Log";
            // 
            // downloadProgressBar
            // 
            this.downloadProgressBar.Location = new System.Drawing.Point(6, 173);
            this.downloadProgressBar.Name = "downloadProgressBar";
            this.downloadProgressBar.Size = new System.Drawing.Size(270, 23);
            this.downloadProgressBar.TabIndex = 8;
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.Controls.Add(this.button5);
            this.controlGroupBox.Controls.Add(this.button1);
            this.controlGroupBox.Controls.Add(this.button2);
            this.controlGroupBox.Location = new System.Drawing.Point(12, 150);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Size = new System.Drawing.Size(258, 65);
            this.controlGroupBox.TabIndex = 15;
            this.controlGroupBox.TabStop = false;
            this.controlGroupBox.Text = "Control";
            this.controlGroupBox.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(176, 18);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 37);
            this.button5.TabIndex = 13;
            this.button5.Text = "Check for updates";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 227);
            this.Controls.Add(this.controlGroupBox);
            this.Controls.Add(this.logGroupBox);
            this.Controls.Add(this.settingsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wallhaven.cc Downloader - Windows Edition";
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            this.logGroupBox.ResumeLayout(false);
            this.controlGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.GroupBox logGroupBox;
        private System.Windows.Forms.GroupBox controlGroupBox;
        private System.Windows.Forms.ProgressBar downloadProgressBar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button5;
    }
}

