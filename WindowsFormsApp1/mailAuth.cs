using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace WindowsFormsApp1
{
    public partial class mailAuth : Form
    {
        public mailAuth()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string emailaddress = textBox1.Text;
            string password = textBox2.Text;
            string recipient = textBox3.Text;

            System.Windows.Forms.OpenFileDialog fdlg = new System.Windows.Forms.OpenFileDialog();
            fdlg.Title = "Browse";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "docx files (*.docx)|*.docx|All files (*.*)|*.*";

            if (fdlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = fdlg.FileName;
            }

            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress(emailaddress);
            mail.To.Add(recipient);
            mail.Subject = "Test Mail";
            mail.Body = "";

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(textBox1.Text);
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(emailaddress, password);
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            System.Windows.Forms.MessageBox.Show("Mail sent");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
