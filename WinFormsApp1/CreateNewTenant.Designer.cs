namespace WinFormsApp1
{
    partial class CreateNewTenant
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
            this.tenantNameInput = new MaterialSkin.Controls.MaterialTextBox();
            this.tenantGenderInput = new MaterialSkin.Controls.MaterialComboBox();
            this.createTenantBtn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gender";
            // 
            // tenantNameInput
            // 
            this.tenantNameInput.AnimateReadOnly = false;
            this.tenantNameInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tenantNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tenantNameInput.Depth = 0;
            this.tenantNameInput.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tenantNameInput.LeadingIcon = null;
            this.tenantNameInput.Location = new System.Drawing.Point(45, 79);
            this.tenantNameInput.MaxLength = 50;
            this.tenantNameInput.MouseState = MaterialSkin.MouseState.OUT;
            this.tenantNameInput.Multiline = false;
            this.tenantNameInput.Name = "tenantNameInput";
            this.tenantNameInput.Size = new System.Drawing.Size(390, 50);
            this.tenantNameInput.TabIndex = 4;
            this.tenantNameInput.Text = "";
            this.tenantNameInput.TrailingIcon = null;
            // 
            // tenantGenderInput
            // 
            this.tenantGenderInput.AutoResize = false;
            this.tenantGenderInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tenantGenderInput.Depth = 0;
            this.tenantGenderInput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.tenantGenderInput.DropDownHeight = 174;
            this.tenantGenderInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tenantGenderInput.DropDownWidth = 121;
            this.tenantGenderInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.tenantGenderInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tenantGenderInput.FormattingEnabled = true;
            this.tenantGenderInput.IntegralHeight = false;
            this.tenantGenderInput.ItemHeight = 43;
            this.tenantGenderInput.Items.AddRange(new object[] {
            "",
            "Male",
            "Female"});
            this.tenantGenderInput.Location = new System.Drawing.Point(45, 174);
            this.tenantGenderInput.MaxDropDownItems = 4;
            this.tenantGenderInput.MouseState = MaterialSkin.MouseState.OUT;
            this.tenantGenderInput.Name = "tenantGenderInput";
            this.tenantGenderInput.Size = new System.Drawing.Size(390, 49);
            this.tenantGenderInput.StartIndex = 0;
            this.tenantGenderInput.TabIndex = 5;
            // 
            // createTenantBtn
            // 
            this.createTenantBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createTenantBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.createTenantBtn.Depth = 0;
            this.createTenantBtn.HighEmphasis = true;
            this.createTenantBtn.Icon = null;
            this.createTenantBtn.Location = new System.Drawing.Point(359, 252);
            this.createTenantBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createTenantBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.createTenantBtn.Name = "createTenantBtn";
            this.createTenantBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.createTenantBtn.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.createTenantBtn.Size = new System.Drawing.Size(76, 36);
            this.createTenantBtn.TabIndex = 6;
            this.createTenantBtn.Text = "Create";
            this.createTenantBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.createTenantBtn.UseAccentColor = false;
            this.createTenantBtn.UseVisualStyleBackColor = true;
            this.createTenantBtn.Click += new System.EventHandler(this.createTenantBtn_Click);
            // 
            // CreateNewTenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.createTenantBtn);
            this.Controls.Add(this.tenantGenderInput);
            this.Controls.Add(this.tenantNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateNewTenant";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Tenant";
            this.Load += new System.EventHandler(this.CreateNewTenant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private MaterialSkin.Controls.MaterialTextBox tenantNameInput;
        private MaterialSkin.Controls.MaterialComboBox tenantGenderInput;
        private MaterialSkin.Controls.MaterialButton createTenantBtn;
    }
}