namespace QuanLyPhongTroTheoThang.Forms
{
    partial class frmBill
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
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            cmbTenant = new ComboBox();
            cmbRoom = new ComboBox();
            Total = new TextBox();
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
            ElectricOld = new TextBox();
            ElectricNew = new TextBox();
            label5 = new Label();
            WaterNew = new TextBox();
            label6 = new Label();
            WaterOld = new TextBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(2, 245);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(797, 204);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Hóa Đơn";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(WaterNew);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(WaterOld);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(ElectricNew);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(ElectricOld);
            groupBox1.Controls.Add(cmbTenant);
            groupBox1.Controls.Add(cmbRoom);
            groupBox1.Controls.Add(Total);
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
            groupBox1.Size = new Size(797, 237);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Hóa Đơn";
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
            // Total
            // 
            Total.Location = new Point(127, 192);
            Total.Name = "Total";
            Total.Size = new Size(294, 27);
            Total.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 194);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 16;
            label4.Text = "Tổng tiền:";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(575, 108);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(575, 70);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 13;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(692, 108);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 12;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // NtnNhap
            // 
            NtnNhap.Location = new Point(692, 70);
            NtnNhap.Name = "NtnNhap";
            NtnNhap.Size = new Size(94, 29);
            NtnNhap.TabIndex = 11;
            NtnNhap.Text = "Nhập...";
            NtnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(692, 34);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 10;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(575, 34);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
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
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 110);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 2;
            label3.Text = "Số điện cũ:";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(460, 33);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // ElectricOld
            // 
            ElectricOld.Location = new Point(127, 107);
            ElectricOld.Name = "ElectricOld";
            ElectricOld.Size = new Size(84, 27);
            ElectricOld.TabIndex = 20;
            // 
            // ElectricNew
            // 
            ElectricNew.Location = new Point(330, 107);
            ElectricNew.Name = "ElectricNew";
            ElectricNew.Size = new Size(91, 27);
            ElectricNew.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(227, 110);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 21;
            label5.Text = "Số điện mới:";
            // 
            // WaterNew
            // 
            WaterNew.Location = new Point(330, 150);
            WaterNew.Name = "WaterNew";
            WaterNew.Size = new Size(91, 27);
            WaterNew.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(227, 153);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 25;
            label6.Text = "Số nước mới:";
            // 
            // WaterOld
            // 
            WaterOld.Location = new Point(127, 150);
            WaterOld.Name = "WaterOld";
            WaterOld.Size = new Size(84, 27);
            WaterOld.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 153);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 23;
            label7.Text = "Số nước cũ:";
            // 
            // frmBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmBill";
            Text = "Quản Lý Hóa Đơn";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private ComboBox cmbTenant;
        private ComboBox cmbRoom;
        private TextBox Total;
        private Label label4;
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
        private TextBox WaterNew;
        private Label label6;
        private TextBox WaterOld;
        private Label label7;
        private TextBox ElectricNew;
        private Label label5;
        private TextBox ElectricOld;
    }
}