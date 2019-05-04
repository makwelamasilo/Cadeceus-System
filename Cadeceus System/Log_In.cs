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
    public partial class Log_In : Form
    {
        string password, username;
        
        public Log_In()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to exit the program", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Visible = true;
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;

            Reception reception = new Reception();
            reception.Show();
            this.Close();
        }
    }
}
