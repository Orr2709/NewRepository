using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormApp
{
    public partial class MyFirstForm : Form
    {
        int interval = 1000;
        public MyFirstForm()
        {
            InitializeComponent();
        }

        private void btnClickME(object sender, EventArgs e)
        {
            MessageBox.Show("hello world");
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("you entered  " + txtName.Text);
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrMyTimer.Interval = interval;
            tmrMyTimer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrMyTimer.Stop();
        }


        private void tmr_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }

}
