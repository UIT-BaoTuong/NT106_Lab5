using System;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit;
using MimeKit;
using MailKit.Security;

namespace Lab5
{
    public partial class ReciveEmail : Form
    {
        public ReciveEmail()
        {
            InitializeComponent();
            listView_Email.Columns.Add("From", 210);
            listView_Email.Columns.Add("Subject", 210);
            listView_Email.Columns.Add("Date", 210);
            listView_Email.View = View.Details;
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            // Thiết lập các cột trong ListView


            // Lấy thông tin email và mật khẩu từ text box
            string email = textBox_Email.Text.Trim();
            string password = textBox_Password.Text.Trim();
            string imapServer = "127.0.0.1";
            int port = 143;

            try
            {
                using (var client = new ImapClient())
                {
                    // Kết nối tới máy chủ IMAP mà không sử dụng SSL
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true; // Tắt xác minh chứng chỉ (dùng cho phát triển)
                    client.Connect(imapServer, port, SecureSocketOptions.StartTlsWhenAvailable);

                    // Xác thực với máy chủ IMAP
                    client.Authenticate(email, password);

                    // Mở hộp thư "INBOX"
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    // Xóa các mục hiện tại trong ListView

                    // Đọc danh sách email và thêm vào ListView
                    for (int i = 0; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i);
                        ListViewItem item = new ListViewItem(new[]
                        {
                            message.From.ToString(),
                            message.Subject,
                            message.Date.ToString()
                        });
                        listView_Email.Items.Add(item);
                    }
                    label_Total.Text = "Total: " + inbox.Count.ToString();
                    label_Recent.Text = "Recent: " + inbox.Recent.ToString();
                    // Đóng kết nối
                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
