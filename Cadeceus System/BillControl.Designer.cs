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
            this.btnPrintBill.Location = new System.Drawing.Point(14, 192);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(131, 49);
            this.btnPrintBill.TabIndex = 12;
            this.btnPrintBill.Text = "&Print Bill";
            this.btnPrintBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintBill.UseVisualStyleBackColor = false;
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
            this.btnEmail.Location = new System.Drawing.Point(14, 261);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(131, 49);
            this.btnEmail.TabIndex = 11;
            this.btnEmail.Text = "&Email";
            this.btnEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmail.UseVisualStyleBackColor = false;
            // 
            // txtBill
            // 
            this.txtBill.BackColor = System.Drawing.SystemColors.Window;
            this.txtBill.Location = new System.Drawing.Point(381, 13);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(406, 439);
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
            this.btnViewBill.Location = new System.Drawing.Point(14, 125);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(131, 49);
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
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter Patient\'s User ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Patient\'s Full Names:";
            // 
            // lblPatientNames
            // 
            this.lblPatientNames.AutoSize = true;
            this.lblPatientNames.BackColor = System.Drawing.Color.Transparent;
            this.lblPatientNames.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientNames.ForeColor = System.Drawing.Color.White;
            this.lblPatientNames.Location = new System.Drawing.Point(196, 81);
            this.lblPatientNames.Name = "lblPatientNames";
            this.lblPatientNames.Size = new System.Drawing.Size(62, 19);
            this.lblPatientNames.TabIndex = 16;
            this.lblPatientNames.Text = "Names";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(339, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(22, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // BillControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblPatientNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrintBill);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.btnViewBill);
            this.Name = "BillControl";
            this.Size = new System.Drawing.Size(800, 464);
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
    }
}
