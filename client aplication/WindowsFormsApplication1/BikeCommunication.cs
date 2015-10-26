using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace WindowsFormsApplication1
{
    class BikeCommunication
    {
        private SerialPort serialPort;
        private Bike parent;
        public bool stillConnected { get; set; }

        /// <summary>
        /// Constructor of the bikeCommunication class.
        /// </summary>
        /// <param name="parent">The parent class.</param>
        public BikeCommunication(Bike parent)
        {
            this.parent = parent;
            this.stillConnected = true;
            serialPort = new SerialPort();
        }

        /// <summary>
        /// Connect to a comm device.
        /// </summary>
        /// <param name="commPortNumber">The port number of the comm device.</param>
        /// <returns>false - when no device is found. true - when sucesfully connected.</returns>
        public bool ConnectToCom(string commPortNumber)
        {
            try
            {
                serialPort = new SerialPort(commPortNumber, 9600, Parity.None, 8, StopBits.One);
                serialPort.Open();
            }
            catch(Exception e)
            {
                return false;
            }
            Thread incommingMessageThread = new Thread(new ThreadStart(ReadMessage));
            incommingMessageThread.IsBackground = true;
            incommingMessageThread.Start();
            return true;
        }

        /// <summary>
        /// Sends message to the connected comm device.
        /// </summary>
        /// <param name="message">The message you want to send.</param>
        public void SendMessage(string message)
        {
            if(stillConnected)
                serialPort.WriteLine(message);
        }

        /// <summary>
        /// Method that runs in a thread, recieves messages from the comm device.
        /// </summary>
        public void ReadMessage()
        {
            string message = "";

            while (stillConnected)
            {
                try
                {
                     message = serialPort.ReadLine();
                }
                catch(Exception e)
                {
                    stillConnected = false;
                    serialPort.Close();
                    Thread.CurrentThread.Abort();
                }
                //Handling incomming messages: 
                if(message != "")
                {
                    String[] splittedMessage1 = message.Split(' ');
                    String[] splittedMessage2 = message.Split('\t');
                    //Model or version number recieved:
                    if(splittedMessage1.Length == 1 && splittedMessage2.Length == 1) 
                    {
                        char[] splittedMessage = message.ToCharArray();
                        //checking if it's a  version number or model number:
                        if (char.IsLetter(splittedMessage[0]))
                            parent.SetModel(message);
                        else
                            parent.SetVersionNumber(message);
                    }
                    //Status:
                    else
                        parent.SetMeasurement(message);
                }
            }
        }
    }
}