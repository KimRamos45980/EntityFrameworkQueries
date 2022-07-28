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
            this.BtnSelectSpecificColumns = new System.Windows.Forms.Button();
            this.BtnMiscQueries = new System.Windows.Forms.Button();
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
            // BtnSelectSpecificColumns
            // 
            this.BtnSelectSpecificColumns.Location = new System.Drawing.Point(62, 293);
            this.BtnSelectSpecificColumns.Name = "BtnSelectSpecificColumns";
            this.BtnSelectSpecificColumns.Size = new System.Drawing.Size(895, 58);
            this.BtnSelectSpecificColumns.TabIndex = 2;
            this.BtnSelectSpecificColumns.Text = "SELECT VendorName, VenderCity, VendorState FROM Vendors";
            this.BtnSelectSpecificColumns.UseVisualStyleBackColor = true;
            this.BtnSelectSpecificColumns.Click += new System.EventHandler(this.BtnSelectSpecificColumns_Click);
            // 
            // BtnMiscQueries
            // 
            this.BtnMiscQueries.Location = new System.Drawing.Point(62, 407);
            this.BtnMiscQueries.Name = "BtnMiscQueries";
            this.BtnMiscQueries.Size = new System.Drawing.Size(383, 58);
            this.BtnMiscQueries.TabIndex = 3;
            this.BtnMiscQueries.Text = "Misc Queries";
            this.BtnMiscQueries.UseVisualStyleBackColor = true;
            this.BtnMiscQueries.Click += new System.EventHandler(this.BtnMiscQueries_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 842);
            this.Controls.Add(this.BtnMiscQueries);
            this.Controls.Add(this.BtnSelectSpecificColumns);
            this.Controls.Add(this.BtnAllCaliVendors);
            this.Controls.Add(this.BtnSelectAllVendors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnSelectAllVendors;
        private Button BtnAllCaliVendors;
        private Button BtnSelectSpecificColumns;
        private Button BtnMiscQueries;
    }
}