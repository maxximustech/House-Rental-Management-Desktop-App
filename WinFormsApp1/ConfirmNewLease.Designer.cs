namespace WinFormsApp1
{
    partial class ConfirmNewLease
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
            this.leaseConfirmNoBtn = new System.Windows.Forms.Button();
            this.leaseConfirmYesBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leaseConfirmNoBtn
            // 
            this.leaseConfirmNoBtn.BackColor = System.Drawing.Color.Red;
            this.leaseConfirmNoBtn.FlatAppearance.BorderSize = 0;
            this.leaseConfirmNoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaseConfirmNoBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.leaseConfirmNoBtn.Location = new System.Drawing.Point(56, 154);
            this.leaseConfirmNoBtn.Name = "leaseConfirmNoBtn";
            this.leaseConfirmNoBtn.Size = new System.Drawing.Size(104, 33);
            this.leaseConfirmNoBtn.TabIndex = 10;
            this.leaseConfirmNoBtn.Text = "No";
            this.leaseConfirmNoBtn.UseVisualStyleBackColor = false;
            // 
            // leaseConfirmYesBtn
            // 
            this.leaseConfirmYesBtn.BackColor = System.Drawing.Color.Green;
            this.leaseConfirmYesBtn.FlatAppearance.BorderSize = 0;
            this.leaseConfirmYesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaseConfirmYesBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.leaseConfirmYesBtn.Location = new System.Drawing.Point(193, 154);
            this.leaseConfirmYesBtn.Name = "leaseConfirmYesBtn";
            this.leaseConfirmYesBtn.Size = new System.Drawing.Size(104, 33);
            this.leaseConfirmYesBtn.TabIndex = 10;
            this.leaseConfirmYesBtn.Text = "Yes";
            this.leaseConfirmYesBtn.UseVisualStyleBackColor = false;
            this.leaseConfirmYesBtn.Click += new System.EventHandler(this.leaseConfirmYesBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 60);
            this.label1.TabIndex = 11;
            this.label1.Text = "Are you sure you want to\r\ncreate this lease record?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ConfirmNewLease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.leaseConfirmNoBtn;
            this.ClientSize = new System.Drawing.Size(358, 255);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leaseConfirmYesBtn);
            this.Controls.Add(this.leaseConfirmNoBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmNewLease";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConfirmNewLease";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button leaseConfirmNoBtn;
        private Button leaseConfirmYesBtn;
        private Label label1;
    }
}