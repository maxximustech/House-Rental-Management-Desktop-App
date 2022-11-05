namespace WinFormsApp1
{
    partial class CreateNewLease
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.leaseApartmentIdInput = new System.Windows.Forms.TextBox();
            this.leaseTenantIdInput = new System.Windows.Forms.TextBox();
            this.leasePriceInput = new System.Windows.Forms.TextBox();
            this.leaseTransactionRefInput = new System.Windows.Forms.TextBox();
            this.leaseValidTillInput = new System.Windows.Forms.DateTimePicker();
            this.createTenantBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(69, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Apartment ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(411, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tenant ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(69, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price ($)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(411, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Transaction Reference";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(69, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Expires";
            // 
            // leaseApartmentIdInput
            // 
            this.leaseApartmentIdInput.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leaseApartmentIdInput.Location = new System.Drawing.Point(69, 95);
            this.leaseApartmentIdInput.Name = "leaseApartmentIdInput";
            this.leaseApartmentIdInput.Size = new System.Drawing.Size(302, 36);
            this.leaseApartmentIdInput.TabIndex = 0;
            // 
            // leaseTenantIdInput
            // 
            this.leaseTenantIdInput.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leaseTenantIdInput.Location = new System.Drawing.Point(411, 95);
            this.leaseTenantIdInput.Name = "leaseTenantIdInput";
            this.leaseTenantIdInput.Size = new System.Drawing.Size(318, 36);
            this.leaseTenantIdInput.TabIndex = 1;
            // 
            // leasePriceInput
            // 
            this.leasePriceInput.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leasePriceInput.Location = new System.Drawing.Point(69, 208);
            this.leasePriceInput.Name = "leasePriceInput";
            this.leasePriceInput.Size = new System.Drawing.Size(302, 36);
            this.leasePriceInput.TabIndex = 2;
            // 
            // leaseTransactionRefInput
            // 
            this.leaseTransactionRefInput.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leaseTransactionRefInput.Location = new System.Drawing.Point(411, 208);
            this.leaseTransactionRefInput.Name = "leaseTransactionRefInput";
            this.leaseTransactionRefInput.Size = new System.Drawing.Size(318, 36);
            this.leaseTransactionRefInput.TabIndex = 3;
            // 
            // leaseValidTillInput
            // 
            this.leaseValidTillInput.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leaseValidTillInput.Location = new System.Drawing.Point(69, 326);
            this.leaseValidTillInput.Name = "leaseValidTillInput";
            this.leaseValidTillInput.Size = new System.Drawing.Size(302, 36);
            this.leaseValidTillInput.TabIndex = 4;
            // 
            // createTenantBtn
            // 
            this.createTenantBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.createTenantBtn.FlatAppearance.BorderSize = 0;
            this.createTenantBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTenantBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createTenantBtn.Location = new System.Drawing.Point(411, 326);
            this.createTenantBtn.Name = "createTenantBtn";
            this.createTenantBtn.Size = new System.Drawing.Size(104, 33);
            this.createTenantBtn.TabIndex = 5;
            this.createTenantBtn.Text = "Create";
            this.createTenantBtn.UseVisualStyleBackColor = false;
            this.createTenantBtn.Click += new System.EventHandler(this.createTenantBtn_Click_1);
            // 
            // CreateNewLease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createTenantBtn);
            this.Controls.Add(this.leaseValidTillInput);
            this.Controls.Add(this.leaseTenantIdInput);
            this.Controls.Add(this.leaseTransactionRefInput);
            this.Controls.Add(this.leasePriceInput);
            this.Controls.Add(this.leaseApartmentIdInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "CreateNewLease";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Lease";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox leaseApartmentIdInput;
        private TextBox leaseTenantIdInput;
        private TextBox leasePriceInput;
        private TextBox leaseTransactionRefInput;
        private DateTimePicker leaseValidTillInput;
        private Button createTenantBtn;
    }
}