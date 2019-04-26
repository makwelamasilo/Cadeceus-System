using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Refresh();
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        public void SplashStart()
        {
            Application.Run(new Splash());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to exit the program", "Confirm Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings sttgs = new Settings();
            sttgs.ShowDialog();
            this.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Log_In openForm = new Log_In();
            openForm.ShowDialog();
            Visible = false;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Info infoform = new Info();
            infoform.ShowDialog();
            this.Visible = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            AdminLogForReg rg = new AdminLogForReg();
            rg.ShowDialog();
            this.Visible = false;
        }
    }
}
