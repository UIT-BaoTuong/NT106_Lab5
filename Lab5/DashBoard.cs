using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void button_Bai1_Click(object sender, EventArgs e)
        {
            SendEmail sendEmail = new SendEmail();
            sendEmail.Show();
        }

        private void button_Bai2_Click(object sender, EventArgs e)
        {
            ReciveEmail reciveEmail = new ReciveEmail();
            reciveEmail.Show();
        }

        private void button_Bai3_Click(object sender, EventArgs e)
        {
            SendGmail sendGmail = new SendGmail();
            sendGmail.Show();
        }
    }
}
