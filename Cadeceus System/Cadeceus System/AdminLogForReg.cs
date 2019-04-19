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
    public partial class AdminLogForReg : Form
    {
        public AdminLogForReg()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Visible = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                Register Regi = new Register();
                Regi.ShowDialog();
                this.Close();
            
        }

        private void AdminLogForReg_Load(object sender, EventArgs e)
        {

        }
    }
}
