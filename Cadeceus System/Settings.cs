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
        int fontSize = 0;
        public Settings()
        {
            InitializeComponent();
        }

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
            Color darkTheme = Color.DimGray;
            
            Color light = Color.AntiqueWhite;
            if (radDark.Checked)
            {
                
                AboutCadeceus about = new AboutCadeceus();
                Admin admin = new Admin();
                AdminLogForReg reg = new AdminLogForReg();
                Clerk cleck = new Clerk();
                ContinueReg cont = new ContinueReg();
                Database data = new Database();
                Doctor doc = new Doctor();
                Form1 home = new Form1();
                Settings setting = new Settings();
                Info info = new Info();
                Log_In login = new Log_In();
                Nurse nurse = new Nurse();
                Patient pat = new Patient();
                Register register = new Register();

                setting.BackColor = darkTheme;
                about.BackColor = darkTheme;
                admin.BackColor = darkTheme;
                reg.BackColor = darkTheme;
                cleck.BackColor = darkTheme;
                cont.BackColor = darkTheme;
                data.BackColor = darkTheme;
                doc.BackColor = darkTheme;
                home.BackColor = darkTheme;
                info.BackColor = darkTheme;
                login.BackColor = darkTheme;
                nurse.BackColor = darkTheme;
                pat.BackColor = darkTheme;
                register.BackColor = darkTheme;
                setting.Show();
            }
        }
    }
}
