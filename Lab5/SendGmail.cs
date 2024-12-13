using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Lab5
{
    public partial class SendGmail : Form
    {
        private List<Attachment> attachments = new List<Attachment>(); // Danh sách file đính kèm

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
            mail.IsBodyHtml = true; // Hỗ trợ HTML trong email

            // Thêm file đính kèm từ danh sách
            foreach (var attachment in attachments)
            {
                mail.Attachments.Add(attachment);
            }

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

        private void button_attachFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true; // Cho phép chọn nhiều file
                openFileDialog.Filter = "All Files (*.*)|*.*"; // Chấp nhận mọi loại file

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        foreach (string filePath in openFileDialog.FileNames)
                        {
                            // Thêm file đính kèm vào danh sách
                            Attachment attachment = new Attachment(filePath);
                            attachments.Add(attachment);
                            // Hiển thị thông tin file đã chọn vào RichTextBox
                            richTextBox_Body.AppendText($"{filePath}\n");
                        }
                        MessageBox.Show("Files attached successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding attachment: " + ex.Message);
                    }
                }
            }
        }
    }
}
