namespace WindowsFormsApplication1
{
    partial class PatienctsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatienctsControl));
            this.tabPatients = new System.Windows.Forms.TabControl();
            this.tabAddPatients = new System.Windows.Forms.TabPage();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPatientsList = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelPatientsList = new System.Windows.Forms.Panel();
            this.panelAddPatients = new System.Windows.Forms.Panel();
            this.tabRemovePatients = new System.Windows.Forms.TabPage();
            this.tabUpdatePatients = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPatients.SuspendLayout();
            this.tabAddPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPatientsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabRemovePatients.SuspendLayout();
            this.tabUpdatePatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPatients
            // 
            this.tabPatients.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabPatients.Controls.Add(this.tabAddPatients);
            this.tabPatients.Controls.Add(this.tabPatientsList);
            this.tabPatients.Controls.Add(this.tabRemovePatients);
            this.tabPatients.Controls.Add(this.tabUpdatePatients);
            this.tabPatients.ImageList = this.imageList1;
            this.tabPatients.Location = new System.Drawing.Point(3, 6);
            this.tabPatients.Name = "tabPatients";
            this.tabPatients.SelectedIndex = 0;
            this.tabPatients.ShowToolTips = true;
            this.tabPatients.Size = new System.Drawing.Size(829, 445);
            this.tabPatients.TabIndex = 1;
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
            this.tabAddPatients.ImageIndex = 2;
            this.tabAddPatients.Location = new System.Drawing.Point(4, 26);
            this.tabAddPatients.Name = "tabAddPatients";
            this.tabAddPatients.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddPatients.Size = new System.Drawing.Size(821, 416);
            this.tabAddPatients.TabIndex = 0;
            this.tabAddPatients.Text = "Add Patients";
            // 
            // comboGender
            // 
            this.comboGender.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboGender.Location = new System.Drawing.Point(205, 154);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(130, 21);
            this.comboGender.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gender:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(205, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(675, 351);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 60);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "        &Add Patient";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Names:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 109);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // tabPatientsList
            // 
            this.tabPatientsList.BackColor = System.Drawing.Color.Transparent;
            this.tabPatientsList.Controls.Add(this.textBox3);
            this.tabPatientsList.Controls.Add(this.label6);
            this.tabPatientsList.Controls.Add(this.dataGridView1);
            this.tabPatientsList.ImageIndex = 0;
            this.tabPatientsList.Location = new System.Drawing.Point(4, 26);
            this.tabPatientsList.Name = "tabPatientsList";
            this.tabPatientsList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatientsList.Size = new System.Drawing.Size(821, 415);
            this.tabPatientsList.TabIndex = 1;
            this.tabPatientsList.Text = "Patient List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(821, 394);
            this.dataGridView1.TabIndex = 0;
            // 
            // panelPatientsList
            // 
            this.panelPatientsList.BackColor = System.Drawing.Color.Black;
            this.panelPatientsList.Location = new System.Drawing.Point(79, 1);
            this.panelPatientsList.Name = "panelPatientsList";
            this.panelPatientsList.Size = new System.Drawing.Size(61, 10);
            this.panelPatientsList.TabIndex = 9;
            // 
            // panelAddPatients
            // 
            this.panelAddPatients.BackColor = System.Drawing.Color.Black;
            this.panelAddPatients.Location = new System.Drawing.Point(3, 3);
            this.panelAddPatients.Name = "panelAddPatients";
            this.panelAddPatients.Size = new System.Drawing.Size(75, 10);
            this.panelAddPatients.TabIndex = 9;
            // 
            // tabRemovePatients
            // 
            this.tabRemovePatients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabRemovePatients.Controls.Add(this.txtUserId);
            this.tabRemovePatients.Controls.Add(this.label1);
            this.tabRemovePatients.Controls.Add(this.dataGridView2);
            this.tabRemovePatients.ImageIndex = 1;
            this.tabRemovePatients.Location = new System.Drawing.Point(4, 26);
            this.tabRemovePatients.Name = "tabRemovePatients";
            this.tabRemovePatients.Padding = new System.Windows.Forms.Padding(3);
            this.tabRemovePatients.Size = new System.Drawing.Size(821, 416);
            this.tabRemovePatients.TabIndex = 2;
            this.tabRemovePatients.Text = "Remove Patient";
            this.tabRemovePatients.UseVisualStyleBackColor = true;
            // 
            // tabUpdatePatients
            // 
            this.tabUpdatePatients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabUpdatePatients.Controls.Add(this.dataGridView3);
            this.tabUpdatePatients.ImageIndex = 3;
            this.tabUpdatePatients.Location = new System.Drawing.Point(4, 26);
            this.tabUpdatePatients.Name = "tabUpdatePatients";
            this.tabUpdatePatients.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdatePatients.Size = new System.Drawing.Size(821, 416);
            this.tabUpdatePatients.TabIndex = 3;
            this.tabUpdatePatients.Text = "Update Patients";
            this.tabUpdatePatients.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-1, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(825, 396);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(-1, 24);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(825, 402);
            this.dataGridView3.TabIndex = 1;
            // 
            // txtUserId
            // 
            this.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserId.Location = new System.Drawing.Point(100, 3);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(128, 20);
            this.txtUserId.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Student:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(100, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Enter Student:";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-database-view-filled-50.png");
            this.imageList1.Images.SetKeyName(1, "icons8-minus-filled-50.png");
            this.imageList1.Images.SetKeyName(2, "icons8-plus-filled-50.png");
            this.imageList1.Images.SetKeyName(3, "icons8-update-filled-50.png");
            // 
            // PatienctsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.tabPatients);
            this.Controls.Add(this.panelAddPatients);
            this.Controls.Add(this.panelPatientsList);
            this.Name = "PatienctsControl";
            this.Size = new System.Drawing.Size(835, 454);
            this.tabPatients.ResumeLayout(false);
            this.tabAddPatients.ResumeLayout(false);
            this.tabAddPatients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPatientsList.ResumeLayout(false);
            this.tabPatientsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabRemovePatients.ResumeLayout(false);
            this.tabRemovePatients.PerformLayout();
            this.tabUpdatePatients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPatients;
        private System.Windows.Forms.TabPage tabAddPatients;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPatientsList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelPatientsList;
        private System.Windows.Forms.Panel panelAddPatients;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabRemovePatients;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabUpdatePatients;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ImageList imageList1;
    }
}
