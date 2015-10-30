namespace WindowsFormsApplication1
{
    partial class FormClient
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setComPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startVideoTrainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minVideoWorkoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOldDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TChatView = new System.Windows.Forms.TextBox();
            this.TChatSend = new System.Windows.Forms.TextBox();
            this.BSend = new System.Windows.Forms.Button();
            this.LCurrentPower = new System.Windows.Forms.Label();
            this.LTime = new System.Windows.Forms.Label();
            this.LHeartBeat = new System.Windows.Forms.Label();
            this.LRoundPerMin = new System.Windows.Forms.Label();
            this.LSpeed = new System.Windows.Forms.Label();
            this.LDistance = new System.Windows.Forms.Label();
            this.LEnergy = new System.Windows.Forms.Label();
            this.BComConnect = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.actualPowerLabel = new System.Windows.Forms.Label();
            this.heartBeatLabel = new System.Windows.Forms.Label();
            this.rpmLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.energyLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.requestedPowerLabel = new System.Windows.Forms.Label();
            this.pwrTxtBox = new System.Windows.Forms.TextBox();
            this.timeTxtBox = new System.Windows.Forms.TextBox();
            this.distanceTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.RTBChatText = new System.Windows.Forms.RichTextBox();
            this.broadCastButton = new System.Windows.Forms.Button();
            this.connectedUsers = new System.Windows.Forms.ComboBox();
            this.newClient = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.BStartTraining = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.optionsToolStripMenuItem,
            this.viewOldDataToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFileToolStripMenuItem,
            this.quickSaveToolStripMenuItem,
            this.loadFileToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.saveFileToolStripMenuItem.Text = "save file";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // quickSaveToolStripMenuItem
            // 
            this.quickSaveToolStripMenuItem.Name = "quickSaveToolStripMenuItem";
            this.quickSaveToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.quickSaveToolStripMenuItem.Text = "quick save";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.loadFileToolStripMenuItem.Text = "load file";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.quitToolStripMenuItem.Text = "quit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setComPortToolStripMenuItem,
            this.connectToServerToolStripMenuItem,
            this.startVideoTrainingToolStripMenuItem,
            this.minVideoWorkoutToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // setComPortToolStripMenuItem
            // 
            this.setComPortToolStripMenuItem.Name = "setComPortToolStripMenuItem";
            this.setComPortToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.setComPortToolStripMenuItem.Text = "set ComPort";
            // 
            // connectToServerToolStripMenuItem
            // 
            this.connectToServerToolStripMenuItem.Name = "connectToServerToolStripMenuItem";
            this.connectToServerToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.connectToServerToolStripMenuItem.Text = "connect to Server";
            // 
            // startVideoTrainingToolStripMenuItem
            // 
            this.startVideoTrainingToolStripMenuItem.Name = "startVideoTrainingToolStripMenuItem";
            this.startVideoTrainingToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.startVideoTrainingToolStripMenuItem.Text = "15 min video workout";
            this.startVideoTrainingToolStripMenuItem.Click += new System.EventHandler(this.startVideoTrainingToolStripMenuItem_Click);
            // 
            // minVideoWorkoutToolStripMenuItem
            // 
            this.minVideoWorkoutToolStripMenuItem.Name = "minVideoWorkoutToolStripMenuItem";
            this.minVideoWorkoutToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.minVideoWorkoutToolStripMenuItem.Text = "45 min video workout";
            this.minVideoWorkoutToolStripMenuItem.Click += new System.EventHandler(this.minVideoWorkoutToolStripMenuItem_Click);
            // 
            // viewOldDataToolStripMenuItem
            // 
            this.viewOldDataToolStripMenuItem.Name = "viewOldDataToolStripMenuItem";
            this.viewOldDataToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.viewOldDataToolStripMenuItem.Text = "view old data";
            this.viewOldDataToolStripMenuItem.Click += new System.EventHandler(this.viewOldDataToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.findToolStripMenuItem.Text = "Find";
            // 
            // TChatView
            // 
            this.TChatView.Enabled = false;
            this.TChatView.ForeColor = System.Drawing.SystemColors.Menu;
            this.TChatView.Location = new System.Drawing.Point(15, 380);
            this.TChatView.Multiline = true;
            this.TChatView.Name = "TChatView";
            this.TChatView.ReadOnly = true;
            this.TChatView.Size = new System.Drawing.Size(497, 223);
            this.TChatView.TabIndex = 0;
            // 
            // TChatSend
            // 
            this.TChatSend.Location = new System.Drawing.Point(12, 609);
            this.TChatSend.Name = "TChatSend";
            this.TChatSend.Size = new System.Drawing.Size(326, 20);
            this.TChatSend.TabIndex = 2;
            // 
            // BSend
            // 
            this.BSend.Location = new System.Drawing.Point(353, 609);
            this.BSend.Name = "BSend";
            this.BSend.Size = new System.Drawing.Size(75, 23);
            this.BSend.TabIndex = 3;
            this.BSend.Text = "send";
            this.BSend.UseVisualStyleBackColor = true;
            this.BSend.Click += new System.EventHandler(this.BSend_Click);
            // 
            // LCurrentPower
            // 
            this.LCurrentPower.AutoSize = true;
            this.LCurrentPower.BackColor = System.Drawing.Color.Transparent;
            this.LCurrentPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LCurrentPower.Location = new System.Drawing.Point(9, 67);
            this.LCurrentPower.Name = "LCurrentPower";
            this.LCurrentPower.Size = new System.Drawing.Size(108, 18);
            this.LCurrentPower.TabIndex = 6;
            this.LCurrentPower.Text = "Current Power:";
            // 
            // LTime
            // 
            this.LTime.AutoSize = true;
            this.LTime.BackColor = System.Drawing.Color.Transparent;
            this.LTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LTime.Location = new System.Drawing.Point(9, 90);
            this.LTime.Name = "LTime";
            this.LTime.Size = new System.Drawing.Size(45, 18);
            this.LTime.TabIndex = 7;
            this.LTime.Text = "Time:";
            // 
            // LHeartBeat
            // 
            this.LHeartBeat.AutoSize = true;
            this.LHeartBeat.BackColor = System.Drawing.Color.Transparent;
            this.LHeartBeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LHeartBeat.Location = new System.Drawing.Point(9, 115);
            this.LHeartBeat.Name = "LHeartBeat";
            this.LHeartBeat.Size = new System.Drawing.Size(78, 18);
            this.LHeartBeat.TabIndex = 8;
            this.LHeartBeat.Text = "HeartBeat:";
            // 
            // LRoundPerMin
            // 
            this.LRoundPerMin.AutoSize = true;
            this.LRoundPerMin.BackColor = System.Drawing.Color.Transparent;
            this.LRoundPerMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LRoundPerMin.Location = new System.Drawing.Point(9, 137);
            this.LRoundPerMin.Name = "LRoundPerMin";
            this.LRoundPerMin.Size = new System.Drawing.Size(139, 18);
            this.LRoundPerMin.TabIndex = 9;
            this.LRoundPerMin.Text = "Rounds Per Minute:";
            // 
            // LSpeed
            // 
            this.LSpeed.AutoSize = true;
            this.LSpeed.BackColor = System.Drawing.Color.Transparent;
            this.LSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LSpeed.Location = new System.Drawing.Point(9, 162);
            this.LSpeed.Name = "LSpeed";
            this.LSpeed.Size = new System.Drawing.Size(54, 18);
            this.LSpeed.TabIndex = 10;
            this.LSpeed.Text = "Speed:";
            // 
            // LDistance
            // 
            this.LDistance.AutoSize = true;
            this.LDistance.BackColor = System.Drawing.Color.Transparent;
            this.LDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LDistance.Location = new System.Drawing.Point(9, 187);
            this.LDistance.Name = "LDistance";
            this.LDistance.Size = new System.Drawing.Size(70, 18);
            this.LDistance.TabIndex = 11;
            this.LDistance.Text = "Distance:";
            // 
            // LEnergy
            // 
            this.LEnergy.AutoSize = true;
            this.LEnergy.BackColor = System.Drawing.Color.Transparent;
            this.LEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LEnergy.Location = new System.Drawing.Point(9, 212);
            this.LEnergy.Name = "LEnergy";
            this.LEnergy.Size = new System.Drawing.Size(58, 18);
            this.LEnergy.TabIndex = 12;
            this.LEnergy.Text = "Energy:";
            // 
            // BComConnect
            // 
            this.BComConnect.Location = new System.Drawing.Point(15, 336);
            this.BComConnect.Name = "BComConnect";
            this.BComConnect.Size = new System.Drawing.Size(110, 38);
            this.BComConnect.TabIndex = 13;
            this.BComConnect.Text = "Com Connect";
            this.BComConnect.UseVisualStyleBackColor = true;
            this.BComConnect.Click += new System.EventHandler(this.BComConnect_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(131, 336);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(105, 38);
            this.resetButton.TabIndex = 14;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Model:";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.BackColor = System.Drawing.Color.Transparent;
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.Location = new System.Drawing.Point(71, 277);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(0, 18);
            this.modelLabel.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Version:";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(81, 305);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(0, 18);
            this.versionLabel.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(396, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Status:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(302, 345);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 18);
            this.statusLabel.TabIndex = 20;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(60, 90);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 18);
            this.timeLabel.TabIndex = 21;
            // 
            // actualPowerLabel
            // 
            this.actualPowerLabel.AutoSize = true;
            this.actualPowerLabel.BackColor = System.Drawing.Color.Transparent;
            this.actualPowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualPowerLabel.Location = new System.Drawing.Point(123, 67);
            this.actualPowerLabel.Name = "actualPowerLabel";
            this.actualPowerLabel.Size = new System.Drawing.Size(0, 18);
            this.actualPowerLabel.TabIndex = 22;
            // 
            // heartBeatLabel
            // 
            this.heartBeatLabel.AutoSize = true;
            this.heartBeatLabel.BackColor = System.Drawing.Color.Transparent;
            this.heartBeatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heartBeatLabel.Location = new System.Drawing.Point(93, 115);
            this.heartBeatLabel.Name = "heartBeatLabel";
            this.heartBeatLabel.Size = new System.Drawing.Size(0, 18);
            this.heartBeatLabel.TabIndex = 23;
            // 
            // rpmLabel
            // 
            this.rpmLabel.AutoSize = true;
            this.rpmLabel.BackColor = System.Drawing.Color.Transparent;
            this.rpmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpmLabel.Location = new System.Drawing.Point(154, 137);
            this.rpmLabel.Name = "rpmLabel";
            this.rpmLabel.Size = new System.Drawing.Size(0, 18);
            this.rpmLabel.TabIndex = 24;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.BackColor = System.Drawing.Color.Transparent;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.Location = new System.Drawing.Point(68, 162);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(0, 18);
            this.speedLabel.TabIndex = 25;
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.distanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceLabel.Location = new System.Drawing.Point(85, 187);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(0, 18);
            this.distanceLabel.TabIndex = 26;
            // 
            // energyLabel
            // 
            this.energyLabel.AutoSize = true;
            this.energyLabel.BackColor = System.Drawing.Color.Transparent;
            this.energyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.energyLabel.Location = new System.Drawing.Point(68, 212);
            this.energyLabel.Name = "energyLabel";
            this.energyLabel.Size = new System.Drawing.Size(0, 18);
            this.energyLabel.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Requested Power:";
            // 
            // requestedPowerLabel
            // 
            this.requestedPowerLabel.AutoSize = true;
            this.requestedPowerLabel.BackColor = System.Drawing.Color.Transparent;
            this.requestedPowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestedPowerLabel.Location = new System.Drawing.Point(145, 240);
            this.requestedPowerLabel.Name = "requestedPowerLabel";
            this.requestedPowerLabel.Size = new System.Drawing.Size(0, 18);
            this.requestedPowerLabel.TabIndex = 29;
            // 
            // pwrTxtBox
            // 
            this.pwrTxtBox.Location = new System.Drawing.Point(350, 36);
            this.pwrTxtBox.Name = "pwrTxtBox";
            this.pwrTxtBox.Size = new System.Drawing.Size(100, 20);
            this.pwrTxtBox.TabIndex = 35;
            this.pwrTxtBox.TextChanged += new System.EventHandler(this.pwrTxtBox_TextChanged);
            // 
            // timeTxtBox
            // 
            this.timeTxtBox.Location = new System.Drawing.Point(350, 65);
            this.timeTxtBox.Name = "timeTxtBox";
            this.timeTxtBox.Size = new System.Drawing.Size(100, 20);
            this.timeTxtBox.TabIndex = 34;
            this.timeTxtBox.TextChanged += new System.EventHandler(this.timeTxtBox_TextChanged);
            // 
            // distanceTxtBox
            // 
            this.distanceTxtBox.Location = new System.Drawing.Point(350, 92);
            this.distanceTxtBox.Name = "distanceTxtBox";
            this.distanceTxtBox.Size = new System.Drawing.Size(100, 20);
            this.distanceTxtBox.TabIndex = 33;
            this.distanceTxtBox.TextChanged += new System.EventHandler(this.distanceTxtBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(259, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Set distance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(259, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "Set time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(259, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 18);
            this.label7.TabIndex = 30;
            this.label7.Text = "Set power:";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(375, 118);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 36;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // RTBChatText
            // 
            this.RTBChatText.BackColor = System.Drawing.Color.White;
            this.RTBChatText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RTBChatText.Location = new System.Drawing.Point(28, 391);
            this.RTBChatText.Name = "RTBChatText";
            this.RTBChatText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.RTBChatText.Size = new System.Drawing.Size(474, 196);
            this.RTBChatText.TabIndex = 37;
            this.RTBChatText.Text = "";
            // 
            // broadCastButton
            // 
            this.broadCastButton.Location = new System.Drawing.Point(434, 609);
            this.broadCastButton.Name = "broadCastButton";
            this.broadCastButton.Size = new System.Drawing.Size(78, 23);
            this.broadCastButton.TabIndex = 14;
            this.broadCastButton.Text = "Broadcast";
            this.broadCastButton.UseVisualStyleBackColor = true;
            this.broadCastButton.Click += new System.EventHandler(this.broadCastButton_Click);
            // 
            // connectedUsers
            // 
            this.connectedUsers.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.connectedUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.connectedUsers.FormattingEnabled = true;
            this.connectedUsers.Location = new System.Drawing.Point(329, 147);
            this.connectedUsers.Name = "connectedUsers";
            this.connectedUsers.Size = new System.Drawing.Size(121, 21);
            this.connectedUsers.TabIndex = 37;
            this.connectedUsers.SelectedIndexChanged += new System.EventHandler(this.connectedUsers_SelectedIndexChanged);
            // 
            // newClient
            // 
            this.newClient.Location = new System.Drawing.Point(13, 336);
            this.newClient.Name = "newClient";
            this.newClient.Size = new System.Drawing.Size(113, 38);
            this.newClient.TabIndex = 38;
            this.newClient.Text = "New client";
            this.newClient.UseVisualStyleBackColor = true;
            this.newClient.Click += new System.EventHandler(this.newClient_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(533, 36);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(311, 593);
            this.chart1.TabIndex = 39;
            this.chart1.Text = "chart1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 25);
            this.label8.TabIndex = 40;
            this.label8.Text = "Latest measurement:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // BStartTraining
            // 
            this.BStartTraining.Location = new System.Drawing.Point(242, 336);
            this.BStartTraining.Name = "BStartTraining";
            this.BStartTraining.Size = new System.Drawing.Size(129, 38);
            this.BStartTraining.TabIndex = 41;
            this.BStartTraining.Text = "Start Astrand training";
            this.BStartTraining.UseVisualStyleBackColor = true;
            this.BStartTraining.Click += new System.EventHandler(this.BStartTraining_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormClient
            // 
            this.AcceptButton = this.BSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(521, 636);
            this.Controls.Add(this.BStartTraining);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.newClient);
            this.Controls.Add(this.RTBChatText);
            this.Controls.Add(this.connectedUsers);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.pwrTxtBox);
            this.Controls.Add(this.timeTxtBox);
            this.Controls.Add(this.distanceTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.requestedPowerLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.energyLabel);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.rpmLabel);
            this.Controls.Add(this.heartBeatLabel);
            this.Controls.Add(this.actualPowerLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BSend);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.TChatSend);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TChatView);
            this.Controls.Add(this.BComConnect);
            this.Controls.Add(this.LEnergy);
            this.Controls.Add(this.LDistance);
            this.Controls.Add(this.LCurrentPower);
            this.Controls.Add(this.LSpeed);
            this.Controls.Add(this.LTime);
            this.Controls.Add(this.LRoundPerMin);
            this.Controls.Add(this.LHeartBeat);
            this.Controls.Add(this.broadCastButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormClient";
            this.Text = "Client App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClient_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setComPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToServerToolStripMenuItem;
        private System.Windows.Forms.TextBox TChatView;
        private System.Windows.Forms.TextBox TChatSend;
        private System.Windows.Forms.Button BSend;
        private System.Windows.Forms.Label LCurrentPower;
        private System.Windows.Forms.Label LTime;
        private System.Windows.Forms.Label LHeartBeat;
        private System.Windows.Forms.Label LRoundPerMin;
        private System.Windows.Forms.Label LSpeed;
        private System.Windows.Forms.Label LDistance;
        private System.Windows.Forms.Label LEnergy;
        private System.Windows.Forms.Button BComConnect;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label actualPowerLabel;
        private System.Windows.Forms.Label heartBeatLabel;
        private System.Windows.Forms.Label rpmLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label energyLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label requestedPowerLabel;
        private System.Windows.Forms.TextBox pwrTxtBox;
        private System.Windows.Forms.TextBox timeTxtBox;
        private System.Windows.Forms.TextBox distanceTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.RichTextBox RTBChatText;
        private System.Windows.Forms.Button broadCastButton;
        private System.Windows.Forms.ComboBox connectedUsers;
        private System.Windows.Forms.Button newClient;
        private System.Windows.Forms.ToolStripMenuItem viewOldDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startVideoTrainingToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem minVideoWorkoutToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BStartTraining;
        public System.Windows.Forms.Timer timer1;
    }
}

