﻿namespace WindowsFormsApplication1
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnEmployeeManagement = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnPatientsManagement = new System.Windows.Forms.Button();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelControls = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.TimerTime_Tick);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLeft.BackgroundImage")));
            this.panelLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLeft.Controls.Add(this.btnEmployeeManagement);
            this.panelLeft.Controls.Add(this.panelSide);
            this.panelLeft.Controls.Add(this.btnBill);
            this.panelLeft.Controls.Add(this.btnPatientsManagement);
            this.panelLeft.Controls.Add(this.btnAppointment);
            this.panelLeft.Controls.Add(this.btnHome);
            this.panelLeft.Controls.Add(this.panel3);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(209, 598);
            this.panelLeft.TabIndex = 8;
            // 
            // btnEmployeeManagement
            // 
            this.btnEmployeeManagement.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployeeManagement.FlatAppearance.BorderSize = 0;
            this.btnEmployeeManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeManagement.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeManagement.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeManagement.Image")));
            this.btnEmployeeManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeManagement.Location = new System.Drawing.Point(12, 402);
            this.btnEmployeeManagement.Name = "btnEmployeeManagement";
            this.btnEmployeeManagement.Size = new System.Drawing.Size(203, 60);
            this.btnEmployeeManagement.TabIndex = 3;
            this.btnEmployeeManagement.Text = "Employees Management";
            this.btnEmployeeManagement.UseVisualStyleBackColor = false;
            this.btnEmployeeManagement.Click += new System.EventHandler(this.BtnEmployeeManagement_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Location = new System.Drawing.Point(1, 142);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(7, 60);
            this.panelSide.TabIndex = 1;
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.Transparent;
            this.btnBill.FlatAppearance.BorderSize = 0;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Image = ((System.Drawing.Image)(resources.GetObject("btnBill.Image")));
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Location = new System.Drawing.Point(12, 336);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(203, 60);
            this.btnBill.TabIndex = 2;
            this.btnBill.Text = "     Bills";
            this.btnBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.BtnBill_Click_1);
            // 
            // btnPatientsManagement
            // 
            this.btnPatientsManagement.BackColor = System.Drawing.Color.Transparent;
            this.btnPatientsManagement.FlatAppearance.BorderSize = 0;
            this.btnPatientsManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientsManagement.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientsManagement.ForeColor = System.Drawing.Color.White;
            this.btnPatientsManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnPatientsManagement.Image")));
            this.btnPatientsManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatientsManagement.Location = new System.Drawing.Point(12, 271);
            this.btnPatientsManagement.Name = "btnPatientsManagement";
            this.btnPatientsManagement.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPatientsManagement.Size = new System.Drawing.Size(181, 60);
            this.btnPatientsManagement.TabIndex = 2;
            this.btnPatientsManagement.Text = "Patients  Management";
            this.btnPatientsManagement.UseVisualStyleBackColor = false;
            this.btnPatientsManagement.Click += new System.EventHandler(this.BtnPatientsManagement_Click_1);
            // 
            // btnAppointment
            // 
            this.btnAppointment.BackColor = System.Drawing.Color.Transparent;
            this.btnAppointment.FlatAppearance.BorderSize = 0;
            this.btnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAppointment.Image = ((System.Drawing.Image)(resources.GetObject("btnAppointment.Image")));
            this.btnAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppointment.Location = new System.Drawing.Point(12, 205);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(192, 60);
            this.btnAppointment.TabIndex = 2;
            this.btnAppointment.Text = "     Appointments";
            this.btnAppointment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppointment.UseVisualStyleBackColor = false;
            this.btnAppointment.Click += new System.EventHandler(this.BtnAppointment_Click_1);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(11, 140);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(196, 60);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "     Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click_1);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnMinimize);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 134);
            this.panel3.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimize.Location = new System.Drawing.Point(167, 8);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(38, 29);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Code Exircutioners";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(166, 50);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(42, 19);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "Role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(110, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Role:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(165, 19);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(89, 19);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Cadeceus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome:";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Location = new System.Drawing.Point(209, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(855, 50);
            this.panel4.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(6, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(462, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hospital Management System";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(808, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 50);
            this.btnClose.TabIndex = 2;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panelControls
            // 
            this.panelControls.Location = new System.Drawing.Point(209, 132);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(855, 466);
            this.panelControls.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lblRole);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.labelTime);
            this.panel2.Controls.Add(this.lblWelcome);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(209, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 86);
            this.panel2.TabIndex = 9;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelTime.Location = new System.Drawing.Point(733, 28);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(83, 19);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "HH:MM:SS";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 598);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelLeft.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnEmployeeManagement;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnPatientsManagement;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTime;
    }
}