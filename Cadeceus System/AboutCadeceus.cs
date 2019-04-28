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
    public partial class AboutCadeceus : Form
    {
        public AboutCadeceus()
        {
            InitializeComponent();
        }

        private void AboutCadeceus_Load(object sender, EventArgs e)
        {
            AboutPreview.src = "C:\\Users\\User\\Documents\\Code exicutioners.pdf";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Info myInfo = new Info();
            myInfo.Visible = true;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to exit the program", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
