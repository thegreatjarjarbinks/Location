namespace Location
{
    partial class frmInformation
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
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblApt = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblPostal = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtApt = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtPostal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Location = new System.Drawing.Point(13, 13);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(177, 13);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Text = "Please enter your information below:";
            // 
            // lblApt
            // 
            this.lblApt.AutoSize = true;
            this.lblApt.Location = new System.Drawing.Point(13, 64);
            this.lblApt.Name = "lblApt";
            this.lblApt.Size = new System.Drawing.Size(66, 13);
            this.lblApt.TabIndex = 1;
            this.lblApt.Text = "Apt. Number";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(13, 94);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(70, 13);
            this.lblStreet.TabIndex = 2;
            this.lblStreet.Text = "Street Adress";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(13, 126);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(13, 157);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(49, 13);
            this.lblProvince.TabIndex = 4;
            this.lblProvince.Text = "Province";
            // 
            // lblPostal
            // 
            this.lblPostal.AutoSize = true;
            this.lblPostal.Location = new System.Drawing.Point(13, 184);
            this.lblPostal.Name = "lblPostal";
            this.lblPostal.Size = new System.Drawing.Size(64, 13);
            this.lblPostal.TabIndex = 5;
            this.lblPostal.Text = "Postal Code";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(137, 226);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show me!";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtApt
            // 
            this.txtApt.Location = new System.Drawing.Point(123, 56);
            this.txtApt.Name = "txtApt";
            this.txtApt.Size = new System.Drawing.Size(100, 20);
            this.txtApt.TabIndex = 7;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(123, 87);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 20);
            this.txtStreet.TabIndex = 8;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(123, 118);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 9;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(123, 149);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(100, 20);
            this.txtProvince.TabIndex = 10;
            // 
            // txtPostal
            // 
            this.txtPostal.Location = new System.Drawing.Point(123, 176);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(100, 20);
            this.txtPostal.TabIndex = 11;
            // 
            // frmInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtPostal);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtApt);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblPostal);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblApt);
            this.Controls.Add(this.lblEnter);
            this.Name = "frmInformation";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblApt;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblPostal;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtApt;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtPostal;
    }
}

