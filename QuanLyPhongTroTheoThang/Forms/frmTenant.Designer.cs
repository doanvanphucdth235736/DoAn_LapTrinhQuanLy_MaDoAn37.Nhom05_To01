namespace QuanLyPhongTroTheoThang.Forms
{
    partial class frmTenant
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox2 = new GroupBox();
            dgvTenant = new DataGridView();
            TenantID = new DataGridViewTextBoxColumn();
            colTenantName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colCCCD = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            txtCCCD = new TextBox();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnXuat = new Button();
            NtnNhap = new Button();
            btnTimKiem = new Button();
            txtPhone = new TextBox();
            btnLuu = new Button();
            label1 = new Label();
            btnXoa = new Button();
            label2 = new Label();
            btnSua = new Button();
            label3 = new Label();
            btnThem = new Button();
            txtName = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTenant).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvTenant);
            groupBox2.Location = new Point(2, 160);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(797, 289);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Khách Hàng";
            // 
            // dgvTenant
            // 
            dgvTenant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTenant.Columns.AddRange(new DataGridViewColumn[] { TenantID, colTenantName, colPhone, colCCCD });
            dgvTenant.Location = new Point(0, 26);
            dgvTenant.Name = "dgvTenant";
            dgvTenant.RowHeadersVisible = false;
            dgvTenant.RowHeadersWidth = 51;
            dgvTenant.Size = new Size(797, 263);
            dgvTenant.TabIndex = 0;
            dgvTenant.CellClick += dgvTenant_CellClick;
            // 
            // TenantID
            // 
            TenantID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TenantID.HeaderText = "Mã Khách Hàng";
            TenantID.MinimumWidth = 6;
            TenantID.Name = "TenantID";
            TenantID.Width = 143;
            // 
            // colTenantName
            // 
            colTenantName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTenantName.HeaderText = "Họ và Tên";
            colTenantName.MinimumWidth = 6;
            colTenantName.Name = "colTenantName";
            // 
            // colPhone
            // 
            colPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.NullValue = null;
            colPhone.DefaultCellStyle = dataGridViewCellStyle1;
            colPhone.HeaderText = "Số Điện Thoại";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            // 
            // colCCCD
            // 
            colCCCD.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCCCD.HeaderText = "CCCD";
            colCCCD.MinimumWidth = 6;
            colCCCD.Name = "colCCCD";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCCCD);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(NtnNhap);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtName);
            groupBox1.Location = new Point(2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(797, 152);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(127, 108);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(294, 27);
            txtCCCD.TabIndex = 15;
            txtCCCD.TextChanged += txtCCCD_TextChanged;
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
            // txtPhone
            // 
            txtPhone.Location = new Point(127, 67);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(294, 27);
            txtPhone.TabIndex = 4;
            txtPhone.TextChanged += txtPhone_TextChanged;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 33);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và Tên:";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 70);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "Số điện thoại:";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(460, 69);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 110);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "CCCD:";
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
            // txtName
            // 
            txtName.Location = new Point(127, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(294, 27);
            txtName.TabIndex = 3;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // frmTenant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmTenant";
            Text = "Quản Lý Khách Hàng";
            Load += frmTenant_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTenant).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dgvTenant;
        private GroupBox groupBox1;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnXuat;
        private Button NtnNhap;
        private Button btnTimKiem;
        private TextBox txtPhone;
        private Button btnLuu;
        private Label label1;
        private Button btnXoa;
        private Label label2;
        private Button btnSua;
        private Label label3;
        private Button btnThem;
        private TextBox txtName;
        private TextBox txtCCCD;
        private DataGridViewTextBoxColumn TenantID;
        private DataGridViewTextBoxColumn colTenantName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colCCCD;
    }
}