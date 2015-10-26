using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    partial class Graph : UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.valueMaxBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.valueMinBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(155, 57);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(482, 235);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(8, 57);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(141, 116);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.valueMaxBox);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.valueMinBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(133, 90);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Value";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // valueMaxBox
            // 
            this.valueMaxBox.Location = new System.Drawing.Point(36, 40);
            this.valueMaxBox.Name = "valueMaxBox";
            this.valueMaxBox.Size = new System.Drawing.Size(81, 20);
            this.valueMaxBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Min";
            // 
            // valueMinBox
            // 
            this.valueMinBox.Location = new System.Drawing.Point(36, 14);
            this.valueMinBox.Name = "valueMinBox";
            this.valueMinBox.Size = new System.Drawing.Size(81, 20);
            this.valueMinBox.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Reload";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(87, 269);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.chart1);
            this.Name = "Graph";
            this.Size = new System.Drawing.Size(651, 311);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentSearchType = SearchTypes.BETWEEN_VALUES;
                plot();
            }
            catch (FormatException arg)
            {
                MessageBox.Show("Voer alleen getallen in", arg.Source);
            }
        }

        public void setup()
        {
            String[] signals = new String[] { "actualpower", "speed", "rpm", "pulse", "requestedpower", "energy" };

            Array.ForEach(signals, signal =>
            {
                chart1.Series.Add(signal);
                chart1.Series[signal].ChartType = SeriesChartType.Line;
            });

            for (int x = 0; x < chart1.Series.Count; x++)
            {
                seriesCheckBoxes.Add(new CheckBox());  // Create le box

                int totLength = 0;              // Calculate the space we've already taken with our checkboxes
                for (int y = 0; y < x; y++)
                    totLength += 30 + (7 * seriesCheckBoxes[y].Text.Length);

                // Create/Config the box
                seriesCheckBoxes[x].AutoSize = true;
                seriesCheckBoxes[x].Location = new Point(390, 32);
                seriesCheckBoxes[x].Name = chart1.Series[x].Name;
                seriesCheckBoxes[x].Text = chart1.Series[x].Name;
                seriesCheckBoxes[x].Size = new System.Drawing.Size(80, 17);
                seriesCheckBoxes[x].TabIndex = 0;
                seriesCheckBoxes[x].UseVisualStyleBackColor = true;
                seriesCheckBoxes[x].Name = chart1.Series[x].Name;
                seriesCheckBoxes[x].Checked = true;     // Check the value (all signals are enabled by default)
                seriesCheckBoxes[x].Location = new System.Drawing.Point(20 + totLength, 25);

                // Allow the box to en-/disable the corresponding chart data
                seriesCheckBoxes[x].CheckedChanged += new EventHandler(signal_checkbox_clicked);

                // And finally add the button to the panel
                Controls.Add(seriesCheckBoxes[x]);
            }

        }

        public void signal_checkbox_clicked(object sender, EventArgs args)
        {
            CheckBox box = sender as CheckBox;
            // Flip the state
            chart1.Series[box.Name].Enabled = !chart1.Series[box.Name].Enabled;
        }

        #endregion
        private List<CheckBox> seriesCheckBoxes = new List<CheckBox>();
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private Button button1;
        private TextBox valueMaxBox;
        private TextBox valueMinBox;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button4;
    }
}
