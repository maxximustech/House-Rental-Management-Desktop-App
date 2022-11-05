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
    public partial class CreateNewLease : Form
    {
        public CreateNewLease()
        {
            InitializeComponent();
        }

        private void createRecord(object sender, EventArgs e)
        {
            this.Enabled = false;
            var apartmentId = leaseApartmentIdInput.Text.Trim();
            var tenantId = leaseTenantIdInput.Text.Trim();
            var price = leasePriceInput.Text.Trim();
            var transactionRef = leaseTransactionRefInput.Text.Trim();
            var validTill = leaseValidTillInput.Value;
            Lease lease = new Lease("", apartmentId, tenantId, price, transactionRef, validTill);
            if (lease.Create())
            {
                new EventHandler(onCreate)?.Invoke(this, new EventArgs());
                leaseApartmentIdInput.Text = "";
                leaseTenantIdInput.Text = "";
                leasePriceInput.Text = "";
                leaseTransactionRefInput.Text = "";
                leaseValidTillInput.Value = DateTime.Now;
                MessageBox.Show("Lease record created successfully!");
            }
            this.Enabled = true;
        }
        public event EventHandler? onCreate;

        private void createTenantBtn_Click_1(object sender, EventArgs e)
        {
            var apartmentId = leaseApartmentIdInput.Text.Trim();
            var tenantId = leaseTenantIdInput.Text.Trim();
            var price = leasePriceInput.Text.Trim();
            var transactionRef = leaseTransactionRefInput.Text.Trim();
            var validTill = leaseValidTillInput.Value;
            if (apartmentId == "")
            {
                MessageBox.Show("Please add a valid apartment Id");
                return;
            }
            if (tenantId == "")
            {
                MessageBox.Show("Please add a valid tenant Id");
                return;
            }
            if (price == "")
            {
                MessageBox.Show("Please add a valid price");
                return;
            }
            if (transactionRef == "")
            {
                MessageBox.Show("Please add a valid transaction ref");
                return;
            }
            if (DateTime.Now > validTill)
            {
                MessageBox.Show("Expiration date cannot be earlier than the current date");
                return;
            }
            ConfirmNewLease form = new();
            form.onAccept += new EventHandler(createRecord);
            form.ShowDialog();
        }
    }
}
