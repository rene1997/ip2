using Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class OldSesionData : Form
    {
        Networkconnect network;
        Network.User user;
        bool isPhysician;
        int depth = 0;
        List<UserClient> users;
        List<Session> sesions;
        List<Measurement> measurements;
        public OldSesionData(Networkconnect network, string username)
        {
            this.network = network;
            InitializeComponent();
            user = network.getUser(username);
            if (user is Physician)
            {
                Physician p = (Physician)user;
                listBox_Data.DataSource = p.clients;
                users = p.clients;
                isPhysician = true;
            }
            else
            {
                UserClient a = (UserClient)user;
                listBox_Data.DataSource = a.sessions;
                isPhysician = false;
            }

        }

        private void LEnergy_Click(object sender, EventArgs e)
        {

        }

        private void LDistance_Click(object sender, EventArgs e)
        {

        }

        private void OldSesionData_Load(object sender, EventArgs e)
        {

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void listBox_Data_SelectedIndexChanged(object sender, EventArgs e)
        {
            int temp = listBox_Data.SelectedIndex;
            if (isPhysician && depth == 2 || !isPhysician && depth == 1)
            {
                Measurement tempc = measurements.ElementAt(temp);
                label_CurrentPower.ResetText();
                label_Distance.ResetText();
                label_Energy.ResetText();
                label_HeartBeat.ResetText();
                label_RequestedPower.ResetText();
                label_RoundPerMin.ResetText();
                label_Speed.ResetText();
                label_Time.ResetText();

                label_CurrentPower.Text += tempc.actual_power;
                label_Distance.Text += tempc.distance;
                label_Energy.Text += tempc.energy;
                label_HeartBeat.Text += tempc.pulse;
                label_RequestedPower.Text += tempc.requested_power;
                label_RoundPerMin.Text += tempc.rpm; ;
                label_Speed.Text += tempc.speed;
                label_Time.Text += tempc.time;


            }

        }

        private void button_Select_Click(object sender, EventArgs e)
        {
            
            int temp = listBox_Data.SelectedIndex;
            if (temp >=0)
            {
                if (isPhysician)
                {
                    if (depth == 0)
                    {
                        UserClient tempc = users.ElementAt(temp);
                        listBox_Data.DataSource = tempc.getSessions();
                        sesions = tempc.getSessions();
                        depth++;
                    }
                    else if (depth == 1)
                    {
                        Session tempc = sesions.ElementAt(temp);
                        listBox_Data.DataSource = tempc.getMeasurement();
                        measurements = tempc.getMeasurement();
                        depth++;
                    }

                }
                else
                {
                    if (depth == 0)
                    {
                        Session tempc = sesions.ElementAt(temp);
                        listBox_Data.DataSource = tempc.getMeasurement();
                        measurements = tempc.getMeasurement();
                        depth++;
                    }

                }
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            if (isPhysician)
            {
                if (depth == 0)
                {
                   
                }
                else if (depth == 1)
                {
                    listBox_Data.DataSource = users;
                    depth--;
                }
                else
                {
                    listBox_Data.DataSource = sesions;
                    depth--;
                }

            }
            else
            {
                if (depth == 0)
                {
                    
                }
                else if (depth == 1)
                {
                    listBox_Data.DataSource = sesions;
                    depth--;
                }

            }
        }
    }
}
