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
    public partial class Settings : Form
    {
        //int fontSize = 0;
        public Settings()
        {
            InitializeComponent();
        }
        Color color;
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to exit the program", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            //frm.MdiParent = this;
            frm.Visible = true;
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnSetFont_Click(object sender, EventArgs e)
        {

        }

        private void radTheme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            if (radDark.Checked)
            {
                color = Color.FromArgb(41, 44, 51);
                Settings setting = new Settings();
                Form1 home = new Form1();
                home.BackColor = color;
                setting.BackColor = color;
                setting.Show();
            }
            if (radLight.Checked)
            {
                color = Color.WhiteSmoke;
                Settings setting = new Settings();
                setting.BackColor = color;
                setting.Show();
            }
        }
    }
}
