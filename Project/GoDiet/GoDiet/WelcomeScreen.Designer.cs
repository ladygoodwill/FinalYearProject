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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.logoPic = new System.Windows.Forms.PictureBox();
            this.avatarChangeBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.PrimaryInformation = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.intakeBox = new System.Windows.Forms.TextBox();
            this.userNlbl = new System.Windows.Forms.Label();
            this.unameBox = new System.Windows.Forms.TextBox();
            this.kgBox = new System.Windows.Forms.TextBox();
            this.caloriesLbl = new System.Windows.Forms.Label();
            this.weoghtLbl = new System.Windows.Forms.Label();
            this.BMIBox = new System.Windows.Forms.TextBox();
            this.dietLbl = new System.Windows.Forms.Label();
            this.bmiLbl = new System.Windows.Forms.Label();
            this.dietModeBox = new System.Windows.Forms.TextBox();
            this.kgLbl = new System.Windows.Forms.Label();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.newPasswBox = new System.Windows.Forms.TextBox();
            this.oldPasswBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.noRadioBtn = new System.Windows.Forms.RadioButton();
            this.yesRadioBtn = new System.Windows.Forms.RadioButton();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.currentWeightLossLbl = new System.Windows.Forms.Label();
            this.currentLossChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RemoveAccountBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.GoDietLogo = new System.Windows.Forms.PictureBox();
            this.dietPlanBtn = new System.Windows.Forms.Button();
            this.weightUpdateBtn = new System.Windows.Forms.Button();
            this.predictedProgressWeightLossLbl = new System.Windows.Forms.Label();
            this.predictionWeightLoss = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.currentBtnRefresh = new System.Windows.Forms.Button();
            this.predictedBtnRefresh = new System.Windows.Forms.Button();
            this.recipesRichBox = new System.Windows.Forms.RichTextBox();
            this.tblVegeRecipiesTableAdapter1 = new GoDiet.GoDietCustInfoDataSetTableAdapters.tblVegeRecipiesTableAdapter();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            this.PrimaryInformation.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentLossChart)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoDietLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predictionWeightLoss)).BeginInit();
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
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
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
            this.avatarChangeBtn.Size = new System.Drawing.Size(75, 46);
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
            this.tabPage1.Controls.Add(this.intakeBox);
            this.tabPage1.Controls.Add(this.userNlbl);
            this.tabPage1.Controls.Add(this.unameBox);
            this.tabPage1.Controls.Add(this.kgBox);
            this.tabPage1.Controls.Add(this.caloriesLbl);
            this.tabPage1.Controls.Add(this.weoghtLbl);
            this.tabPage1.Controls.Add(this.BMIBox);
            this.tabPage1.Controls.Add(this.dietLbl);
            this.tabPage1.Controls.Add(this.bmiLbl);
            this.tabPage1.Controls.Add(this.dietModeBox);
            this.tabPage1.Controls.Add(this.kgLbl);
            this.tabPage1.Controls.Add(this.weightBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(254, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Activity";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // intakeBox
            // 
            this.intakeBox.Enabled = false;
            this.intakeBox.Location = new System.Drawing.Point(168, 199);
            this.intakeBox.Name = "intakeBox";
            this.intakeBox.Size = new System.Drawing.Size(71, 22);
            this.intakeBox.TabIndex = 5;
            this.intakeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.intakeBox.TextChanged += new System.EventHandler(this.intakeBox_TextChanged);
            // 
            // userNlbl
            // 
            this.userNlbl.AutoSize = true;
            this.userNlbl.Location = new System.Drawing.Point(9, 18);
            this.userNlbl.Name = "userNlbl";
            this.userNlbl.Size = new System.Drawing.Size(111, 17);
            this.userNlbl.TabIndex = 0;
            this.userNlbl.Text = "Your Username:";
            // 
            // unameBox
            // 
            this.unameBox.Enabled = false;
            this.unameBox.Location = new System.Drawing.Point(139, 18);
            this.unameBox.Name = "unameBox";
            this.unameBox.Size = new System.Drawing.Size(100, 22);
            this.unameBox.TabIndex = 4;
            this.unameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.unameBox.TextChanged += new System.EventHandler(this.unameBox_TextChanged);
            // 
            // kgBox
            // 
            this.kgBox.Enabled = false;
            this.kgBox.Location = new System.Drawing.Point(139, 161);
            this.kgBox.Name = "kgBox";
            this.kgBox.Size = new System.Drawing.Size(100, 22);
            this.kgBox.TabIndex = 6;
            this.kgBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.kgBox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // caloriesLbl
            // 
            this.caloriesLbl.AutoSize = true;
            this.caloriesLbl.Location = new System.Drawing.Point(6, 199);
            this.caloriesLbl.Name = "caloriesLbl";
            this.caloriesLbl.Size = new System.Drawing.Size(140, 17);
            this.caloriesLbl.TabIndex = 5;
            this.caloriesLbl.Text = "Calories Daily Intake:";
            // 
            // weoghtLbl
            // 
            this.weoghtLbl.AutoSize = true;
            this.weoghtLbl.Location = new System.Drawing.Point(9, 50);
            this.weoghtLbl.Name = "weoghtLbl";
            this.weoghtLbl.Size = new System.Drawing.Size(107, 17);
            this.weoghtLbl.TabIndex = 1;
            this.weoghtLbl.Text = "Current Weight:";
            // 
            // BMIBox
            // 
            this.BMIBox.Enabled = false;
            this.BMIBox.Location = new System.Drawing.Point(139, 123);
            this.BMIBox.Name = "BMIBox";
            this.BMIBox.Size = new System.Drawing.Size(100, 22);
            this.BMIBox.TabIndex = 7;
            this.BMIBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BMIBox.TextChanged += new System.EventHandler(this.BMIBox_TextChanged);
            // 
            // dietLbl
            // 
            this.dietLbl.AutoSize = true;
            this.dietLbl.Location = new System.Drawing.Point(9, 87);
            this.dietLbl.Name = "dietLbl";
            this.dietLbl.Size = new System.Drawing.Size(76, 17);
            this.dietLbl.TabIndex = 2;
            this.dietLbl.Text = "Diet Mode:";
            // 
            // bmiLbl
            // 
            this.bmiLbl.AutoSize = true;
            this.bmiLbl.Location = new System.Drawing.Point(9, 123);
            this.bmiLbl.Name = "bmiLbl";
            this.bmiLbl.Size = new System.Drawing.Size(120, 17);
            this.bmiLbl.TabIndex = 3;
            this.bmiLbl.Text = "Your Current BMI:";
            // 
            // dietModeBox
            // 
            this.dietModeBox.Enabled = false;
            this.dietModeBox.Location = new System.Drawing.Point(139, 87);
            this.dietModeBox.Name = "dietModeBox";
            this.dietModeBox.Size = new System.Drawing.Size(100, 22);
            this.dietModeBox.TabIndex = 8;
            this.dietModeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dietModeBox.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // kgLbl
            // 
            this.kgLbl.AutoSize = true;
            this.kgLbl.Location = new System.Drawing.Point(9, 161);
            this.kgLbl.Name = "kgLbl";
            this.kgLbl.Size = new System.Drawing.Size(93, 17);
            this.kgLbl.TabIndex = 4;
            this.kgLbl.Text = "Kg To Loose:";
            // 
            // weightBox
            // 
            this.weightBox.Enabled = false;
            this.weightBox.Location = new System.Drawing.Point(139, 50);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(100, 22);
            this.weightBox.TabIndex = 9;
            this.weightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.weightBox.TextChanged += new System.EventHandler(this.weightBox_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.newPasswBox);
            this.tabPage2.Controls.Add(this.oldPasswBox);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.clearBtn);
            this.tabPage2.Controls.Add(this.updateBtn);
            this.tabPage2.Controls.Add(this.GenderBox);
            this.tabPage2.Controls.Add(this.noRadioBtn);
            this.tabPage2.Controls.Add(this.yesRadioBtn);
            this.tabPage2.Controls.Add(this.surnameBox);
            this.tabPage2.Controls.Add(this.nameBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.surnameLbl);
            this.tabPage2.Controls.Add(this.nameLbl);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(254, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // newPasswBox
            // 
            this.newPasswBox.Location = new System.Drawing.Point(115, 264);
            this.newPasswBox.Name = "newPasswBox";
            this.newPasswBox.Size = new System.Drawing.Size(100, 22);
            this.newPasswBox.TabIndex = 15;
            this.newPasswBox.UseSystemPasswordChar = true;
            // 
            // oldPasswBox
            // 
            this.oldPasswBox.Location = new System.Drawing.Point(115, 234);
            this.oldPasswBox.Name = "oldPasswBox";
            this.oldPasswBox.Size = new System.Drawing.Size(100, 22);
            this.oldPasswBox.TabIndex = 14;
            this.oldPasswBox.UseSystemPasswordChar = true;
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
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(173, 292);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 26);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(173, 324);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 28);
            this.updateBtn.TabIndex = 9;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // GenderBox
            // 
            this.GenderBox.Items.AddRange(new object[] {
            "",
            "Male",
            "Female"});
            this.GenderBox.Location = new System.Drawing.Point(83, 166);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(121, 24);
            this.GenderBox.TabIndex = 8;
            this.GenderBox.SelectedIndexChanged += new System.EventHandler(this.GenderBox_SelectedIndexChanged);
            // 
            // noRadioBtn
            // 
            this.noRadioBtn.AutoSize = true;
            this.noRadioBtn.Location = new System.Drawing.Point(91, 132);
            this.noRadioBtn.Name = "noRadioBtn";
            this.noRadioBtn.Size = new System.Drawing.Size(47, 21);
            this.noRadioBtn.TabIndex = 7;
            this.noRadioBtn.TabStop = true;
            this.noRadioBtn.Text = "No";
            this.noRadioBtn.UseVisualStyleBackColor = true;
            this.noRadioBtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // yesRadioBtn
            // 
            this.yesRadioBtn.AutoSize = true;
            this.yesRadioBtn.Location = new System.Drawing.Point(17, 132);
            this.yesRadioBtn.Name = "yesRadioBtn";
            this.yesRadioBtn.Size = new System.Drawing.Size(53, 21);
            this.yesRadioBtn.TabIndex = 6;
            this.yesRadioBtn.TabStop = true;
            this.yesRadioBtn.Text = "Yes";
            this.yesRadioBtn.UseVisualStyleBackColor = true;
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(104, 52);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(100, 22);
            this.surnameBox.TabIndex = 5;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(104, 10);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 22);
            this.nameBox.TabIndex = 4;
            this.nameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.Location = new System.Drawing.Point(14, 52);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(65, 17);
            this.surnameLbl.TabIndex = 1;
            this.surnameLbl.Text = "Surname";
            this.surnameLbl.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(14, 15);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(64, 17);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Forname";
            this.nameLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.currentBtnRefresh);
            this.tabPage3.Controls.Add(this.currentWeightLossLbl);
            this.tabPage3.Controls.Add(this.currentLossChart);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(254, 358);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Progress";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // currentWeightLossLbl
            // 
            this.currentWeightLossLbl.AutoSize = true;
            this.currentWeightLossLbl.Location = new System.Drawing.Point(48, 33);
            this.currentWeightLossLbl.Name = "currentWeightLossLbl";
            this.currentWeightLossLbl.Size = new System.Drawing.Size(137, 17);
            this.currentWeightLossLbl.TabIndex = 1;
            this.currentWeightLossLbl.Text = "Current Weight Loss";
            // 
            // currentLossChart
            // 
            this.currentLossChart.BorderlineColor = System.Drawing.Color.DarkGray;
            this.currentLossChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            chartArea5.Name = "ChartArea1";
            this.currentLossChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.currentLossChart.Legends.Add(legend5);
            this.currentLossChart.Location = new System.Drawing.Point(3, 88);
            this.currentLossChart.Name = "currentLossChart";
            this.currentLossChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series5.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series5.CustomProperties = "EmptyPointValue=Zero, LineTension=0.2, LabelStyle=Top";
            series5.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.IsXValueIndexed = true;
            series5.Legend = "Legend1";
            series5.Name = "Progress";
            series5.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series5.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.currentLossChart.Series.Add(series5);
            this.currentLossChart.Size = new System.Drawing.Size(248, 212);
            this.currentLossChart.TabIndex = 0;
            this.currentLossChart.Text = "currentWeightLoss";
            this.currentLossChart.UseWaitCursor = true;
            this.currentLossChart.Click += new System.EventHandler(this.currentLossChart_Click);
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
            this.RemoveAccountBtn.Size = new System.Drawing.Size(262, 32);
            this.RemoveAccountBtn.TabIndex = 9;
            this.RemoveAccountBtn.Text = "Remove Account";
            this.RemoveAccountBtn.UseVisualStyleBackColor = false;
            this.RemoveAccountBtn.Click += new System.EventHandler(this.RemoveAccountBtn_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.monthCalendar1);
            this.flowLayoutPanel2.Controls.Add(this.recipesRichBox);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(754, 12);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(382, 587);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // GoDietLogo
            // 
            this.GoDietLogo.Image = ((System.Drawing.Image)(resources.GetObject("GoDietLogo.Image")));
            this.GoDietLogo.Location = new System.Drawing.Point(395, 15);
            this.GoDietLogo.Name = "GoDietLogo";
            this.GoDietLogo.Size = new System.Drawing.Size(287, 160);
            this.GoDietLogo.TabIndex = 3;
            this.GoDietLogo.TabStop = false;
            this.GoDietLogo.Resize += new System.EventHandler(this.WelcomeScreen_Load);
            // 
            // dietPlanBtn
            // 
            this.dietPlanBtn.Location = new System.Drawing.Point(317, 524);
            this.dietPlanBtn.Name = "dietPlanBtn";
            this.dietPlanBtn.Size = new System.Drawing.Size(156, 78);
            this.dietPlanBtn.TabIndex = 10;
            this.dietPlanBtn.Text = "Choose/Change Your Diet Plan";
            this.dietPlanBtn.UseVisualStyleBackColor = true;
            this.dietPlanBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // weightUpdateBtn
            // 
            this.weightUpdateBtn.Location = new System.Drawing.Point(568, 524);
            this.weightUpdateBtn.Name = "weightUpdateBtn";
            this.weightUpdateBtn.Size = new System.Drawing.Size(157, 78);
            this.weightUpdateBtn.TabIndex = 11;
            this.weightUpdateBtn.Text = "Update Your Weight";
            this.weightUpdateBtn.UseVisualStyleBackColor = true;
            this.weightUpdateBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // predictedProgressWeightLossLbl
            // 
            this.predictedProgressWeightLossLbl.AutoSize = true;
            this.predictedProgressWeightLossLbl.Location = new System.Drawing.Point(325, 214);
            this.predictedProgressWeightLossLbl.Name = "predictedProgressWeightLossLbl";
            this.predictedProgressWeightLossLbl.Size = new System.Drawing.Size(304, 17);
            this.predictedProgressWeightLossLbl.TabIndex = 12;
            this.predictedProgressWeightLossLbl.Text = "Your Predicted Progress For Your Weight Loss";
            this.predictedProgressWeightLossLbl.Click += new System.EventHandler(this.predictedProgressWeightLossLbl_Click);
            // 
            // predictionWeightLoss
            // 
            chartArea6.Name = "ChartArea1";
            this.predictionWeightLoss.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.predictionWeightLoss.Legends.Add(legend6);
            this.predictionWeightLoss.Location = new System.Drawing.Point(317, 243);
            this.predictionWeightLoss.Name = "predictionWeightLoss";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series6.Color = System.Drawing.Color.Red;
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "Prediction";
            series6.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.predictionWeightLoss.Series.Add(series6);
            this.predictionWeightLoss.Size = new System.Drawing.Size(408, 257);
            this.predictionWeightLoss.TabIndex = 13;
            this.predictionWeightLoss.Text = "predictedWeightLoss";
            // 
            // currentBtnRefresh
            // 
            this.currentBtnRefresh.Location = new System.Drawing.Point(166, 317);
            this.currentBtnRefresh.Name = "currentBtnRefresh";
            this.currentBtnRefresh.Size = new System.Drawing.Size(75, 23);
            this.currentBtnRefresh.TabIndex = 2;
            this.currentBtnRefresh.Text = "Refresh";
            this.currentBtnRefresh.UseVisualStyleBackColor = true;
            this.currentBtnRefresh.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // predictedBtnRefresh
            // 
            this.predictedBtnRefresh.Location = new System.Drawing.Point(640, 467);
            this.predictedBtnRefresh.Name = "predictedBtnRefresh";
            this.predictedBtnRefresh.Size = new System.Drawing.Size(75, 23);
            this.predictedBtnRefresh.TabIndex = 14;
            this.predictedBtnRefresh.Text = "Refresh";
            this.predictedBtnRefresh.UseVisualStyleBackColor = true;
            this.predictedBtnRefresh.Click += new System.EventHandler(this.predictedBtnRefresh_Click);
            // 
            // recipesRichBox
            // 
            this.recipesRichBox.Location = new System.Drawing.Point(3, 228);
            this.recipesRichBox.Name = "recipesRichBox";
            this.recipesRichBox.Size = new System.Drawing.Size(363, 338);
            this.recipesRichBox.TabIndex = 1;
            this.recipesRichBox.Text = "";
            this.recipesRichBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // tblVegeRecipiesTableAdapter1
            // 
            this.tblVegeRecipiesTableAdapter1.ClearBeforeFill = true;
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1363, 638);
            this.Controls.Add(this.predictedBtnRefresh);
            this.Controls.Add(this.predictionWeightLoss);
            this.Controls.Add(this.predictedProgressWeightLossLbl);
            this.Controls.Add(this.dietPlanBtn);
            this.Controls.Add(this.weightUpdateBtn);
            this.Controls.Add(this.GoDietLogo);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "WelcomeScreen";
            this.Text = "WelcomeScreen";
            this.Load += new System.EventHandler(this.WelcomeScreen_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            this.PrimaryInformation.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentLossChart)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GoDietLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predictionWeightLoss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox logoPic;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PictureBox GoDietLogo;
        private System.Windows.Forms.TabControl PrimaryInformation;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button RemoveAccountBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.RadioButton noRadioBtn;
        private System.Windows.Forms.RadioButton yesRadioBtn;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.Button avatarChangeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newPasswBox;
        private System.Windows.Forms.TextBox oldPasswBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.Label caloriesLbl;
        private System.Windows.Forms.Label kgLbl;
        private System.Windows.Forms.Label bmiLbl;
        private System.Windows.Forms.Label dietLbl;
        private System.Windows.Forms.Label weoghtLbl;
        private System.Windows.Forms.Label userNlbl;
        private System.Windows.Forms.TextBox intakeBox;
        private System.Windows.Forms.TextBox kgBox;
        private System.Windows.Forms.TextBox BMIBox;
        private System.Windows.Forms.TextBox dietModeBox;
        private System.Windows.Forms.TextBox unameBox;
        private System.Windows.Forms.Label currentWeightLossLbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart currentLossChart;
        private System.Windows.Forms.Button dietPlanBtn;
        private System.Windows.Forms.Button weightUpdateBtn;
        private System.Windows.Forms.Label predictedProgressWeightLossLbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart predictionWeightLoss;
        private System.Windows.Forms.Button currentBtnRefresh;
        private System.Windows.Forms.Button predictedBtnRefresh;
        private System.Windows.Forms.RichTextBox recipesRichBox;
        private GoDietCustInfoDataSetTableAdapters.tblVegeRecipiesTableAdapter tblVegeRecipiesTableAdapter1;
    }
}