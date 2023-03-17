
namespace SpellmanXRVGui_Logging
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxGeneratorComPort = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonConnectToGenerator = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxGeneratorModel = new System.Windows.Forms.ToolStripTextBox();
            this.GeneratorSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGeneratorMonitor = new System.Windows.Forms.TabPage();
            this.buttonResetGeneratorFaults = new System.Windows.Forms.Button();
            this.buttonEnableFilament = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxGeneratorStatus = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBoxFilamentEnabled = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBoxArcFault = new System.Windows.Forms.CheckBox();
            this.checkBoxInterlock2 = new System.Windows.Forms.CheckBox();
            this.checkBoxInterlock1 = new System.Windows.Forms.CheckBox();
            this.checkBoxHVPSReady = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxFilamentCurrent = new System.Windows.Forms.TextBox();
            this.textBoxmA = new System.Windows.Forms.TextBox();
            this.textBoxkV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxDemand = new System.Windows.Forms.GroupBox();
            this.buttonSendFilamentPreHeatLimit = new System.Windows.Forms.Button();
            this.buttonSendmADemand = new System.Windows.Forms.Button();
            this.buttonSendkVDemand = new System.Windows.Forms.Button();
            this.numericUpDownFilamentCurrentDemand = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownmADemand = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownkVDemand = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxDataLogging = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonViewFile = new System.Windows.Forms.Button();
            this.buttonToggleLogging = new System.Windows.Forms.Button();
            this.buttonSaveFileName = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageFilamentControl = new System.Windows.Forms.TabPage();
            this.tabPageGeneratorScaling = new System.Windows.Forms.TabPage();
            this.textBoxGeneratorScalingkV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxGeneratorScalingVoltsPerBit = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxGeneratorScalingmAPerBit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxGeneratorScailngmA = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxGeneratorScalingAPerBit = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxGeneratorScalingFilCurrent = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageGeneratorMonitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBoxGeneratorStatus.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxDemand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilamentCurrentDemand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownmADemand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownkVDemand)).BeginInit();
            this.groupBoxDataLogging.SuspendLayout();
            this.tabPageGeneratorScaling.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBoxGeneratorComPort,
            this.toolStripSeparator1,
            this.toolStripButtonConnectToGenerator,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.toolStripTextBoxGeneratorModel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 425);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(116, 22);
            this.toolStripLabel1.Text = "Generator Com Port:";
            // 
            // toolStripTextBoxGeneratorComPort
            // 
            this.toolStripTextBoxGeneratorComPort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxGeneratorComPort.Name = "toolStripTextBoxGeneratorComPort";
            this.toolStripTextBoxGeneratorComPort.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxGeneratorComPort.Text = "Not Connected";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonConnectToGenerator
            // 
            this.toolStripButtonConnectToGenerator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonConnectToGenerator.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonConnectToGenerator.Image")));
            this.toolStripButtonConnectToGenerator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConnectToGenerator.Name = "toolStripButtonConnectToGenerator";
            this.toolStripButtonConnectToGenerator.Size = new System.Drawing.Size(125, 22);
            this.toolStripButtonConnectToGenerator.Text = "Connect to Generator";
            this.toolStripButtonConnectToGenerator.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(99, 22);
            this.toolStripLabel2.Text = "Generator Model:";
            // 
            // toolStripTextBoxGeneratorModel
            // 
            this.toolStripTextBoxGeneratorModel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxGeneratorModel.Name = "toolStripTextBoxGeneratorModel";
            this.toolStripTextBoxGeneratorModel.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxGeneratorModel.Text = "Not Connected";
            // 
            // GeneratorSerialPort
            // 
            this.GeneratorSerialPort.BaudRate = 115200;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageGeneratorMonitor);
            this.tabControl1.Controls.Add(this.tabPageFilamentControl);
            this.tabControl1.Controls.Add(this.tabPageGeneratorScaling);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 395);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageGeneratorMonitor
            // 
            this.tabPageGeneratorMonitor.Controls.Add(this.buttonResetGeneratorFaults);
            this.tabPageGeneratorMonitor.Controls.Add(this.buttonEnableFilament);
            this.tabPageGeneratorMonitor.Controls.Add(this.label8);
            this.tabPageGeneratorMonitor.Controls.Add(this.comboBox1);
            this.tabPageGeneratorMonitor.Controls.Add(this.chart1);
            this.tabPageGeneratorMonitor.Controls.Add(this.groupBoxGeneratorStatus);
            this.tabPageGeneratorMonitor.Controls.Add(this.groupBox1);
            this.tabPageGeneratorMonitor.Controls.Add(this.groupBoxDemand);
            this.tabPageGeneratorMonitor.Controls.Add(this.groupBoxDataLogging);
            this.tabPageGeneratorMonitor.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneratorMonitor.Name = "tabPageGeneratorMonitor";
            this.tabPageGeneratorMonitor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneratorMonitor.Size = new System.Drawing.Size(768, 369);
            this.tabPageGeneratorMonitor.TabIndex = 0;
            this.tabPageGeneratorMonitor.Text = "Generator Monitor";
            this.tabPageGeneratorMonitor.UseVisualStyleBackColor = true;
            // 
            // buttonResetGeneratorFaults
            // 
            this.buttonResetGeneratorFaults.Location = new System.Drawing.Point(238, 200);
            this.buttonResetGeneratorFaults.Name = "buttonResetGeneratorFaults";
            this.buttonResetGeneratorFaults.Size = new System.Drawing.Size(132, 49);
            this.buttonResetGeneratorFaults.TabIndex = 15;
            this.buttonResetGeneratorFaults.Text = "Reset Faults";
            this.buttonResetGeneratorFaults.UseVisualStyleBackColor = true;
            // 
            // buttonEnableFilament
            // 
            this.buttonEnableFilament.Location = new System.Drawing.Point(238, 117);
            this.buttonEnableFilament.Name = "buttonEnableFilament";
            this.buttonEnableFilament.Size = new System.Drawing.Size(132, 54);
            this.buttonEnableFilament.TabIndex = 14;
            this.buttonEnableFilament.Text = "Enable Filament";
            this.buttonEnableFilament.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(480, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Viewing: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Filament Current",
            "mA Feedback",
            "kV Feedback"});
            this.comboBox1.Location = new System.Drawing.Point(536, 342);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(376, 6);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(386, 330);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // groupBoxGeneratorStatus
            // 
            this.groupBoxGeneratorStatus.Controls.Add(this.checkBox5);
            this.groupBoxGeneratorStatus.Controls.Add(this.checkBox3);
            this.groupBoxGeneratorStatus.Controls.Add(this.checkBox2);
            this.groupBoxGeneratorStatus.Controls.Add(this.checkBoxFilamentEnabled);
            this.groupBoxGeneratorStatus.Controls.Add(this.checkBox1);
            this.groupBoxGeneratorStatus.Controls.Add(this.checkBox4);
            this.groupBoxGeneratorStatus.Controls.Add(this.checkBoxArcFault);
            this.groupBoxGeneratorStatus.Controls.Add(this.checkBoxInterlock2);
            this.groupBoxGeneratorStatus.Controls.Add(this.checkBoxInterlock1);
            this.groupBoxGeneratorStatus.Controls.Add(this.checkBoxHVPSReady);
            this.groupBoxGeneratorStatus.Location = new System.Drawing.Point(6, 112);
            this.groupBoxGeneratorStatus.Name = "groupBoxGeneratorStatus";
            this.groupBoxGeneratorStatus.Size = new System.Drawing.Size(227, 137);
            this.groupBoxGeneratorStatus.TabIndex = 10;
            this.groupBoxGeneratorStatus.TabStop = false;
            this.groupBoxGeneratorStatus.Text = "Generator Status";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(98, 111);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(66, 17);
            this.checkBox5.TabIndex = 9;
            this.checkBox5.Text = "Spare_3";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(98, 88);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(66, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Spare_2";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(98, 65);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(66, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Spare_1";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBoxFilamentEnabled
            // 
            this.checkBoxFilamentEnabled.AutoSize = true;
            this.checkBoxFilamentEnabled.Location = new System.Drawing.Point(98, 42);
            this.checkBoxFilamentEnabled.Name = "checkBoxFilamentEnabled";
            this.checkBoxFilamentEnabled.Size = new System.Drawing.Size(107, 17);
            this.checkBoxFilamentEnabled.TabIndex = 6;
            this.checkBoxFilamentEnabled.Text = "Filament Enabled";
            this.checkBoxFilamentEnabled.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(98, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "X-Ray Enabled";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 111);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(71, 17);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Pre-Warn";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBoxArcFault
            // 
            this.checkBoxArcFault.AutoSize = true;
            this.checkBoxArcFault.Location = new System.Drawing.Point(6, 88);
            this.checkBoxArcFault.Name = "checkBoxArcFault";
            this.checkBoxArcFault.Size = new System.Drawing.Size(68, 17);
            this.checkBoxArcFault.TabIndex = 3;
            this.checkBoxArcFault.Text = "Arc Fault";
            this.checkBoxArcFault.UseVisualStyleBackColor = true;
            // 
            // checkBoxInterlock2
            // 
            this.checkBoxInterlock2.AutoSize = true;
            this.checkBoxInterlock2.Location = new System.Drawing.Point(6, 65);
            this.checkBoxInterlock2.Name = "checkBoxInterlock2";
            this.checkBoxInterlock2.Size = new System.Drawing.Size(76, 17);
            this.checkBoxInterlock2.TabIndex = 2;
            this.checkBoxInterlock2.Text = "Interlock 2";
            this.checkBoxInterlock2.UseVisualStyleBackColor = true;
            // 
            // checkBoxInterlock1
            // 
            this.checkBoxInterlock1.AutoSize = true;
            this.checkBoxInterlock1.Location = new System.Drawing.Point(6, 42);
            this.checkBoxInterlock1.Name = "checkBoxInterlock1";
            this.checkBoxInterlock1.Size = new System.Drawing.Size(76, 17);
            this.checkBoxInterlock1.TabIndex = 1;
            this.checkBoxInterlock1.Text = "Interlock 1";
            this.checkBoxInterlock1.UseVisualStyleBackColor = true;
            // 
            // checkBoxHVPSReady
            // 
            this.checkBoxHVPSReady.AutoSize = true;
            this.checkBoxHVPSReady.Location = new System.Drawing.Point(6, 19);
            this.checkBoxHVPSReady.Name = "checkBoxHVPSReady";
            this.checkBoxHVPSReady.Size = new System.Drawing.Size(86, 17);
            this.checkBoxHVPSReady.TabIndex = 0;
            this.checkBoxHVPSReady.Text = "HVPSReady";
            this.checkBoxHVPSReady.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxFilamentCurrent);
            this.groupBox1.Controls.Add(this.textBoxmA);
            this.groupBox1.Controls.Add(this.textBoxkV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(239, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Measrued Values";
            // 
            // textBoxFilamentCurrent
            // 
            this.textBoxFilamentCurrent.Location = new System.Drawing.Point(72, 70);
            this.textBoxFilamentCurrent.Name = "textBoxFilamentCurrent";
            this.textBoxFilamentCurrent.Size = new System.Drawing.Size(49, 20);
            this.textBoxFilamentCurrent.TabIndex = 12;
            // 
            // textBoxmA
            // 
            this.textBoxmA.Location = new System.Drawing.Point(37, 44);
            this.textBoxmA.Name = "textBoxmA";
            this.textBoxmA.Size = new System.Drawing.Size(84, 20);
            this.textBoxmA.TabIndex = 11;
            // 
            // textBoxkV
            // 
            this.textBoxkV.Location = new System.Drawing.Point(35, 18);
            this.textBoxkV.Name = "textBoxkV";
            this.textBoxkV.Size = new System.Drawing.Size(84, 20);
            this.textBoxkV.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fil. Current:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "mA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "kV:";
            // 
            // groupBoxDemand
            // 
            this.groupBoxDemand.Controls.Add(this.buttonSendFilamentPreHeatLimit);
            this.groupBoxDemand.Controls.Add(this.buttonSendmADemand);
            this.groupBoxDemand.Controls.Add(this.buttonSendkVDemand);
            this.groupBoxDemand.Controls.Add(this.numericUpDownFilamentCurrentDemand);
            this.groupBoxDemand.Controls.Add(this.label4);
            this.groupBoxDemand.Controls.Add(this.numericUpDownmADemand);
            this.groupBoxDemand.Controls.Add(this.label3);
            this.groupBoxDemand.Controls.Add(this.numericUpDownkVDemand);
            this.groupBoxDemand.Controls.Add(this.label2);
            this.groupBoxDemand.Location = new System.Drawing.Point(6, 6);
            this.groupBoxDemand.Name = "groupBoxDemand";
            this.groupBoxDemand.Size = new System.Drawing.Size(227, 100);
            this.groupBoxDemand.TabIndex = 1;
            this.groupBoxDemand.TabStop = false;
            this.groupBoxDemand.Text = "Programed Demand";
            // 
            // buttonSendFilamentPreHeatLimit
            // 
            this.buttonSendFilamentPreHeatLimit.Location = new System.Drawing.Point(125, 68);
            this.buttonSendFilamentPreHeatLimit.Name = "buttonSendFilamentPreHeatLimit";
            this.buttonSendFilamentPreHeatLimit.Size = new System.Drawing.Size(96, 23);
            this.buttonSendFilamentPreHeatLimit.TabIndex = 8;
            this.buttonSendFilamentPreHeatLimit.Text = "Send Command";
            this.buttonSendFilamentPreHeatLimit.UseVisualStyleBackColor = true;
            this.buttonSendFilamentPreHeatLimit.Click += new System.EventHandler(this.buttonSendFilamentPreHeatLimit_Click);
            // 
            // buttonSendmADemand
            // 
            this.buttonSendmADemand.Location = new System.Drawing.Point(125, 42);
            this.buttonSendmADemand.Name = "buttonSendmADemand";
            this.buttonSendmADemand.Size = new System.Drawing.Size(96, 23);
            this.buttonSendmADemand.TabIndex = 7;
            this.buttonSendmADemand.Text = "Send Command";
            this.buttonSendmADemand.UseVisualStyleBackColor = true;
            this.buttonSendmADemand.Click += new System.EventHandler(this.buttonSendmADemand_Click);
            // 
            // buttonSendkVDemand
            // 
            this.buttonSendkVDemand.Location = new System.Drawing.Point(125, 16);
            this.buttonSendkVDemand.Name = "buttonSendkVDemand";
            this.buttonSendkVDemand.Size = new System.Drawing.Size(96, 23);
            this.buttonSendkVDemand.TabIndex = 6;
            this.buttonSendkVDemand.Text = "Send Command";
            this.buttonSendkVDemand.UseVisualStyleBackColor = true;
            this.buttonSendkVDemand.Click += new System.EventHandler(this.buttonSendkVDemand_Click);
            // 
            // numericUpDownFilamentCurrentDemand
            // 
            this.numericUpDownFilamentCurrentDemand.Location = new System.Drawing.Point(69, 71);
            this.numericUpDownFilamentCurrentDemand.Name = "numericUpDownFilamentCurrentDemand";
            this.numericUpDownFilamentCurrentDemand.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownFilamentCurrentDemand.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fil. Current:";
            // 
            // numericUpDownmADemand
            // 
            this.numericUpDownmADemand.Location = new System.Drawing.Point(35, 45);
            this.numericUpDownmADemand.Name = "numericUpDownmADemand";
            this.numericUpDownmADemand.Size = new System.Drawing.Size(82, 20);
            this.numericUpDownmADemand.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "mA:";
            // 
            // numericUpDownkVDemand
            // 
            this.numericUpDownkVDemand.Location = new System.Drawing.Point(35, 19);
            this.numericUpDownkVDemand.Name = "numericUpDownkVDemand";
            this.numericUpDownkVDemand.Size = new System.Drawing.Size(82, 20);
            this.numericUpDownkVDemand.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "kV:";
            // 
            // groupBoxDataLogging
            // 
            this.groupBoxDataLogging.Controls.Add(this.button1);
            this.groupBoxDataLogging.Controls.Add(this.buttonViewFile);
            this.groupBoxDataLogging.Controls.Add(this.buttonToggleLogging);
            this.groupBoxDataLogging.Controls.Add(this.buttonSaveFileName);
            this.groupBoxDataLogging.Controls.Add(this.textBox1);
            this.groupBoxDataLogging.Controls.Add(this.label1);
            this.groupBoxDataLogging.Location = new System.Drawing.Point(6, 255);
            this.groupBoxDataLogging.Name = "groupBoxDataLogging";
            this.groupBoxDataLogging.Size = new System.Drawing.Size(340, 77);
            this.groupBoxDataLogging.TabIndex = 0;
            this.groupBoxDataLogging.TabStop = false;
            this.groupBoxDataLogging.Text = "Data Logging";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonViewFile
            // 
            this.buttonViewFile.Location = new System.Drawing.Point(133, 45);
            this.buttonViewFile.Name = "buttonViewFile";
            this.buttonViewFile.Size = new System.Drawing.Size(118, 23);
            this.buttonViewFile.TabIndex = 4;
            this.buttonViewFile.Text = "View File";
            this.buttonViewFile.UseVisualStyleBackColor = true;
            // 
            // buttonToggleLogging
            // 
            this.buttonToggleLogging.Location = new System.Drawing.Point(9, 45);
            this.buttonToggleLogging.Name = "buttonToggleLogging";
            this.buttonToggleLogging.Size = new System.Drawing.Size(118, 23);
            this.buttonToggleLogging.TabIndex = 3;
            this.buttonToggleLogging.Text = "Start Logging";
            this.buttonToggleLogging.UseVisualStyleBackColor = true;
            // 
            // buttonSaveFileName
            // 
            this.buttonSaveFileName.Location = new System.Drawing.Point(257, 45);
            this.buttonSaveFileName.Name = "buttonSaveFileName";
            this.buttonSaveFileName.Size = new System.Drawing.Size(77, 23);
            this.buttonSaveFileName.TabIndex = 2;
            this.buttonSaveFileName.Text = "Save";
            this.buttonSaveFileName.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name:";
            // 
            // tabPageFilamentControl
            // 
            this.tabPageFilamentControl.Location = new System.Drawing.Point(4, 22);
            this.tabPageFilamentControl.Name = "tabPageFilamentControl";
            this.tabPageFilamentControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFilamentControl.Size = new System.Drawing.Size(768, 369);
            this.tabPageFilamentControl.TabIndex = 1;
            this.tabPageFilamentControl.Text = "Filament Control";
            this.tabPageFilamentControl.UseVisualStyleBackColor = true;
            // 
            // tabPageGeneratorScaling
            // 
            this.tabPageGeneratorScaling.Controls.Add(this.groupBox4);
            this.tabPageGeneratorScaling.Controls.Add(this.groupBox3);
            this.tabPageGeneratorScaling.Controls.Add(this.groupBox2);
            this.tabPageGeneratorScaling.Controls.Add(this.label10);
            this.tabPageGeneratorScaling.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneratorScaling.Name = "tabPageGeneratorScaling";
            this.tabPageGeneratorScaling.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneratorScaling.Size = new System.Drawing.Size(768, 369);
            this.tabPageGeneratorScaling.TabIndex = 2;
            this.tabPageGeneratorScaling.Text = "Scaling & Limits";
            this.tabPageGeneratorScaling.UseVisualStyleBackColor = true;
            // 
            // textBoxGeneratorScalingkV
            // 
            this.textBoxGeneratorScalingkV.Location = new System.Drawing.Point(58, 19);
            this.textBoxGeneratorScalingkV.Name = "textBoxGeneratorScalingkV";
            this.textBoxGeneratorScalingkV.Size = new System.Drawing.Size(100, 20);
            this.textBoxGeneratorScalingkV.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Max kV:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(164, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBoxGeneratorScalingVoltsPerBit);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxGeneratorScalingkV);
            this.groupBox2.Location = new System.Drawing.Point(6, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 77);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "kV Scaling";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "kV/bit:";
            // 
            // textBoxGeneratorScalingVoltsPerBit
            // 
            this.textBoxGeneratorScalingVoltsPerBit.Location = new System.Drawing.Point(58, 45);
            this.textBoxGeneratorScalingVoltsPerBit.Name = "textBoxGeneratorScalingVoltsPerBit";
            this.textBoxGeneratorScalingVoltsPerBit.Size = new System.Drawing.Size(100, 20);
            this.textBoxGeneratorScalingVoltsPerBit.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBoxGeneratorScalingmAPerBit);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBoxGeneratorScailngmA);
            this.groupBox3.Location = new System.Drawing.Point(6, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 77);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "mA Scaling";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "mA/bit:";
            // 
            // textBoxGeneratorScalingmAPerBit
            // 
            this.textBoxGeneratorScalingmAPerBit.Location = new System.Drawing.Point(58, 45);
            this.textBoxGeneratorScalingmAPerBit.Name = "textBoxGeneratorScalingmAPerBit";
            this.textBoxGeneratorScalingmAPerBit.Size = new System.Drawing.Size(100, 20);
            this.textBoxGeneratorScalingmAPerBit.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Max mA:";
            // 
            // textBoxGeneratorScailngmA
            // 
            this.textBoxGeneratorScailngmA.Location = new System.Drawing.Point(58, 19);
            this.textBoxGeneratorScailngmA.Name = "textBoxGeneratorScailngmA";
            this.textBoxGeneratorScailngmA.Size = new System.Drawing.Size(100, 20);
            this.textBoxGeneratorScailngmA.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.textBoxGeneratorScalingAPerBit);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.textBoxGeneratorScalingFilCurrent);
            this.groupBox4.Location = new System.Drawing.Point(6, 177);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 77);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filament Current Scaling";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "A/bit:";
            // 
            // textBoxGeneratorScalingAPerBit
            // 
            this.textBoxGeneratorScalingAPerBit.Location = new System.Drawing.Point(58, 45);
            this.textBoxGeneratorScalingAPerBit.Name = "textBoxGeneratorScalingAPerBit";
            this.textBoxGeneratorScalingAPerBit.Size = new System.Drawing.Size(100, 20);
            this.textBoxGeneratorScalingAPerBit.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Max A:";
            // 
            // textBoxGeneratorScalingFilCurrent
            // 
            this.textBoxGeneratorScalingFilCurrent.Location = new System.Drawing.Point(58, 19);
            this.textBoxGeneratorScalingFilCurrent.Name = "textBoxGeneratorScalingFilCurrent";
            this.textBoxGeneratorScalingFilCurrent.Size = new System.Drawing.Size(100, 20);
            this.textBoxGeneratorScalingFilCurrent.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Spellman XRV GUI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageGeneratorMonitor.ResumeLayout(false);
            this.tabPageGeneratorMonitor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBoxGeneratorStatus.ResumeLayout(false);
            this.groupBoxGeneratorStatus.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxDemand.ResumeLayout(false);
            this.groupBoxDemand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilamentCurrentDemand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownmADemand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownkVDemand)).EndInit();
            this.groupBoxDataLogging.ResumeLayout(false);
            this.groupBoxDataLogging.PerformLayout();
            this.tabPageGeneratorScaling.ResumeLayout(false);
            this.tabPageGeneratorScaling.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxGeneratorComPort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonConnectToGenerator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.IO.Ports.SerialPort GeneratorSerialPort;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxGeneratorModel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGeneratorMonitor;
        private System.Windows.Forms.GroupBox groupBoxDataLogging;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonViewFile;
        private System.Windows.Forms.Button buttonToggleLogging;
        private System.Windows.Forms.Button buttonSaveFileName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageFilamentControl;
        private System.Windows.Forms.GroupBox groupBoxDemand;
        private System.Windows.Forms.NumericUpDown numericUpDownkVDemand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBoxGeneratorStatus;
        private System.Windows.Forms.CheckBox checkBoxHVPSReady;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxFilamentCurrent;
        private System.Windows.Forms.TextBox textBoxmA;
        private System.Windows.Forms.TextBox textBoxkV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSendFilamentPreHeatLimit;
        private System.Windows.Forms.Button buttonSendmADemand;
        private System.Windows.Forms.Button buttonSendkVDemand;
        private System.Windows.Forms.NumericUpDown numericUpDownFilamentCurrentDemand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownmADemand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxInterlock1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBoxArcFault;
        private System.Windows.Forms.CheckBox checkBoxInterlock2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonResetGeneratorFaults;
        private System.Windows.Forms.Button buttonEnableFilament;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBoxFilamentEnabled;
        private System.Windows.Forms.TabPage tabPageGeneratorScaling;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxGeneratorScalingAPerBit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxGeneratorScalingFilCurrent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxGeneratorScalingmAPerBit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxGeneratorScailngmA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxGeneratorScalingVoltsPerBit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxGeneratorScalingkV;
        private System.Windows.Forms.Label label10;
    }
}

