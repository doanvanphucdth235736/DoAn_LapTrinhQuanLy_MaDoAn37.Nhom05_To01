using System;
using QuanLyPhongTroTheoThang.Data;
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
    public partial class frmTenant : Form
    {
        QLPTDbContext context = new QLPTDbContext();
        bool isAddMode = false;
        int selectedTenantId;

        public frmTenant()
        {
            InitializeComponent();
        }

        private void frmTenant_Load(object sender, EventArgs e)
        {
            dgvTenant.AutoGenerateColumns = false;
            dgvTenant.DataSource = context.Tenants.ToList();
        }

        private void dgvTenant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvTenant.Rows[e.RowIndex];

                selectedTenantId = (int)row.Cells["TenantID"].Value;

                txtName.Text = row.Cells["colTenantName"].Value.ToString();
                txtPhone.Text = row.Cells["colPhone"].Value.ToString();
                txtCCCD.Text = row.Cells["colCCCD"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAddMode = true;

            txtName.Clear();
            txtPhone.Clear();
            txtCCCD.Clear();

            txtName.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isAddMode = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên!");
                return;
            }

            if (isAddMode)
            {
                Tenant t = new Tenant()
                {
                    TenantName = txtName.Text,
                    Phone = txtPhone.Text,
                    CCCD = txtCCCD.Text
                };

                context.Tenants.Add(t);
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                Tenant t = context.Tenants.Find(selectedTenantId);

                if (t != null)
                {
                    t.TenantName = txtName.Text;
                    t.Phone = txtPhone.Text;
                    t.CCCD = txtCCCD.Text;

                    MessageBox.Show("Cập nhật thành công!");
                }
            }

            context.SaveChanges();
            dgvTenant.DataSource = context.Tenants.ToList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                Tenant t = context.Tenants.Find(selectedTenantId);

                if (t != null)
                {
                    context.Tenants.Remove(t);
                    context.SaveChanges();

                    dgvTenant.DataSource = context.Tenants.ToList();
                    MessageBox.Show("Xóa thành công!");
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPhone.Clear();
            txtCCCD.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPhone.Clear();
            txtCCCD.Clear();

            txtName.Focus();
        }

        private void SearchData()
        {
            string name = txtName.Text.ToLower();
            string phone = txtPhone.Text.ToLower();
            string cccd = txtCCCD.Text.ToLower();

            if (name == "" && phone == "" && cccd == "")
            {
                dgvTenant.DataSource = context.Tenants.ToList();
            }

            dgvTenant.DataSource = context.Tenants
                .Where(t =>
                    (string.IsNullOrEmpty(name) || t.TenantName.ToLower().Contains(name)) &&
                    (string.IsNullOrEmpty(phone) || t.Phone.ToLower().Contains(phone)) &&
                    (string.IsNullOrEmpty(cccd) || t.CCCD.ToLower().Contains(cccd))
                )
                .ToList();
        }

        private void NtnNhap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhập Excel (demo)");
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xuất Excel (demo)");
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }
    }
}

