namespace WindowsFormsApplication1
{
    partial class BillControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillControl));
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.txtBill = new System.Windows.Forms.RichTextBox();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPatientNames = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtAttachment = new System.Windows.Forms.TextBox();
            this.btnAttachment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintBill.FlatAppearance.BorderSize = 0;
            this.btnPrintBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintBill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBill.ForeColor = System.Drawing.Color.White;
            this.btnPrintBill.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintBill.Image")));
            this.btnPrintBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintBill.Location = new System.Drawing.Point(19, 236);
            this.btnPrintBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(175, 60);
            this.btnPrintBill.TabIndex = 12;
            this.btnPrintBill.Text = "&Print Bill";
            this.btnPrintBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintBill.UseVisualStyleBackColor = false;
            this.btnPrintBill.Click += new System.EventHandler(this.BtnPrintBill_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.BackColor = System.Drawing.Color.Transparent;
            this.btnEmail.FlatAppearance.BorderSize = 0;
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmail.ForeColor = System.Drawing.Color.White;
            this.btnEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnEmail.Image")));
            this.btnEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmail.Location = new System.Drawing.Point(19, 321);
            this.btnEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(175, 60);
            this.btnEmail.TabIndex = 11;
            this.btnEmail.Text = "&Email";
            this.btnEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmail.UseVisualStyleBackColor = false;
            this.btnEmail.Click += new System.EventHandler(this.BtnEmail_Click);
            // 
            // txtBill
            // 
            this.txtBill.BackColor = System.Drawing.SystemColors.Window;
            this.txtBill.Location = new System.Drawing.Point(508, 16);
            this.txtBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(540, 607);
            this.txtBill.TabIndex = 10;
            this.txtBill.Text = "";
            // 
            // btnViewBill
            // 
            this.btnViewBill.BackColor = System.Drawing.Color.Transparent;
            this.btnViewBill.FlatAppearance.BorderSize = 0;
            this.btnViewBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBill.ForeColor = System.Drawing.Color.White;
            this.btnViewBill.Image = ((System.Drawing.Image)(resources.GetObject("btnViewBill.Image")));
            this.btnViewBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewBill.Location = new System.Drawing.Point(19, 154);
            this.btnViewBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(175, 60);
            this.btnViewBill.TabIndex = 9;
            this.btnViewBill.Text = "&View Bill";
            this.btnViewBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewBill.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter Patient\'s User ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(281, 50);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 22);
            this.textBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Patient\'s Full Names:";
            // 
            // lblPatientNames
            // 
            this.lblPatientNames.AutoSize = true;
            this.lblPatientNames.BackColor = System.Drawing.Color.Transparent;
            this.lblPatientNames.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientNames.ForeColor = System.Drawing.Color.White;
            this.lblPatientNames.Location = new System.Drawing.Point(261, 100);
            this.lblPatientNames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientNames.Name = "lblPatientNames";
            this.lblPatientNames.Size = new System.Drawing.Size(74, 24);
            this.lblPatientNames.TabIndex = 16;
            this.lblPatientNames.Text = "Names";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(452, 48);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(29, 28);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "CC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Subject:";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(530, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Body";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(600, 45);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(360, 22);
            this.txtTo.TabIndex = 22;
            this.txtTo.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(600, 100);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(360, 22);
            this.txtCC.TabIndex = 23;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(600, 151);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(360, 22);
            this.txtSubject.TabIndex = 24;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(600, 203);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBody.Size = new System.Drawing.Size(360, 263);
            this.txtBody.TabIndex = 25;
            // 
            // txtAttachment
            // 
            this.txtAttachment.Location = new System.Drawing.Point(600, 498);
            this.txtAttachment.Name = "txtAttachment";
            this.txtAttachment.Size = new System.Drawing.Size(360, 22);
            this.txtAttachment.TabIndex = 26;
            // 
            // btnAttachment
            // 
            this.btnAttachment.Location = new System.Drawing.Point(713, 540);
            this.btnAttachment.Name = "btnAttachment";
            this.btnAttachment.Size = new System.Drawing.Size(148, 37);
            this.btnAttachment.TabIndex = 27;
            this.btnAttachment.Text = "Add Attachment";
            this.btnAttachment.UseVisualStyleBackColor = true;
            this.btnAttachment.Click += new System.EventHandler(this.BtnAttachment_Click);
            // 
            // BillControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.btnAttachment);
            this.Controls.Add(this.txtAttachment);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblPatientNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrintBill);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.btnViewBill);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BillControl";
            this.Size = new System.Drawing.Size(1067, 702);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.RichTextBox txtBill;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPatientNames;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TextBox txtAttachment;
        private System.Windows.Forms.Button btnAttachment;
    }
}
