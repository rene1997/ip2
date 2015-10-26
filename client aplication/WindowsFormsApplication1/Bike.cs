using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Network;

namespace WindowsFormsApplication1
{ 
    class Bike
    {
        private bool usingComm;
        private BikeCommunication bikeCommunication;
        private Simulator simulator;
        //Values of the bike:
        private string model, versionNumber, status, measurement;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="commportNumber">The number of the commport the bike is connected to.</param>
        public Bike(string commportNumber)
        {
            bikeCommunication = new BikeCommunication(this);
            if (bikeCommunication.ConnectToCom(commportNumber))
            {
                usingComm = true;
                status = "Connected to " + commportNumber;
            }
            else //When there is nothing connected to the commport;
            {
                simulator = new Simulator();
                status = "Simulator";
            }
        }   

        /// <summary>
        /// Set the current status of connection.
        /// </summary>
        /// <param name="status">The new status.</param>
        public void SetStatus(string status)
        {
            this.status = status;
        }

        /// <summary>
        /// Returns the current status of the connection.
        /// </summary>
        /// <returns>Connection status.</returns>
        public string GetStatus()
        {
            if(!bikeCommunication.stillConnected)
                status = "Error: connection lost";
            return status;
        }

        /// <summary>
        /// Reset the bike.
        /// </summary>
        public void Reset()
        {
            if (usingComm)
                bikeCommunication.SendMessage("RS");
            else
                simulator.SendMessage("RS");
        }

        /// <summary>
        /// Set the model field.
        /// </summary>
        /// <param name="model">The new value of the model field.</param>
        public void SetModel(string model)
        {
            this.model = model;
        }

        /// <summary>
        /// Get the value of the model field.
        /// </summary>
        /// <returns>The value of the model field.</returns>
        public string GetModel()
        {
            if (usingComm)
                bikeCommunication.SendMessage("ID");
            else
                model = simulator.SendMessage("ID");
            Thread.Sleep(40);
            return model;
        }

        /// <summary>
        /// Set the version number of the bike.
        /// </summary>
        /// <param name="versionNumber">The new version number of the bike.</param>
        public void SetVersionNumber(string versionNumber)
        {
            this.versionNumber = versionNumber;
        }

        /// <summary>
        /// Get the version number of the bike.
        /// </summary>
        /// <returns>The version number of the bike.</returns>
        public string GetVersionNumber()
        {
            if (usingComm)
                bikeCommunication.SendMessage("VE");
            else
                versionNumber = simulator.SendMessage("VE");
            Thread.Sleep(40);
            return versionNumber;
        }
        
        /// <summary>
        /// Set the current meusurement of the bike.
        /// </summary>
        /// <param name="measurement">The current meusurement.</param>
        public void SetMeasurement(string measurement)
        {
            this.measurement = measurement;
        }

        /// <summary>
        /// Get the current meusurement values from the bike.
        /// </summary>
        /// <returns>The current meusurement.</returns>
        public Measurement GetMeasurement()
        {
            if (usingComm)
                bikeCommunication.SendMessage("ST");
            else
                measurement = simulator.SendMessage("ST");
            Thread.Sleep(40);
            //Splitting the values:
            if(measurement != null)
            {
                String[] values = measurement.Split('\t');
                Measurement m = new Measurement(Int32.Parse(values[0]), Int32.Parse(values[1]), Int32.Parse(values[2]), Int32.Parse(values[3]), Int32.Parse(values[4]), Int32.Parse(values[5]), values[6], Int32.Parse(values[7]));
                return m;
            }
            return null;
        }

        /// <summary>
        /// Set the requested power of the bike.
        /// </summary>
        /// <param name="watt">The requested power in watts, range 0-400</param>
        public void SetPower(int watt)
        {
            if(usingComm)
            {
                bikeCommunication.SendMessage("CM");
                bikeCommunication.SendMessage("PW " + watt);
            }
            else
            {
                simulator.SendMessage("CM");
                simulator.SendMessage("PW " + watt);
            }
        }

        /// <summary>
        /// Set the distance of the bike.
        /// </summary>
        /// <param name="distance">The distance the user has to cycle, value*=10</param>
        public void SetDistance(int distance)
        {
            if (usingComm)
            {
                bikeCommunication.SendMessage("CM");
                bikeCommunication.SendMessage("PD " + distance);
            }
            else
            {
                simulator.SendMessage("CM");
                simulator.SendMessage("PD " + distance*10);
            }
        }

        /// <summary>
        /// Set the time of the bike.
        /// </summary>
        /// <param name="time">The amount of time the user has to cycle.</param>
        public void setTime(int time)
        {
            if (usingComm)
            {
                bikeCommunication.SendMessage("CM");
                bikeCommunication.SendMessage("PT " + time);
            }
            else
            {
                simulator.SendMessage("CM");
                simulator.SendMessage("PT " + time);
            }
        }
    }
}