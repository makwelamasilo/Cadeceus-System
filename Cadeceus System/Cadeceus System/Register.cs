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
    public partial class Register : Form
    {
        string position;
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to exit the program", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Visible = true;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            position = "Nurse";
            btnProceed.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            position = "Doctor";
           
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            groupBox1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Text == "On call doctor") 
            {
                DocRegistryOnCall onCall = new DocRegistryOnCall();
                onCall.ShowDialog();
                this.Close();
            }
            if (radioButton2.Text == "Regular doctor")
            {
                DocRegistry2 reg = new DocRegistry2();
                reg.ShowDialog();
                this.Close();
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            position = "Patient";
            btnProceed.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            position = "Receptionist";
            btnProceed.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //DocRegistryOnCall frm = new DocRegistryOnCall();
            // frm.ShowDialog();
            //  this.Close();
            btnProceed.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //  DocRegistry2 frm2 = new DocRegistry2();
            //   frm2.ShowDialog();
            //   this.Close();
            btnProceed.Visible = true;
        }
    }
}
