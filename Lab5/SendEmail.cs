using System;
using System.Net;
using System.Net.Mail;
namespace Lab5
{
    public partial class SendEmail : Form
    {
        public SendEmail()
        {
            InitializeComponent();
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            try
            {
                string fromEmail = textBox_FromEmail.Text.Trim();
                string fromPassword = textBox_Password.Text.Trim();
                string toEmail = textBox_ToEmail.Text.Trim();
                string subject = textBox_Subject.Text.Trim();
                string body = richTextBox_Body.Text.Trim();

                MailMessage mailMessage = new MailMessage(fromEmail, toEmail, subject, body);
                SmtpClient smtpClient = new SmtpClient("127.0.0.1")
                {
                    Credentials = new NetworkCredential(fromEmail, fromPassword),
                };
                smtpClient.Send(mailMessage);
                MessageBox.Show("Email sent successfully!");
            }
            catch
            {
                MessageBox.Show("Failed to send email!");
            }
        }
    }
}
