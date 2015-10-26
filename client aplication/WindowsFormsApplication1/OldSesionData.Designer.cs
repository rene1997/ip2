namespace WindowsFormsApplication1
{
    partial class OldSesionData
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
            this.listBox_Data = new System.Windows.Forms.ListBox();
            this.button_Select = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.requestedPowerLabel = new System.Windows.Forms.Label();
            this.label_RequestedPower = new System.Windows.Forms.Label();
            this.energyLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.heartBeatLabel = new System.Windows.Forms.Label();
            this.actualPowerLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label_Energy = new System.Windows.Forms.Label();
            this.label_Distance = new System.Windows.Forms.Label();
            this.label_CurrentPower = new System.Windows.Forms.Label();
            this.label_Speed = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.label_RoundPerMin = new System.Windows.Forms.Label();
            this.label_HeartBeat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_Data
            // 
            this.listBox_Data.FormattingEnabled = true;
            this.listBox_Data.Location = new System.Drawing.Point(268, 12);
            this.listBox_Data.Name = "listBox_Data";
            this.listBox_Data.Size = new System.Drawing.Size(540, 147);
            this.listBox_Data.TabIndex = 0;
            this.listBox_Data.SelectedIndexChanged += new System.EventHandler(this.listBox_Data_SelectedIndexChanged);
            // 
            // button_Select
            // 
            this.button_Select.Location = new System.Drawing.Point(12, 12);
            this.button_Select.Name = "button_Select";
            this.button_Select.Size = new System.Drawing.Size(235, 42);
            this.button_Select.TabIndex = 1;
            this.button_Select.Text = "Select";
            this.button_Select.UseVisualStyleBackColor = true;
            this.button_Select.Click += new System.EventHandler(this.button_Select_Click);
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(12, 60);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(235, 42);
            this.button_Back.TabIndex = 2;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(12, 108);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(235, 42);
            this.button_Exit.TabIndex = 3;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // requestedPowerLabel
            // 
            this.requestedPowerLabel.AutoSize = true;
            this.requestedPowerLabel.BackColor = System.Drawing.Color.Transparent;
            this.requestedPowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestedPowerLabel.Location = new System.Drawing.Point(145, 366);
            this.requestedPowerLabel.Name = "requestedPowerLabel";
            this.requestedPowerLabel.Size = new System.Drawing.Size(0, 18);
            this.requestedPowerLabel.TabIndex = 44;
            // 
            // label_RequestedPower
            // 
            this.label_RequestedPower.AutoSize = true;
            this.label_RequestedPower.BackColor = System.Drawing.Color.Transparent;
            this.label_RequestedPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RequestedPower.Location = new System.Drawing.Point(9, 366);
            this.label_RequestedPower.Name = "label_RequestedPower";
            this.label_RequestedPower.Size = new System.Drawing.Size(130, 18);
            this.label_RequestedPower.TabIndex = 43;
            this.label_RequestedPower.Text = "Requested Power:";
            // 
            // energyLabel
            // 
            this.energyLabel.AutoSize = true;
            this.energyLabel.BackColor = System.Drawing.Color.Transparent;
            this.energyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.energyLabel.Location = new System.Drawing.Point(68, 338);
            this.energyLabel.Name = "energyLabel";
            this.energyLabel.Size = new System.Drawing.Size(0, 18);
            this.energyLabel.TabIndex = 42;
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.distanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceLabel.Location = new System.Drawing.Point(85, 313);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(0, 18);
            this.distanceLabel.TabIndex = 41;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.BackColor = System.Drawing.Color.Transparent;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.Location = new System.Drawing.Point(68, 288);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(0, 18);
            this.speedLabel.TabIndex = 40;
            // 
            // heartBeatLabel
            // 
            this.heartBeatLabel.AutoSize = true;
            this.heartBeatLabel.BackColor = System.Drawing.Color.Transparent;
            this.heartBeatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heartBeatLabel.Location = new System.Drawing.Point(93, 241);
            this.heartBeatLabel.Name = "heartBeatLabel";
            this.heartBeatLabel.Size = new System.Drawing.Size(0, 18);
            this.heartBeatLabel.TabIndex = 39;
            // 
            // actualPowerLabel
            // 
            this.actualPowerLabel.AutoSize = true;
            this.actualPowerLabel.BackColor = System.Drawing.Color.Transparent;
            this.actualPowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualPowerLabel.Location = new System.Drawing.Point(123, 193);
            this.actualPowerLabel.Name = "actualPowerLabel";
            this.actualPowerLabel.Size = new System.Drawing.Size(0, 18);
            this.actualPowerLabel.TabIndex = 38;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(60, 216);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 18);
            this.timeLabel.TabIndex = 37;
            // 
            // label_Energy
            // 
            this.label_Energy.AutoSize = true;
            this.label_Energy.BackColor = System.Drawing.Color.Transparent;
            this.label_Energy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_Energy.Location = new System.Drawing.Point(9, 338);
            this.label_Energy.Name = "label_Energy";
            this.label_Energy.Size = new System.Drawing.Size(58, 18);
            this.label_Energy.TabIndex = 36;
            this.label_Energy.Text = "Energy:";
            this.label_Energy.Click += new System.EventHandler(this.LEnergy_Click);
            // 
            // label_Distance
            // 
            this.label_Distance.AutoSize = true;
            this.label_Distance.BackColor = System.Drawing.Color.Transparent;
            this.label_Distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_Distance.Location = new System.Drawing.Point(9, 313);
            this.label_Distance.Name = "label_Distance";
            this.label_Distance.Size = new System.Drawing.Size(70, 18);
            this.label_Distance.TabIndex = 35;
            this.label_Distance.Text = "Distance:";
            this.label_Distance.Click += new System.EventHandler(this.LDistance_Click);
            // 
            // label_CurrentPower
            // 
            this.label_CurrentPower.AutoSize = true;
            this.label_CurrentPower.BackColor = System.Drawing.Color.Transparent;
            this.label_CurrentPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_CurrentPower.Location = new System.Drawing.Point(9, 193);
            this.label_CurrentPower.Name = "label_CurrentPower";
            this.label_CurrentPower.Size = new System.Drawing.Size(108, 18);
            this.label_CurrentPower.TabIndex = 30;
            this.label_CurrentPower.Text = "Current Power:";
            // 
            // label_Speed
            // 
            this.label_Speed.AutoSize = true;
            this.label_Speed.BackColor = System.Drawing.Color.Transparent;
            this.label_Speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_Speed.Location = new System.Drawing.Point(9, 288);
            this.label_Speed.Name = "label_Speed";
            this.label_Speed.Size = new System.Drawing.Size(54, 18);
            this.label_Speed.TabIndex = 34;
            this.label_Speed.Text = "Speed:";
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.BackColor = System.Drawing.Color.Transparent;
            this.label_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_Time.Location = new System.Drawing.Point(9, 216);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(45, 18);
            this.label_Time.TabIndex = 31;
            this.label_Time.Text = "Time:";
            // 
            // label_RoundPerMin
            // 
            this.label_RoundPerMin.AutoSize = true;
            this.label_RoundPerMin.BackColor = System.Drawing.Color.Transparent;
            this.label_RoundPerMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_RoundPerMin.Location = new System.Drawing.Point(9, 263);
            this.label_RoundPerMin.Name = "label_RoundPerMin";
            this.label_RoundPerMin.Size = new System.Drawing.Size(139, 18);
            this.label_RoundPerMin.TabIndex = 33;
            this.label_RoundPerMin.Text = "Rounds Per Minute:";
            // 
            // label_HeartBeat
            // 
            this.label_HeartBeat.AutoSize = true;
            this.label_HeartBeat.BackColor = System.Drawing.Color.Transparent;
            this.label_HeartBeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_HeartBeat.Location = new System.Drawing.Point(9, 241);
            this.label_HeartBeat.Name = "label_HeartBeat";
            this.label_HeartBeat.Size = new System.Drawing.Size(78, 18);
            this.label_HeartBeat.TabIndex = 32;
            this.label_HeartBeat.Text = "HeartBeat:";
            // 
            // OldSesionData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 420);
            this.Controls.Add(this.requestedPowerLabel);
            this.Controls.Add(this.label_RequestedPower);
            this.Controls.Add(this.energyLabel);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.heartBeatLabel);
            this.Controls.Add(this.actualPowerLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label_Energy);
            this.Controls.Add(this.label_Distance);
            this.Controls.Add(this.label_CurrentPower);
            this.Controls.Add(this.label_Speed);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.label_RoundPerMin);
            this.Controls.Add(this.label_HeartBeat);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Select);
            this.Controls.Add(this.listBox_Data);
            this.Name = "OldSesionData";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.OldSesionData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Data;
        private System.Windows.Forms.Button button_Select;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label requestedPowerLabel;
        private System.Windows.Forms.Label label_RequestedPower;
        private System.Windows.Forms.Label energyLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label heartBeatLabel;
        private System.Windows.Forms.Label actualPowerLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label_Energy;
        private System.Windows.Forms.Label label_Distance;
        private System.Windows.Forms.Label label_CurrentPower;
        private System.Windows.Forms.Label label_Speed;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label_RoundPerMin;
        private System.Windows.Forms.Label label_HeartBeat;
    }
}