
using System.Windows.Forms;
using QuanLyPhongTroTheoThang.Data;

namespace QuanLyPhongTroTheoThang.Forms
{
    partial class frmRoom
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtRoomName = new TextBox();
            txtPrice = new TextBox();
            cmbStatus = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            groupBox1 = new GroupBox();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnXuat = new Button();
            NtnNhap = new Button();
            btnTimKiem = new Button();
            groupBox2 = new GroupBox();
            dgvRoom = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoom).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 33);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên Phòng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 70);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "Giá Phòng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 110);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "Trạng thái:";
            // 
            // txtRoomName
            // 
            txtRoomName.Location = new Point(117, 34);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.Size = new Size(294, 27);
            txtRoomName.TabIndex = 3;
            txtRoomName.TextChanged += txtRoomName_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(117, 67);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(294, 27);
            txtPrice.TabIndex = 4;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(117, 107);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(294, 28);
            cmbStatus.TabIndex = 5;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(460, 33);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(460, 69);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(460, 107);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(575, 34);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(NtnNhap);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtRoomName);
            groupBox1.Controls.Add(cmbStatus);
            groupBox1.Location = new Point(2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(797, 152);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Phòng";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(575, 108);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(575, 70);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 13;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(692, 108);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 12;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // NtnNhap
            // 
            NtnNhap.Location = new Point(692, 70);
            NtnNhap.Name = "NtnNhap";
            NtnNhap.Size = new Size(94, 29);
            NtnNhap.TabIndex = 11;
            NtnNhap.Text = "Nhập...";
            NtnNhap.UseVisualStyleBackColor = true;
            NtnNhap.Click += NtnNhap_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(692, 34);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 10;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvRoom);
            groupBox2.Location = new Point(2, 161);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(797, 289);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Phòng";
            // 
            // dgvRoom
            // 
            dgvRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoom.Location = new Point(0, 26);
            dgvRoom.Name = "dgvRoom";
            dgvRoom.RowHeadersVisible = false;
            dgvRoom.RowHeadersWidth = 51;
            dgvRoom.Size = new Size(797, 263);
            dgvRoom.TabIndex = 0;
            dgvRoom.CellClick += dgvRoom_CellClick;
            dgvRoom.CellFormatting += dgvRoom_CellFormatting;
            // 
            // frmRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmRoom";
            Text = "Quản Lý Phòng";
            Load += frmRoom_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRoom).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtRoomName;
        private TextBox txtPrice;
        private ComboBox cmbStatus;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLuu;
        private GroupBox groupBox1;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnXuat;
        private Button NtnNhap;
        private Button btnTimKiem;
        private GroupBox groupBox2;
        private DataGridView dgvRoom;
    }
}