using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UKMS.view;

namespace UKMS
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i = i + 1;

            if (i == 5)
            {
               timer1.Enabled = false;
               login login = new login();
               login.Show();
               this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
