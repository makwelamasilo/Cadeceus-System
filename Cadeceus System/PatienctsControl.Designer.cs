﻿namespace WindowsFormsApplication1
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
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEntryDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPatientsList = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabRemovePatients = new System.Windows.Forms.TabPage();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabUpdatePatients = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabAdmission = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabOperations = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelPatientsList = new System.Windows.Forms.Panel();
            this.panelAddPatients = new System.Windows.Forms.Panel();
            this.tabPatients.SuspendLayout();
            this.tabAddPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPatientsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabRemovePatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabUpdatePatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabAdmission.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPatients
            // 
            this.tabPatients.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabPatients.Controls.Add(this.tabAddPatients);
            this.tabPatients.Controls.Add(this.tabPatientsList);
            this.tabPatients.Controls.Add(this.tabRemovePatients);
            this.tabPatients.Controls.Add(this.tabUpdatePatients);
            this.tabPatients.Controls.Add(this.tabAdmission);
            this.tabPatients.Controls.Add(this.tabOperations);
            this.tabPatients.ImageList = this.imageList1;
            this.tabPatients.Location = new System.Drawing.Point(4, 7);
            this.tabPatients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPatients.Name = "tabPatients";
            this.tabPatients.SelectedIndex = 0;
            this.tabPatients.ShowToolTips = true;
            this.tabPatients.Size = new System.Drawing.Size(1105, 548);
            this.tabPatients.TabIndex = 1;
            // 
            // tabAddPatients
            // 
            this.tabAddPatients.BackColor = System.Drawing.Color.White;
            this.tabAddPatients.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabAddPatients.BackgroundImage")));
            this.tabAddPatients.Controls.Add(this.maskedTextBox3);
            this.tabAddPatients.Controls.Add(this.maskedTextBox2);
            this.tabAddPatients.Controls.Add(this.comboBox3);
            this.tabAddPatients.Controls.Add(this.label15);
            this.tabAddPatients.Controls.Add(this.textBox7);
            this.tabAddPatients.Controls.Add(this.label14);
            this.tabAddPatients.Controls.Add(this.comboBox2);
            this.tabAddPatients.Controls.Add(this.label13);
            this.tabAddPatients.Controls.Add(this.comboBox1);
            this.tabAddPatients.Controls.Add(this.label12);
            this.tabAddPatients.Controls.Add(this.dateTimePicker1);
            this.tabAddPatients.Controls.Add(this.label11);
            this.tabAddPatients.Controls.Add(this.txtEntryDate);
            this.tabAddPatients.Controls.Add(this.label10);
            this.tabAddPatients.Controls.Add(this.textBox5);
            this.tabAddPatients.Controls.Add(this.label9);
            this.tabAddPatients.Controls.Add(this.textBox4);
            this.tabAddPatients.Controls.Add(this.label8);
            this.tabAddPatients.Controls.Add(this.label7);
            this.tabAddPatients.Controls.Add(this.label5);
            this.tabAddPatients.Controls.Add(this.textBox2);
            this.tabAddPatients.Controls.Add(this.textBox1);
            this.tabAddPatients.Controls.Add(this.label4);
            this.tabAddPatients.Controls.Add(this.btnAdd);
            this.tabAddPatients.Controls.Add(this.label3);
            this.tabAddPatients.Controls.Add(this.pictureBox1);
            this.tabAddPatients.Controls.Add(this.label2);
            this.tabAddPatients.ImageIndex = 2;
            this.tabAddPatients.Location = new System.Drawing.Point(4, 28);
            this.tabAddPatients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAddPatients.Name = "tabAddPatients";
            this.tabAddPatients.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAddPatients.Size = new System.Drawing.Size(1097, 516);
            this.tabAddPatients.TabIndex = 0;
            this.tabAddPatients.Text = "Add Patients";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(324, 187);
            this.maskedTextBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTextBox3.Mask = "(999) 000-0000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(172, 22);
            this.maskedTextBox3.TabIndex = 30;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(324, 288);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTextBox2.Mask = "0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(172, 22);
            this.maskedTextBox2.TabIndex = 29;
            this.maskedTextBox2.ValidatingType = typeof(int);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
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
            this.comboBox3.Location = new System.Drawing.Point(823, 288);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(172, 24);
            this.comboBox3.Sorted = true;
            this.comboBox3.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(629, 287);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 23);
            this.label15.TabIndex = 27;
            this.label15.Text = "Department:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(823, 252);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(172, 22);
            this.textBox7.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(629, 255);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 23);
            this.label14.TabIndex = 25;
            this.label14.Text = "Diagnosis:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Dr Pablo",
            "Dr Moripe",
            "Dr Sumi",
            "Dr Makwela"});
            this.comboBox2.Location = new System.Drawing.Point(823, 219);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(172, 24);
            this.comboBox2.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(629, 223);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 23);
            this.label13.TabIndex = 23;
            this.label13.Text = "Docter Refered To:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboBox1.Location = new System.Drawing.Point(823, 186);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 24);
            this.comboBox1.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(629, 190);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 23);
            this.label12.TabIndex = 21;
            this.label12.Text = "Sex";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(823, 154);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 22);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(629, 158);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 23);
            this.label11.TabIndex = 19;
            this.label11.Text = "Date Of Birth:";
            // 
            // txtEntryDate
            // 
            this.txtEntryDate.Location = new System.Drawing.Point(823, 124);
            this.txtEntryDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEntryDate.Name = "txtEntryDate";
            this.txtEntryDate.Size = new System.Drawing.Size(172, 22);
            this.txtEntryDate.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(629, 123);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 23);
            this.label10.TabIndex = 17;
            this.label10.Text = "Entry Date:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(324, 251);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(172, 22);
            this.textBox5.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(161, 283);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Postal Code:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(324, 219);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(172, 22);
            this.textBox4.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(161, 250);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Street:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(161, 218);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phone Number:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(324, 156);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(324, 124);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 22);
            this.textBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
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
            this.btnAdd.Location = new System.Drawing.Point(900, 432);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(187, 74);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "        &Add Patient";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Names:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 134);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
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
            this.tabPatientsList.Location = new System.Drawing.Point(4, 28);
            this.tabPatientsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPatientsList.Name = "tabPatientsList";
            this.tabPatientsList.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPatientsList.Size = new System.Drawing.Size(1097, 516);
            this.tabPatientsList.TabIndex = 1;
            this.tabPatientsList.Text = "Patient List";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(133, 5);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 22);
            this.textBox3.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Enter Student:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1095, 485);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabRemovePatients
            // 
            this.tabRemovePatients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabRemovePatients.Controls.Add(this.txtUserId);
            this.tabRemovePatients.Controls.Add(this.label1);
            this.tabRemovePatients.Controls.Add(this.dataGridView2);
            this.tabRemovePatients.ImageIndex = 1;
            this.tabRemovePatients.Location = new System.Drawing.Point(4, 28);
            this.tabRemovePatients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabRemovePatients.Name = "tabRemovePatients";
            this.tabRemovePatients.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabRemovePatients.Size = new System.Drawing.Size(1097, 516);
            this.tabRemovePatients.TabIndex = 2;
            this.tabRemovePatients.Text = "Remove Patient";
            this.tabRemovePatients.UseVisualStyleBackColor = true;
            // 
            // txtUserId
            // 
            this.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserId.Location = new System.Drawing.Point(133, 4);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(170, 22);
            this.txtUserId.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Student:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-1, 33);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1100, 487);
            this.dataGridView2.TabIndex = 1;
            // 
            // tabUpdatePatients
            // 
            this.tabUpdatePatients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabUpdatePatients.Controls.Add(this.dataGridView3);
            this.tabUpdatePatients.ImageIndex = 3;
            this.tabUpdatePatients.Location = new System.Drawing.Point(4, 28);
            this.tabUpdatePatients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabUpdatePatients.Name = "tabUpdatePatients";
            this.tabUpdatePatients.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabUpdatePatients.Size = new System.Drawing.Size(1097, 516);
            this.tabUpdatePatients.TabIndex = 3;
            this.tabUpdatePatients.Text = "Update Patients";
            this.tabUpdatePatients.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(-1, 30);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1100, 495);
            this.dataGridView3.TabIndex = 1;
            // 
            // tabAdmission
            // 
            this.tabAdmission.Controls.Add(this.dataGridView4);
            this.tabAdmission.Location = new System.Drawing.Point(4, 28);
            this.tabAdmission.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAdmission.Name = "tabAdmission";
            this.tabAdmission.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAdmission.Size = new System.Drawing.Size(1097, 516);
            this.tabAdmission.TabIndex = 4;
            this.tabAdmission.Text = "Patient Admission";
            this.tabAdmission.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(8, 7);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(1079, 496);
            this.dataGridView4.TabIndex = 0;
            // 
            // tabOperations
            // 
            this.tabOperations.Location = new System.Drawing.Point(4, 28);
            this.tabOperations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabOperations.Name = "tabOperations";
            this.tabOperations.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabOperations.Size = new System.Drawing.Size(1097, 516);
            this.tabOperations.TabIndex = 5;
            this.tabOperations.Text = "Patient Operations";
            this.tabOperations.UseVisualStyleBackColor = true;
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
            // panelPatientsList
            // 
            this.panelPatientsList.BackColor = System.Drawing.Color.Black;
            this.panelPatientsList.Location = new System.Drawing.Point(105, 1);
            this.panelPatientsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPatientsList.Name = "panelPatientsList";
            this.panelPatientsList.Size = new System.Drawing.Size(81, 12);
            this.panelPatientsList.TabIndex = 9;
            // 
            // panelAddPatients
            // 
            this.panelAddPatients.BackColor = System.Drawing.Color.Black;
            this.panelAddPatients.Location = new System.Drawing.Point(4, 4);
            this.panelAddPatients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelAddPatients.Name = "panelAddPatients";
            this.panelAddPatients.Size = new System.Drawing.Size(100, 12);
            this.panelAddPatients.TabIndex = 9;
            // 
            // PatienctsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.tabPatients);
            this.Controls.Add(this.panelAddPatients);
            this.Controls.Add(this.panelPatientsList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PatienctsControl";
            this.Size = new System.Drawing.Size(1113, 559);
            this.Load += new System.EventHandler(this.PatienctsControl_Load);
            this.tabPatients.ResumeLayout(false);
            this.tabAddPatients.ResumeLayout(false);
            this.tabAddPatients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPatientsList.ResumeLayout(false);
            this.tabPatientsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabRemovePatients.ResumeLayout(false);
            this.tabRemovePatients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabUpdatePatients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabAdmission.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPatients;
        private System.Windows.Forms.TabPage tabAddPatients;
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
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEntryDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabAdmission;
        private System.Windows.Forms.TabPage tabOperations;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
    }
}
