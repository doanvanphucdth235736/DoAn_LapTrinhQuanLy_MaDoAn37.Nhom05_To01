namespace QuanLyPhongTroTheoThang.Forms
{
    partial class frmContract
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox2 = new GroupBox();
            dgvContract = new DataGridView();
            colContractID = new DataGridViewTextBoxColumn();
            colRoom = new DataGridViewTextBoxColumn();
            colTenant = new DataGridViewTextBoxColumn();
            colStartDate = new DataGridViewTextBoxColumn();
            colDeposit = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            dtpStartDate = new DateTimePicker();
            cmbTenant = new ComboBox();
            cmbRoom = new ComboBox();
            txtDeposit = new TextBox();
            label4 = new Label();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnXuat = new Button();
            NtnNhap = new Button();
            btnTimKiem = new Button();
            btnLuu = new Button();
            label1 = new Label();
            btnXoa = new Button();
            label2 = new Label();
            btnSua = new Button();
            label3 = new Label();
            btnThem = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContract).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvContract);
            groupBox2.Location = new Point(2, 207);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(797, 242);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Hợp Đồng";
            // 
            // dgvContract
            // 
            dgvContract.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContract.Columns.AddRange(new DataGridViewColumn[] { colContractID, colRoom, colTenant, colStartDate, colDeposit });
            dgvContract.Location = new Point(0, 26);
            dgvContract.Name = "dgvContract";
            dgvContract.RowHeadersVisible = false;
            dgvContract.RowHeadersWidth = 51;
            dgvContract.Size = new Size(797, 216);
            dgvContract.TabIndex = 0;
            dgvContract.CellClick += dgvContract_CellClick;
            // 
            // colContractID
            // 
            colContractID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colContractID.DataPropertyName = "ContractID";
            colContractID.HeaderText = "Mã Hợp Đồng";
            colContractID.MinimumWidth = 6;
            colContractID.Name = "colContractID";
            colContractID.Width = 133;
            // 
            // colRoom
            // 
            colRoom.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colRoom.DataPropertyName = "Room";
            colRoom.HeaderText = "Phòng";
            colRoom.MinimumWidth = 6;
            colRoom.Name = "colRoom";
            // 
            // colTenant
            // 
            colTenant.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTenant.DataPropertyName = "Tenant";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.NullValue = null;
            colTenant.DefaultCellStyle = dataGridViewCellStyle3;
            colTenant.HeaderText = "Khách Hàng";
            colTenant.MinimumWidth = 6;
            colTenant.Name = "colTenant";
            // 
            // colStartDate
            // 
            colStartDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colStartDate.DataPropertyName = "StartDate";
            colStartDate.HeaderText = "Ngày";
            colStartDate.MinimumWidth = 6;
            colStartDate.Name = "colStartDate";
            // 
            // colDeposit
            // 
            colDeposit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDeposit.DataPropertyName = "Deposit";
            colDeposit.HeaderText = "Tiền Cọc";
            colDeposit.MinimumWidth = 6;
            colDeposit.Name = "colDeposit";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpStartDate);
            groupBox1.Controls.Add(cmbTenant);
            groupBox1.Controls.Add(cmbRoom);
            groupBox1.Controls.Add(txtDeposit);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(NtnNhap);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Location = new Point(2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(797, 199);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Hợp Đồng";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(127, 108);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(219, 27);
            dtpStartDate.TabIndex = 20;
            // 
            // cmbTenant
            // 
            cmbTenant.FormattingEnabled = true;
            cmbTenant.Location = new Point(127, 67);
            cmbTenant.Name = "cmbTenant";
            cmbTenant.Size = new Size(294, 28);
            cmbTenant.TabIndex = 19;
            // 
            // cmbRoom
            // 
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Location = new Point(127, 26);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(294, 28);
            cmbRoom.TabIndex = 18;
            // 
            // txtDeposit
            // 
            txtDeposit.Location = new Point(127, 151);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(294, 27);
            txtDeposit.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 153);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 16;
            label4.Text = "Tiền cọc:";
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
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Phòng:";
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
            label2.Size = new Size(89, 20);
            label2.TabIndex = 1;
            label2.Text = "Khách hàng:";
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
            label3.Size = new Size(102, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày bất đầu:";
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
            // frmContract
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmContract";
            Text = "Quản Lý Hợp Đồng";
            Load += frmContract_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvContract).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dgvContract;
        private GroupBox groupBox1;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnXuat;
        private Button NtnNhap;
        private Button btnTimKiem;
        private Button btnLuu;
        private Label label1;
        private Button btnXoa;
        private Label label2;
        private Button btnSua;
        private Label label3;
        private Button btnThem;
        private TextBox txtDeposit;
        private Label label4;
        private DateTimePicker dtpStartDate;
        private ComboBox cmbTenant;
        private ComboBox cmbRoom;
        private DataGridViewTextBoxColumn colContractID;
        private DataGridViewTextBoxColumn colRoom;
        private DataGridViewTextBoxColumn colTenant;
        private DataGridViewTextBoxColumn colStartDate;
        private DataGridViewTextBoxColumn colDeposit;
    }
}