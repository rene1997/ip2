using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private String commPortLetter;
        private SerialPort commPort;
        private bool usingCommport;
        private Simulator simulator;

        public Form1()
        {
            commPort = new SerialPort();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(commPort.IsOpen) 
                commPort.WriteLine("rs");
            if (!usingCommport && simulator != null)
                consoleOutput.Text = simulator.ReceiveCommand("RS");
            pwrTxtBox.Text = "";
            timeTxtBox.Text = "";
            distanceTxtBox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CommForm commChooser = new CommForm();
            DialogResult dialogResult = commChooser.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                commPortLetter = commChooser.getCommport;
                commPort = new SerialPort(commPortLetter, 9600, Parity.None, 8, StopBits.One);
              try
              {
                 commPort.Open();
                    usingCommport = true;
              }
              catch(Exception ex)
              {
                    usingCommport = false;
              }
                   
                if(usingCommport)
                {
                    Thread readThread = new Thread(new ThreadStart(new SerialRead(commPort, this).ReadSerial));
                    readThread.Start();
                    connectLabel.Text = "Connected to: " + commPortLetter;
                    commPort.WriteLine("ID");
                    commPort.WriteLine("VE");
                }
                else
                {
                    connectLabel.Text = "Connected to: Simulator";
                    simulator = new Simulator();
                    modelLabel.Text = simulator.ReceiveCommand("ID");
                    versionLabel.Text = simulator.ReceiveCommand("VE");
                }
                
            }
            commChooser.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(commPort.IsOpen || simulator != null)
            {
                if (usingCommport)
                    commPort.WriteLine("cm");
                else
                    simulator.ReceiveCommand("CM");
                if(pwrTxtBox.Text != "")
                {
                    if (usingCommport)
                        commPort.WriteLine("PW " + pwrTxtBox.Text);
                    else
                    {
                        String status = simulator.ReceiveCommand("PW " + pwrTxtBox.Text);
                        consoleOutput.Text = status;
                        if(status != "ERROR")
                            outputStatus(status);
                    }   
                }
                if (timeTxtBox.Text != "")
                {
                    if(usingCommport)
                        commPort.WriteLine("PT " + timeTxtBox.Text);
                    else
                    {
                        String status = simulator.ReceiveCommand("PT " + timeTxtBox.Text);
                        consoleOutput.Text = status;
                        if (status != "ERROR")
                            outputStatus(status);
                    }
                }
                if (distanceTxtBox.Text != "")
                {
                    if(usingCommport)
                        commPort.WriteLine("PD " + distanceTxtBox.Text);
                    else
                    {
                        String status = simulator.ReceiveCommand("PD " + distanceTxtBox.Text);
                        consoleOutput.Text = status;
                        if (status != "ERROR")
                            outputStatus(status);
                    }
                }
            }
        }

        delegate void SetTextCallback(string text);

        public void setConsoleOutput(string text)
        {
            if (this.consoleOutput.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setConsoleOutput);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.consoleOutput.Text = text;
            }
        }

        public void setModelNumber(string modelNumber)
        {
            if (this.modelLabel.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setModelNumber);
                this.Invoke(d, new object[] { modelNumber });
            }
            else
            {
                this.modelLabel.Text = modelNumber;
            }
        }

        public void setLabel(String text, String label)
        { 
            switch (label)
            {
                case "pulse":
                    setPulseLabel(text);
                    break;
                case "rpm":
                    setRpmLabel(text);
                    break;
                case "speed":
                    setSpeedLabel(text);
                    break;
                case "distance":
                    setDistanceLabel(text);
                    break;
                case "requested_power":
                    setRequestedPowerLabel(text);
                    break;
                case "energy":
                    setEnergyLabel(text);
                    break;
                case "time":
                    setTimeLabel(text);
                    break;
                case "actual_power":
                    setActuelPowerLabel(text);
                    break;
            }
        }

        private void setPulseLabel(String text)
        {
            if (this.pulseLabel.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setPulseLabel);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.pulseLabel.Text = text;
            }
        }

        private void setRpmLabel(String text)
        {
            if (this.rpmLabel.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setRpmLabel);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.rpmLabel.Text = text;
            }
        }

        private void setDistanceLabel(String text)
        {
            if (this.distanceLabel.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setDistanceLabel);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.distanceLabel.Text = text;
            }
        }

        private void setRequestedPowerLabel(String text)
        {
            if (this.requestedPowerLabel.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setRequestedPowerLabel);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.requestedPowerLabel.Text = text;
            }
        }

        private void setEnergyLabel(String text)
        {
            if (this.energyLabel.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setEnergyLabel);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.energyLabel.Text = text;
            }
        }

        private void setTimeLabel(String text)
        {
            if (this.timeLabel.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setTimeLabel);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.timeLabel.Text = text;
            }
        }

        private void setActuelPowerLabel(String text)
        {
            if (this.actualPowerLabel.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setActuelPowerLabel);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.actualPowerLabel.Text = text;
            }
        }



        private void setSpeedLabel(String text)
        {
            if (this.speedLabel.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setSpeedLabel);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.speedLabel.Text = text;
            }
        }

        public void setVersionNumber(string versionNumber)
        {
            if (this.modelLabel.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setVersionNumber);
                this.Invoke(d, new object[] { versionNumber });
            }
            else
            {
                this.versionLabel.Text = versionNumber;
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            if(usingCommport)
                commPort.WriteLine("ST");
            else
            {
                String status = simulator.ReceiveCommand("ST");
                consoleOutput.Text = status;
                outputStatus(status);
            }
                
        }

        public void outputStatus(String status)
        {
            String[] values = status.Split('\t');
            setLabel(values[0], "pulse");
            setLabel(values[1], "rpm");
            setLabel(values[2], "speed");
            setLabel(values[3], "distance");
            setLabel(values[4], "requested_power");
            setLabel(values[5], "energy");
            setLabel(values[6], "time");
            setLabel(values[7], "actual_power");
        }
    }

    public class SerialRead
    {

        private SerialPort commPort;
        private Form1 parent;
        private bool modelSet;

        public SerialRead(SerialPort commPort, Form1 parent)
        {
            this.commPort = commPort;
            this.parent = parent;
        }

        public void ReadSerial()
        {
            while (true)
            {
                string input = commPort.ReadLine();
                if (input != "")
                {
                        String[] splittedInput = input.Split(' ');
                        String[] splittedInput2 = input.Split('\t');
                        if (splittedInput.Length == 1 && splittedInput2.Length == 1) //model & version number
                        {

                            char[] splittedString = input.ToCharArray();
                            if (char.IsLetter(splittedString[0]))
                            {
                                //Modelnumber
                                if(!modelSet)
                                {
                                parent.setModelNumber(input);
                                modelSet = !modelSet;
                                }
                            }
                            else
                            {
                                //Version number
                                parent.setVersionNumber(input);
                            }
                        }
                        else //The status reply
                        {
                        parent.outputStatus(input);
                    }

                    String display = "";
                    for(int x = 0; x < splittedInput2.Length; x++)
                    {
                        display += splittedInput2[x] + "\n";
                    }
                   parent.setConsoleOutput(display);
                }
                    

                
            }
        }
    }
}
