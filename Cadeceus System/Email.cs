using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace WindowsFormsApplication1
{
    public partial class Email : UserControl
    {
        public Email()
        {
            InitializeComponent();
        }

        private void BtnAttachment_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string path = dlg.FileName.ToString();
                txtAttachment.Text = path;
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();


                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("Cadeceusdelivery@gmail.com");
                mail.CC.Add(txtCC.Text);
                mail.To.Add(txtTo.Text);
                mail.Subject = txtSubject.Text;
                mail.Body = txtBody.Text;
                mail.Attachments.Add(new Attachment(txtAttachment.Text));

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("Cadeceusdelivery@gmail.com", "CadDelivery");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Email Sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
