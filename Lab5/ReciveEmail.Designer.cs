namespace Lab5
{
    partial class ReciveEmail
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
            textBox_Email = new TextBox();
            textBox_Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button_Login = new Button();
            label_Total = new Label();
            label_Recent = new Label();
            listView_Email = new ListView();
            SuspendLayout();
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(122, 27);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(282, 27);
            textBox_Email.TabIndex = 0;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(122, 81);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(282, 27);
            textBox_Password.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 34);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 88);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // button_Login
            // 
            button_Login.Location = new Point(592, 27);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(149, 58);
            button_Login.TabIndex = 2;
            button_Login.Text = "Login";
            button_Login.UseVisualStyleBackColor = true;
            button_Login.Click += button_Login_Click;
            // 
            // label_Total
            // 
            label_Total.AutoSize = true;
            label_Total.Location = new Point(66, 153);
            label_Total.Name = "label_Total";
            label_Total.Size = new Size(49, 20);
            label_Total.TabIndex = 3;
            label_Total.Text = "Total :";
            // 
            // label_Recent
            // 
            label_Recent.AutoSize = true;
            label_Recent.Location = new Point(198, 153);
            label_Recent.Name = "label_Recent";
            label_Recent.Size = new Size(61, 20);
            label_Recent.TabIndex = 3;
            label_Recent.Text = "Recent :";
            // 
            // listView_Email
            // 
            listView_Email.Location = new Point(66, 195);
            listView_Email.Name = "listView_Email";
            listView_Email.Size = new Size(675, 243);
            listView_Email.TabIndex = 4;
            listView_Email.UseCompatibleStateImageBehavior = false;
            // 
            // ReciveEmail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView_Email);
            Controls.Add(label_Recent);
            Controls.Add(label_Total);
            Controls.Add(button_Login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Email);
            Name = "ReciveEmail";
            Text = "Recive Email";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Email;
        private TextBox textBox_Password;
        private Label label1;
        private Label label2;
        private Button button_Login;
        private Label label_Total;
        private Label label_Recent;
        private ListView listView_Email;
    }
}