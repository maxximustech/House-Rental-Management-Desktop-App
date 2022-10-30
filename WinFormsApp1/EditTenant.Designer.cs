namespace WinFormsApp1
{
    partial class EditTenant
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
            this.editTenantBtn = new MaterialSkin.Controls.MaterialButton();
            this.tenantGenderInput = new MaterialSkin.Controls.MaterialComboBox();
            this.tenantNameInput = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editTenantBtn
            // 
            this.editTenantBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editTenantBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.editTenantBtn.Depth = 0;
            this.editTenantBtn.HighEmphasis = true;
            this.editTenantBtn.Icon = null;
            this.editTenantBtn.Location = new System.Drawing.Point(354, 263);
            this.editTenantBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editTenantBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.editTenantBtn.Name = "editTenantBtn";
            this.editTenantBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.editTenantBtn.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.editTenantBtn.Size = new System.Drawing.Size(77, 36);
            this.editTenantBtn.TabIndex = 11;
            this.editTenantBtn.Text = "Update";
            this.editTenantBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.editTenantBtn.UseAccentColor = false;
            this.editTenantBtn.UseVisualStyleBackColor = true;
            this.editTenantBtn.Click += new System.EventHandler(this.editTenantBtn_Click);
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
            this.tenantGenderInput.Location = new System.Drawing.Point(40, 185);
            this.tenantGenderInput.MaxDropDownItems = 4;
            this.tenantGenderInput.MouseState = MaterialSkin.MouseState.OUT;
            this.tenantGenderInput.Name = "tenantGenderInput";
            this.tenantGenderInput.Size = new System.Drawing.Size(390, 49);
            this.tenantGenderInput.StartIndex = 0;
            this.tenantGenderInput.TabIndex = 10;
            // 
            // tenantNameInput
            // 
            this.tenantNameInput.AnimateReadOnly = false;
            this.tenantNameInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tenantNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tenantNameInput.Depth = 0;
            this.tenantNameInput.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tenantNameInput.LeadingIcon = null;
            this.tenantNameInput.Location = new System.Drawing.Point(40, 90);
            this.tenantNameInput.MaxLength = 50;
            this.tenantNameInput.MouseState = MaterialSkin.MouseState.OUT;
            this.tenantNameInput.Multiline = false;
            this.tenantNameInput.Name = "tenantNameInput";
            this.tenantNameInput.Size = new System.Drawing.Size(390, 50);
            this.tenantNameInput.TabIndex = 9;
            this.tenantNameInput.Text = "";
            this.tenantNameInput.TrailingIcon = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Full name";
            // 
            // EditTenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.editTenantBtn);
            this.Controls.Add(this.tenantGenderInput);
            this.Controls.Add(this.tenantNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditTenant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Tenant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton editTenantBtn;
        private MaterialSkin.Controls.MaterialComboBox tenantGenderInput;
        private MaterialSkin.Controls.MaterialTextBox tenantNameInput;
        private Label label2;
        private Label label1;
    }
}