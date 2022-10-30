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
            this.leaseApartmentIdInput = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.leaseTenantIdInput = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.leasePriceInput = new MaterialSkin.Controls.MaterialTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.leaseTransactionRefInput = new MaterialSkin.Controls.MaterialTextBox();
            this.leaseValidTillInput = new MetroFramework.Controls.MetroDateTime();
            this.label5 = new System.Windows.Forms.Label();
            this.createTenantBtn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // leaseApartmentIdInput
            // 
            this.leaseApartmentIdInput.AnimateReadOnly = false;
            this.leaseApartmentIdInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.leaseApartmentIdInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.leaseApartmentIdInput.Depth = 0;
            this.leaseApartmentIdInput.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.leaseApartmentIdInput.LeadingIcon = null;
            this.leaseApartmentIdInput.Location = new System.Drawing.Point(69, 95);
            this.leaseApartmentIdInput.MaxLength = 50;
            this.leaseApartmentIdInput.MouseState = MaterialSkin.MouseState.OUT;
            this.leaseApartmentIdInput.Multiline = false;
            this.leaseApartmentIdInput.Name = "leaseApartmentIdInput";
            this.leaseApartmentIdInput.Size = new System.Drawing.Size(302, 50);
            this.leaseApartmentIdInput.TabIndex = 0;
            this.leaseApartmentIdInput.Text = "";
            this.leaseApartmentIdInput.TrailingIcon = null;
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
            // leaseTenantIdInput
            // 
            this.leaseTenantIdInput.AnimateReadOnly = false;
            this.leaseTenantIdInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.leaseTenantIdInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.leaseTenantIdInput.Depth = 0;
            this.leaseTenantIdInput.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.leaseTenantIdInput.LeadingIcon = null;
            this.leaseTenantIdInput.Location = new System.Drawing.Point(411, 95);
            this.leaseTenantIdInput.MaxLength = 50;
            this.leaseTenantIdInput.MouseState = MaterialSkin.MouseState.OUT;
            this.leaseTenantIdInput.Multiline = false;
            this.leaseTenantIdInput.Name = "leaseTenantIdInput";
            this.leaseTenantIdInput.Size = new System.Drawing.Size(318, 50);
            this.leaseTenantIdInput.TabIndex = 1;
            this.leaseTenantIdInput.Text = "";
            this.leaseTenantIdInput.TrailingIcon = null;
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
            // leasePriceInput
            // 
            this.leasePriceInput.AnimateReadOnly = false;
            this.leasePriceInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.leasePriceInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.leasePriceInput.Depth = 0;
            this.leasePriceInput.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.leasePriceInput.LeadingIcon = null;
            this.leasePriceInput.Location = new System.Drawing.Point(69, 208);
            this.leasePriceInput.MaxLength = 50;
            this.leasePriceInput.MouseState = MaterialSkin.MouseState.OUT;
            this.leasePriceInput.Multiline = false;
            this.leasePriceInput.Name = "leasePriceInput";
            this.leasePriceInput.Size = new System.Drawing.Size(302, 50);
            this.leasePriceInput.TabIndex = 2;
            this.leasePriceInput.Text = "";
            this.leasePriceInput.TrailingIcon = null;
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
            // leaseTransactionRefInput
            // 
            this.leaseTransactionRefInput.AnimateReadOnly = false;
            this.leaseTransactionRefInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.leaseTransactionRefInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.leaseTransactionRefInput.Depth = 0;
            this.leaseTransactionRefInput.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.leaseTransactionRefInput.LeadingIcon = null;
            this.leaseTransactionRefInput.Location = new System.Drawing.Point(411, 208);
            this.leaseTransactionRefInput.MaxLength = 50;
            this.leaseTransactionRefInput.MouseState = MaterialSkin.MouseState.OUT;
            this.leaseTransactionRefInput.Multiline = false;
            this.leaseTransactionRefInput.Name = "leaseTransactionRefInput";
            this.leaseTransactionRefInput.Size = new System.Drawing.Size(318, 50);
            this.leaseTransactionRefInput.TabIndex = 3;
            this.leaseTransactionRefInput.Text = "";
            this.leaseTransactionRefInput.TrailingIcon = null;
            // 
            // leaseValidTillInput
            // 
            this.leaseValidTillInput.Location = new System.Drawing.Point(69, 326);
            this.leaseValidTillInput.MinimumSize = new System.Drawing.Size(0, 29);
            this.leaseValidTillInput.Name = "leaseValidTillInput";
            this.leaseValidTillInput.Size = new System.Drawing.Size(302, 29);
            this.leaseValidTillInput.TabIndex = 4;
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
            // createTenantBtn
            // 
            this.createTenantBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createTenantBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.createTenantBtn.Depth = 0;
            this.createTenantBtn.HighEmphasis = true;
            this.createTenantBtn.Icon = null;
            this.createTenantBtn.Location = new System.Drawing.Point(411, 326);
            this.createTenantBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createTenantBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.createTenantBtn.Name = "createTenantBtn";
            this.createTenantBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.createTenantBtn.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.createTenantBtn.Size = new System.Drawing.Size(76, 36);
            this.createTenantBtn.TabIndex = 5;
            this.createTenantBtn.Text = "Create";
            this.createTenantBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.createTenantBtn.UseAccentColor = false;
            this.createTenantBtn.UseVisualStyleBackColor = true;
            this.createTenantBtn.Click += new System.EventHandler(this.createTenantBtn_Click);
            // 
            // CreateNewLease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createTenantBtn);
            this.Controls.Add(this.leaseValidTillInput);
            this.Controls.Add(this.leaseTransactionRefInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.leaseTenantIdInput);
            this.Controls.Add(this.leasePriceInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.leaseApartmentIdInput);
            this.Controls.Add(this.label1);
            this.Name = "CreateNewLease";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Lease";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox leaseApartmentIdInput;
        private Label label1;
        private Label label2;
        private MaterialSkin.Controls.MaterialTextBox leaseTenantIdInput;
        private Label label3;
        private MaterialSkin.Controls.MaterialTextBox leasePriceInput;
        private Label label4;
        private MaterialSkin.Controls.MaterialTextBox leaseTransactionRefInput;
        private MetroFramework.Controls.MetroDateTime leaseValidTillInput;
        private Label label5;
        private MaterialSkin.Controls.MaterialButton createTenantBtn;
    }
}