using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTroTheoThang.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            frmRoom f = new frmRoom();
            f.ShowDialog();
        }

        private void btnTenant_Click(object sender, EventArgs e)
        {
            frmTenant f = new frmTenant();
            f.ShowDialog();
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            frmContract f = new frmContract();
            f.ShowDialog();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            frmBill f = new frmBill();    
            f.ShowDialog();
        }
    }
}
