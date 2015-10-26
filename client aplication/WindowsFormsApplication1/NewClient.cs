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
    public partial class NewClient : Form
    {
        private Networkconnect network;
        private string physicianName;

        public NewClient(Networkconnect network, string physicianName)
        {
            InitializeComponent();
            this.ActiveControl = gebruikersNaam;
            this.network = network;
            this.physicianName = physicianName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(gebruikersNaam.Text!=""&&password.Text!="")
            {
                if(network.GetAllUsers().FindIndex(user => user.username.ToLower() == gebruikersNaam.Text.ToLower()) == -1)
                {
                    network.addNewClient(new Network.UserClient(gebruikersNaam.Text, password.Text,physicianName), physicianName);

                    MessageBox.Show("Gebruiker '"+ gebruikersNaam.Text + "' met wachtwoord '"+ password.Text + "' aangemaakt.");
                    this.Hide();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Username already in use, please choose another one.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields!");
            }
           // if (usernameTextBox.Text != "" && passwordTextBox.Text != "")
            //{
            //    Tuple<bool, bool> login = network.login(usernameTextBox.Text, passwordTextBox.Text);
            //    if (login.Item1)
            //    {
            //        Form form = new FormClient(network, login.Item2);
            //        this.Hide();
            //        if (form.ShowDialog() == DialogResult.Cancel)
            //            this.Dispose();
            //    }
            //    else
             //       MessageBox.Show("Wrong username or password");
            //}
            //else
            //    MessageBox.Show("Please enter a username and a password!");
        }
    }
}
