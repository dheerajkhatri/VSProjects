namespace IPdriver
{
    partial class f_ipdriver
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
            this.b_setip = new System.Windows.Forms.Button();
            this.b_addip = new System.Windows.Forms.Button();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.l_name = new System.Windows.Forms.Label();
            this.l_ipdetail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_setip
            // 
            this.b_setip.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_setip.Location = new System.Drawing.Point(252, 235);
            this.b_setip.Name = "b_setip";
            this.b_setip.Size = new System.Drawing.Size(105, 37);
            this.b_setip.TabIndex = 0;
            this.b_setip.Text = "Set IP";
            this.b_setip.UseVisualStyleBackColor = true;
            this.b_setip.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_addip
            // 
            this.b_addip.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_addip.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.b_addip.Location = new System.Drawing.Point(81, 235);
            this.b_addip.Name = "b_addip";
            this.b_addip.Size = new System.Drawing.Size(113, 37);
            this.b_addip.TabIndex = 1;
            this.b_addip.Text = "Add IP";
            this.b_addip.UseVisualStyleBackColor = true;
            this.b_addip.Click += new System.EventHandler(this.button2_Click);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(140, 73);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(156, 20);
            this.domainUpDown1.TabIndex = 4;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Location = new System.Drawing.Point(115, 167);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(242, 20);
            this.domainUpDown2.TabIndex = 5;
            this.domainUpDown2.Text = "domainUpDown2";
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_name.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_name.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.l_name.Location = new System.Drawing.Point(193, 36);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(56, 25);
            this.l_name.TabIndex = 6;
            this.l_name.Text = "Name";
            // 
            // l_ipdetail
            // 
            this.l_ipdetail.AutoSize = true;
            this.l_ipdetail.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_ipdetail.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ipdetail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.l_ipdetail.Location = new System.Drawing.Point(179, 128);
            this.l_ipdetail.Name = "l_ipdetail";
            this.l_ipdetail.Size = new System.Drawing.Size(92, 25);
            this.l_ipdetail.TabIndex = 7;
            this.l_ipdetail.Text = "IP Details";
            // 
            // f_ipdriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IPdriver.Properties.Resources.IPimages2;
            this.ClientSize = new System.Drawing.Size(472, 320);
            this.Controls.Add(this.l_ipdetail);
            this.Controls.Add(this.l_name);
            this.Controls.Add(this.domainUpDown2);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.b_addip);
            this.Controls.Add(this.b_setip);
            this.Name = "f_ipdriver";
            this.Text = "IPdriver";
            this.Load += new System.EventHandler(this.f_ipdriver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_setip;
        private System.Windows.Forms.Button b_addip;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.Label l_ipdetail;
    }
}

