namespace WinFormsApp1
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dashboard = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.label14 = new System.Windows.Forms.Label();
            this.viewLeaseFromDashboard = new MaterialSkin.Controls.MaterialButton();
            this.createLeaseFromDashboard = new MaterialSkin.Controls.MaterialButton();
            this.label10 = new System.Windows.Forms.Label();
            this.totalLease = new System.Windows.Forms.Label();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.label13 = new System.Windows.Forms.Label();
            this.viewApartmentFromDashboard = new MaterialSkin.Controls.MaterialButton();
            this.createApartmentFromDashboard = new MaterialSkin.Controls.MaterialButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.leasedApartments = new System.Windows.Forms.Label();
            this.totalApartments = new System.Windows.Forms.Label();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.label11 = new System.Windows.Forms.Label();
            this.viewTenantFromDashboard = new MaterialSkin.Controls.MaterialButton();
            this.createTenantFromDashboard = new MaterialSkin.Controls.MaterialButton();
            this.label4 = new System.Windows.Forms.Label();
            this.totalTenants = new System.Windows.Forms.Label();
            this.tenants = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.apartments = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.refreshApartmentBtn = new System.Windows.Forms.Button();
            this.createApartmentBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lease = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.leaseRefreshBtn = new System.Windows.Forms.Button();
            this.leaseCreateBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.dashboard.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tenants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.apartments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.lease.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dashboard);
            this.tabControl1.Controls.Add(this.tenants);
            this.tabControl1.Controls.Add(this.apartments);
            this.tabControl1.Controls.Add(this.lease);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(15, 15);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1144, 625);
            this.tabControl1.TabIndex = 0;
            // 
            // dashboard
            // 
            this.dashboard.Controls.Add(this.label12);
            this.dashboard.Controls.Add(this.materialCard3);
            this.dashboard.Controls.Add(this.materialCard2);
            this.dashboard.Controls.Add(this.materialCard1);
            this.dashboard.Location = new System.Drawing.Point(4, 48);
            this.dashboard.Name = "dashboard";
            this.dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.dashboard.Size = new System.Drawing.Size(1136, 573);
            this.dashboard.TabIndex = 0;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(222, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(665, 37);
            this.label12.TabIndex = 2;
            this.label12.Text = "House Rental Management App by Patience Nkom";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.label14);
            this.materialCard3.Controls.Add(this.viewLeaseFromDashboard);
            this.materialCard3.Controls.Add(this.createLeaseFromDashboard);
            this.materialCard3.Controls.Add(this.label10);
            this.materialCard3.Controls.Add(this.totalLease);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(758, 201);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(342, 298);
            this.materialCard3.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(29, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(197, 37);
            this.label14.TabIndex = 4;
            this.label14.Text = "Lease Records";
            // 
            // viewLeaseFromDashboard
            // 
            this.viewLeaseFromDashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewLeaseFromDashboard.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.viewLeaseFromDashboard.Depth = 0;
            this.viewLeaseFromDashboard.HighEmphasis = true;
            this.viewLeaseFromDashboard.Icon = null;
            this.viewLeaseFromDashboard.Location = new System.Drawing.Point(209, 222);
            this.viewLeaseFromDashboard.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.viewLeaseFromDashboard.MouseState = MaterialSkin.MouseState.HOVER;
            this.viewLeaseFromDashboard.Name = "viewLeaseFromDashboard";
            this.viewLeaseFromDashboard.NoAccentTextColor = System.Drawing.Color.Empty;
            this.viewLeaseFromDashboard.Size = new System.Drawing.Size(86, 36);
            this.viewLeaseFromDashboard.TabIndex = 3;
            this.viewLeaseFromDashboard.Text = "View all";
            this.viewLeaseFromDashboard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.viewLeaseFromDashboard.UseAccentColor = false;
            this.viewLeaseFromDashboard.UseVisualStyleBackColor = true;
            this.viewLeaseFromDashboard.Click += new System.EventHandler(this.viewLeaseFromDashboard_Click);
            // 
            // createLeaseFromDashboard
            // 
            this.createLeaseFromDashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createLeaseFromDashboard.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.createLeaseFromDashboard.Depth = 0;
            this.createLeaseFromDashboard.HighEmphasis = true;
            this.createLeaseFromDashboard.Icon = null;
            this.createLeaseFromDashboard.Location = new System.Drawing.Point(58, 222);
            this.createLeaseFromDashboard.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createLeaseFromDashboard.MouseState = MaterialSkin.MouseState.HOVER;
            this.createLeaseFromDashboard.Name = "createLeaseFromDashboard";
            this.createLeaseFromDashboard.NoAccentTextColor = System.Drawing.Color.Empty;
            this.createLeaseFromDashboard.Size = new System.Drawing.Size(111, 36);
            this.createLeaseFromDashboard.TabIndex = 3;
            this.createLeaseFromDashboard.Text = "Create New";
            this.createLeaseFromDashboard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.createLeaseFromDashboard.UseAccentColor = false;
            this.createLeaseFromDashboard.UseVisualStyleBackColor = true;
            this.createLeaseFromDashboard.Click += new System.EventHandler(this.createLeaseFromDashboard_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(160, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Total";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLease
            // 
            this.totalLease.AutoSize = true;
            this.totalLease.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalLease.Location = new System.Drawing.Point(148, 88);
            this.totalLease.Name = "totalLease";
            this.totalLease.Size = new System.Drawing.Size(77, 89);
            this.totalLease.TabIndex = 1;
            this.totalLease.Text = "0";
            this.totalLease.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.label13);
            this.materialCard2.Controls.Add(this.viewApartmentFromDashboard);
            this.materialCard2.Controls.Add(this.createApartmentFromDashboard);
            this.materialCard2.Controls.Add(this.label9);
            this.materialCard2.Controls.Add(this.label6);
            this.materialCard2.Controls.Add(this.leasedApartments);
            this.materialCard2.Controls.Add(this.totalApartments);
            this.materialCard2.Controls.Add(this.materialDivider2);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(385, 198);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(345, 298);
            this.materialCard2.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(27, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(170, 37);
            this.label13.TabIndex = 4;
            this.label13.Text = "Apartments";
            // 
            // viewApartmentFromDashboard
            // 
            this.viewApartmentFromDashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewApartmentFromDashboard.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.viewApartmentFromDashboard.Depth = 0;
            this.viewApartmentFromDashboard.HighEmphasis = true;
            this.viewApartmentFromDashboard.Icon = null;
            this.viewApartmentFromDashboard.Location = new System.Drawing.Point(207, 225);
            this.viewApartmentFromDashboard.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.viewApartmentFromDashboard.MouseState = MaterialSkin.MouseState.HOVER;
            this.viewApartmentFromDashboard.Name = "viewApartmentFromDashboard";
            this.viewApartmentFromDashboard.NoAccentTextColor = System.Drawing.Color.Empty;
            this.viewApartmentFromDashboard.Size = new System.Drawing.Size(86, 36);
            this.viewApartmentFromDashboard.TabIndex = 3;
            this.viewApartmentFromDashboard.Text = "View all";
            this.viewApartmentFromDashboard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.viewApartmentFromDashboard.UseAccentColor = false;
            this.viewApartmentFromDashboard.UseVisualStyleBackColor = true;
            this.viewApartmentFromDashboard.Click += new System.EventHandler(this.viewApartmentFromDashboard_Click);
            // 
            // createApartmentFromDashboard
            // 
            this.createApartmentFromDashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createApartmentFromDashboard.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.createApartmentFromDashboard.Depth = 0;
            this.createApartmentFromDashboard.HighEmphasis = true;
            this.createApartmentFromDashboard.Icon = null;
            this.createApartmentFromDashboard.Location = new System.Drawing.Point(56, 225);
            this.createApartmentFromDashboard.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createApartmentFromDashboard.MouseState = MaterialSkin.MouseState.HOVER;
            this.createApartmentFromDashboard.Name = "createApartmentFromDashboard";
            this.createApartmentFromDashboard.NoAccentTextColor = System.Drawing.Color.Empty;
            this.createApartmentFromDashboard.Size = new System.Drawing.Size(111, 36);
            this.createApartmentFromDashboard.TabIndex = 3;
            this.createApartmentFromDashboard.Text = "Create New";
            this.createApartmentFromDashboard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.createApartmentFromDashboard.UseAccentColor = false;
            this.createApartmentFromDashboard.UseVisualStyleBackColor = true;
            this.createApartmentFromDashboard.Click += new System.EventHandler(this.createApartmentFromDashboard_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(222, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "Leased";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(68, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leasedApartments
            // 
            this.leasedApartments.AutoSize = true;
            this.leasedApartments.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.leasedApartments.Location = new System.Drawing.Point(216, 78);
            this.leasedApartments.Name = "leasedApartments";
            this.leasedApartments.Size = new System.Drawing.Size(77, 89);
            this.leasedApartments.TabIndex = 1;
            this.leasedApartments.Text = "0";
            this.leasedApartments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalApartments
            // 
            this.totalApartments.AutoSize = true;
            this.totalApartments.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalApartments.Location = new System.Drawing.Point(56, 78);
            this.totalApartments.Name = "totalApartments";
            this.totalApartments.Size = new System.Drawing.Size(77, 89);
            this.totalApartments.TabIndex = 1;
            this.totalApartments.Text = "0";
            this.totalApartments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.Black;
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(175, 94);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(1, 90);
            this.materialDivider2.TabIndex = 3;
            this.materialDivider2.Text = "materialDivider1";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.label11);
            this.materialCard1.Controls.Add(this.viewTenantFromDashboard);
            this.materialCard1.Controls.Add(this.createTenantFromDashboard);
            this.materialCard1.Controls.Add(this.label4);
            this.materialCard1.Controls.Add(this.totalTenants);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(26, 196);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(331, 298);
            this.materialCard1.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(32, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 37);
            this.label11.TabIndex = 4;
            this.label11.Text = "Tenants";
            // 
            // viewTenantFromDashboard
            // 
            this.viewTenantFromDashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewTenantFromDashboard.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.viewTenantFromDashboard.Depth = 0;
            this.viewTenantFromDashboard.HighEmphasis = true;
            this.viewTenantFromDashboard.Icon = null;
            this.viewTenantFromDashboard.Location = new System.Drawing.Point(183, 227);
            this.viewTenantFromDashboard.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.viewTenantFromDashboard.MouseState = MaterialSkin.MouseState.HOVER;
            this.viewTenantFromDashboard.Name = "viewTenantFromDashboard";
            this.viewTenantFromDashboard.NoAccentTextColor = System.Drawing.Color.Empty;
            this.viewTenantFromDashboard.Size = new System.Drawing.Size(86, 36);
            this.viewTenantFromDashboard.TabIndex = 3;
            this.viewTenantFromDashboard.Text = "View all";
            this.viewTenantFromDashboard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.viewTenantFromDashboard.UseAccentColor = false;
            this.viewTenantFromDashboard.UseVisualStyleBackColor = true;
            this.viewTenantFromDashboard.Click += new System.EventHandler(this.viewTenantFromDashboard_Click);
            // 
            // createTenantFromDashboard
            // 
            this.createTenantFromDashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createTenantFromDashboard.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.createTenantFromDashboard.Depth = 0;
            this.createTenantFromDashboard.HighEmphasis = true;
            this.createTenantFromDashboard.Icon = null;
            this.createTenantFromDashboard.Location = new System.Drawing.Point(32, 227);
            this.createTenantFromDashboard.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createTenantFromDashboard.MouseState = MaterialSkin.MouseState.HOVER;
            this.createTenantFromDashboard.Name = "createTenantFromDashboard";
            this.createTenantFromDashboard.NoAccentTextColor = System.Drawing.Color.Empty;
            this.createTenantFromDashboard.Size = new System.Drawing.Size(111, 36);
            this.createTenantFromDashboard.TabIndex = 3;
            this.createTenantFromDashboard.Text = "Create New";
            this.createTenantFromDashboard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.createTenantFromDashboard.UseAccentColor = false;
            this.createTenantFromDashboard.UseVisualStyleBackColor = true;
            this.createTenantFromDashboard.Click += new System.EventHandler(this.createTenantFromDashboard_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(141, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalTenants
            // 
            this.totalTenants.AutoSize = true;
            this.totalTenants.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalTenants.Location = new System.Drawing.Point(131, 80);
            this.totalTenants.Name = "totalTenants";
            this.totalTenants.Size = new System.Drawing.Size(77, 89);
            this.totalTenants.TabIndex = 1;
            this.totalTenants.Text = "0";
            this.totalTenants.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tenants
            // 
            this.tenants.Controls.Add(this.dataGridView1);
            this.tenants.Controls.Add(this.button3);
            this.tenants.Controls.Add(this.label1);
            this.tenants.Controls.Add(this.button1);
            this.tenants.Location = new System.Drawing.Point(4, 48);
            this.tenants.Name = "tenants";
            this.tenants.Padding = new System.Windows.Forms.Padding(3);
            this.tenants.Size = new System.Drawing.Size(1136, 573);
            this.tenants.TabIndex = 1;
            this.tenants.Text = "Tenants";
            this.tenants.UseVisualStyleBackColor = true;
            this.tenants.Click += new System.EventHandler(this.tenants_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1073, 409);
            this.dataGridView1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(880, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tenants";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(997, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // apartments
            // 
            this.apartments.Controls.Add(this.dataGridView2);
            this.apartments.Controls.Add(this.refreshApartmentBtn);
            this.apartments.Controls.Add(this.createApartmentBtn);
            this.apartments.Controls.Add(this.label2);
            this.apartments.Location = new System.Drawing.Point(4, 48);
            this.apartments.Name = "apartments";
            this.apartments.Padding = new System.Windows.Forms.Padding(3);
            this.apartments.Size = new System.Drawing.Size(1136, 573);
            this.apartments.TabIndex = 2;
            this.apartments.Text = "Apartments";
            this.apartments.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(29, 87);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 40;
            this.dataGridView2.Size = new System.Drawing.Size(1076, 456);
            this.dataGridView2.TabIndex = 8;
            // 
            // refreshApartmentBtn
            // 
            this.refreshApartmentBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.refreshApartmentBtn.FlatAppearance.BorderSize = 0;
            this.refreshApartmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshApartmentBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refreshApartmentBtn.Location = new System.Drawing.Point(884, 33);
            this.refreshApartmentBtn.Name = "refreshApartmentBtn";
            this.refreshApartmentBtn.Size = new System.Drawing.Size(109, 33);
            this.refreshApartmentBtn.TabIndex = 7;
            this.refreshApartmentBtn.Text = "Refresh";
            this.refreshApartmentBtn.UseVisualStyleBackColor = false;
            this.refreshApartmentBtn.Click += new System.EventHandler(this.refreshApartmentBtn_Click);
            // 
            // createApartmentBtn
            // 
            this.createApartmentBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.createApartmentBtn.FlatAppearance.BorderSize = 0;
            this.createApartmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createApartmentBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createApartmentBtn.Location = new System.Drawing.Point(1001, 33);
            this.createApartmentBtn.Name = "createApartmentBtn";
            this.createApartmentBtn.Size = new System.Drawing.Size(104, 33);
            this.createApartmentBtn.TabIndex = 5;
            this.createApartmentBtn.Text = "Create New";
            this.createApartmentBtn.UseVisualStyleBackColor = false;
            this.createApartmentBtn.Click += new System.EventHandler(this.createApartmentBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apartments";
            // 
            // lease
            // 
            this.lease.Controls.Add(this.dataGridView3);
            this.lease.Controls.Add(this.leaseRefreshBtn);
            this.lease.Controls.Add(this.leaseCreateBtn);
            this.lease.Controls.Add(this.label3);
            this.lease.Location = new System.Drawing.Point(4, 48);
            this.lease.Name = "lease";
            this.lease.Padding = new System.Windows.Forms.Padding(3);
            this.lease.Size = new System.Drawing.Size(1136, 573);
            this.lease.TabIndex = 3;
            this.lease.Text = "Lease Records";
            this.lease.UseVisualStyleBackColor = true;
            this.lease.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(29, 87);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 40;
            this.dataGridView3.Size = new System.Drawing.Size(1076, 454);
            this.dataGridView3.TabIndex = 12;
            // 
            // leaseRefreshBtn
            // 
            this.leaseRefreshBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.leaseRefreshBtn.FlatAppearance.BorderSize = 0;
            this.leaseRefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaseRefreshBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.leaseRefreshBtn.Location = new System.Drawing.Point(884, 33);
            this.leaseRefreshBtn.Name = "leaseRefreshBtn";
            this.leaseRefreshBtn.Size = new System.Drawing.Size(109, 33);
            this.leaseRefreshBtn.TabIndex = 11;
            this.leaseRefreshBtn.Text = "Refresh";
            this.leaseRefreshBtn.UseVisualStyleBackColor = false;
            this.leaseRefreshBtn.Click += new System.EventHandler(this.leaseRefreshBtn_Click);
            // 
            // leaseCreateBtn
            // 
            this.leaseCreateBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.leaseCreateBtn.FlatAppearance.BorderSize = 0;
            this.leaseCreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaseCreateBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.leaseCreateBtn.Location = new System.Drawing.Point(1001, 33);
            this.leaseCreateBtn.Name = "leaseCreateBtn";
            this.leaseCreateBtn.Size = new System.Drawing.Size(104, 33);
            this.leaseCreateBtn.TabIndex = 9;
            this.leaseCreateBtn.Text = "Create New";
            this.leaseCreateBtn.UseVisualStyleBackColor = false;
            this.leaseCreateBtn.Click += new System.EventHandler(this.leaseCreateBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lease Records";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1144, 625);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "House Rental Management App by Patience Nkom";
            this.tabControl1.ResumeLayout(false);
            this.dashboard.ResumeLayout(false);
            this.dashboard.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tenants.ResumeLayout(false);
            this.tenants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.apartments.ResumeLayout(false);
            this.apartments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.lease.ResumeLayout(false);
            this.lease.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage dashboard;
        private TabPage tenants;
        private TabPage apartments;
        private TabPage lease;
        private Label label1;
        private Button button1;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button refreshApartmentBtn;
        private Button createApartmentBtn;
        private Label label2;
        private DataGridView dataGridView3;
        private Button leaseRefreshBtn;
        private Button leaseCreateBtn;
        private Label label3;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private Label label6;
        private Label label9;
        private Label label4;
        private Label leasedApartments;
        private Label totalApartments;
        private Label totalTenants;
        private Label label12;
        private Label label10;
        private Label totalLease;
        private Label label14;
        private MaterialSkin.Controls.MaterialButton viewLeaseFromDashboard;
        private MaterialSkin.Controls.MaterialButton createLeaseFromDashboard;
        private Label label13;
        private MaterialSkin.Controls.MaterialButton viewApartmentFromDashboard;
        private MaterialSkin.Controls.MaterialButton createApartmentFromDashboard;
        private Label label11;
        private MaterialSkin.Controls.MaterialButton viewTenantFromDashboard;
        private MaterialSkin.Controls.MaterialButton createTenantFromDashboard;
    }
}