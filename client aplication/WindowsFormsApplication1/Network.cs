using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    public class Network
    {
        private NetworkCommunication networkCommunication;
        public string status { get; set; }
        public string power, time, distance;

        public Network(string ipAdress, int port)
        {
            networkCommunication = new NetworkCommunication(ipAdress, port, this);
            if (networkCommunication.ConnectToServer())
                status = "Connected";
            else
                status = "Can't connect to: " + ipAdress + ":" + port;
        }

        public void login(string username, string password)
        {
            networkCommunication.SendMessage("LO\tusername\tpassword");
        }

        public void sendBikeValues(string power, string time, string distance)
        {
            networkCommunication.SendMessage("BV\tpower\ttime\tdistance");
        }

        public void sendMeasurement(Measurement measurement)
        {
            //Send object;
        }
    }
}
