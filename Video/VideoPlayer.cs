using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video
{
    public partial class VideoPlayer : Form
    {
        public VideoPlayer(String video)
        {          
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.URL = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\Video\"+video;
            this.FormClosed += MyClosedHandler;
        }

        protected void MyClosedHandler(object sender, EventArgs e)
        {
            MessageBox.Show("Training afgesloten");
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.Hide();
            axWindowsMediaPlayer1.close();
            axWindowsMediaPlayer1.Dispose();
            this.Close();
        }

    }
}
