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
            /*string filename = txtAttachment.Text;
            reader = new StreamReader(filename);
            Verdanna10font = new Font("Verdanna", 10);
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.PrintTextFileHanders);
            pd.Print();
            if(reader!=null)
            {
                reader.Close();
            }*/


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
            Email mail = new Email();
            AddControlsToPanel(mail);

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnAttachment_Click(object sender, EventArgs e)
        {
            
        }

        private void AddControlsToPanel(Control e)
        {
            e.Dock = DockStyle.Fill;
            panelView.Controls.Clear();
            panelView.Controls.Add(e);
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string doctorName = cmbDoctor.Text;
            string patient = txtPatientID.Text;
            string meds = cmbMedication.Text;
            double cost = 0;
            if(cmbMedication.SelectedIndex == 0)
            {
                cost = 50;
            }

            StreamWriter mywriter = new StreamWriter("C:\\Users\\sumes\\OneDrive\\Documents\\2019\\ITRW311\\Cadecues System\\bills");

            try
            {
                mywriter.WriteLine("Patient: " + patient + "\n" + "Doctor: " + doctorName + "\n" + "Medication: " + meds + "R" + cost);
                MessageBox.Show("Bill Successfully created");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnViewBill_Click(object sender, EventArgs e)
        {
            Bill mybill = new Bill();
            AddControlsToPanel(mybill);
        }
    }
}
