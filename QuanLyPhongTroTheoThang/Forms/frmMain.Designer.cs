namespace QuanLyPhongTroTheoThang.Forms
{
    partial class frmMain
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
            btnRoom = new Button();
            btnOut = new Button();
            btnTenant = new Button();
            btnContract = new Button();
            btnBill = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(197, 27);
            label1.Name = "label1";
            label1.Size = new Size(374, 39);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ PHÒNG TRỌ";
            // 
            // btnRoom
            // 
            btnRoom.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRoom.Location = new Point(297, 127);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(180, 29);
            btnRoom.TabIndex = 1;
            btnRoom.Text = "Phòng";
            btnRoom.UseVisualStyleBackColor = true;
            btnRoom.Click += btnRoom_Click;
            // 
            // btnOut
            // 
            btnOut.Location = new Point(325, 398);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(94, 29);
            btnOut.TabIndex = 2;
            btnOut.Text = "Thoát";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // btnTenant
            // 
            btnTenant.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTenant.Location = new Point(297, 177);
            btnTenant.Name = "btnTenant";
            btnTenant.Size = new Size(180, 29);
            btnTenant.TabIndex = 3;
            btnTenant.Text = "Khách Hàng";
            btnTenant.UseVisualStyleBackColor = true;
            btnTenant.Click += btnTenant_Click;
            // 
            // btnContract
            // 
            btnContract.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnContract.Location = new Point(297, 229);
            btnContract.Name = "btnContract";
            btnContract.Size = new Size(180, 29);
            btnContract.TabIndex = 4;
            btnContract.Text = "Hợp Đồng";
            btnContract.UseVisualStyleBackColor = true;
            btnContract.Click += btnContract_Click;
            // 
            // btnBill
            // 
            btnBill.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBill.Location = new Point(297, 286);
            btnBill.Name = "btnBill";
            btnBill.Size = new Size(180, 29);
            btnBill.TabIndex = 5;
            btnBill.Text = "Hóa Đơn";
            btnBill.UseVisualStyleBackColor = true;
            btnBill.Click += btnBill_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBill);
            Controls.Add(btnContract);
            Controls.Add(btnTenant);
            Controls.Add(btnOut);
            Controls.Add(btnRoom);
            Controls.Add(label1);
            Name = "frmMain";
            Text = "Trang chủ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRoom;
        private Button btnOut;
        private Button btnTenant;
        private Button btnContract;
        private Button btnBill;
    }
}