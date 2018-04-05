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

namespace WordToPDFConverter
{
    public partial class mailAuth : Form
    {
        public mailAuth()
        {
            InitializeComponent();
        }

        public string path;

        private void mailAuth_Load(object sender, EventArgs e)
        {
            //show in center of the screen
            Size screenSize = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size;
            Location = new Point(screenSize.Width / 2 - Width / 2, screenSize.Height / 2 - Height / 2);

        }

       
        
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtemail.Text) && !String.IsNullOrEmpty(txtpassword.Text) && !String.IsNullOrEmpty(txtrecipient.Text))
            {
                string emailaddress = txtemail.Text;
                string password = txtpassword.Text;
                string recipient = txtrecipient.Text;
                string path = AppForm.SetValueForText1;
                 
                
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(emailaddress);
                mail.To.Add(recipient);
                mail.Subject = "Test Mail";
                mail.Body = "";

                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(path);
                mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(emailaddress, password);
                SmtpServer.EnableSsl = true;

                
                SmtpServer.Send(mail);
                System.Windows.Forms.MessageBox.Show("Mail sent");

                txtemail.Clear();
                txtpassword.Clear();
                txtrecipient.Clear();
            }

            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            AppForm af = new AppForm();
            this.Hide();
            af.Show();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
