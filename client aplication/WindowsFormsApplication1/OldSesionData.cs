using Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        UserClient user;
        bool isPhysician;
        int depth = 0;
        List<UserClient> users;
        List<Measurement> measurements;
        public OldSesionData(Networkconnect network, User user)
        {
            this.network = network;
            this.user = (UserClient)user;
            InitializeComponent();
            if (user is Physician)
            {
                //todo
                Physician p = (Physician)user;
                listBox_Data.DataSource = p.clients;
                users = p.clients;
                isPhysician = true;
            }
            else
            {
                UserClient a = (UserClient)user;
                listBox_Data.DataSource = a.sessions;
                Debug.WriteLine("aantal sessies: " + a.sessions[0].ToString());
                isPhysician = false;
            }

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
                    //todo

                }
                else
                {
                    Debug.WriteLine("aantal sessies: " + user.sessions.Count);
                    Session tempc = user.sessions[temp];
                    listBox1.DataSource = tempc.measurements;
                  

                }
            }
        }

      
        
    }
}
