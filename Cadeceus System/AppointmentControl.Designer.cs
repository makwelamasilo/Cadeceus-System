namespace WindowsFormsApplication1
{
    partial class AppointmentControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentControl));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAddAppointment = new System.Windows.Forms.TabPage();
            this.tabAllAppointments = new System.Windows.Forms.TabPage();
            this.tabTodaysAppointments = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelTodaysAppointments = new System.Windows.Forms.Panel();
            this.panelAllAppointments = new System.Windows.Forms.Panel();
            this.panelAddAppointment = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAddAppointment);
            this.tabControl1.Controls.Add(this.tabAllAppointments);
            this.tabControl1.Controls.Add(this.tabTodaysAppointments);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(3, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(832, 443);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tab_Appointmenta_SelectedIndexChanged);
            // 
            // tabAddAppointment
            // 
            this.tabAddAppointment.ImageIndex = 2;
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
            this.tabAllAppointments.ImageIndex = 0;
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
            this.tabTodaysAppointments.ImageIndex = 1;
            this.tabTodaysAppointments.Location = new System.Drawing.Point(4, 23);
            this.tabTodaysAppointments.Name = "tabTodaysAppointments";
            this.tabTodaysAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabTodaysAppointments.Size = new System.Drawing.Size(824, 416);
            this.tabTodaysAppointments.TabIndex = 2;
            this.tabTodaysAppointments.Text = "Today\'s Appointments";
            this.tabTodaysAppointments.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "4-256.png");
            this.imageList1.Images.SetKeyName(1, "31-128.png");
            this.imageList1.Images.SetKeyName(2, "add_new_create_date_appointment-256.png");
            // 
            // panelTodaysAppointments
            // 
            this.panelTodaysAppointments.BackColor = System.Drawing.Color.Black;
            this.panelTodaysAppointments.Location = new System.Drawing.Point(231, 3);
            this.panelTodaysAppointments.Name = "panelTodaysAppointments";
            this.panelTodaysAppointments.Size = new System.Drawing.Size(140, 10);
            this.panelTodaysAppointments.TabIndex = 0;
            // 
            // panelAllAppointments
            // 
            this.panelAllAppointments.BackColor = System.Drawing.Color.Black;
            this.panelAllAppointments.Location = new System.Drawing.Point(120, 3);
            this.panelAllAppointments.Name = "panelAllAppointments";
            this.panelAllAppointments.Size = new System.Drawing.Size(110, 10);
            this.panelAllAppointments.TabIndex = 1;
            // 
            // panelAddAppointment
            // 
            this.panelAddAppointment.BackColor = System.Drawing.Color.Black;
            this.panelAddAppointment.Location = new System.Drawing.Point(7, 3);
            this.panelAddAppointment.Name = "panelAddAppointment";
            this.panelAddAppointment.Size = new System.Drawing.Size(112, 10);
            this.panelAddAppointment.TabIndex = 1;
            // 
            // AppointmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTodaysAppointments);
            this.Controls.Add(this.panelAllAppointments);
            this.Controls.Add(this.panelAddAppointment);
            this.Controls.Add(this.tabControl1);
            this.Name = "AppointmentControl";
            this.Size = new System.Drawing.Size(835, 454);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAddAppointment;
        private System.Windows.Forms.TabPage tabAllAppointments;
        private System.Windows.Forms.TabPage tabTodaysAppointments;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelTodaysAppointments;
        private System.Windows.Forms.Panel panelAllAppointments;
        private System.Windows.Forms.Panel panelAddAppointment;
    }
}
