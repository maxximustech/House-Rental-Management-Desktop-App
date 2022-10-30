namespace WinFormsApp1
{
    partial class CreateNewApartment
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
            this.createApartmentBtn = new MaterialSkin.Controls.MaterialButton();
            this.apartmentStatusInput = new MaterialSkin.Controls.MaterialComboBox();
            this.apartmentNameInput = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.apartmentNoInput = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // createApartmentBtn
            // 
            this.createApartmentBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createApartmentBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.createApartmentBtn.Depth = 0;
            this.createApartmentBtn.HighEmphasis = true;
            this.createApartmentBtn.Icon = null;
            this.createApartmentBtn.Location = new System.Drawing.Point(363, 321);
            this.createApartmentBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createApartmentBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.createApartmentBtn.Name = "createApartmentBtn";
            this.createApartmentBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.createApartmentBtn.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.createApartmentBtn.Size = new System.Drawing.Size(76, 36);
            this.createApartmentBtn.TabIndex = 11;
            this.createApartmentBtn.Text = "Create";
            this.createApartmentBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.createApartmentBtn.UseAccentColor = false;
            this.createApartmentBtn.UseVisualStyleBackColor = true;
            this.createApartmentBtn.Click += new System.EventHandler(this.createApartmentBtn_Click);
            // 
            // apartmentStatusInput
            // 
            this.apartmentStatusInput.AutoResize = false;
            this.apartmentStatusInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.apartmentStatusInput.Depth = 0;
            this.apartmentStatusInput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.apartmentStatusInput.DropDownHeight = 174;
            this.apartmentStatusInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.apartmentStatusInput.DropDownWidth = 121;
            this.apartmentStatusInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.apartmentStatusInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.apartmentStatusInput.FormattingEnabled = true;
            this.apartmentStatusInput.IntegralHeight = false;
            this.apartmentStatusInput.ItemHeight = 43;
            this.apartmentStatusInput.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.apartmentStatusInput.Location = new System.Drawing.Point(49, 243);
            this.apartmentStatusInput.MaxDropDownItems = 4;
            this.apartmentStatusInput.MouseState = MaterialSkin.MouseState.OUT;
            this.apartmentStatusInput.Name = "apartmentStatusInput";
            this.apartmentStatusInput.Size = new System.Drawing.Size(390, 49);
            this.apartmentStatusInput.StartIndex = 2;
            this.apartmentStatusInput.TabIndex = 10;
            // 
            // apartmentNameInput
            // 
            this.apartmentNameInput.AnimateReadOnly = false;
            this.apartmentNameInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.apartmentNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.apartmentNameInput.Depth = 0;
            this.apartmentNameInput.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.apartmentNameInput.LeadingIcon = null;
            this.apartmentNameInput.Location = new System.Drawing.Point(49, 67);
            this.apartmentNameInput.MaxLength = 50;
            this.apartmentNameInput.MouseState = MaterialSkin.MouseState.OUT;
            this.apartmentNameInput.Multiline = false;
            this.apartmentNameInput.Name = "apartmentNameInput";
            this.apartmentNameInput.Size = new System.Drawing.Size(390, 50);
            this.apartmentNameInput.TabIndex = 0;
            this.apartmentNameInput.Text = "";
            this.apartmentNameInput.TrailingIcon = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(49, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Apartment name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(49, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apartment number";
            // 
            // apartmentNoInput
            // 
            this.apartmentNoInput.AnimateReadOnly = false;
            this.apartmentNoInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.apartmentNoInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.apartmentNoInput.Depth = 0;
            this.apartmentNoInput.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.apartmentNoInput.LeadingIcon = null;
            this.apartmentNoInput.Location = new System.Drawing.Point(49, 156);
            this.apartmentNoInput.MaxLength = 50;
            this.apartmentNoInput.MouseState = MaterialSkin.MouseState.OUT;
            this.apartmentNoInput.Multiline = false;
            this.apartmentNoInput.Name = "apartmentNoInput";
            this.apartmentNoInput.Size = new System.Drawing.Size(390, 50);
            this.apartmentNoInput.TabIndex = 1;
            this.apartmentNoInput.Text = "";
            this.apartmentNoInput.TrailingIcon = null;
            // 
            // CreateNewApartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 391);
            this.Controls.Add(this.createApartmentBtn);
            this.Controls.Add(this.apartmentStatusInput);
            this.Controls.Add(this.apartmentNoInput);
            this.Controls.Add(this.apartmentNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "CreateNewApartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateNewApartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton createApartmentBtn;
        private MaterialSkin.Controls.MaterialComboBox apartmentStatusInput;
        private MaterialSkin.Controls.MaterialTextBox apartmentNameInput;
        private Label label2;
        private Label label1;
        private Label label3;
        private MaterialSkin.Controls.MaterialTextBox apartmentNoInput;
    }
}