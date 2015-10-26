using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        private Networkconnect network;

        public Login()
        {
            InitializeComponent();
            network = new Networkconnect("127.0.0.1", 130);
            Thread connectionThread = new Thread(new ThreadStart(ConnectThread));
            connectionThread.IsBackground = true;
            connectionThread.Start();
        }

        public void ConnectThread()
        {
            while(statusLabel.Text != "Connected")
            {
                SetStatusLabel(network.status);
            }
        }

        delegate void SetTextLabel(string text);

        private void SetStatusLabel(string status)
        {
            if (this.statusLabel.InvokeRequired)
            {
                SetTextLabel d = new SetTextLabel(SetStatusLabel);              
                this.Invoke(d, new object[] { status });
            }
            else
                this.statusLabel.Text = status;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (statusLabel.Text == "Connected")
            {
                if (usernameTextBox.Text != "" && passwordTextBox.Text != "")
                {
                    Tuple<bool, bool> login = network.login(usernameTextBox.Text, passwordTextBox.Text);
                    if (login.Item1)
                    {
                        Form form = new FormClient(network, login.Item2, usernameTextBox.Text.ToLower());
                        this.Hide();
                        if (form.ShowDialog() == DialogResult.Cancel)
                            this.Dispose();
                    }
                    else
                        MessageBox.Show("Wrong username or password");
                }
                else
                    MessageBox.Show("Please enter a username and a password!");
            }
        }
    }
}
