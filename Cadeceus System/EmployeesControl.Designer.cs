namespace WindowsFormsApplication1
{
    partial class EmployeesControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesControl));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAddEmployee = new System.Windows.Forms.TabPage();
            this.tabRemoveEmployee = new System.Windows.Forms.TabPage();
            this.tabUpdate = new System.Windows.Forms.TabPage();
            this.tabViewEmployees = new System.Windows.Forms.TabPage();
            this.dataViewDoctorBy = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupDocType = new System.Windows.Forms.GroupBox();
            this.radResident = new System.Windows.Forms.RadioButton();
            this.radOnCall = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radReceptionist = new System.Windows.Forms.RadioButton();
            this.radAdmin = new System.Windows.Forms.RadioButton();
            this.radNurse = new System.Windows.Forms.RadioButton();
            this.radDoc = new System.Windows.Forms.RadioButton();
            this.panelRegForm = new System.Windows.Forms.Panel();
            this.txtFees = new System.Windows.Forms.MaskedTextBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.MaskedTextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContacts = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFNames = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabAddEmployee.SuspendLayout();
            this.tabViewEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewDoctorBy)).BeginInit();
            this.groupDocType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelRegForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabAddEmployee);
            this.tabControl1.Controls.Add(this.tabRemoveEmployee);
            this.tabControl1.Controls.Add(this.tabUpdate);
            this.tabControl1.Controls.Add(this.tabViewEmployees);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(866, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAddEmployee
            // 
            this.tabAddEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabAddEmployee.BackgroundImage")));
            this.tabAddEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabAddEmployee.Controls.Add(this.groupDocType);
            this.tabAddEmployee.Controls.Add(this.groupBox1);
            this.tabAddEmployee.Controls.Add(this.panelRegForm);
            this.tabAddEmployee.ImageIndex = 2;
            this.tabAddEmployee.Location = new System.Drawing.Point(4, 26);
            this.tabAddEmployee.Name = "tabAddEmployee";
            this.tabAddEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddEmployee.Size = new System.Drawing.Size(858, 417);
            this.tabAddEmployee.TabIndex = 0;
            this.tabAddEmployee.Text = "Add Employee";
            this.tabAddEmployee.UseVisualStyleBackColor = true;
            // 
            // tabRemoveEmployee
            // 
            this.tabRemoveEmployee.ImageIndex = 1;
            this.tabRemoveEmployee.Location = new System.Drawing.Point(4, 26);
            this.tabRemoveEmployee.Name = "tabRemoveEmployee";
            this.tabRemoveEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabRemoveEmployee.Size = new System.Drawing.Size(858, 398);
            this.tabRemoveEmployee.TabIndex = 1;
            this.tabRemoveEmployee.Text = "Remove Employee";
            this.tabRemoveEmployee.UseVisualStyleBackColor = true;
            // 
            // tabUpdate
            // 
            this.tabUpdate.ImageIndex = 3;
            this.tabUpdate.Location = new System.Drawing.Point(4, 26);
            this.tabUpdate.Name = "tabUpdate";
            this.tabUpdate.Size = new System.Drawing.Size(858, 398);
            this.tabUpdate.TabIndex = 2;
            this.tabUpdate.Text = "Update Employee Details";
            this.tabUpdate.UseVisualStyleBackColor = true;
            // 
            // tabViewEmployees
            // 
            this.tabViewEmployees.Controls.Add(this.dataViewDoctorBy);
            this.tabViewEmployees.ImageIndex = 0;
            this.tabViewEmployees.Location = new System.Drawing.Point(4, 26);
            this.tabViewEmployees.Name = "tabViewEmployees";
            this.tabViewEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewEmployees.Size = new System.Drawing.Size(858, 398);
            this.tabViewEmployees.TabIndex = 3;
            this.tabViewEmployees.Text = "View Employee";
            this.tabViewEmployees.UseVisualStyleBackColor = true;
            // 
            // dataViewDoctorBy
            // 
            this.dataViewDoctorBy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewDoctorBy.Location = new System.Drawing.Point(6, 6);
            this.dataViewDoctorBy.Name = "dataViewDoctorBy";
            this.dataViewDoctorBy.Size = new System.Drawing.Size(846, 386);
            this.dataViewDoctorBy.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-database-view-filled-50.png");
            this.imageList1.Images.SetKeyName(1, "icons8-minus-filled-50.png");
            this.imageList1.Images.SetKeyName(2, "icons8-plus-filled-50.png");
            this.imageList1.Images.SetKeyName(3, "icons8-update-filled-50.png");
            this.imageList1.Images.SetKeyName(4, "icons8-businessman-filled-500.png");
            this.imageList1.Images.SetKeyName(5, "icons8-front-desk-filled-50 (1).png");
            this.imageList1.Images.SetKeyName(6, "icons8-medical-doctor-filled-100.png");
            this.imageList1.Images.SetKeyName(7, "icons8-nurse-filled-100.png");
            // 
            // groupDocType
            // 
            this.groupDocType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupDocType.Controls.Add(this.radResident);
            this.groupDocType.Controls.Add(this.radOnCall);
            this.groupDocType.ForeColor = System.Drawing.Color.White;
            this.groupDocType.Location = new System.Drawing.Point(227, 51);
            this.groupDocType.Name = "groupDocType";
            this.groupDocType.Size = new System.Drawing.Size(405, 35);
            this.groupDocType.TabIndex = 5;
            this.groupDocType.TabStop = false;
            this.groupDocType.Text = "Select Type of Doctor";
            this.groupDocType.Visible = false;
            // 
            // radResident
            // 
            this.radResident.AutoSize = true;
            this.radResident.BackColor = System.Drawing.Color.Transparent;
            this.radResident.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radResident.Location = new System.Drawing.Point(133, 12);
            this.radResident.Name = "radResident";
            this.radResident.Size = new System.Drawing.Size(119, 20);
            this.radResident.TabIndex = 1;
            this.radResident.TabStop = true;
            this.radResident.Text = "Resident Doctor";
            this.radResident.UseVisualStyleBackColor = false;
            // 
            // radOnCall
            // 
            this.radOnCall.AutoSize = true;
            this.radOnCall.BackColor = System.Drawing.Color.Transparent;
            this.radOnCall.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOnCall.Location = new System.Drawing.Point(7, 12);
            this.radOnCall.Name = "radOnCall";
            this.radOnCall.Size = new System.Drawing.Size(111, 20);
            this.radOnCall.TabIndex = 0;
            this.radOnCall.TabStop = true;
            this.radOnCall.Text = "On-Call Doctor";
            this.radOnCall.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.radReceptionist);
            this.groupBox1.Controls.Add(this.radAdmin);
            this.groupBox1.Controls.Add(this.radNurse);
            this.groupBox1.Controls.Add(this.radDoc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(227, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 42);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Employee Type";
            // 
            // radReceptionist
            // 
            this.radReceptionist.AutoSize = true;
            this.radReceptionist.BackColor = System.Drawing.Color.Transparent;
            this.radReceptionist.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radReceptionist.ForeColor = System.Drawing.Color.White;
            this.radReceptionist.Location = new System.Drawing.Point(281, 17);
            this.radReceptionist.Name = "radReceptionist";
            this.radReceptionist.Size = new System.Drawing.Size(113, 22);
            this.radReceptionist.TabIndex = 3;
            this.radReceptionist.TabStop = true;
            this.radReceptionist.Text = "Receptionist";
            this.radReceptionist.UseVisualStyleBackColor = false;
            // 
            // radAdmin
            // 
            this.radAdmin.AutoSize = true;
            this.radAdmin.BackColor = System.Drawing.Color.Transparent;
            this.radAdmin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAdmin.ForeColor = System.Drawing.Color.White;
            this.radAdmin.Location = new System.Drawing.Point(193, 17);
            this.radAdmin.Name = "radAdmin";
            this.radAdmin.Size = new System.Drawing.Size(71, 22);
            this.radAdmin.TabIndex = 2;
            this.radAdmin.TabStop = true;
            this.radAdmin.Text = "Admin";
            this.radAdmin.UseVisualStyleBackColor = false;
            // 
            // radNurse
            // 
            this.radNurse.AutoSize = true;
            this.radNurse.BackColor = System.Drawing.Color.Transparent;
            this.radNurse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNurse.ForeColor = System.Drawing.Color.White;
            this.radNurse.Location = new System.Drawing.Point(103, 17);
            this.radNurse.Name = "radNurse";
            this.radNurse.Size = new System.Drawing.Size(67, 22);
            this.radNurse.TabIndex = 1;
            this.radNurse.TabStop = true;
            this.radNurse.Text = "Nurse";
            this.radNurse.UseVisualStyleBackColor = false;
            // 
            // radDoc
            // 
            this.radDoc.AutoSize = true;
            this.radDoc.BackColor = System.Drawing.Color.Transparent;
            this.radDoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDoc.ForeColor = System.Drawing.Color.White;
            this.radDoc.Location = new System.Drawing.Point(6, 17);
            this.radDoc.Name = "radDoc";
            this.radDoc.Size = new System.Drawing.Size(73, 22);
            this.radDoc.TabIndex = 0;
            this.radDoc.TabStop = true;
            this.radDoc.Text = "Doctor";
            this.radDoc.UseVisualStyleBackColor = false;
            // 
            // panelRegForm
            // 
            this.panelRegForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelRegForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRegForm.Controls.Add(this.txtFees);
            this.panelRegForm.Controls.Add(this.cmbDepartment);
            this.panelRegForm.Controls.Add(this.btnRegister);
            this.panelRegForm.Controls.Add(this.lblFees);
            this.panelRegForm.Controls.Add(this.lblDepartment);
            this.panelRegForm.Controls.Add(this.txtCode);
            this.panelRegForm.Controls.Add(this.txtStreet);
            this.panelRegForm.Controls.Add(this.label9);
            this.panelRegForm.Controls.Add(this.txtCity);
            this.panelRegForm.Controls.Add(this.label8);
            this.panelRegForm.Controls.Add(this.label7);
            this.panelRegForm.Controls.Add(this.txtContacts);
            this.panelRegForm.Controls.Add(this.label5);
            this.panelRegForm.Controls.Add(this.txtLName);
            this.panelRegForm.Controls.Add(this.txtFNames);
            this.panelRegForm.Controls.Add(this.label4);
            this.panelRegForm.Controls.Add(this.label3);
            this.panelRegForm.Location = new System.Drawing.Point(227, 94);
            this.panelRegForm.Name = "panelRegForm";
            this.panelRegForm.Size = new System.Drawing.Size(405, 307);
            this.panelRegForm.TabIndex = 3;
            this.panelRegForm.Visible = false;
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(218, 203);
            this.txtFees.Mask = "R000000.00";
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(130, 20);
            this.txtFees.TabIndex = 34;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "Anaesthetics",
            "Bloodbank",
            "Cardiology",
            "Dental",
            "Emergency",
            "Gynaecology",
            "Intensivecareunit(ICU)",
            "Laboratory",
            "Morgue",
            "MRI",
            "Neurology",
            "Oncology",
            "OperationTheatre",
            "Orthopaedic",
            "Out-patient",
            "Pathology"});
            this.cmbDepartment.Location = new System.Drawing.Point(218, 173);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(130, 21);
            this.cmbDepartment.Sorted = true;
            this.cmbDepartment.TabIndex = 29;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.Image")));
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.Location = new System.Drawing.Point(142, 231);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(142, 59);
            this.btnRegister.TabIndex = 33;
            this.btnRegister.Text = "          Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.BackColor = System.Drawing.Color.Transparent;
            this.lblFees.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.ForeColor = System.Drawing.Color.White;
            this.lblFees.Location = new System.Drawing.Point(53, 199);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(152, 22);
            this.lblFees.TabIndex = 31;
            this.lblFees.Text = "Fees Per Patient";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartment.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.White;
            this.lblDepartment.Location = new System.Drawing.Point(53, 172);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(109, 22);
            this.lblDepartment.TabIndex = 29;
            this.lblDepartment.Text = "Department";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(218, 147);
            this.txtCode.Mask = "0000";
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(130, 20);
            this.txtCode.TabIndex = 28;
            this.txtCode.ValidatingType = typeof(int);
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(218, 120);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(130, 20);
            this.txtStreet.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(53, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 22);
            this.label9.TabIndex = 26;
            this.label9.Text = "Postal Code:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(218, 94);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(130, 20);
            this.txtCity.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(53, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 22);
            this.label8.TabIndex = 24;
            this.label8.Text = "Street:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(53, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "City:";
            // 
            // txtContacts
            // 
            this.txtContacts.Location = new System.Drawing.Point(218, 69);
            this.txtContacts.Mask = "(999) 000-0000";
            this.txtContacts.Name = "txtContacts";
            this.txtContacts.Size = new System.Drawing.Size(130, 20);
            this.txtContacts.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(53, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Phone Number:";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(218, 43);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(130, 20);
            this.txtLName.TabIndex = 20;
            // 
            // txtFNames
            // 
            this.txtFNames.Location = new System.Drawing.Point(218, 17);
            this.txtFNames.Name = "txtFNames";
            this.txtFNames.Size = new System.Drawing.Size(130, 20);
            this.txtFNames.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(53, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "First Names:";
            // 
            // EmployeesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.tabControl1);
            this.Name = "EmployeesControl";
            this.Size = new System.Drawing.Size(869, 452);
            this.Load += new System.EventHandler(this.EmployeesControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAddEmployee.ResumeLayout(false);
            this.tabViewEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewDoctorBy)).EndInit();
            this.groupDocType.ResumeLayout(false);
            this.groupDocType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelRegForm.ResumeLayout(false);
            this.panelRegForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAddEmployee;
        private System.Windows.Forms.TabPage tabRemoveEmployee;
        private System.Windows.Forms.TabPage tabUpdate;
        private System.Windows.Forms.TabPage tabViewEmployees;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataViewDoctorBy;
        private System.Windows.Forms.GroupBox groupDocType;
        private System.Windows.Forms.RadioButton radResident;
        private System.Windows.Forms.RadioButton radOnCall;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radReceptionist;
        private System.Windows.Forms.RadioButton radAdmin;
        private System.Windows.Forms.RadioButton radNurse;
        private System.Windows.Forms.RadioButton radDoc;
        private System.Windows.Forms.Panel panelRegForm;
        private System.Windows.Forms.MaskedTextBox txtFees;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.MaskedTextBox txtCode;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtContacts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFNames;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
