using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongTroTheoThang.Data;

namespace QuanLyPhongTroTheoThang.Forms
{
    public partial class frmContract : Form
    {
        QLPTDbContext context = new QLPTDbContext();
        bool isAddMode = false;
        int selectedContractId;
        public frmContract()
        {
            InitializeComponent();
        }

        private void frmContract_Load(object sender, EventArgs e)
        {
            // load phòng
            cmbRoom.DataSource = context.Rooms.ToList();
            cmbRoom.DisplayMember = "RoomName";
            cmbRoom.ValueMember = "RoomID";

            // load khách
            cmbTenant.DataSource = context.Tenants.ToList();
            cmbTenant.DisplayMember = "TenantName";
            cmbTenant.ValueMember = "TenantID";

            LoadGrid();
        }

        private void LoadGrid()
        {
            dgvContract.DataSource = context.Contracts
                .Select(c => new
                {
                    c.ContractID,
                    Room = c.Room.RoomName,
                    Tenant = c.Tenant.TenantName,
                    c.StartDate,
                    c.Deposit
                })
                .ToList();
        }

        private void dgvContract_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvContract.Rows[e.RowIndex];

                selectedContractId = (int)row.Cells["ContractID"].Value;

                txtDeposit.Text = row.Cells["Deposit"].Value.ToString();
                dtpStartDate.Value = Convert.ToDateTime(row.Cells["StartDate"].Value);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAddMode = true;

            cmbRoom.SelectedIndex = -1;
            cmbTenant.SelectedIndex = -1;
            txtDeposit.Clear();

            txtDeposit.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isAddMode = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cmbRoom.SelectedValue == null || cmbTenant.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn phòng và khách!");
                return;
            }

            if (!decimal.TryParse(txtDeposit.Text, out decimal deposit))
            {
                MessageBox.Show("Tiền cọc phải là số!");
                return;
            }

            if (isAddMode)
            {
                Contract c = new Contract()
                {
                    RoomID = (int)cmbRoom.SelectedValue,
                    TenantID = (int)cmbTenant.SelectedValue,
                    StartDate = dtpStartDate.Value,
                    Deposit = deposit
                };

                context.Contracts.Add(c);
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                Contract c = context.Contracts.Find(selectedContractId);

                if (c != null)
                {
                    c.RoomID = (int)cmbRoom.SelectedValue;
                    c.TenantID = (int)cmbTenant.SelectedValue;
                    c.StartDate = dtpStartDate.Value;
                    c.Deposit = deposit;

                    MessageBox.Show("Cập nhật thành công!");
                }
            }

            context.SaveChanges();
            LoadGrid();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                Contract c = context.Contracts.Find(selectedContractId);

                if (c != null)
                {
                    context.Contracts.Remove(c);
                    context.SaveChanges();

                    LoadGrid();
                    MessageBox.Show("Xóa thành công!");
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            cmbRoom.SelectedIndex = -1;
            cmbTenant.SelectedIndex = -1;
            txtDeposit.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string room = cmbRoom.Text.ToLower();
            string tenant = cmbTenant.Text.ToLower();

            dgvContract.DataSource = context.Contracts
                .Where(c =>
                    (string.IsNullOrEmpty(room) || c.Room.RoomName.ToLower().Contains(room)) &&
                    (string.IsNullOrEmpty(tenant) || c.Tenant.TenantName.ToLower().Contains(tenant))
                )
                .Select(c => new
                {
                    c.ContractID,
                    Room = c.Room.RoomName,
                    Tenant = c.Tenant.TenantName,
                    c.StartDate,
                    c.Deposit
                })
                .ToList();
        }

        private void NtnNhap_Click(object sender, EventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {

        }
    }
}
