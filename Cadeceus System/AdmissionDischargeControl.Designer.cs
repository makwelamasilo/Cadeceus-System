namespace WindowsFormsApplication1
{
    partial class AdmissionDischargeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmissionDischargeControl));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAdmit = new System.Windows.Forms.TabPage();
            this.tabViewAdmitted = new System.Windows.Forms.TabPage();
            this.tabDischarge = new System.Windows.Forms.TabPage();
            this.tabViewDischarged = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabAdmit);
            this.tabControl1.Controls.Add(this.tabViewAdmitted);
            this.tabControl1.Controls.Add(this.tabDischarge);
            this.tabControl1.Controls.Add(this.tabViewDischarged);
            this.tabControl1.Location = new System.Drawing.Point(3, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(863, 432);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAdmit
            // 
            this.tabAdmit.Location = new System.Drawing.Point(4, 25);
            this.tabAdmit.Name = "tabAdmit";
            this.tabAdmit.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdmit.Size = new System.Drawing.Size(855, 403);
            this.tabAdmit.TabIndex = 0;
            this.tabAdmit.Text = "Admit Patients";
            this.tabAdmit.UseVisualStyleBackColor = true;
            // 
            // tabViewAdmitted
            // 
            this.tabViewAdmitted.Location = new System.Drawing.Point(4, 25);
            this.tabViewAdmitted.Name = "tabViewAdmitted";
            this.tabViewAdmitted.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewAdmitted.Size = new System.Drawing.Size(855, 403);
            this.tabViewAdmitted.TabIndex = 1;
            this.tabViewAdmitted.Text = "View Admitted Patients";
            this.tabViewAdmitted.UseVisualStyleBackColor = true;
            // 
            // tabDischarge
            // 
            this.tabDischarge.Location = new System.Drawing.Point(4, 25);
            this.tabDischarge.Name = "tabDischarge";
            this.tabDischarge.Size = new System.Drawing.Size(855, 403);
            this.tabDischarge.TabIndex = 2;
            this.tabDischarge.Text = "Discharge Patients";
            this.tabDischarge.UseVisualStyleBackColor = true;
            // 
            // tabViewDischarged
            // 
            this.tabViewDischarged.Location = new System.Drawing.Point(4, 25);
            this.tabViewDischarged.Name = "tabViewDischarged";
            this.tabViewDischarged.Size = new System.Drawing.Size(855, 403);
            this.tabViewDischarged.TabIndex = 3;
            this.tabViewDischarged.Text = "View Discharged Patients";
            this.tabViewDischarged.UseVisualStyleBackColor = true;
            // 
            // AdmissionDischargeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.tabControl1);
            this.Name = "AdmissionDischargeControl";
            this.Size = new System.Drawing.Size(865, 446);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAdmit;
        private System.Windows.Forms.TabPage tabViewAdmitted;
        private System.Windows.Forms.TabPage tabDischarge;
        private System.Windows.Forms.TabPage tabViewDischarged;
    }
}
