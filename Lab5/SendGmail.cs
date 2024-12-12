using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Lab5
{
    public partial class SendGmail : Form
    {
        public SendGmail()
        {
            InitializeComponent();
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            string fromGmail = textBox_FromEmail.Text;
            string appPassword = textBox_Password.Text; // Sử dụng mật khẩu ứng dụng
            string toGmail = textBox_ToEmail.Text;
            string subject = textBox_Subject.Text;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(fromGmail);
            mail.To.Add(toGmail);
            mail.Subject = subject;
            mail.Body = richTextBox_Body.Text;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587, // Sử dụng cổng SMTP của Gmail
                Credentials = new NetworkCredential(fromGmail, appPassword),
                EnableSsl = true // Sử dụng SSL
            };

            try
            {
                smtpClient.Send(mail);
                MessageBox.Show("Mail sent successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
