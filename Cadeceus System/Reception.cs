using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Reception : Form
    {
        public Reception()
        {
            InitializeComponent();
        }

        private void tabReception_DrawItem(object sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;
            var text = this.tabReception.TabPages[e.Index].Text;
            var sizeText = g.MeasureString(text, this.tabReception.Font);

            var x = e.Bounds.Left + 3;
            var y = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;

            g.DrawString(text, this.tabReception.Font, Brushes.Black, x, y);
        }

        private void Reception_Load(object sender, EventArgs e)
        {
            tabPatientManagement.Text = "PATIENT\nMANAGEMENT";
            btnHomeSelected.Visible = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Log_In loginForm = new Log_In();
            loginForm.Show();
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Do you wish to exit the program", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tabControlSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabReception.SelectedIndex == 0)
            {
                btnHomeSelected.Visible = true;
                btnAppointmentSelected.Visible = false;
                btnPatientsSelected.Visible = false;
            }
            if (tabReception.SelectedIndex == 1)
            {
                btnHomeSelected.Visible = false;
                btnAppointmentSelected.Visible = true;
                btnPatientsSelected.Visible = false;
            }
            if (tabReception.SelectedIndex == 2)
            {
                btnHomeSelected.Visible = false;
                btnAppointmentSelected.Visible = false;
                btnPatientsSelected.Visible = true;
            }
        }
    }
}
