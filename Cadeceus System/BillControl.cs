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
using System.IO;
using System.Drawing.Printing;

namespace WindowsFormsApplication1
{
    public partial class BillControl : UserControl
    {
        private Font Verdanna10font;
        private StreamReader reader;
        public BillControl()
        {
            InitializeComponent();
        }

        private void BtnPrintBill_Click(object sender, EventArgs e)
        {
            string filename = txtAttachment.Text;
            reader = new StreamReader(filename);
            Verdanna10font = new Font("Verdanna", 10);
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.PrintTextFileHanders);
            pd.Print();
            if(reader!=null)
            {
                reader.Close();
            }


        }

        private void PrintTextFileHanders(object sender, PrintPageEventArgs ppeArgs)
        {
            Graphics g = ppeArgs.Graphics;
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;

            float leftMargin = ppeArgs.MarginBounds.Left;
            float topMargin = ppeArgs.MarginBounds.Top;
            string line = null;

            linesPerPage = ppeArgs.MarginBounds.Height / Verdanna10font.GetHeight(g);
            while(count<linesPerPage && ((line = reader.ReadLine()) != null))
            {
                yPos = topMargin + (count * Verdanna10font.GetHeight(g));
                g.DrawString(line, Verdanna10font, Brushes.Black, leftMargin, yPos, new StringFormat());
                count++;
            }//end of while

            if(line!=null)
            {
                ppeArgs.HasMorePages = true;
            }
            else
            {
                ppeArgs.HasMorePages = false;
            }
        }

        private void BtnEmail_Click(object sender, EventArgs e)
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

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

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
    }
}
