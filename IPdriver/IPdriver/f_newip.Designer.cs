namespace IPdriver
{
    partial class f_newip
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
            this.t_ipaddress = new System.Windows.Forms.TextBox();
            this.t_subnetmask = new System.Windows.Forms.TextBox();
            this.t_defaultgateway = new System.Windows.Forms.TextBox();
            this.l_ipaddress = new System.Windows.Forms.Label();
            this.l_subnetmask = new System.Windows.Forms.Label();
            this.l_defaultgateway = new System.Windows.Forms.Label();
            this.b_submit = new System.Windows.Forms.Button();
            this.t_name = new System.Windows.Forms.TextBox();
            this.l_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // t_ipaddress
            // 
            this.t_ipaddress.Location = new System.Drawing.Point(31, 166);
            this.t_ipaddress.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.t_ipaddress.Name = "t_ipaddress";
            this.t_ipaddress.Size = new System.Drawing.Size(180, 31);
            this.t_ipaddress.TabIndex = 0;
            this.t_ipaddress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // t_subnetmask
            // 
            this.t_subnetmask.Location = new System.Drawing.Point(291, 166);
            this.t_subnetmask.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.t_subnetmask.Name = "t_subnetmask";
            this.t_subnetmask.Size = new System.Drawing.Size(180, 31);
            this.t_subnetmask.TabIndex = 1;
            // 
            // t_defaultgateway
            // 
            this.t_defaultgateway.Location = new System.Drawing.Point(553, 166);
            this.t_defaultgateway.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.t_defaultgateway.Name = "t_defaultgateway";
            this.t_defaultgateway.Size = new System.Drawing.Size(180, 31);
            this.t_defaultgateway.TabIndex = 2;
            // 
            // l_ipaddress
            // 
            this.l_ipaddress.AutoSize = true;
            this.l_ipaddress.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_ipaddress.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.l_ipaddress.Location = new System.Drawing.Point(74, 125);
            this.l_ipaddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.l_ipaddress.Name = "l_ipaddress";
            this.l_ipaddress.Size = new System.Drawing.Size(90, 25);
            this.l_ipaddress.TabIndex = 3;
            this.l_ipaddress.Text = "IPAddress";
            this.l_ipaddress.Click += new System.EventHandler(this.label1_Click);
            // 
            // l_subnetmask
            // 
            this.l_subnetmask.AutoSize = true;
            this.l_subnetmask.Location = new System.Drawing.Point(327, 125);
            this.l_subnetmask.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.l_subnetmask.Name = "l_subnetmask";
            this.l_subnetmask.Size = new System.Drawing.Size(118, 25);
            this.l_subnetmask.TabIndex = 4;
            this.l_subnetmask.Text = "SubNet Mask";
            // 
            // l_defaultgateway
            // 
            this.l_defaultgateway.AutoSize = true;
            this.l_defaultgateway.Location = new System.Drawing.Point(562, 125);
            this.l_defaultgateway.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.l_defaultgateway.Name = "l_defaultgateway";
            this.l_defaultgateway.Size = new System.Drawing.Size(144, 25);
            this.l_defaultgateway.TabIndex = 5;
            this.l_defaultgateway.Text = "Default Gateway";
            // 
            // b_submit
            // 
            this.b_submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_submit.Location = new System.Drawing.Point(310, 241);
            this.b_submit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.b_submit.Name = "b_submit";
            this.b_submit.Size = new System.Drawing.Size(161, 59);
            this.b_submit.TabIndex = 6;
            this.b_submit.Text = "Submit";
            this.b_submit.UseVisualStyleBackColor = true;
            this.b_submit.Click += new System.EventHandler(this.b_submit_Click);
            // 
            // t_name
            // 
            this.t_name.Location = new System.Drawing.Point(291, 67);
            this.t_name.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.t_name.Name = "t_name";
            this.t_name.Size = new System.Drawing.Size(180, 31);
            this.t_name.TabIndex = 7;
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_name.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.l_name.Location = new System.Drawing.Point(351, 23);
            this.l_name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(56, 25);
            this.l_name.TabIndex = 8;
            this.l_name.Text = "Name";
            // 
            // f_newip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::IPdriver.Properties.Resources.ip2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 454);
            this.Controls.Add(this.l_name);
            this.Controls.Add(this.t_name);
            this.Controls.Add(this.b_submit);
            this.Controls.Add(this.l_defaultgateway);
            this.Controls.Add(this.l_subnetmask);
            this.Controls.Add(this.l_ipaddress);
            this.Controls.Add(this.t_defaultgateway);
            this.Controls.Add(this.t_subnetmask);
            this.Controls.Add(this.t_ipaddress);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "f_newip";
            this.Text = "NewIP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_ipaddress;
        private System.Windows.Forms.TextBox t_subnetmask;
        private System.Windows.Forms.TextBox t_defaultgateway;
        private System.Windows.Forms.Label l_ipaddress;
        private System.Windows.Forms.Label l_subnetmask;
        private System.Windows.Forms.Label l_defaultgateway;
        private System.Windows.Forms.Button b_submit;
        private System.Windows.Forms.TextBox t_name;
        private System.Windows.Forms.Label l_name;

    }
}