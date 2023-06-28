using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DITI_CV
{
    public partial class sys_splash : Form
    {
        public sys_splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                //progressBar1.Value = progressBar1.Value + 2;
                progressBar1.Value = progressBar1.Value + 50;
            }
            else
            {
                timer1.Enabled = false;
                sys_login fl = new sys_login();
                fl.Show();
                this.Visible = false;
            }
        }
    }
}
