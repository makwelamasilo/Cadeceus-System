namespace WindowsFormsApplication1
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSetFont = new System.Windows.Forms.Button();
            this.btnSetTheme = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.groupThemes = new System.Windows.Forms.GroupBox();
            this.radLight = new System.Windows.Forms.RadioButton();
            this.radDark = new System.Windows.Forms.RadioButton();
            this.comboFontSizes = new System.Windows.Forms.ComboBox();
            this.groupThemes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1058, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "            Settings                                                             " +
    "         ";
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(12, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(58, 52);
            this.button7.TabIndex = 8;
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(886, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 32);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(849, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(31, 32);
            this.btnBack.TabIndex = 10;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(53, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "&Apply Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnApplyChanges_Click);
            // 
            // btnSetFont
            // 
            this.btnSetFont.FlatAppearance.BorderSize = 0;
            this.btnSetFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetFont.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetFont.Image = ((System.Drawing.Image)(resources.GetObject("btnSetFont.Image")));
            this.btnSetFont.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetFont.Location = new System.Drawing.Point(53, 79);
            this.btnSetFont.Name = "btnSetFont";
            this.btnSetFont.Size = new System.Drawing.Size(126, 54);
            this.btnSetFont.TabIndex = 15;
            this.btnSetFont.Text = "&Set Font";
            this.btnSetFont.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSetFont.UseVisualStyleBackColor = true;
            this.btnSetFont.Click += new System.EventHandler(this.BtnSetFont_Click);
            // 
            // btnSetTheme
            // 
            this.btnSetTheme.FlatAppearance.BorderSize = 0;
            this.btnSetTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetTheme.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetTheme.Image = ((System.Drawing.Image)(resources.GetObject("btnSetTheme.Image")));
            this.btnSetTheme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetTheme.Location = new System.Drawing.Point(53, 139);
            this.btnSetTheme.Name = "btnSetTheme";
            this.btnSetTheme.Size = new System.Drawing.Size(150, 54);
            this.btnSetTheme.TabIndex = 16;
            this.btnSetTheme.Text = "&Set Theme";
            this.btnSetTheme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSetTheme.UseVisualStyleBackColor = true;
            this.btnSetTheme.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(216, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "*Changes could not be applied";
            this.label2.Visible = false;
            // 
            // groupThemes
            // 
            this.groupThemes.Controls.Add(this.radDark);
            this.groupThemes.Controls.Add(this.radLight);
            this.groupThemes.Location = new System.Drawing.Point(209, 139);
            this.groupThemes.Name = "groupThemes";
            this.groupThemes.Size = new System.Drawing.Size(228, 54);
            this.groupThemes.TabIndex = 18;
            this.groupThemes.TabStop = false;
            this.groupThemes.Text = "Select theme";
            this.groupThemes.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // radLight
            // 
            this.radLight.AutoSize = true;
            this.radLight.Location = new System.Drawing.Point(6, 19);
            this.radLight.Name = "radLight";
            this.radLight.Size = new System.Drawing.Size(84, 17);
            this.radLight.TabIndex = 0;
            this.radLight.TabStop = true;
            this.radLight.Text = "Light Theme";
            this.radLight.UseVisualStyleBackColor = true;
            this.radLight.CheckedChanged += new System.EventHandler(this.radTheme_CheckedChanged);
            // 
            // radDark
            // 
            this.radDark.AutoSize = true;
            this.radDark.Location = new System.Drawing.Point(133, 19);
            this.radDark.Name = "radDark";
            this.radDark.Size = new System.Drawing.Size(84, 17);
            this.radDark.TabIndex = 1;
            this.radDark.TabStop = true;
            this.radDark.Text = "Dark Theme";
            this.radDark.UseVisualStyleBackColor = true;
            this.radDark.CheckedChanged += new System.EventHandler(this.radTheme_CheckedChanged);
            // 
            // comboFontSizes
            // 
            this.comboFontSizes.FormattingEnabled = true;
            this.comboFontSizes.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20"});
            this.comboFontSizes.Location = new System.Drawing.Point(209, 98);
            this.comboFontSizes.Name = "comboFontSizes";
            this.comboFontSizes.Size = new System.Drawing.Size(131, 21);
            this.comboFontSizes.TabIndex = 20;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 487);
            this.Controls.Add(this.comboFontSizes);
            this.Controls.Add(this.groupThemes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSetTheme);
            this.Controls.Add(this.btnSetFont);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.groupThemes.ResumeLayout(false);
            this.groupThemes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSetFont;
        private System.Windows.Forms.Button btnSetTheme;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupThemes;
        private System.Windows.Forms.RadioButton radDark;
        private System.Windows.Forms.RadioButton radLight;
        private System.Windows.Forms.ComboBox comboFontSizes;
    }
}