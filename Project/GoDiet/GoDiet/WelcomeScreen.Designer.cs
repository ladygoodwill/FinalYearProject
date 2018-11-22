namespace GoDiet
{
    partial class WelcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.logoPic = new System.Windows.Forms.PictureBox();
            this.avatarChangeBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.PrimaryInformation = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.RemoveAccountBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.GoDietLogo = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            this.PrimaryInformation.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoDietLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.logoPic);
            this.flowLayoutPanel1.Controls.Add(this.avatarChangeBtn);
            this.flowLayoutPanel1.Controls.Add(this.BackBtn);
            this.flowLayoutPanel1.Controls.Add(this.PrimaryInformation);
            this.flowLayoutPanel1.Controls.Add(this.RemoveAccountBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 15);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(278, 588);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // logoPic
            // 
            this.logoPic.Image = ((System.Drawing.Image)(resources.GetObject("logoPic.Image")));
            this.logoPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoPic.InitialImage")));
            this.logoPic.Location = new System.Drawing.Point(3, 3);
            this.logoPic.Name = "logoPic";
            this.logoPic.Size = new System.Drawing.Size(146, 129);
            this.logoPic.TabIndex = 0;
            this.logoPic.TabStop = false;
            // 
            // avatarChangeBtn
            // 
            this.avatarChangeBtn.Location = new System.Drawing.Point(155, 3);
            this.avatarChangeBtn.Name = "avatarChangeBtn";
            this.avatarChangeBtn.Size = new System.Drawing.Size(75, 66);
            this.avatarChangeBtn.TabIndex = 24;
            this.avatarChangeBtn.Text = "Avatar Change";
            this.avatarChangeBtn.UseVisualStyleBackColor = true;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Lavender;
            this.BackBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.BackBtn.FlatAppearance.BorderSize = 2;
            this.BackBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BackBtn.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackBtn.Image = ((System.Drawing.Image)(resources.GetObject("BackBtn.Image")));
            this.BackBtn.Location = new System.Drawing.Point(236, 3);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(32, 32);
            this.BackBtn.TabIndex = 23;
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // PrimaryInformation
            // 
            this.PrimaryInformation.AllowDrop = true;
            this.PrimaryInformation.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.PrimaryInformation.Controls.Add(this.tabPage1);
            this.PrimaryInformation.Controls.Add(this.tabPage2);
            this.PrimaryInformation.Controls.Add(this.tabPage3);
            this.flowLayoutPanel1.SetFlowBreak(this.PrimaryInformation, true);
            this.PrimaryInformation.HotTrack = true;
            this.PrimaryInformation.Location = new System.Drawing.Point(3, 138);
            this.PrimaryInformation.Multiline = true;
            this.PrimaryInformation.Name = "PrimaryInformation";
            this.PrimaryInformation.RightToLeftLayout = true;
            this.PrimaryInformation.SelectedIndex = 0;
            this.PrimaryInformation.ShowToolTips = true;
            this.PrimaryInformation.Size = new System.Drawing.Size(262, 390);
            this.PrimaryInformation.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(254, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Activity";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.GenderBox);
            this.tabPage2.Controls.Add(this.radioButton2);
            this.tabPage2.Controls.Add(this.radioButton1);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(254, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(115, 264);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(115, 234);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "New Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Old Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password Change";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GenderBox
            // 
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderBox.Location = new System.Drawing.Point(83, 166);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(121, 24);
            this.GenderBox.TabIndex = 8;
            this.GenderBox.SelectedIndexChanged += new System.EventHandler(this.GenderBox_SelectedIndexChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(91, 132);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 21);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 132);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 21);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yes";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Are You vegetarian?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forname";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(254, 358);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Options88";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // RemoveAccountBtn
            // 
            this.RemoveAccountBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemoveAccountBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.RemoveAccountBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.RemoveAccountBtn.FlatAppearance.BorderSize = 2;
            this.RemoveAccountBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RemoveAccountBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.RemoveAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveAccountBtn.Font = new System.Drawing.Font("Roboto", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveAccountBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RemoveAccountBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RemoveAccountBtn.Location = new System.Drawing.Point(3, 534);
            this.RemoveAccountBtn.Name = "RemoveAccountBtn";
            this.RemoveAccountBtn.Size = new System.Drawing.Size(89, 32);
            this.RemoveAccountBtn.TabIndex = 9;
            this.RemoveAccountBtn.Text = "Remove";
            this.RemoveAccountBtn.UseVisualStyleBackColor = false;
            this.RemoveAccountBtn.Click += new System.EventHandler(this.RemoveAccountBtn_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.monthCalendar1);
            this.flowLayoutPanel2.Controls.Add(this.richTextBox1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(670, 15);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(325, 587);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 228);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(291, 338);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Alalala mama hiash asjkf hjsgdf";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // GoDietLogo
            // 
            this.GoDietLogo.Image = ((System.Drawing.Image)(resources.GetObject("GoDietLogo.Image")));
            this.GoDietLogo.Location = new System.Drawing.Point(303, 15);
            this.GoDietLogo.Name = "GoDietLogo";
            this.GoDietLogo.Size = new System.Drawing.Size(340, 132);
            this.GoDietLogo.TabIndex = 3;
            this.GoDietLogo.TabStop = false;
            this.GoDietLogo.Resize += new System.EventHandler(this.WelcomeScreen_Load);
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1025, 615);
            this.Controls.Add(this.GoDietLogo);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "WelcomeScreen";
            this.Text = "WelcomeScreen";
            this.Load += new System.EventHandler(this.WelcomeScreen_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            this.PrimaryInformation.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GoDietLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox logoPic;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PictureBox GoDietLogo;
        private System.Windows.Forms.TabControl PrimaryInformation;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button RemoveAccountBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.Button avatarChangeBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}