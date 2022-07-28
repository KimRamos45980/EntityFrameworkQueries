namespace EntityFrameworkQueries
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSelectAllVendors = new System.Windows.Forms.Button();
            this.BtnAllCaliVendors = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSelectAllVendors
            // 
            this.BtnSelectAllVendors.Location = new System.Drawing.Point(62, 59);
            this.BtnSelectAllVendors.Name = "BtnSelectAllVendors";
            this.BtnSelectAllVendors.Size = new System.Drawing.Size(383, 58);
            this.BtnSelectAllVendors.TabIndex = 0;
            this.BtnSelectAllVendors.Text = "SELECT*FROM Vendors";
            this.BtnSelectAllVendors.UseVisualStyleBackColor = true;
            this.BtnSelectAllVendors.Click += new System.EventHandler(this.BtnSelectAllVendors_Click);
            // 
            // BtnAllCaliVendors
            // 
            this.BtnAllCaliVendors.Location = new System.Drawing.Point(62, 176);
            this.BtnAllCaliVendors.Name = "BtnAllCaliVendors";
            this.BtnAllCaliVendors.Size = new System.Drawing.Size(1113, 58);
            this.BtnAllCaliVendors.TabIndex = 1;
            this.BtnAllCaliVendors.Text = "SELECT*FROM Vendors WHERE VendorState=\'CA\' ORDER BY VendorName ASC";
            this.BtnAllCaliVendors.UseVisualStyleBackColor = true;
            this.BtnAllCaliVendors.Click += new System.EventHandler(this.BtnAllCaliVendors_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(62, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 842);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnAllCaliVendors);
            this.Controls.Add(this.BtnSelectAllVendors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnSelectAllVendors;
        private Button BtnAllCaliVendors;
        private Button button3;
    }
}