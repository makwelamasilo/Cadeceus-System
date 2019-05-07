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
    public partial class Dashboard : Form
    {
        int PanelWidth;
        bool isCollapsed;

        public Dashboard()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            DashControl dash = new DashControl();
            AddControlsToPanel(dash);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Log_In login = new Log_In();
            this.Hide();
            login.ShowDialog();
        }

        private void AddControlsToPanel(Control e)
        {
            e.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(e);
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            DashControl dash = new DashControl();
            AddControlsToPanel(dash);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if(panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if(panelLeft.Width <= 53)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void TimerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
        }

        private void BtnAppointment_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnAppointment);
            AppointmentControl appointment = new AppointmentControl();
            AddControlsToPanel(appointment);
        }

        private void BtnPatientsManagement_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnPatientsManagement);
            PatienctsControl patiencts = new PatienctsControl();
            AddControlsToPanel(patiencts);
        }

        private void BtnBill_Click(object sender, EventArgs e)
        {

        }
    }
}
