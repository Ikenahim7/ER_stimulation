namespace Emergency_Department_Simulation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbDOccupied = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbCOccupied = new System.Windows.Forms.Label();
            this.lbDAvailable = new System.Windows.Forms.Label();
            this.lbBOccupied = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbAOccupied = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbCAvailable = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbBAvailable = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbAAvailable = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbRoomSelectedAvailable = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.lbRoomSelectedOccupied = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.lbNumberOfBeds = new System.Windows.Forms.Label();
            this.simulationTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.iNSTRUCTIONSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPatientsButton = new System.Windows.Forms.Button();
            this.nrOfPatientsTextBox = new System.Windows.Forms.TextBox();
            this.bt_save_report = new System.Windows.Forms.Button();
            this.startStopButton = new System.Windows.Forms.Button();
            this.gbTools = new System.Windows.Forms.GroupBox();
            this.addPatientsRndCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSecondsPerPatient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbContinuousPatients = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.settingsTapPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbBedD = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbRoomA = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbBedC = new System.Windows.Forms.TextBox();
            this.tbRoomB = new System.Windows.Forms.TextBox();
            this.tbRoomD = new System.Windows.Forms.TextBox();
            this.tbBedB = new System.Windows.Forms.TextBox();
            this.tbBedA = new System.Windows.Forms.TextBox();
            this.tbRoomC = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label115 = new System.Windows.Forms.Label();
            this.label116 = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.label118 = new System.Windows.Forms.Label();
            this.lbSelectedRoomCurrent = new System.Windows.Forms.Label();
            this.lbSelectedRoomTotal = new System.Windows.Forms.Label();
            this.label126 = new System.Windows.Forms.Label();
            this.label127 = new System.Windows.Forms.Label();
            this.patientsDTotalLabel = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DeadPatientsALabel = new System.Windows.Forms.Label();
            this.patientsAAvgTreatLabel = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.patientsAAvgWaitingLabel = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.patientsALeftLabel = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.patientsAInRoomLabel = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.patientsAWaitingLabel = new System.Windows.Forms.Label();
            this.patientsATotalLabel = new System.Windows.Forms.Label();
            this.patientsACurrentLabel = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.DeadPatientsBLabel = new System.Windows.Forms.Label();
            this.patientsBAvgTreatLabel = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.patientsBAvgWaitingLabel = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.patientsBLeftLabel = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.patientsBInRoomLabel = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.patientsBWaitingLabel = new System.Windows.Forms.Label();
            this.patientsBTotalLabel = new System.Windows.Forms.Label();
            this.patientsBCurrentLabel = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.DeadPatientsCLabel = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.patientsCAvgTreatLabel = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.patientsCAvgWaitingLabel = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.patientsCLeftLabel = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.patientsCInRoomLabel = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.patientsCWaitingLabel = new System.Windows.Forms.Label();
            this.patientsCTotalLabel = new System.Windows.Forms.Label();
            this.patientsCCurrentLabel = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.DeadPatientsDLabel = new System.Windows.Forms.Label();
            this.patientsDAvgTreatLabel = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.patientsDAvgWaitingLabel = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.patientsDLeftLabel = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.patientsDInRoomLabel = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.patientsDWaitingLabel = new System.Windows.Forms.Label();
            this.patientsDTotalNrLabel = new System.Windows.Forms.Label();
            this.patientsDCurrentLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DeadTotalPatientsLabel = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.patientsAvgTreatLabel = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.patientsAvgWaitingLabel = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.patientsLeftLabel = new System.Windows.Forms.Label();
            this.patientsInRoomLabel = new System.Windows.Forms.Label();
            this.patientsWaitingLabel = new System.Windows.Forms.Label();
            this.patientsCurrentNRLabel = new System.Windows.Forms.Label();
            this.patientsTotalNRLabel = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.warningLabel = new System.Windows.Forms.Label();
            this.pbSimulation = new System.Windows.Forms.PictureBox();
            this.warningTimer = new System.Windows.Forms.Timer(this.components);
            this.simElapsedTimeLabel = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gbTools.SuspendLayout();
            this.settingsTapPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.patientsDTotalLabel.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSimulation)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbDOccupied);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.lbCOccupied);
            this.groupBox4.Controls.Add(this.lbDAvailable);
            this.groupBox4.Controls.Add(this.lbBOccupied);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.lbAOccupied);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.lbCAvailable);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.lbBAvailable);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.lbAAvailable);
            this.groupBox4.Location = new System.Drawing.Point(4, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(278, 198);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Beds";
            // 
            // lbDOccupied
            // 
            this.lbDOccupied.AutoSize = true;
            this.lbDOccupied.Location = new System.Drawing.Point(194, 142);
            this.lbDOccupied.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDOccupied.Name = "lbDOccupied";
            this.lbDOccupied.Size = new System.Drawing.Size(18, 17);
            this.lbDOccupied.TabIndex = 14;
            this.lbDOccupied.Text = "D";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "A";
            // 
            // lbCOccupied
            // 
            this.lbCOccupied.AutoSize = true;
            this.lbCOccupied.Location = new System.Drawing.Point(194, 112);
            this.lbCOccupied.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCOccupied.Name = "lbCOccupied";
            this.lbCOccupied.Size = new System.Drawing.Size(17, 17);
            this.lbCOccupied.TabIndex = 12;
            this.lbCOccupied.Text = "C";
            // 
            // lbDAvailable
            // 
            this.lbDAvailable.AutoSize = true;
            this.lbDAvailable.Location = new System.Drawing.Point(92, 142);
            this.lbDAvailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDAvailable.Name = "lbDAvailable";
            this.lbDAvailable.Size = new System.Drawing.Size(18, 17);
            this.lbDAvailable.TabIndex = 13;
            this.lbDAvailable.Text = "D";
            // 
            // lbBOccupied
            // 
            this.lbBOccupied.AutoSize = true;
            this.lbBOccupied.Location = new System.Drawing.Point(194, 80);
            this.lbBOccupied.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBOccupied.Name = "lbBOccupied";
            this.lbBOccupied.Size = new System.Drawing.Size(17, 17);
            this.lbBOccupied.TabIndex = 10;
            this.lbBOccupied.Text = "B";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 80);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "B";
            // 
            // lbAOccupied
            // 
            this.lbAOccupied.AutoSize = true;
            this.lbAOccupied.Location = new System.Drawing.Point(194, 48);
            this.lbAOccupied.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAOccupied.Name = "lbAOccupied";
            this.lbAOccupied.Size = new System.Drawing.Size(17, 17);
            this.lbAOccupied.TabIndex = 8;
            this.lbAOccupied.Text = "A";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 112);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 17);
            this.label15.TabIndex = 4;
            this.label15.Text = "C";
            // 
            // lbCAvailable
            // 
            this.lbCAvailable.AutoSize = true;
            this.lbCAvailable.Location = new System.Drawing.Point(92, 112);
            this.lbCAvailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCAvailable.Name = "lbCAvailable";
            this.lbCAvailable.Size = new System.Drawing.Size(17, 17);
            this.lbCAvailable.TabIndex = 11;
            this.lbCAvailable.Text = "C";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(4, 142);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 17);
            this.label17.TabIndex = 5;
            this.label17.Text = "D";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.LightGray;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 21);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 18);
            this.label18.TabIndex = 1;
            this.label18.Text = "Type";
            // 
            // lbBAvailable
            // 
            this.lbBAvailable.AutoSize = true;
            this.lbBAvailable.Location = new System.Drawing.Point(92, 80);
            this.lbBAvailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBAvailable.Name = "lbBAvailable";
            this.lbBAvailable.Size = new System.Drawing.Size(17, 17);
            this.lbBAvailable.TabIndex = 9;
            this.lbBAvailable.Text = "B";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.LightGray;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(72, 21);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 18);
            this.label20.TabIndex = 0;
            this.label20.Text = "Available";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.LightGray;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(160, 21);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 18);
            this.label21.TabIndex = 6;
            this.label21.Text = "Occupied";
            // 
            // lbAAvailable
            // 
            this.lbAAvailable.AutoSize = true;
            this.lbAAvailable.Location = new System.Drawing.Point(92, 48);
            this.lbAAvailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAAvailable.Name = "lbAAvailable";
            this.lbAAvailable.Size = new System.Drawing.Size(17, 17);
            this.lbAAvailable.TabIndex = 7;
            this.lbAAvailable.Text = "A";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(142, 29);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(102, 24);
            this.categoryComboBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(378, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Beds";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbRoomSelectedAvailable);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label57);
            this.groupBox6.Controls.Add(this.lbRoomSelectedOccupied);
            this.groupBox6.Controls.Add(this.label56);
            this.groupBox6.Controls.Add(this.lbNumberOfBeds);
            this.groupBox6.Location = new System.Drawing.Point(8, 411);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(366, 85);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Selected Room";
            // 
            // lbRoomSelectedAvailable
            // 
            this.lbRoomSelectedAvailable.AutoSize = true;
            this.lbRoomSelectedAvailable.Location = new System.Drawing.Point(292, 32);
            this.lbRoomSelectedAvailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRoomSelectedAvailable.Name = "lbRoomSelectedAvailable";
            this.lbRoomSelectedAvailable.Size = new System.Drawing.Size(16, 17);
            this.lbRoomSelectedAvailable.TabIndex = 23;
            this.lbRoomSelectedAvailable.Text = "0";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Total NR: ";
            // 
            // label57
            // 
            this.label57.Location = new System.Drawing.Point(218, 49);
            this.label57.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(69, 19);
            this.label57.TabIndex = 20;
            this.label57.Text = "Occupied: ";
            // 
            // lbRoomSelectedOccupied
            // 
            this.lbRoomSelectedOccupied.AutoSize = true;
            this.lbRoomSelectedOccupied.Location = new System.Drawing.Point(292, 49);
            this.lbRoomSelectedOccupied.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRoomSelectedOccupied.Name = "lbRoomSelectedOccupied";
            this.lbRoomSelectedOccupied.Size = new System.Drawing.Size(16, 17);
            this.lbRoomSelectedOccupied.TabIndex = 22;
            this.lbRoomSelectedOccupied.Text = "0";
            // 
            // label56
            // 
            this.label56.Location = new System.Drawing.Point(218, 30);
            this.label56.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(69, 19);
            this.label56.TabIndex = 21;
            this.label56.Text = "Available:";
            // 
            // lbNumberOfBeds
            // 
            this.lbNumberOfBeds.AutoSize = true;
            this.lbNumberOfBeds.Location = new System.Drawing.Point(138, 30);
            this.lbNumberOfBeds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNumberOfBeds.Name = "lbNumberOfBeds";
            this.lbNumberOfBeds.Size = new System.Drawing.Size(16, 17);
            this.lbNumberOfBeds.TabIndex = 25;
            this.lbNumberOfBeds.Text = "0";
            // 
            // simulationTimer
            // 
            this.simulationTimer.Interval = 10;
            this.simulationTimer.Tick += new System.EventHandler(this.simulationTimer_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1356, 25);
            this.toolStrip1.TabIndex = 37;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNSTRUCTIONSToolStripMenuItem});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(14, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // iNSTRUCTIONSToolStripMenuItem
            // 
            this.iNSTRUCTIONSToolStripMenuItem.Name = "iNSTRUCTIONSToolStripMenuItem";
            this.iNSTRUCTIONSToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.iNSTRUCTIONSToolStripMenuItem.Text = "INSTRUCTIONS";
            // 
            // addPatientsButton
            // 
            this.addPatientsButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addPatientsButton.Location = new System.Drawing.Point(262, 43);
            this.addPatientsButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPatientsButton.Name = "addPatientsButton";
            this.addPatientsButton.Size = new System.Drawing.Size(98, 28);
            this.addPatientsButton.TabIndex = 1;
            this.addPatientsButton.Text = "Add Patients";
            this.addPatientsButton.UseVisualStyleBackColor = false;
            this.addPatientsButton.Click += new System.EventHandler(this.addPatientsButton_Click);
            // 
            // nrOfPatientsTextBox
            // 
            this.nrOfPatientsTextBox.Location = new System.Drawing.Point(142, 65);
            this.nrOfPatientsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nrOfPatientsTextBox.Name = "nrOfPatientsTextBox";
            this.nrOfPatientsTextBox.Size = new System.Drawing.Size(102, 22);
            this.nrOfPatientsTextBox.TabIndex = 4;
            // 
            // bt_save_report
            // 
            this.bt_save_report.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_save_report.Enabled = false;
            this.bt_save_report.Location = new System.Drawing.Point(30, 41);
            this.bt_save_report.Margin = new System.Windows.Forms.Padding(2);
            this.bt_save_report.Name = "bt_save_report";
            this.bt_save_report.Size = new System.Drawing.Size(132, 30);
            this.bt_save_report.TabIndex = 18;
            this.bt_save_report.Text = "Save Report";
            this.bt_save_report.UseVisualStyleBackColor = false;
            this.bt_save_report.Click += new System.EventHandler(this.bt_save_report_Click);
            // 
            // startStopButton
            // 
            this.startStopButton.BackColor = System.Drawing.Color.ForestGreen;
            this.startStopButton.Location = new System.Drawing.Point(206, 41);
            this.startStopButton.Margin = new System.Windows.Forms.Padding(2);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(132, 30);
            this.startStopButton.TabIndex = 5;
            this.startStopButton.Text = "Start";
            this.startStopButton.UseVisualStyleBackColor = false;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // gbTools
            // 
            this.gbTools.Controls.Add(this.addPatientsRndCheckBox);
            this.gbTools.Controls.Add(this.label3);
            this.gbTools.Controls.Add(this.tbSecondsPerPatient);
            this.gbTools.Controls.Add(this.label1);
            this.gbTools.Controls.Add(this.cbContinuousPatients);
            this.gbTools.Controls.Add(this.label22);
            this.gbTools.Controls.Add(this.label19);
            this.gbTools.Controls.Add(this.addPatientsButton);
            this.gbTools.Controls.Add(this.nrOfPatientsTextBox);
            this.gbTools.Controls.Add(this.categoryComboBox);
            this.gbTools.Location = new System.Drawing.Point(2, 322);
            this.gbTools.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbTools.Name = "gbTools";
            this.gbTools.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbTools.Size = new System.Drawing.Size(368, 173);
            this.gbTools.TabIndex = 40;
            this.gbTools.TabStop = false;
            this.gbTools.Text = "Patients";
            // 
            // addPatientsRndCheckBox
            // 
            this.addPatientsRndCheckBox.AutoSize = true;
            this.addPatientsRndCheckBox.Location = new System.Drawing.Point(4, 128);
            this.addPatientsRndCheckBox.Name = "addPatientsRndCheckBox";
            this.addPatientsRndCheckBox.Size = new System.Drawing.Size(171, 21);
            this.addPatientsRndCheckBox.TabIndex = 45;
            this.addPatientsRndCheckBox.Text = "Add patients randomly";
            this.addPatientsRndCheckBox.UseVisualStyleBackColor = true;
            this.addPatientsRndCheckBox.CheckedChanged += new System.EventHandler(this.addPatientsRndCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "seconds";
            // 
            // tbSecondsPerPatient
            // 
            this.tbSecondsPerPatient.Location = new System.Drawing.Point(124, 101);
            this.tbSecondsPerPatient.Margin = new System.Windows.Forms.Padding(2);
            this.tbSecondsPerPatient.Name = "tbSecondsPerPatient";
            this.tbSecondsPerPatient.Size = new System.Drawing.Size(48, 22);
            this.tbSecondsPerPatient.TabIndex = 43;
            this.tbSecondsPerPatient.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "1 Patient per ";
            // 
            // cbContinuousPatients
            // 
            this.cbContinuousPatients.AutoSize = true;
            this.cbContinuousPatients.Location = new System.Drawing.Point(4, 105);
            this.cbContinuousPatients.Margin = new System.Windows.Forms.Padding(2);
            this.cbContinuousPatients.Name = "cbContinuousPatients";
            this.cbContinuousPatients.Size = new System.Drawing.Size(18, 17);
            this.cbContinuousPatients.TabIndex = 41;
            this.cbContinuousPatients.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 32);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(129, 17);
            this.label22.TabIndex = 40;
            this.label22.Text = "Category (optional)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 70);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(128, 17);
            this.label19.TabIndex = 39;
            this.label19.Text = "Number of patients";
            // 
            // settingsTapPage
            // 
            this.settingsTapPage.Controls.Add(this.groupBox2);
            this.settingsTapPage.Controls.Add(this.gbTools);
            this.settingsTapPage.Location = new System.Drawing.Point(4, 25);
            this.settingsTapPage.Margin = new System.Windows.Forms.Padding(2);
            this.settingsTapPage.Name = "settingsTapPage";
            this.settingsTapPage.Padding = new System.Windows.Forms.Padding(2);
            this.settingsTapPage.Size = new System.Drawing.Size(378, 499);
            this.settingsTapPage.TabIndex = 0;
            this.settingsTapPage.Text = "Settings";
            this.settingsTapPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGenerate);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbBedD);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.tbRoomA);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.tbBedC);
            this.groupBox2.Controls.Add(this.tbRoomB);
            this.groupBox2.Controls.Add(this.tbRoomD);
            this.groupBox2.Controls.Add(this.tbBedB);
            this.groupBox2.Controls.Add(this.tbBedA);
            this.groupBox2.Controls.Add(this.tbRoomC);
            this.groupBox2.Location = new System.Drawing.Point(2, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(368, 309);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generate Plan";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGenerate.Location = new System.Drawing.Point(156, 268);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(98, 28);
            this.btnGenerate.TabIndex = 56;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(91, 35);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 17);
            this.label10.TabIndex = 49;
            this.label10.Text = "Number of Rooms";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 55;
            this.label8.Text = "Number of Beds";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 171);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 17);
            this.label12.TabIndex = 47;
            this.label12.Text = "Category C";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 222);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 48;
            this.label11.Text = "Category D";
            // 
            // tbBedD
            // 
            this.tbBedD.Location = new System.Drawing.Point(238, 218);
            this.tbBedD.Margin = new System.Windows.Forms.Padding(2);
            this.tbBedD.Name = "tbBedD";
            this.tbBedD.Size = new System.Drawing.Size(100, 22);
            this.tbBedD.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 122);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 17);
            this.label14.TabIndex = 46;
            this.label14.Text = "Category B";
            // 
            // tbRoomA
            // 
            this.tbRoomA.Location = new System.Drawing.Point(92, 78);
            this.tbRoomA.Margin = new System.Windows.Forms.Padding(2);
            this.tbRoomA.Name = "tbRoomA";
            this.tbRoomA.Size = new System.Drawing.Size(100, 22);
            this.tbRoomA.TabIndex = 41;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 80);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 17);
            this.label16.TabIndex = 45;
            this.label16.Text = "Category A";
            // 
            // tbBedC
            // 
            this.tbBedC.Location = new System.Drawing.Point(238, 171);
            this.tbBedC.Margin = new System.Windows.Forms.Padding(2);
            this.tbBedC.Name = "tbBedC";
            this.tbBedC.Size = new System.Drawing.Size(100, 22);
            this.tbBedC.TabIndex = 53;
            // 
            // tbRoomB
            // 
            this.tbRoomB.Location = new System.Drawing.Point(92, 120);
            this.tbRoomB.Margin = new System.Windows.Forms.Padding(2);
            this.tbRoomB.Name = "tbRoomB";
            this.tbRoomB.Size = new System.Drawing.Size(100, 22);
            this.tbRoomB.TabIndex = 42;
            // 
            // tbRoomD
            // 
            this.tbRoomD.Location = new System.Drawing.Point(94, 220);
            this.tbRoomD.Margin = new System.Windows.Forms.Padding(2);
            this.tbRoomD.Name = "tbRoomD";
            this.tbRoomD.Size = new System.Drawing.Size(100, 22);
            this.tbRoomD.TabIndex = 44;
            // 
            // tbBedB
            // 
            this.tbBedB.Location = new System.Drawing.Point(238, 120);
            this.tbBedB.Margin = new System.Windows.Forms.Padding(2);
            this.tbBedB.Name = "tbBedB";
            this.tbBedB.Size = new System.Drawing.Size(100, 22);
            this.tbBedB.TabIndex = 52;
            // 
            // tbBedA
            // 
            this.tbBedA.Location = new System.Drawing.Point(238, 78);
            this.tbBedA.Margin = new System.Windows.Forms.Padding(2);
            this.tbBedA.Name = "tbBedA";
            this.tbBedA.Size = new System.Drawing.Size(100, 22);
            this.tbBedA.TabIndex = 51;
            // 
            // tbRoomC
            // 
            this.tbRoomC.Location = new System.Drawing.Point(92, 171);
            this.tbRoomC.Margin = new System.Windows.Forms.Padding(2);
            this.tbRoomC.Name = "tbRoomC";
            this.tbRoomC.Size = new System.Drawing.Size(100, 22);
            this.tbRoomC.TabIndex = 43;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.settingsTapPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(965, 39);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(386, 528);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.patientsDTotalLabel);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(378, 499);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Patients";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label115);
            this.groupBox1.Controls.Add(this.label116);
            this.groupBox1.Controls.Add(this.label117);
            this.groupBox1.Controls.Add(this.label118);
            this.groupBox1.Controls.Add(this.lbSelectedRoomCurrent);
            this.groupBox1.Controls.Add(this.lbSelectedRoomTotal);
            this.groupBox1.Controls.Add(this.label126);
            this.groupBox1.Controls.Add(this.label127);
            this.groupBox1.Location = new System.Drawing.Point(5, 409);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(366, 85);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Room";
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(308, 49);
            this.label115.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(54, 17);
            this.label115.TabIndex = 13;
            this.label115.Text = "label37";
            // 
            // label116
            // 
            this.label116.Location = new System.Drawing.Point(195, 48);
            this.label116.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(122, 19);
            this.label116.TabIndex = 12;
            this.label116.Text = "AVG treat time:";
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(308, 30);
            this.label117.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(54, 17);
            this.label117.TabIndex = 11;
            this.label117.Text = "label35";
            // 
            // label118
            // 
            this.label118.Location = new System.Drawing.Point(196, 30);
            this.label118.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(122, 19);
            this.label118.TabIndex = 10;
            this.label118.Text = "AVG waiting time:";
            // 
            // lbSelectedRoomCurrent
            // 
            this.lbSelectedRoomCurrent.AutoSize = true;
            this.lbSelectedRoomCurrent.Location = new System.Drawing.Point(138, 48);
            this.lbSelectedRoomCurrent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSelectedRoomCurrent.Name = "lbSelectedRoomCurrent";
            this.lbSelectedRoomCurrent.Size = new System.Drawing.Size(54, 17);
            this.lbSelectedRoomCurrent.TabIndex = 6;
            this.lbSelectedRoomCurrent.Text = "label31";
            // 
            // lbSelectedRoomTotal
            // 
            this.lbSelectedRoomTotal.AutoSize = true;
            this.lbSelectedRoomTotal.Location = new System.Drawing.Point(138, 30);
            this.lbSelectedRoomTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSelectedRoomTotal.Name = "lbSelectedRoomTotal";
            this.lbSelectedRoomTotal.Size = new System.Drawing.Size(54, 17);
            this.lbSelectedRoomTotal.TabIndex = 5;
            this.lbSelectedRoomTotal.Text = "label30";
            // 
            // label126
            // 
            this.label126.Location = new System.Drawing.Point(16, 48);
            this.label126.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(116, 19);
            this.label126.TabIndex = 1;
            this.label126.Text = "Curent NR: ";
            // 
            // label127
            // 
            this.label127.Location = new System.Drawing.Point(16, 28);
            this.label127.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(116, 19);
            this.label127.TabIndex = 0;
            this.label127.Text = "Total NR: ";
            // 
            // patientsDTotalLabel
            // 
            this.patientsDTotalLabel.Controls.Add(this.tabPage3);
            this.patientsDTotalLabel.Controls.Add(this.tabPage4);
            this.patientsDTotalLabel.Controls.Add(this.tabPage5);
            this.patientsDTotalLabel.Controls.Add(this.tabPage6);
            this.patientsDTotalLabel.Location = new System.Drawing.Point(6, 125);
            this.patientsDTotalLabel.Margin = new System.Windows.Forms.Padding(2);
            this.patientsDTotalLabel.Name = "patientsDTotalLabel";
            this.patientsDTotalLabel.SelectedIndex = 0;
            this.patientsDTotalLabel.Size = new System.Drawing.Size(366, 135);
            this.patientsDTotalLabel.TabIndex = 14;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DeadPatientsALabel);
            this.tabPage3.Controls.Add(this.patientsAAvgTreatLabel);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label43);
            this.tabPage3.Controls.Add(this.patientsAAvgWaitingLabel);
            this.tabPage3.Controls.Add(this.label42);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label41);
            this.tabPage3.Controls.Add(this.patientsALeftLabel);
            this.tabPage3.Controls.Add(this.label40);
            this.tabPage3.Controls.Add(this.patientsAInRoomLabel);
            this.tabPage3.Controls.Add(this.label39);
            this.tabPage3.Controls.Add(this.patientsAWaitingLabel);
            this.tabPage3.Controls.Add(this.patientsATotalLabel);
            this.tabPage3.Controls.Add(this.patientsACurrentLabel);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(358, 106);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Category A";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DeadPatientsALabel
            // 
            this.DeadPatientsALabel.AutoSize = true;
            this.DeadPatientsALabel.Location = new System.Drawing.Point(289, 72);
            this.DeadPatientsALabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DeadPatientsALabel.Name = "DeadPatientsALabel";
            this.DeadPatientsALabel.Size = new System.Drawing.Size(54, 17);
            this.DeadPatientsALabel.TabIndex = 17;
            this.DeadPatientsALabel.Text = "label24";
            // 
            // patientsAAvgTreatLabel
            // 
            this.patientsAAvgTreatLabel.AutoSize = true;
            this.patientsAAvgTreatLabel.Location = new System.Drawing.Point(134, 75);
            this.patientsAAvgTreatLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsAAvgTreatLabel.Name = "patientsAAvgTreatLabel";
            this.patientsAAvgTreatLabel.Size = new System.Drawing.Size(46, 17);
            this.patientsAAvgTreatLabel.TabIndex = 13;
            this.patientsAAvgTreatLabel.Text = "label1";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(214, 72);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(46, 17);
            this.label24.TabIndex = 16;
            this.label24.Text = "Dead:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "AVG treat time:";
            // 
            // label43
            // 
            this.label43.Location = new System.Drawing.Point(12, 18);
            this.label43.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(116, 19);
            this.label43.TabIndex = 0;
            this.label43.Text = "Total NR: ";
            // 
            // patientsAAvgWaitingLabel
            // 
            this.patientsAAvgWaitingLabel.AutoSize = true;
            this.patientsAAvgWaitingLabel.Location = new System.Drawing.Point(134, 56);
            this.patientsAAvgWaitingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsAAvgWaitingLabel.Name = "patientsAAvgWaitingLabel";
            this.patientsAAvgWaitingLabel.Size = new System.Drawing.Size(46, 17);
            this.patientsAAvgWaitingLabel.TabIndex = 11;
            this.patientsAAvgWaitingLabel.Text = "label3";
            // 
            // label42
            // 
            this.label42.Location = new System.Drawing.Point(12, 38);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(116, 19);
            this.label42.TabIndex = 1;
            this.label42.Text = "Curent NR: ";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "AVG waiting time:";
            // 
            // label41
            // 
            this.label41.Location = new System.Drawing.Point(214, 38);
            this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(69, 19);
            this.label41.TabIndex = 2;
            this.label41.Text = "Waiting: ";
            // 
            // patientsALeftLabel
            // 
            this.patientsALeftLabel.AutoSize = true;
            this.patientsALeftLabel.Location = new System.Drawing.Point(289, 18);
            this.patientsALeftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsALeftLabel.Name = "patientsALeftLabel";
            this.patientsALeftLabel.Size = new System.Drawing.Size(46, 17);
            this.patientsALeftLabel.TabIndex = 9;
            this.patientsALeftLabel.Text = "label5";
            // 
            // label40
            // 
            this.label40.Location = new System.Drawing.Point(214, 54);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(69, 19);
            this.label40.TabIndex = 3;
            this.label40.Text = "In room:";
            // 
            // patientsAInRoomLabel
            // 
            this.patientsAInRoomLabel.AutoSize = true;
            this.patientsAInRoomLabel.Location = new System.Drawing.Point(289, 54);
            this.patientsAInRoomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsAInRoomLabel.Name = "patientsAInRoomLabel";
            this.patientsAInRoomLabel.Size = new System.Drawing.Size(46, 17);
            this.patientsAInRoomLabel.TabIndex = 8;
            this.patientsAInRoomLabel.Text = "label6";
            // 
            // label39
            // 
            this.label39.Location = new System.Drawing.Point(214, 18);
            this.label39.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(69, 19);
            this.label39.TabIndex = 4;
            this.label39.Text = "Left:";
            // 
            // patientsAWaitingLabel
            // 
            this.patientsAWaitingLabel.AutoSize = true;
            this.patientsAWaitingLabel.Location = new System.Drawing.Point(289, 38);
            this.patientsAWaitingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsAWaitingLabel.Name = "patientsAWaitingLabel";
            this.patientsAWaitingLabel.Size = new System.Drawing.Size(46, 17);
            this.patientsAWaitingLabel.TabIndex = 7;
            this.patientsAWaitingLabel.Text = "label7";
            // 
            // patientsATotalLabel
            // 
            this.patientsATotalLabel.AutoSize = true;
            this.patientsATotalLabel.Location = new System.Drawing.Point(134, 20);
            this.patientsATotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsATotalLabel.Name = "patientsATotalLabel";
            this.patientsATotalLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsATotalLabel.TabIndex = 5;
            this.patientsATotalLabel.Text = "label24";
            // 
            // patientsACurrentLabel
            // 
            this.patientsACurrentLabel.AutoSize = true;
            this.patientsACurrentLabel.Location = new System.Drawing.Point(134, 38);
            this.patientsACurrentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsACurrentLabel.Name = "patientsACurrentLabel";
            this.patientsACurrentLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsACurrentLabel.TabIndex = 6;
            this.patientsACurrentLabel.Text = "label23";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.DeadPatientsBLabel);
            this.tabPage4.Controls.Add(this.patientsBAvgTreatLabel);
            this.tabPage4.Controls.Add(this.label31);
            this.tabPage4.Controls.Add(this.label45);
            this.tabPage4.Controls.Add(this.label46);
            this.tabPage4.Controls.Add(this.patientsBAvgWaitingLabel);
            this.tabPage4.Controls.Add(this.label48);
            this.tabPage4.Controls.Add(this.label49);
            this.tabPage4.Controls.Add(this.label50);
            this.tabPage4.Controls.Add(this.patientsBLeftLabel);
            this.tabPage4.Controls.Add(this.label52);
            this.tabPage4.Controls.Add(this.patientsBInRoomLabel);
            this.tabPage4.Controls.Add(this.label54);
            this.tabPage4.Controls.Add(this.patientsBWaitingLabel);
            this.tabPage4.Controls.Add(this.patientsBTotalLabel);
            this.tabPage4.Controls.Add(this.patientsBCurrentLabel);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(358, 106);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Category B";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // DeadPatientsBLabel
            // 
            this.DeadPatientsBLabel.AutoSize = true;
            this.DeadPatientsBLabel.Location = new System.Drawing.Point(289, 74);
            this.DeadPatientsBLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DeadPatientsBLabel.Name = "DeadPatientsBLabel";
            this.DeadPatientsBLabel.Size = new System.Drawing.Size(54, 17);
            this.DeadPatientsBLabel.TabIndex = 17;
            this.DeadPatientsBLabel.Text = "label24";
            // 
            // patientsBAvgTreatLabel
            // 
            this.patientsBAvgTreatLabel.AutoSize = true;
            this.patientsBAvgTreatLabel.Location = new System.Drawing.Point(134, 76);
            this.patientsBAvgTreatLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsBAvgTreatLabel.Name = "patientsBAvgTreatLabel";
            this.patientsBAvgTreatLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsBAvgTreatLabel.TabIndex = 27;
            this.patientsBAvgTreatLabel.Text = "label44";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(214, 74);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(46, 17);
            this.label31.TabIndex = 16;
            this.label31.Text = "Dead:";
            // 
            // label45
            // 
            this.label45.Location = new System.Drawing.Point(12, 76);
            this.label45.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(122, 19);
            this.label45.TabIndex = 26;
            this.label45.Text = "AVG treat time:";
            // 
            // label46
            // 
            this.label46.Location = new System.Drawing.Point(12, 19);
            this.label46.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(116, 19);
            this.label46.TabIndex = 14;
            this.label46.Text = "Total NR: ";
            // 
            // patientsBAvgWaitingLabel
            // 
            this.patientsBAvgWaitingLabel.AutoSize = true;
            this.patientsBAvgWaitingLabel.Location = new System.Drawing.Point(134, 58);
            this.patientsBAvgWaitingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsBAvgWaitingLabel.Name = "patientsBAvgWaitingLabel";
            this.patientsBAvgWaitingLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsBAvgWaitingLabel.TabIndex = 25;
            this.patientsBAvgWaitingLabel.Text = "label47";
            // 
            // label48
            // 
            this.label48.Location = new System.Drawing.Point(12, 38);
            this.label48.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(116, 19);
            this.label48.TabIndex = 15;
            this.label48.Text = "Curent NR: ";
            // 
            // label49
            // 
            this.label49.Location = new System.Drawing.Point(12, 58);
            this.label49.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(122, 19);
            this.label49.TabIndex = 24;
            this.label49.Text = "AVG waiting time:";
            // 
            // label50
            // 
            this.label50.Location = new System.Drawing.Point(214, 38);
            this.label50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(69, 19);
            this.label50.TabIndex = 16;
            this.label50.Text = "Waiting: ";
            // 
            // patientsBLeftLabel
            // 
            this.patientsBLeftLabel.AutoSize = true;
            this.patientsBLeftLabel.Location = new System.Drawing.Point(289, 19);
            this.patientsBLeftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsBLeftLabel.Name = "patientsBLeftLabel";
            this.patientsBLeftLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsBLeftLabel.TabIndex = 23;
            this.patientsBLeftLabel.Text = "label51";
            // 
            // label52
            // 
            this.label52.Location = new System.Drawing.Point(214, 55);
            this.label52.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(69, 19);
            this.label52.TabIndex = 17;
            this.label52.Text = "In room:";
            // 
            // patientsBInRoomLabel
            // 
            this.patientsBInRoomLabel.AutoSize = true;
            this.patientsBInRoomLabel.Location = new System.Drawing.Point(289, 55);
            this.patientsBInRoomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsBInRoomLabel.Name = "patientsBInRoomLabel";
            this.patientsBInRoomLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsBInRoomLabel.TabIndex = 22;
            this.patientsBInRoomLabel.Text = "label53";
            // 
            // label54
            // 
            this.label54.Location = new System.Drawing.Point(214, 19);
            this.label54.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(69, 19);
            this.label54.TabIndex = 18;
            this.label54.Text = "Left:";
            // 
            // patientsBWaitingLabel
            // 
            this.patientsBWaitingLabel.AutoSize = true;
            this.patientsBWaitingLabel.Location = new System.Drawing.Point(289, 38);
            this.patientsBWaitingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsBWaitingLabel.Name = "patientsBWaitingLabel";
            this.patientsBWaitingLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsBWaitingLabel.TabIndex = 21;
            this.patientsBWaitingLabel.Text = "label55";
            // 
            // patientsBTotalLabel
            // 
            this.patientsBTotalLabel.AutoSize = true;
            this.patientsBTotalLabel.Location = new System.Drawing.Point(134, 21);
            this.patientsBTotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsBTotalLabel.Name = "patientsBTotalLabel";
            this.patientsBTotalLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsBTotalLabel.TabIndex = 19;
            this.patientsBTotalLabel.Text = "label56";
            // 
            // patientsBCurrentLabel
            // 
            this.patientsBCurrentLabel.AutoSize = true;
            this.patientsBCurrentLabel.Location = new System.Drawing.Point(134, 38);
            this.patientsBCurrentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsBCurrentLabel.Name = "patientsBCurrentLabel";
            this.patientsBCurrentLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsBCurrentLabel.TabIndex = 20;
            this.patientsBCurrentLabel.Text = "label57";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.DeadPatientsCLabel);
            this.tabPage5.Controls.Add(this.label33);
            this.tabPage5.Controls.Add(this.patientsCAvgTreatLabel);
            this.tabPage5.Controls.Add(this.label59);
            this.tabPage5.Controls.Add(this.label60);
            this.tabPage5.Controls.Add(this.patientsCAvgWaitingLabel);
            this.tabPage5.Controls.Add(this.label62);
            this.tabPage5.Controls.Add(this.label63);
            this.tabPage5.Controls.Add(this.label64);
            this.tabPage5.Controls.Add(this.patientsCLeftLabel);
            this.tabPage5.Controls.Add(this.label66);
            this.tabPage5.Controls.Add(this.patientsCInRoomLabel);
            this.tabPage5.Controls.Add(this.label68);
            this.tabPage5.Controls.Add(this.patientsCWaitingLabel);
            this.tabPage5.Controls.Add(this.patientsCTotalLabel);
            this.tabPage5.Controls.Add(this.patientsCCurrentLabel);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(358, 106);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Category C";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // DeadPatientsCLabel
            // 
            this.DeadPatientsCLabel.AutoSize = true;
            this.DeadPatientsCLabel.Location = new System.Drawing.Point(289, 71);
            this.DeadPatientsCLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DeadPatientsCLabel.Name = "DeadPatientsCLabel";
            this.DeadPatientsCLabel.Size = new System.Drawing.Size(54, 17);
            this.DeadPatientsCLabel.TabIndex = 29;
            this.DeadPatientsCLabel.Text = "label24";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(214, 71);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(46, 17);
            this.label33.TabIndex = 28;
            this.label33.Text = "Dead:";
            // 
            // patientsCAvgTreatLabel
            // 
            this.patientsCAvgTreatLabel.AutoSize = true;
            this.patientsCAvgTreatLabel.Location = new System.Drawing.Point(134, 74);
            this.patientsCAvgTreatLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsCAvgTreatLabel.Name = "patientsCAvgTreatLabel";
            this.patientsCAvgTreatLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsCAvgTreatLabel.TabIndex = 27;
            this.patientsCAvgTreatLabel.Text = "label58";
            // 
            // label59
            // 
            this.label59.Location = new System.Drawing.Point(12, 74);
            this.label59.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(122, 19);
            this.label59.TabIndex = 26;
            this.label59.Text = "AVG treat time:";
            // 
            // label60
            // 
            this.label60.Location = new System.Drawing.Point(12, 18);
            this.label60.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(116, 19);
            this.label60.TabIndex = 14;
            this.label60.Text = "Total NR: ";
            // 
            // patientsCAvgWaitingLabel
            // 
            this.patientsCAvgWaitingLabel.AutoSize = true;
            this.patientsCAvgWaitingLabel.Location = new System.Drawing.Point(134, 55);
            this.patientsCAvgWaitingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsCAvgWaitingLabel.Name = "patientsCAvgWaitingLabel";
            this.patientsCAvgWaitingLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsCAvgWaitingLabel.TabIndex = 25;
            this.patientsCAvgWaitingLabel.Text = "label61";
            // 
            // label62
            // 
            this.label62.Location = new System.Drawing.Point(12, 36);
            this.label62.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(116, 19);
            this.label62.TabIndex = 15;
            this.label62.Text = "Curent NR: ";
            // 
            // label63
            // 
            this.label63.Location = new System.Drawing.Point(12, 55);
            this.label63.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(122, 19);
            this.label63.TabIndex = 24;
            this.label63.Text = "AVG waiting time:";
            // 
            // label64
            // 
            this.label64.Location = new System.Drawing.Point(214, 36);
            this.label64.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(69, 19);
            this.label64.TabIndex = 16;
            this.label64.Text = "Waiting: ";
            // 
            // patientsCLeftLabel
            // 
            this.patientsCLeftLabel.AutoSize = true;
            this.patientsCLeftLabel.Location = new System.Drawing.Point(289, 18);
            this.patientsCLeftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsCLeftLabel.Name = "patientsCLeftLabel";
            this.patientsCLeftLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsCLeftLabel.TabIndex = 23;
            this.patientsCLeftLabel.Text = "label65";
            // 
            // label66
            // 
            this.label66.Location = new System.Drawing.Point(214, 52);
            this.label66.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(69, 19);
            this.label66.TabIndex = 17;
            this.label66.Text = "In room:";
            // 
            // patientsCInRoomLabel
            // 
            this.patientsCInRoomLabel.AutoSize = true;
            this.patientsCInRoomLabel.Location = new System.Drawing.Point(289, 52);
            this.patientsCInRoomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsCInRoomLabel.Name = "patientsCInRoomLabel";
            this.patientsCInRoomLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsCInRoomLabel.TabIndex = 22;
            this.patientsCInRoomLabel.Text = "label67";
            // 
            // label68
            // 
            this.label68.Location = new System.Drawing.Point(214, 18);
            this.label68.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(69, 19);
            this.label68.TabIndex = 18;
            this.label68.Text = "Left:";
            // 
            // patientsCWaitingLabel
            // 
            this.patientsCWaitingLabel.AutoSize = true;
            this.patientsCWaitingLabel.Location = new System.Drawing.Point(289, 36);
            this.patientsCWaitingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsCWaitingLabel.Name = "patientsCWaitingLabel";
            this.patientsCWaitingLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsCWaitingLabel.TabIndex = 21;
            this.patientsCWaitingLabel.Text = "label69";
            // 
            // patientsCTotalLabel
            // 
            this.patientsCTotalLabel.AutoSize = true;
            this.patientsCTotalLabel.Location = new System.Drawing.Point(134, 19);
            this.patientsCTotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsCTotalLabel.Name = "patientsCTotalLabel";
            this.patientsCTotalLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsCTotalLabel.TabIndex = 19;
            this.patientsCTotalLabel.Text = "label70";
            // 
            // patientsCCurrentLabel
            // 
            this.patientsCCurrentLabel.AutoSize = true;
            this.patientsCCurrentLabel.Location = new System.Drawing.Point(134, 36);
            this.patientsCCurrentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsCCurrentLabel.Name = "patientsCCurrentLabel";
            this.patientsCCurrentLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsCCurrentLabel.TabIndex = 20;
            this.patientsCCurrentLabel.Text = "label71";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.DeadPatientsDLabel);
            this.tabPage6.Controls.Add(this.patientsDAvgTreatLabel);
            this.tabPage6.Controls.Add(this.label35);
            this.tabPage6.Controls.Add(this.label73);
            this.tabPage6.Controls.Add(this.label74);
            this.tabPage6.Controls.Add(this.patientsDAvgWaitingLabel);
            this.tabPage6.Controls.Add(this.label76);
            this.tabPage6.Controls.Add(this.label77);
            this.tabPage6.Controls.Add(this.label78);
            this.tabPage6.Controls.Add(this.patientsDLeftLabel);
            this.tabPage6.Controls.Add(this.label80);
            this.tabPage6.Controls.Add(this.patientsDInRoomLabel);
            this.tabPage6.Controls.Add(this.label82);
            this.tabPage6.Controls.Add(this.patientsDWaitingLabel);
            this.tabPage6.Controls.Add(this.patientsDTotalNrLabel);
            this.tabPage6.Controls.Add(this.patientsDCurrentLabel);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(358, 106);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Category D";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // DeadPatientsDLabel
            // 
            this.DeadPatientsDLabel.AutoSize = true;
            this.DeadPatientsDLabel.Location = new System.Drawing.Point(289, 70);
            this.DeadPatientsDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DeadPatientsDLabel.Name = "DeadPatientsDLabel";
            this.DeadPatientsDLabel.Size = new System.Drawing.Size(54, 17);
            this.DeadPatientsDLabel.TabIndex = 17;
            this.DeadPatientsDLabel.Text = "label24";
            // 
            // patientsDAvgTreatLabel
            // 
            this.patientsDAvgTreatLabel.AutoSize = true;
            this.patientsDAvgTreatLabel.Location = new System.Drawing.Point(134, 72);
            this.patientsDAvgTreatLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsDAvgTreatLabel.Name = "patientsDAvgTreatLabel";
            this.patientsDAvgTreatLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsDAvgTreatLabel.TabIndex = 27;
            this.patientsDAvgTreatLabel.Text = "label72";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(214, 70);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(46, 17);
            this.label35.TabIndex = 16;
            this.label35.Text = "Dead:";
            // 
            // label73
            // 
            this.label73.Location = new System.Drawing.Point(12, 72);
            this.label73.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(122, 19);
            this.label73.TabIndex = 26;
            this.label73.Text = "AVG treat time:";
            // 
            // label74
            // 
            this.label74.Location = new System.Drawing.Point(12, 15);
            this.label74.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(116, 19);
            this.label74.TabIndex = 14;
            this.label74.Text = "Total NR: ";
            // 
            // patientsDAvgWaitingLabel
            // 
            this.patientsDAvgWaitingLabel.AutoSize = true;
            this.patientsDAvgWaitingLabel.Location = new System.Drawing.Point(134, 52);
            this.patientsDAvgWaitingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsDAvgWaitingLabel.Name = "patientsDAvgWaitingLabel";
            this.patientsDAvgWaitingLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsDAvgWaitingLabel.TabIndex = 25;
            this.patientsDAvgWaitingLabel.Text = "label75";
            // 
            // label76
            // 
            this.label76.Location = new System.Drawing.Point(12, 34);
            this.label76.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(116, 19);
            this.label76.TabIndex = 15;
            this.label76.Text = "Curent NR: ";
            // 
            // label77
            // 
            this.label77.Location = new System.Drawing.Point(12, 52);
            this.label77.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(122, 19);
            this.label77.TabIndex = 24;
            this.label77.Text = "AVG waiting time:";
            // 
            // label78
            // 
            this.label78.Location = new System.Drawing.Point(214, 34);
            this.label78.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(69, 19);
            this.label78.TabIndex = 16;
            this.label78.Text = "Waiting: ";
            // 
            // patientsDLeftLabel
            // 
            this.patientsDLeftLabel.AutoSize = true;
            this.patientsDLeftLabel.Location = new System.Drawing.Point(289, 15);
            this.patientsDLeftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsDLeftLabel.Name = "patientsDLeftLabel";
            this.patientsDLeftLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsDLeftLabel.TabIndex = 23;
            this.patientsDLeftLabel.Text = "label79";
            // 
            // label80
            // 
            this.label80.Location = new System.Drawing.Point(214, 51);
            this.label80.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(69, 19);
            this.label80.TabIndex = 17;
            this.label80.Text = "In room:";
            // 
            // patientsDInRoomLabel
            // 
            this.patientsDInRoomLabel.AutoSize = true;
            this.patientsDInRoomLabel.Location = new System.Drawing.Point(289, 51);
            this.patientsDInRoomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsDInRoomLabel.Name = "patientsDInRoomLabel";
            this.patientsDInRoomLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsDInRoomLabel.TabIndex = 22;
            this.patientsDInRoomLabel.Text = "label81";
            // 
            // label82
            // 
            this.label82.Location = new System.Drawing.Point(214, 15);
            this.label82.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(69, 19);
            this.label82.TabIndex = 18;
            this.label82.Text = "Left:";
            // 
            // patientsDWaitingLabel
            // 
            this.patientsDWaitingLabel.AutoSize = true;
            this.patientsDWaitingLabel.Location = new System.Drawing.Point(289, 34);
            this.patientsDWaitingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsDWaitingLabel.Name = "patientsDWaitingLabel";
            this.patientsDWaitingLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsDWaitingLabel.TabIndex = 21;
            this.patientsDWaitingLabel.Text = "label83";
            // 
            // patientsDTotalNrLabel
            // 
            this.patientsDTotalNrLabel.AutoSize = true;
            this.patientsDTotalNrLabel.Location = new System.Drawing.Point(134, 18);
            this.patientsDTotalNrLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsDTotalNrLabel.Name = "patientsDTotalNrLabel";
            this.patientsDTotalNrLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsDTotalNrLabel.TabIndex = 19;
            this.patientsDTotalNrLabel.Text = "label84";
            // 
            // patientsDCurrentLabel
            // 
            this.patientsDCurrentLabel.AutoSize = true;
            this.patientsDCurrentLabel.Location = new System.Drawing.Point(134, 34);
            this.patientsDCurrentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsDCurrentLabel.Name = "patientsDCurrentLabel";
            this.patientsDCurrentLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsDCurrentLabel.TabIndex = 20;
            this.patientsDCurrentLabel.Text = "label85";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DeadTotalPatientsLabel);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.patientsAvgTreatLabel);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.patientsAvgWaitingLabel);
            this.groupBox3.Controls.Add(this.label36);
            this.groupBox3.Controls.Add(this.patientsLeftLabel);
            this.groupBox3.Controls.Add(this.patientsInRoomLabel);
            this.groupBox3.Controls.Add(this.patientsWaitingLabel);
            this.groupBox3.Controls.Add(this.patientsCurrentNRLabel);
            this.groupBox3.Controls.Add(this.patientsTotalNRLabel);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(366, 112);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General";
            // 
            // DeadTotalPatientsLabel
            // 
            this.DeadTotalPatientsLabel.AutoSize = true;
            this.DeadTotalPatientsLabel.Location = new System.Drawing.Point(292, 82);
            this.DeadTotalPatientsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DeadTotalPatientsLabel.Name = "DeadTotalPatientsLabel";
            this.DeadTotalPatientsLabel.Size = new System.Drawing.Size(54, 17);
            this.DeadTotalPatientsLabel.TabIndex = 15;
            this.DeadTotalPatientsLabel.Text = "label24";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(218, 82);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(46, 17);
            this.label23.TabIndex = 14;
            this.label23.Text = "Dead:";
            // 
            // patientsAvgTreatLabel
            // 
            this.patientsAvgTreatLabel.AutoSize = true;
            this.patientsAvgTreatLabel.Location = new System.Drawing.Point(138, 85);
            this.patientsAvgTreatLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsAvgTreatLabel.Name = "patientsAvgTreatLabel";
            this.patientsAvgTreatLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsAvgTreatLabel.TabIndex = 13;
            this.patientsAvgTreatLabel.Text = "label37";
            // 
            // label38
            // 
            this.label38.Location = new System.Drawing.Point(16, 85);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(122, 19);
            this.label38.TabIndex = 12;
            this.label38.Text = "AVG treat time:";
            // 
            // patientsAvgWaitingLabel
            // 
            this.patientsAvgWaitingLabel.AutoSize = true;
            this.patientsAvgWaitingLabel.Location = new System.Drawing.Point(138, 66);
            this.patientsAvgWaitingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsAvgWaitingLabel.Name = "patientsAvgWaitingLabel";
            this.patientsAvgWaitingLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsAvgWaitingLabel.TabIndex = 11;
            this.patientsAvgWaitingLabel.Text = "label35";
            // 
            // label36
            // 
            this.label36.Location = new System.Drawing.Point(16, 66);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(122, 19);
            this.label36.TabIndex = 10;
            this.label36.Text = "AVG waiting time:";
            // 
            // patientsLeftLabel
            // 
            this.patientsLeftLabel.AutoSize = true;
            this.patientsLeftLabel.Location = new System.Drawing.Point(292, 30);
            this.patientsLeftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsLeftLabel.Name = "patientsLeftLabel";
            this.patientsLeftLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsLeftLabel.TabIndex = 9;
            this.patientsLeftLabel.Text = "label34";
            // 
            // patientsInRoomLabel
            // 
            this.patientsInRoomLabel.AutoSize = true;
            this.patientsInRoomLabel.Location = new System.Drawing.Point(292, 64);
            this.patientsInRoomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsInRoomLabel.Name = "patientsInRoomLabel";
            this.patientsInRoomLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsInRoomLabel.TabIndex = 8;
            this.patientsInRoomLabel.Text = "label33";
            // 
            // patientsWaitingLabel
            // 
            this.patientsWaitingLabel.AutoSize = true;
            this.patientsWaitingLabel.Location = new System.Drawing.Point(292, 48);
            this.patientsWaitingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsWaitingLabel.Name = "patientsWaitingLabel";
            this.patientsWaitingLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsWaitingLabel.TabIndex = 7;
            this.patientsWaitingLabel.Text = "label32";
            // 
            // patientsCurrentNRLabel
            // 
            this.patientsCurrentNRLabel.AutoSize = true;
            this.patientsCurrentNRLabel.Location = new System.Drawing.Point(138, 48);
            this.patientsCurrentNRLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsCurrentNRLabel.Name = "patientsCurrentNRLabel";
            this.patientsCurrentNRLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsCurrentNRLabel.TabIndex = 6;
            this.patientsCurrentNRLabel.Text = "label31";
            // 
            // patientsTotalNRLabel
            // 
            this.patientsTotalNRLabel.AutoSize = true;
            this.patientsTotalNRLabel.Location = new System.Drawing.Point(138, 30);
            this.patientsTotalNRLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientsTotalNRLabel.Name = "patientsTotalNRLabel";
            this.patientsTotalNRLabel.Size = new System.Drawing.Size(54, 17);
            this.patientsTotalNRLabel.TabIndex = 5;
            this.patientsTotalNRLabel.Text = "label30";
            // 
            // label29
            // 
            this.label29.Location = new System.Drawing.Point(218, 28);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(69, 19);
            this.label29.TabIndex = 4;
            this.label29.Text = "Left:";
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(218, 64);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(69, 19);
            this.label28.TabIndex = 3;
            this.label28.Text = "In room:";
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(218, 48);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(69, 19);
            this.label27.TabIndex = 2;
            this.label27.Text = "Waiting: ";
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(16, 48);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(116, 19);
            this.label26.TabIndex = 1;
            this.label26.Text = "Curent NR: ";
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(16, 28);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(116, 19);
            this.label25.TabIndex = 0;
            this.label25.Text = "Total NR: ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(746, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Elapsed Time: ";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.bt_save_report);
            this.groupBox5.Controls.Add(this.startStopButton);
            this.groupBox5.Location = new System.Drawing.Point(971, 572);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(376, 90);
            this.groupBox5.TabIndex = 39;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Controls";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(441, 12);
            this.warningLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 24);
            this.warningLabel.TabIndex = 40;
            // 
            // pbSimulation
            // 
            this.pbSimulation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSimulation.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pbSimulation.Location = new System.Drawing.Point(9, 39);
            this.pbSimulation.Margin = new System.Windows.Forms.Padding(2);
            this.pbSimulation.Name = "pbSimulation";
            this.pbSimulation.Size = new System.Drawing.Size(952, 614);
            this.pbSimulation.TabIndex = 36;
            this.pbSimulation.TabStop = false;
            this.pbSimulation.Paint += new System.Windows.Forms.PaintEventHandler(this.pbSimulation_Paint);
            this.pbSimulation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.room_Click);
            // 
            // warningTimer
            // 
            this.warningTimer.Interval = 3000;
            this.warningTimer.Tick += new System.EventHandler(this.warningTimer_Tick);
            // 
            // simElapsedTimeLabel
            // 
            this.simElapsedTimeLabel.AutoSize = true;
            this.simElapsedTimeLabel.Location = new System.Drawing.Point(853, 20);
            this.simElapsedTimeLabel.Name = "simElapsedTimeLabel";
            this.simElapsedTimeLabel.Size = new System.Drawing.Size(16, 17);
            this.simElapsedTimeLabel.TabIndex = 41;
            this.simElapsedTimeLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1356, 674);
            this.Controls.Add(this.simElapsedTimeLabel);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pbSimulation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(753, 567);
            this.Name = "Form1";
            this.Text = "Emergency Room Simulation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbTools.ResumeLayout(false);
            this.gbTools.PerformLayout();
            this.settingsTapPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.patientsDTotalLabel.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSimulation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbDOccupied;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbCOccupied;
        private System.Windows.Forms.Label lbDAvailable;
        private System.Windows.Forms.Label lbBOccupied;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbAOccupied;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbCAvailable;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbBAvailable;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbAAvailable;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer simulationTimer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem iNSTRUCTIONSToolStripMenuItem;
        private System.Windows.Forms.Button addPatientsButton;
        private System.Windows.Forms.TextBox nrOfPatientsTextBox;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.GroupBox gbTools;
        private System.Windows.Forms.TabPage settingsTapPage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.PictureBox pbSimulation;
        private System.Windows.Forms.Button bt_save_report;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbBedD;
        private System.Windows.Forms.TextBox tbRoomA;
        private System.Windows.Forms.TextBox tbBedC;
        private System.Windows.Forms.TextBox tbRoomB;
        private System.Windows.Forms.TextBox tbBedB;
        private System.Windows.Forms.TextBox tbRoomC;
        private System.Windows.Forms.TextBox tbBedA;
        private System.Windows.Forms.TextBox tbRoomD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TabControl patientsDTotalLabel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label patientsAAvgTreatLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label patientsAAvgWaitingLabel;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label patientsALeftLabel;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label patientsAInRoomLabel;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label patientsAWaitingLabel;
        private System.Windows.Forms.Label patientsATotalLabel;
        private System.Windows.Forms.Label patientsACurrentLabel;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label patientsBAvgTreatLabel;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label patientsBAvgWaitingLabel;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label patientsBLeftLabel;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label patientsBInRoomLabel;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label patientsBWaitingLabel;
        private System.Windows.Forms.Label patientsBTotalLabel;
        private System.Windows.Forms.Label patientsBCurrentLabel;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label patientsCAvgTreatLabel;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label patientsCAvgWaitingLabel;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label patientsCLeftLabel;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label patientsCInRoomLabel;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label patientsCWaitingLabel;
        private System.Windows.Forms.Label patientsCTotalLabel;
        private System.Windows.Forms.Label patientsCCurrentLabel;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label patientsDAvgTreatLabel;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label patientsDAvgWaitingLabel;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label patientsDLeftLabel;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label patientsDInRoomLabel;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label patientsDWaitingLabel;
        private System.Windows.Forms.Label patientsDTotalNrLabel;
        private System.Windows.Forms.Label patientsDCurrentLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label patientsAvgTreatLabel;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label patientsAvgWaitingLabel;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label patientsLeftLabel;
        private System.Windows.Forms.Label patientsInRoomLabel;
        private System.Windows.Forms.Label patientsWaitingLabel;
        private System.Windows.Forms.Label patientsCurrentNRLabel;
        private System.Windows.Forms.Label patientsTotalNRLabel;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbContinuousPatients;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSecondsPerPatient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lbRoomSelectedAvailable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label lbRoomSelectedOccupied;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label lbNumberOfBeds;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.Label lbSelectedRoomCurrent;
        private System.Windows.Forms.Label lbSelectedRoomTotal;
        private System.Windows.Forms.Label label126;
        private System.Windows.Forms.Label label127;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label DeadTotalPatientsLabel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Timer warningTimer;
        private System.Windows.Forms.Label DeadPatientsALabel;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label DeadPatientsBLabel;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label DeadPatientsCLabel;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label DeadPatientsDLabel;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label simElapsedTimeLabel;
        private System.Windows.Forms.CheckBox addPatientsRndCheckBox;
    }
}

