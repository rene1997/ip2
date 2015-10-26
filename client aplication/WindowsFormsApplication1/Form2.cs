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
    public partial class CommForm : Form
    {
        public CommForm()
        {
            InitializeComponent();
        }

        private void ComForm_Load(object sender, EventArgs e)
        {

        }

        private void connectButton_Click(object sender, EventArgs e)
        {

        }

        public string getCommport
        {
            get { return commportTxtBox.Text; }
        }
    }
}
