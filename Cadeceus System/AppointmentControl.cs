using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AppointmentControl : UserControl
    {
        public AppointmentControl()
        {
            InitializeComponent();
            panelAddAppointment.Visible = true;
            panelAllAppointments.Visible = false;
            panelTodaysAppointments.Visible = false;
        }

        private void tab_Appointmenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 0)
            {
                panelAddAppointment.Visible = true;
                panelAllAppointments.Visible = false;
                panelTodaysAppointments.Visible = false;
            }
            if (tabControl1.SelectedIndex == 1)
            {
                panelAddAppointment.Visible = false;
                panelAllAppointments.Visible = true;
                panelTodaysAppointments.Visible = false;
            }
            if (tabControl1.SelectedIndex == 2)
            {
                panelAddAppointment.Visible = false;
                panelAllAppointments.Visible = false;
                panelTodaysAppointments.Visible = true;
            }
        }

        private void AppointmentControl_Load(object sender, EventArgs e)
        {
            
        }

        private void txtPatientID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
