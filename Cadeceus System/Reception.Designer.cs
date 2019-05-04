namespace WindowsFormsApplication1
{
    partial class Reception
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reception));
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabReception = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabAppointment = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPatientManagement = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAddAppointment = new System.Windows.Forms.TabPage();
            this.tabAllAppointments = new System.Windows.Forms.TabPage();
            this.tabTodaysAppointments = new System.Windows.Forms.TabPage();
            this.tabPatients = new System.Windows.Forms.TabControl();
            this.tabAddPatients = new System.Windows.Forms.TabPage();
            this.tabPatientsList = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.tabReception.SuspendLayout();
            this.tabAppointment.SuspendLayout();
            this.tabPatientManagement.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPatients.SuspendLayout();
            this.tabAddPatients.SuspendLayout();
            this.tabPatientsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(837, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 32);
            this.button3.TabIndex = 27;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(874, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 32);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1046, 43);
            this.label1.TabIndex = 29;
            this.label1.Text = "            Reception                                                            " +
    "      ";
            // 
            // tabReception
            // 
            this.tabReception.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabReception.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tabReception.Controls.Add(this.tabHome);
            this.tabReception.Controls.Add(this.tabAppointment);
            this.tabReception.Controls.Add(this.tabPatientManagement);
            this.tabReception.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabReception.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabReception.HotTrack = true;
            this.tabReception.ImageList = this.imageList1;
            this.tabReception.ItemSize = new System.Drawing.Size(40, 120);
            this.tabReception.Location = new System.Drawing.Point(12, 55);
            this.tabReception.Multiline = true;
            this.tabReception.Name = "tabReception";
            this.tabReception.Padding = new System.Drawing.Point(6, 6);
            this.tabReception.SelectedIndex = 0;
            this.tabReception.Size = new System.Drawing.Size(893, 420);
            this.tabReception.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabReception.TabIndex = 30;
            this.tabReception.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabReception_DrawItem);
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.White;
            this.tabHome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabHome.ImageKey = "4-256.png";
            this.tabHome.Location = new System.Drawing.Point(124, 4);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(765, 412);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "HOME";
            // 
            // tabAppointment
            // 
            this.tabAppointment.BackColor = System.Drawing.Color.Transparent;
            this.tabAppointment.Controls.Add(this.tabControl1);
            this.tabAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAppointment.ImageIndex = 1;
            this.tabAppointment.Location = new System.Drawing.Point(124, 4);
            this.tabAppointment.Name = "tabAppointment";
            this.tabAppointment.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppointment.Size = new System.Drawing.Size(765, 412);
            this.tabAppointment.TabIndex = 1;
            this.tabAppointment.Text = "APPOINTMENTS";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-home-50.png");
            this.imageList1.Images.SetKeyName(1, "icons8-add-user-male-50.png");
            this.imageList1.Images.SetKeyName(2, "icons8-calendar-50 (1).png");
            this.imageList1.Images.SetKeyName(3, "Appointment_4-3-256.png");
            this.imageList1.Images.SetKeyName(4, "Working_Schedule-256.png");
            this.imageList1.Images.SetKeyName(5, "add_new_create_date_appointment-256.png");
            this.imageList1.Images.SetKeyName(6, "31-128.png");
            this.imageList1.Images.SetKeyName(7, "4-256.png");
            this.imageList1.Images.SetKeyName(8, "icons8-database-50.png");
            // 
            // tabPatientManagement
            // 
            this.tabPatientManagement.BackColor = System.Drawing.Color.Transparent;
            this.tabPatientManagement.Controls.Add(this.tabPatients);
            this.tabPatientManagement.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPatientManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPatientManagement.ImageIndex = 2;
            this.tabPatientManagement.Location = new System.Drawing.Point(124, 4);
            this.tabPatientManagement.Name = "tabPatientManagement";
            this.tabPatientManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatientManagement.Size = new System.Drawing.Size(765, 412);
            this.tabPatientManagement.TabIndex = 2;
            this.tabPatientManagement.Text = "PATIENT MANAGEMENT";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAddAppointment);
            this.tabControl1.Controls.Add(this.tabAllAppointments);
            this.tabControl1.Controls.Add(this.tabTodaysAppointments);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(7, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(753, 402);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAddAppointment
            // 
            this.tabAddAppointment.ImageKey = "add_new_create_date_appointment-256.png";
            this.tabAddAppointment.Location = new System.Drawing.Point(4, 23);
            this.tabAddAppointment.Name = "tabAddAppointment";
            this.tabAddAppointment.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddAppointment.Size = new System.Drawing.Size(745, 375);
            this.tabAddAppointment.TabIndex = 0;
            this.tabAddAppointment.Text = "Add Appointment";
            this.tabAddAppointment.UseVisualStyleBackColor = true;
            // 
            // tabAllAppointments
            // 
            this.tabAllAppointments.ImageIndex = 7;
            this.tabAllAppointments.Location = new System.Drawing.Point(4, 23);
            this.tabAllAppointments.Name = "tabAllAppointments";
            this.tabAllAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllAppointments.Size = new System.Drawing.Size(745, 375);
            this.tabAllAppointments.TabIndex = 1;
            this.tabAllAppointments.Text = "All Appointments";
            this.tabAllAppointments.UseVisualStyleBackColor = true;
            // 
            // tabTodaysAppointments
            // 
            this.tabTodaysAppointments.ImageIndex = 6;
            this.tabTodaysAppointments.Location = new System.Drawing.Point(4, 23);
            this.tabTodaysAppointments.Name = "tabTodaysAppointments";
            this.tabTodaysAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabTodaysAppointments.Size = new System.Drawing.Size(745, 375);
            this.tabTodaysAppointments.TabIndex = 2;
            this.tabTodaysAppointments.Text = "Today\'s Appointments";
            this.tabTodaysAppointments.UseVisualStyleBackColor = true;
            // 
            // tabPatients
            // 
            this.tabPatients.Controls.Add(this.tabAddPatients);
            this.tabPatients.Controls.Add(this.tabPatientsList);
            this.tabPatients.ImageList = this.imageList1;
            this.tabPatients.Location = new System.Drawing.Point(6, 6);
            this.tabPatients.Name = "tabPatients";
            this.tabPatients.SelectedIndex = 0;
            this.tabPatients.Size = new System.Drawing.Size(753, 400);
            this.tabPatients.TabIndex = 0;
            // 
            // tabAddPatients
            // 
            this.tabAddPatients.BackColor = System.Drawing.Color.White;
            this.tabAddPatients.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabAddPatients.BackgroundImage")));
            this.tabAddPatients.Controls.Add(this.comboGender);
            this.tabAddPatients.Controls.Add(this.label5);
            this.tabAddPatients.Controls.Add(this.textBox2);
            this.tabAddPatients.Controls.Add(this.textBox1);
            this.tabAddPatients.Controls.Add(this.label4);
            this.tabAddPatients.Controls.Add(this.btnAdd);
            this.tabAddPatients.Controls.Add(this.label3);
            this.tabAddPatients.Controls.Add(this.pictureBox1);
            this.tabAddPatients.Controls.Add(this.label2);
            this.tabAddPatients.ImageIndex = 1;
            this.tabAddPatients.Location = new System.Drawing.Point(4, 23);
            this.tabAddPatients.Name = "tabAddPatients";
            this.tabAddPatients.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddPatients.Size = new System.Drawing.Size(745, 373);
            this.tabAddPatients.TabIndex = 0;
            this.tabAddPatients.Text = "Add Patients";
            // 
            // tabPatientsList
            // 
            this.tabPatientsList.BackColor = System.Drawing.Color.Transparent;
            this.tabPatientsList.Controls.Add(this.dataGridView1);
            this.tabPatientsList.ImageIndex = 8;
            this.tabPatientsList.Location = new System.Drawing.Point(4, 23);
            this.tabPatientsList.Name = "tabPatientsList";
            this.tabPatientsList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatientsList.Size = new System.Drawing.Size(745, 373);
            this.tabPatientsList.TabIndex = 1;
            this.tabPatientsList.Text = "Patient List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(728, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 57);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Names:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(580, 303);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 60);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "        &Add Patient";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gender:";
            // 
            // comboGender
            // 
            this.comboGender.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboGender.Location = new System.Drawing.Point(124, 153);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(130, 21);
            this.comboGender.TabIndex = 8;
            // 
            // Reception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 487);
            this.Controls.Add(this.tabReception);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reception";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminEnvironment";
            this.Load += new System.EventHandler(this.Reception_Load);
            this.tabReception.ResumeLayout(false);
            this.tabAppointment.ResumeLayout(false);
            this.tabPatientManagement.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPatients.ResumeLayout(false);
            this.tabAddPatients.ResumeLayout(false);
            this.tabAddPatients.PerformLayout();
            this.tabPatientsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabReception;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabAppointment;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPatientManagement;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAddAppointment;
        private System.Windows.Forms.TabPage tabAllAppointments;
        private System.Windows.Forms.TabPage tabTodaysAppointments;
        private System.Windows.Forms.TabControl tabPatients;
        private System.Windows.Forms.TabPage tabAddPatients;
        private System.Windows.Forms.TabPage tabPatientsList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}