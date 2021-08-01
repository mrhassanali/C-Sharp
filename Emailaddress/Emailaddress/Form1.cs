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

namespace Emailaddress
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textemail_enter(object sender, EventArgs e)
        {
            if(textemail.Text == "Email")
            {
                textemail.Clear();
                textemail.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void textemail_leave(object sender, EventArgs e)
        {
            if(textemail.Text == "")
            {
                textemail.ForeColor = Color.FromArgb(255, 255, 255);
                textemail.Text = "Email";
            }
        }

        private void textsubject_enter(object sender, EventArgs e)
        {
            if (textsubject.Text == "Subject")
            {
                textsubject.Clear();
                textsubject.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void textsubject_leave(object sender, EventArgs e)
        {
            if (textsubject.Text == "")
            {
                textsubject.ForeColor = Color.FromArgb(255, 255, 255);
                textsubject.Text = "Subject";
            }
        }

        private void textmessage_enter(object sender, EventArgs e)
        {
            if (textmessage.Text == "Message")
            {
                textmessage.Clear();
                textmessage.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void textmessage_leave(object sender, EventArgs e)
        {
            if (textmessage.Text == "")
            {
                textmessage.ForeColor = Color.FromArgb(255, 255, 255);
                textmessage.Text = "Message";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string to, from, pass, messageBody;

            to = textemail.Text;
            from = "hassanalitechnical@gmail.com";
            pass = "//windowapp";
            messageBody = textmessage.Text;

            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress("hassanalitechnical@gmail.com");
            message.Body = "From :" + from + "<br>Message :" + messageBody;
            message.Subject = textsubject.Text;
            message.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 25;
            smtp.Credentials = new NetworkCredential(from, pass);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            try
            {
                smtp.Send(message);
                DialogResult code = MessageBox.Show("Sent Email Sucessfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(code == DialogResult.OK)
                {
                    textemail.Clear();
                    textsubject.Clear();
                    textmessage.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
