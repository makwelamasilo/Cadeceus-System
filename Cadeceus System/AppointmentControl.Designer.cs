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
            this.tabRemoveAppointments = new System.Windows.Forms.TabPage();
            this.tabUpdateAppointments = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabAddAppointment.SuspendLayout();
            this.tabAllAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabAddAppointment);
            this.tabControl1.Controls.Add(this.tabAllAppointments);
            this.tabControl1.Controls.Add(this.tabTodaysAppointments);
            this.tabControl1.Controls.Add(this.tabRemoveAppointments);
            this.tabControl1.Controls.Add(this.tabUpdateAppointments);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(3, 11);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(867, 440);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tab_Appointmenta_SelectedIndexChanged);
            // 
            // tabAddAppointment
            // 
            this.tabAddAppointment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabAddAppointment.BackgroundImage")));
            this.tabAddAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabAddAppointment.Controls.Add(this.panel1);
            this.tabAddAppointment.Controls.Add(this.groupBox1);
            this.tabAddAppointment.ImageIndex = 3;
            this.tabAddAppointment.Location = new System.Drawing.Point(4, 26);
            this.tabAddAppointment.Name = "tabAddAppointment";
            this.tabAddAppointment.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddAppointment.Size = new System.Drawing.Size(859, 410);
            this.tabAddAppointment.TabIndex = 0;
            this.tabAddAppointment.Text = "Add Appointment";
            this.tabAddAppointment.UseVisualStyleBackColor = true;
            // 
            // tabAllAppointments
            // 
            this.tabAllAppointments.Controls.Add(this.dataGridView1);
            this.tabAllAppointments.Controls.Add(this.textBox3);
            this.tabAllAppointments.Controls.Add(this.label1);
            this.tabAllAppointments.ImageIndex = 5;
            this.tabAllAppointments.Location = new System.Drawing.Point(4, 26);
            this.tabAllAppointments.Name = "tabAllAppointments";
            this.tabAllAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllAppointments.Size = new System.Drawing.Size(859, 410);
            this.tabAllAppointments.TabIndex = 1;
            this.tabAllAppointments.Text = "All Appointments";
            this.tabAllAppointments.UseVisualStyleBackColor = true;
            // 
            // tabTodaysAppointments
            // 
            this.tabTodaysAppointments.ImageIndex = 1;
            this.tabTodaysAppointments.Location = new System.Drawing.Point(4, 26);
            this.tabTodaysAppointments.Name = "tabTodaysAppointments";
            this.tabTodaysAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabTodaysAppointments.Size = new System.Drawing.Size(859, 410);
            this.tabTodaysAppointments.TabIndex = 2;
            this.tabTodaysAppointments.Text = "Today\'s Appointments";
            this.tabTodaysAppointments.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-delete-table-filled-50.png");
            this.imageList1.Images.SetKeyName(1, "icons8-calendar-plus-filled-100.png");
            this.imageList1.Images.SetKeyName(2, "icons8-calendar-plus-filled-100.png");
            this.imageList1.Images.SetKeyName(3, "icons8-rescheduling-a-task-filled-100.png");
            this.imageList1.Images.SetKeyName(4, "icons8-calendar-14-filled-100.png");
            this.imageList1.Images.SetKeyName(5, "icons8-planner-filled-100.png");
            // 
            // panelTodaysAppointments
            // 
            this.panelTodaysAppointments.BackColor = System.Drawing.Color.Black;
            this.panelTodaysAppointments.Location = new System.Drawing.Point(231, 9);
            this.panelTodaysAppointments.Name = "panelTodaysAppointments";
            this.panelTodaysAppointments.Size = new System.Drawing.Size(136, 10);
            this.panelTodaysAppointments.TabIndex = 0;
            // 
            // panelAllAppointments
            // 
            this.panelAllAppointments.BackColor = System.Drawing.Color.Black;
            this.panelAllAppointments.Location = new System.Drawing.Point(120, 9);
            this.panelAllAppointments.Name = "panelAllAppointments";
            this.panelAllAppointments.Size = new System.Drawing.Size(110, 10);
            this.panelAllAppointments.TabIndex = 1;
            // 
            // panelAddAppointment
            // 
            this.panelAddAppointment.BackColor = System.Drawing.Color.Black;
            this.panelAddAppointment.Location = new System.Drawing.Point(3, 9);
            this.panelAddAppointment.Name = "panelAddAppointment";
            this.panelAddAppointment.Size = new System.Drawing.Size(116, 10);
            this.panelAddAppointment.TabIndex = 1;
            // 
            // tabRemoveAppointments
            // 
            this.tabRemoveAppointments.ImageIndex = 2;
            this.tabRemoveAppointments.Location = new System.Drawing.Point(4, 26);
            this.tabRemoveAppointments.Name = "tabRemoveAppointments";
            this.tabRemoveAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabRemoveAppointments.Size = new System.Drawing.Size(859, 410);
            this.tabRemoveAppointments.TabIndex = 3;
            this.tabRemoveAppointments.Text = "Remove Appointments";
            this.tabRemoveAppointments.UseVisualStyleBackColor = true;
            // 
            // tabUpdateAppointments
            // 
            this.tabUpdateAppointments.ImageIndex = 4;
            this.tabUpdateAppointments.Location = new System.Drawing.Point(4, 26);
            this.tabUpdateAppointments.Name = "tabUpdateAppointments";
            this.tabUpdateAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdateAppointments.Size = new System.Drawing.Size(859, 410);
            this.tabUpdateAppointments.TabIndex = 4;
            this.tabUpdateAppointments.Text = "Reschedule Appointments";
            this.tabUpdateAppointments.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(101, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Student:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(859, 390);
            this.dataGridView1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(65, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 350);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Make an appointment";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(65, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 52);
            this.button3.TabIndex = 16;
            this.button3.Text = "Book";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(71, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 26);
            this.textBox1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Enabled = false;
            this.monthCalendar1.Location = new System.Drawing.Point(18, 118);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(515, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 214);
            this.panel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(9, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Doctor";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 26);
            this.textBox2.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Appointment Confirmation";
            // 
            // AppointmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelTodaysAppointments);
            this.Controls.Add(this.panelAllAppointments);
            this.Controls.Add(this.panelAddAppointment);
            this.DoubleBuffered = true;
            this.Name = "AppointmentControl";
            this.Size = new System.Drawing.Size(869, 450);
            this.tabControl1.ResumeLayout(false);
            this.tabAddAppointment.ResumeLayout(false);
            this.tabAllAppointments.ResumeLayout(false);
            this.tabAllAppointments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TabPage tabRemoveAppointments;
        private System.Windows.Forms.TabPage tabUpdateAppointments;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}
