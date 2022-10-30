using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            reloadAll();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateNewTenant form = new();
            form.onCreate += new EventHandler(performDataReload);
            form.ShowDialog();
        }
        private void performDataReload(object sender, EventArgs e)
        {
            this.reloadAll();
        }
        private void reloadAll()
        {
            Lease.RunValidity();
            this.LoadTenantData();
            this.LoadApartmentData();
            this.LoadLeaseData();
            totalTenants.Text = Tenant.FetchAll().Count.ToString();
            totalApartments.Text = Apartment.FetchAll().Count.ToString();
            totalLease.Text = Lease.FetchAll().Count.ToString();
            leasedApartments.Text = Apartment.FetchLeased().Count.ToString();
        }
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.reloadAll();
        }
        public void LoadTenantData()
        {
            List<Tenant.TenantInfo> tenants = Tenant.FetchAll();
            if(dataGridView1.Columns.Count > 0)
            {
                dataGridView1.CellClick -= dataGridView1_CellClick;
                dataGridView1.Columns.Clear();
            }
            var dt = new DataTable();
            dataGridView1.DataSource = dt;
            
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("Created", typeof(DateTime));
            dt.Columns.Add("Updated", typeof(DateTime));
           

            DataGridViewButtonColumn btn = new();
            btn.HeaderText = "";
            btn.Text = "Edit";
            btn.Name = "editBtn";
            btn.FlatStyle = FlatStyle.Flat;
            btn.CellTemplate.Style.Padding = new Padding(0,5,0,5);
            btn.CellTemplate.Style.BackColor = Color.CornflowerBlue;
            btn.CellTemplate.Style.ForeColor = Color.White;
            btn.UseColumnTextForButtonValue = true;
           
            DataGridViewButtonColumn deleteBtn = new();
            deleteBtn.HeaderText = "";
            deleteBtn.Text = "Delete";
            deleteBtn.Name = "deleteBtn";
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.CellTemplate.Style.Padding = new Padding(0, 5, 0, 5);
            deleteBtn.CellTemplate.Style.BackColor = Color.Red;
            deleteBtn.CellTemplate.Style.ForeColor = Color.White;
            deleteBtn.UseColumnTextForButtonValue = true;

            
            dataGridView1.Columns.Add(btn);
            dataGridView1.Columns.Add(deleteBtn);


            foreach (var tenant in tenants)
            {
                dt.Rows.Add(tenant.Id,tenant.Name,tenant.Gender,tenant.CreatedAt,tenant.UpdatedAt);
            }

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Black;

            dataGridView1.CellClick += dataGridView1_CellClick;
        }
        public void LoadApartmentData()
        {
            List<Apartment.ApartmentInfo> apartments = Apartment.FetchAll();
            if (dataGridView2.Columns.Count > 0)
            {
                dataGridView2.CellClick -= dataGridView2_CellClick;
                dataGridView2.Columns.Clear();
            }
            var dt = new DataTable();
            dataGridView2.DataSource = dt;

            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Apartment No", typeof(string));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Created", typeof(DateTime));
            dt.Columns.Add("Updated", typeof(DateTime));


            DataGridViewButtonColumn btn = new();
            btn.HeaderText = "";
            btn.Text = "Edit";
            btn.Name = "editBtn";
            btn.FlatStyle = FlatStyle.Flat;
            btn.CellTemplate.Style.Padding = new Padding(0, 5, 0, 5);
            btn.CellTemplate.Style.BackColor = Color.CornflowerBlue;
            btn.CellTemplate.Style.ForeColor = Color.White;
            btn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn deleteBtn = new();
            deleteBtn.HeaderText = "";
            deleteBtn.Text = "Delete";
            deleteBtn.Name = "deleteBtn";
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.CellTemplate.Style.Padding = new Padding(0, 5, 0, 5);
            deleteBtn.CellTemplate.Style.BackColor = Color.Red;
            deleteBtn.CellTemplate.Style.ForeColor = Color.White;
            deleteBtn.UseColumnTextForButtonValue = true;


            dataGridView2.Columns.Add(btn);
            dataGridView2.Columns.Add(deleteBtn);


            foreach (var apartment in apartments)
            {
                dt.Rows.Add(apartment.Id, apartment.Name, apartment.ApartmentNo, apartment.status, apartment.CreatedAt, apartment.UpdatedAt);
            }

            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView2.Columns[0].DefaultCellStyle.ForeColor = Color.Black;

            dataGridView2.CellClick += dataGridView2_CellClick;
        }
        public void LoadLeaseData()
        {
            List<Lease.LeaseInfo> leases = Lease.FetchAll();
            if (dataGridView3.Columns.Count > 0)
            {
                dataGridView3.CellClick -= dataGridView3_CellClick;
                dataGridView3.Columns.Clear();
            }
            var dt = new DataTable();
            dataGridView3.DataSource = dt;

            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("Apartment ID", typeof(int));
            dt.Columns.Add("Tenant ID", typeof(int));
            dt.Columns.Add("Price ($)", typeof(double));
            dt.Columns.Add("Transaction Ref", typeof(string));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Expires", typeof(DateTime));
            dt.Columns.Add("Created", typeof(DateTime));
            dt.Columns.Add("Updated", typeof(DateTime));


            foreach (var lease in leases)
            {
                dt.Rows.Add(lease.Id, lease.ApartmentId, lease.TenantId, lease.Price, lease.TransactionRef, lease.Status, lease.ValidTill, lease.CreatedAt, lease.UpdatedAt);
            }

            dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView3.Columns[0].DefaultCellStyle.ForeColor = Color.Black;

            dataGridView3.CellClick += dataGridView3_CellClick;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                return;
            }
            string? id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (id == "Edit")
            {
                id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            
            if (dataGridView1.SelectedCells[0].Value.ToString() == "Edit")
            {
                EditTenant form = new(Int32.Parse(id));
                form.onUpdate += new EventHandler(performDataReload);
                form.ShowDialog();
            }
            if (dataGridView1.SelectedCells[0].Value.ToString() == "Delete")
            {
                if (Tenant.DeleteById(id))
                {
                    MessageBox.Show("Tenant ID:"+id+" deleted successfully!");
                    this.LoadTenantData();
                }
            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            string? id = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (id == "Edit")
            {
                id = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            if (dataGridView2.SelectedCells[0].Value.ToString() == "Edit")
            {
                EditApartment form = new(Int32.Parse(id));
                form.onUpdate += new EventHandler(performDataReload);
                form.ShowDialog();
            }
            if (dataGridView2.SelectedCells[0].Value.ToString() == "Delete")
            {
                if (Apartment.DeleteById(id))
                {
                    MessageBox.Show("Apartment ID:" + id + " deleted successfully!");
                    this.LoadApartmentData();
                }
            }
        }
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if(dataGridView3.SelectedCells.Count > 1)
            {
                return;
            }
            int columnIndex = dataGridView3.SelectedCells[0].ColumnIndex;
            string? id = "";
            if(columnIndex < 1 || columnIndex > 2)
            {
                return;
            }
            id = dataGridView3.Rows[e.RowIndex].Cells[columnIndex].Value.ToString();
            if (columnIndex == 1)
            {
                ViewApartment form = new(Int32.Parse(id));
                form.ShowDialog();
            }
            if (columnIndex == 2)
            {
                ViewTenant form = new(Int32.Parse(id));
                form.ShowDialog();
            }
        }
        private void tenants_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.LoadTenantData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void createApartmentBtn_Click(object sender, EventArgs e)
        {
            CreateNewApartment form = new();
            form.onCreate += new EventHandler(performDataReload);
            form.ShowDialog();
        }

        private void refreshApartmentBtn_Click(object sender, EventArgs e)
        {
            this.reloadAll();
        }
        private void leaseCreateBtn_Click(object sender, EventArgs e)
        {
            CreateNewLease form = new();
            form.onCreate += new EventHandler(performDataReload);
            form.ShowDialog();
        }

        private void leaseRefreshBtn_Click(object sender, EventArgs e)
        {
            this.reloadAll();
        }

        private void createTenantFromDashboard_Click(object sender, EventArgs e)
        {
            CreateNewTenant form = new();
            form.onCreate += new EventHandler(performDataReload);
            form.ShowDialog();
        }

        private void viewTenantFromDashboard_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;  
        }

        private void createApartmentFromDashboard_Click(object sender, EventArgs e)
        {
            CreateNewApartment form = new();
            form.onCreate += new EventHandler(performDataReload);
            form.ShowDialog();
        }

        private void viewApartmentFromDashboard_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void createLeaseFromDashboard_Click(object sender, EventArgs e)
        {
            CreateNewLease form = new();
            form.onCreate += new EventHandler(performDataReload);
            form.ShowDialog();
        }

        private void viewLeaseFromDashboard_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }
    }
}
