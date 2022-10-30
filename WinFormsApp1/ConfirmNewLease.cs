using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ConfirmNewLease : Form
    {
        public ConfirmNewLease()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void leaseConfirmYesBtn_Click(object sender, EventArgs e)
        {
            EventHandler handler = this.onAccept;
            if (handler != null)
            {
                this.Close();
                handler(this, new EventArgs());
            }
        }
        public event EventHandler onAccept;
    }
}
