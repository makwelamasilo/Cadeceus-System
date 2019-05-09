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
    public partial class EmployeesControl : UserControl
    {
        public EmployeesControl()
        {
            InitializeComponent();
        }

        private void EmployeeType_CheckedChanged(object sender, EventArgs e)
        {
            if(radDoc.Checked)
            {
                groupDocType.Visible = true;
                panelRegForm.Visible = false;
                
            }
            else
                if(radNurse.Checked)
            {
                panelRegForm.Visible = true;
                lblFees.Visible = false;
                txtFees.Visible = false;
                lblDepartment.Visible = true;
                txtDepartment.Visible = true;
                groupDocType.Visible = false;
            }
            else
                if(radAdmin.Checked)
            {
                panelRegForm.Visible = true;
                lblDepartment.Visible = false;
                txtDepartment.Visible = false;
                lblFees.Visible = false;
                txtFees.Visible = false;
                groupDocType.Visible = false;
            }
            else
                if(radReceptionist.Checked)
            {
                panelRegForm.Visible = true;
                lblDepartment.Visible = false;
                txtDepartment.Visible = false;
                lblFees.Visible = false;
                txtFees.Visible = false;
                groupDocType.Visible = false;
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {

        }

        private void DocType_CheckedChanged(object sender, EventArgs e)
        {
            if (radOnCall.Checked)
            {
                panelRegForm.Visible = true;
                lblDepartment.Visible = true;
                txtDepartment.Visible = true;
                lblFees.Visible = true;
                txtFees.Visible = true;
                lblFees.ResetText();
                lblFees.Text = "Fees Per Call:";
            }
            //else
                if (radResident.Checked)
                {
                    panelRegForm.Visible = true;
                    lblDepartment.Visible = true;
                    txtDepartment.Visible = true;
                    lblFees.Visible = true;
                    txtFees.Visible = true;
                    lblFees.ResetText();
                    lblFees.Text = "Fees Per Patient:";

                }
        }
    }
}
