namespace QuanLyThuVien
{
    partial class FrmThuThu
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.gbxThuThu = new System.Windows.Forms.GroupBox();
            this.dateNgaySinhtt = new System.Windows.Forms.DateTimePicker();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTentt = new System.Windows.Forms.TextBox();
            this.txtMatt = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTentt = new System.Windows.Forms.Label();
            this.lblMatt = new System.Windows.Forms.Label();
            this.gbxSearchThuThu = new System.Windows.Forms.GroupBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.lblThongTinTT = new System.Windows.Forms.Label();
            this.dgvThuthu = new System.Windows.Forms.DataGridView();
            this.gbxThuThu.SuspendLayout();
            this.gbxSearchThuThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuthu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Image = global::QuanLyThuVien.Properties.Resources.home_icon;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 33);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyThuVien.Properties.Resources.Add_icon;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(120, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 33);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyThuVien.Properties.Resources.edit_icon;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(236, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 33);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyThuVien.Properties.Resources.Delete_icon;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(335, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 33);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLyThuVien.Properties.Resources.Save_icon;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(445, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 33);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::QuanLyThuVien.Properties.Resources.Search_icon11;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(503, 41);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // gbxThuThu
            // 
            this.gbxThuThu.Controls.Add(this.dateNgaySinhtt);
            this.gbxThuThu.Controls.Add(this.txtDiachi);
            this.gbxThuThu.Controls.Add(this.txtTentt);
            this.gbxThuThu.Controls.Add(this.txtMatt);
            this.gbxThuThu.Controls.Add(this.lblNgaySinh);
            this.gbxThuThu.Controls.Add(this.lblDiaChi);
            this.gbxThuThu.Controls.Add(this.lblTentt);
            this.gbxThuThu.Controls.Add(this.lblMatt);
            this.gbxThuThu.Location = new System.Drawing.Point(12, 57);
            this.gbxThuThu.Name = "gbxThuThu";
            this.gbxThuThu.Size = new System.Drawing.Size(611, 99);
            this.gbxThuThu.TabIndex = 6;
            this.gbxThuThu.TabStop = false;
            this.gbxThuThu.Text = "Thông tin thủ thư";
            // 
            // dateNgaySinhtt
            // 
            this.dateNgaySinhtt.Location = new System.Drawing.Point(398, 30);
            this.dateNgaySinhtt.Name = "dateNgaySinhtt";
            this.dateNgaySinhtt.Size = new System.Drawing.Size(180, 20);
            this.dateNgaySinhtt.TabIndex = 7;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(398, 67);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(180, 20);
            this.txtDiachi.TabIndex = 6;
            // 
            // txtTentt
            // 
            this.txtTentt.Location = new System.Drawing.Point(93, 64);
            this.txtTentt.Name = "txtTentt";
            this.txtTentt.Size = new System.Drawing.Size(176, 20);
            this.txtTentt.TabIndex = 5;
            // 
            // txtMatt
            // 
            this.txtMatt.Location = new System.Drawing.Point(93, 34);
            this.txtMatt.Name = "txtMatt";
            this.txtMatt.Size = new System.Drawing.Size(176, 20);
            this.txtMatt.TabIndex = 4;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(308, 36);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(54, 13);
            this.lblNgaySinh.TabIndex = 3;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(308, 74);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(40, 13);
            this.lblDiaChi.TabIndex = 2;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblTentt
            // 
            this.lblTentt.AutoSize = true;
            this.lblTentt.Location = new System.Drawing.Point(13, 67);
            this.lblTentt.Name = "lblTentt";
            this.lblTentt.Size = new System.Drawing.Size(62, 13);
            this.lblTentt.TabIndex = 1;
            this.lblTentt.Text = "Tên thủ thư";
            // 
            // lblMatt
            // 
            this.lblMatt.AutoSize = true;
            this.lblMatt.Location = new System.Drawing.Point(15, 37);
            this.lblMatt.Name = "lblMatt";
            this.lblMatt.Size = new System.Drawing.Size(58, 13);
            this.lblMatt.TabIndex = 0;
            this.lblMatt.Text = "Mã thủ thư";
            // 
            // gbxSearchThuThu
            // 
            this.gbxSearchThuThu.Controls.Add(this.txtTimkiem);
            this.gbxSearchThuThu.Controls.Add(this.lblTimKiem);
            this.gbxSearchThuThu.Controls.Add(this.btnTimKiem);
            this.gbxSearchThuThu.Location = new System.Drawing.Point(12, 175);
            this.gbxSearchThuThu.Name = "gbxSearchThuThu";
            this.gbxSearchThuThu.Size = new System.Drawing.Size(611, 100);
            this.gbxSearchThuThu.TabIndex = 7;
            this.gbxSearchThuThu.TabStop = false;
            this.gbxSearchThuThu.Text = "Tìm kiếm thông tin";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(158, 44);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(273, 20);
            this.txtTimkiem.TabIndex = 7;
            this.txtTimkiem.Text = "Nhập thông tin cần tìm kiếm";
            this.txtTimkiem.Click += new System.EventHandler(this.txtTimkiem_Click);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(26, 46);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(85, 13);
            this.lblTimKiem.TabIndex = 4;
            this.lblTimKiem.Text = "Tìm kiếm thủ thư";
            // 
            // lblThongTinTT
            // 
            this.lblThongTinTT.AutoSize = true;
            this.lblThongTinTT.Location = new System.Drawing.Point(272, 290);
            this.lblThongTinTT.Name = "lblThongTinTT";
            this.lblThongTinTT.Size = new System.Drawing.Size(88, 13);
            this.lblThongTinTT.TabIndex = 5;
            this.lblThongTinTT.Text = "Thông tin thủ thư";
            // 
            // dgvThuthu
            // 
            this.dgvThuthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuthu.Location = new System.Drawing.Point(12, 318);
            this.dgvThuthu.Name = "dgvThuthu";
            this.dgvThuthu.Size = new System.Drawing.Size(611, 109);
            this.dgvThuthu.TabIndex = 8;
            this.dgvThuthu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuthu_CellClick);
            // 
            // FrmThuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 444);
            this.Controls.Add(this.dgvThuthu);
            this.Controls.Add(this.lblThongTinTT);
            this.Controls.Add(this.gbxSearchThuThu);
            this.Controls.Add(this.gbxThuThu);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHome);
            this.Name = "FrmThuThu";
            this.Text = "ThuThu";
            this.Load += new System.EventHandler(this.ThuThu_Load);
            this.gbxThuThu.ResumeLayout(false);
            this.gbxThuThu.PerformLayout();
            this.gbxSearchThuThu.ResumeLayout(false);
            this.gbxSearchThuThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuthu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox gbxThuThu;
        private System.Windows.Forms.DateTimePicker dateNgaySinhtt;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTentt;
        private System.Windows.Forms.TextBox txtMatt;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTentt;
        private System.Windows.Forms.Label lblMatt;
        private System.Windows.Forms.GroupBox gbxSearchThuThu;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Label lblThongTinTT;
        private System.Windows.Forms.DataGridView dgvThuthu;
    }
}