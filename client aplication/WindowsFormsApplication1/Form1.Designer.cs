namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.distanceTxtBox = new System.Windows.Forms.TextBox();
            this.timeTxtBox = new System.Windows.Forms.TextBox();
            this.pwrTxtBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.connectLabel = new System.Windows.Forms.Label();
            this.consoleOutput = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pulseLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rpmLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.requestedPowerLabel = new System.Windows.Forms.Label();
            this.energyLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.actualPowerLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Set power:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model:";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.BackColor = System.Drawing.SystemColors.Control;
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.Location = new System.Drawing.Point(275, 413);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(0, 18);
            this.modelLabel.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Connect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Set time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Set distance:";
            // 
            // distanceTxtBox
            // 
            this.distanceTxtBox.Location = new System.Drawing.Point(114, 76);
            this.distanceTxtBox.Name = "distanceTxtBox";
            this.distanceTxtBox.Size = new System.Drawing.Size(100, 20);
            this.distanceTxtBox.TabIndex = 7;
            // 
            // timeTxtBox
            // 
            this.timeTxtBox.Location = new System.Drawing.Point(114, 49);
            this.timeTxtBox.Name = "timeTxtBox";
            this.timeTxtBox.Size = new System.Drawing.Size(100, 20);
            this.timeTxtBox.TabIndex = 8;
            // 
            // pwrTxtBox
            // 
            this.pwrTxtBox.Location = new System.Drawing.Point(114, 20);
            this.pwrTxtBox.Name = "pwrTxtBox";
            this.pwrTxtBox.Size = new System.Drawing.Size(100, 20);
            this.pwrTxtBox.TabIndex = 9;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(220, 76);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 10;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // connectLabel
            // 
            this.connectLabel.AutoSize = true;
            this.connectLabel.Location = new System.Drawing.Point(257, 9);
            this.connectLabel.Name = "connectLabel";
            this.connectLabel.Size = new System.Drawing.Size(0, 13);
            this.connectLabel.TabIndex = 11;
            // 
            // consoleOutput
            // 
            this.consoleOutput.AutoWordSelection = true;
            this.consoleOutput.Location = new System.Drawing.Point(204, 111);
            this.consoleOutput.Name = "consoleOutput";
            this.consoleOutput.ReadOnly = true;
            this.consoleOutput.Size = new System.Drawing.Size(171, 275);
            this.consoleOutput.TabIndex = 12;
            this.consoleOutput.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Version:";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(88, 382);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(0, 18);
            this.versionLabel.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pulse:";
            // 
            // pulseLabel
            // 
            this.pulseLabel.AutoSize = true;
            this.pulseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseLabel.Location = new System.Drawing.Point(67, 110);
            this.pulseLabel.Name = "pulseLabel";
            this.pulseLabel.Size = new System.Drawing.Size(0, 18);
            this.pulseLabel.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Rpm:";
            // 
            // rpmLabel
            // 
            this.rpmLabel.AutoSize = true;
            this.rpmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpmLabel.Location = new System.Drawing.Point(67, 140);
            this.rpmLabel.Name = "rpmLabel";
            this.rpmLabel.Size = new System.Drawing.Size(0, 18);
            this.rpmLabel.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Speed:";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.Location = new System.Drawing.Point(67, 168);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(0, 18);
            this.speedLabel.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 18);
            this.label12.TabIndex = 21;
            this.label12.Text = "Distance:";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceLabel.Location = new System.Drawing.Point(88, 198);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(0, 18);
            this.distanceLabel.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "Requested power:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "Energy:";
            // 
            // requestedPowerLabel
            // 
            this.requestedPowerLabel.AutoSize = true;
            this.requestedPowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestedPowerLabel.Location = new System.Drawing.Point(146, 226);
            this.requestedPowerLabel.Name = "requestedPowerLabel";
            this.requestedPowerLabel.Size = new System.Drawing.Size(0, 18);
            this.requestedPowerLabel.TabIndex = 25;
            // 
            // energyLabel
            // 
            this.energyLabel.AutoSize = true;
            this.energyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.energyLabel.Location = new System.Drawing.Point(76, 258);
            this.energyLabel.Name = "energyLabel";
            this.energyLabel.Size = new System.Drawing.Size(0, 18);
            this.energyLabel.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Actual power:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 18);
            this.label13.TabIndex = 28;
            this.label13.Text = "Time:";
            // 
            // actualPowerLabel
            // 
            this.actualPowerLabel.AutoSize = true;
            this.actualPowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualPowerLabel.Location = new System.Drawing.Point(111, 319);
            this.actualPowerLabel.Name = "actualPowerLabel";
            this.actualPowerLabel.Size = new System.Drawing.Size(0, 18);
            this.actualPowerLabel.TabIndex = 29;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(63, 289);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 18);
            this.timeLabel.TabIndex = 30;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(301, 76);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 31;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 449);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.actualPowerLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.energyLabel);
            this.Controls.Add(this.requestedPowerLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rpmLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pulseLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.consoleOutput);
            this.Controls.Add(this.connectLabel);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.pwrTxtBox);
            this.Controls.Add(this.timeTxtBox);
            this.Controls.Add(this.distanceTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox distanceTxtBox;
        private System.Windows.Forms.TextBox timeTxtBox;
        private System.Windows.Forms.TextBox pwrTxtBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label connectLabel;
        private System.Windows.Forms.RichTextBox consoleOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label pulseLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label rpmLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label requestedPowerLabel;
        private System.Windows.Forms.Label energyLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label actualPowerLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button refreshButton;
    }
}

