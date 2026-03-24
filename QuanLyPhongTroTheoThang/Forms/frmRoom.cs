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
    public partial class frmRoom : Form
    {
        QLPTDbContext context = new QLPTDbContext();
        bool isAddMode = false;
        int selectedRoomId;

        public frmRoom()
        {
            InitializeComponent();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isAddMode = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAddMode = true;

            txtRoomName.Clear();
            txtPrice.Clear();
            cmbStatus.SelectedIndex = -1;

            selectedRoomId = 0;

            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtRoomName.Text == "" || txtPrice.Text == "" || cmbStatus.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Giá phòng phải là số!");
                return;
            }

            if (price <= 0)
            {
                MessageBox.Show("Giá phòng phải > 0!");
                return;
            }

            if (isAddMode)
            {
                Room room = new Room()
                {
                    RoomName = txtRoomName.Text,
                    Price = price,
                    Status = cmbStatus.Text
                };

                context.Rooms.Add(room);
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                Room room = context.Rooms.Find(selectedRoomId);

                if (room != null)
                {
                    room.RoomName = txtRoomName.Text;
                    room.Price = price;
                    room.Status = cmbStatus.Text;

                    MessageBox.Show("Cập nhật thành công!");
                }
            }

            context.SaveChanges();
            dgvRoom.DataSource = context.Rooms.ToList();
        }

        private void frmRoom_Load(object sender, EventArgs e)
        {
            dgvRoom.AutoGenerateColumns = false;
            dgvRoom.DataSource = context.Rooms.ToList();

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;

            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Trống");
            cmbStatus.Items.Add("Đã thuê");

            LoadGrid();

            dgvRoom.CellFormatting += dgvRoom_CellFormatting;
        }

        private void LoadGrid()
        {
            dgvRoom.AutoGenerateColumns = true;


            dgvRoom.DataSource = context.Rooms.ToList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng!");
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa không?",
                                         "Xác nhận",
                                         MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                Room room = context.Rooms.Find(selectedRoomId);

                if (room != null)
                {
                    context.Rooms.Remove(room);
                    context.SaveChanges();

                    dgvRoom.DataSource = context.Rooms.ToList();

                    btnHuyBo_Click(null, null);
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            txtRoomName.Clear();
            txtPrice.Clear();
            cmbStatus.SelectedIndex = -1;

            selectedRoomId = 0;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRoom.Rows[e.RowIndex];

                selectedRoomId = (int)row.Cells["RoomID"].Value;

                txtRoomName.Text = row.Cells["RoomName"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                cmbStatus.Text = row.Cells["Status"].Value.ToString();

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = true;
                isAddMode = false;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            txtRoomName.Clear();
            txtPrice.Clear();
            cmbStatus.SelectedIndex = -1;

            txtRoomName.Focus();
        }

        private void SearchRoom()
        {
            string name = txtRoomName.Text.ToLower();
            string price = txtPrice.Text.ToLower();
            string status = cmbStatus.Text.ToLower();

            // 👉 reset nếu không nhập gì
            if (name == "" && price == "" && status == "")
            {
                dgvRoom.DataSource = context.Rooms.ToList();
                return;
            }

            dgvRoom.DataSource = context.Rooms
                .Where(r =>
                    (string.IsNullOrEmpty(name) || r.RoomName.ToLower().Contains(name)) &&
                    (string.IsNullOrEmpty(price) || r.Price.ToString().Contains(price)) &&
                    (string.IsNullOrEmpty(status) || r.Status.ToLower().Contains(status))
                )
                .ToList();
        }

        private void NtnNhap_Click(object sender, EventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {

        }

        private void txtRoomName_TextChanged(object sender, EventArgs e)
        {
            SearchRoom();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            SearchRoom();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchRoom();
        }

        private void dgvRoom_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvRoom.Columns[e.ColumnIndex].Name == "Price" && e.Value != null)
            {
                e.Value = string.Format("{0:N0}", e.Value);
            }
        }
    }
}
