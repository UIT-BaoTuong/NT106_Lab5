namespace Lab5
{
    partial class SendGmail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_Send = new Button();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox_Password = new TextBox();
            textBox_Subject = new TextBox();
            textBox_ToEmail = new TextBox();
            textBox_FromEmail = new TextBox();
            richTextBox_Body = new RichTextBox();
            SuspendLayout();
            // 
            // button_Send
            // 
            button_Send.Location = new Point(569, 57);
            button_Send.Name = "button_Send";
            button_Send.Size = new Size(119, 51);
            button_Send.TabIndex = 14;
            button_Send.Text = "Send";
            button_Send.UseVisualStyleBackColor = true;
            button_Send.Click += button_Send_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(493, 19);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 181);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 10;
            label5.Text = "Body";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 131);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 11;
            label3.Text = "Subject";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 76);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 12;
            label2.Text = "To Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 13;
            label1.Text = "From Email";
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(569, 12);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(219, 27);
            textBox_Password.TabIndex = 5;
            // 
            // textBox_Subject
            // 
            textBox_Subject.Location = new Point(102, 124);
            textBox_Subject.Name = "textBox_Subject";
            textBox_Subject.Size = new Size(686, 27);
            textBox_Subject.TabIndex = 6;
            // 
            // textBox_ToEmail
            // 
            textBox_ToEmail.Location = new Point(102, 69);
            textBox_ToEmail.Name = "textBox_ToEmail";
            textBox_ToEmail.Size = new Size(219, 27);
            textBox_ToEmail.TabIndex = 7;
            // 
            // textBox_FromEmail
            // 
            textBox_FromEmail.Location = new Point(102, 12);
            textBox_FromEmail.Name = "textBox_FromEmail";
            textBox_FromEmail.Size = new Size(219, 27);
            textBox_FromEmail.TabIndex = 8;
            // 
            // richTextBox_Body
            // 
            richTextBox_Body.Location = new Point(102, 181);
            richTextBox_Body.Name = "richTextBox_Body";
            richTextBox_Body.Size = new Size(686, 257);
            richTextBox_Body.TabIndex = 4;
            richTextBox_Body.Text = "";
            // 
            // SendGmail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Send);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Subject);
            Controls.Add(textBox_ToEmail);
            Controls.Add(textBox_FromEmail);
            Controls.Add(richTextBox_Body);
            Name = "SendGmail";
            Text = "Send Gmail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Send;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox_Password;
        private TextBox textBox_Subject;
        private TextBox textBox_ToEmail;
        private TextBox textBox_FromEmail;
        private RichTextBox richTextBox_Body;
    }
}