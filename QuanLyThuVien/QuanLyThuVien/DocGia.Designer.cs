namespace QuanLyThuVien
{
    partial class FrmDocGia
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
            this.btnSearchDG = new System.Windows.Forms.Button();
            this.gbxDocGia = new System.Windows.Forms.GroupBox();
            this.dateNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTendg = new System.Windows.Forms.TextBox();
            this.txtMadg = new System.Windows.Forms.TextBox();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblTendg = new System.Windows.Forms.Label();
            this.lblMadg = new System.Windows.Forms.Label();
            this.gbxTimKiemDG = new System.Windows.Forms.GroupBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.lblTimkiem = new System.Windows.Forms.Label();
            this.lblThongtin = new System.Windows.Forms.Label();
            this.dgvDocgia = new System.Windows.Forms.DataGridView();
            this.gbxDocGia.SuspendLayout();
            this.gbxTimKiemDG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocgia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Image = global::QuanLyThuVien.Properties.Resources.home_icon;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 31);
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
            this.btnThem.Location = new System.Drawing.Point(111, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 31);
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
            this.btnSua.Location = new System.Drawing.Point(205, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
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
            this.btnXoa.Location = new System.Drawing.Point(301, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
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
            this.btnLuu.Location = new System.Drawing.Point(408, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 31);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSearchDG
            // 
            this.btnSearchDG.Image = global::QuanLyThuVien.Properties.Resources.Search_icon11;
            this.btnSearchDG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchDG.Location = new System.Drawing.Point(375, 32);
            this.btnSearchDG.Name = "btnSearchDG";
            this.btnSearchDG.Size = new System.Drawing.Size(75, 23);
            this.btnSearchDG.TabIndex = 5;
            this.btnSearchDG.Text = "Tìm kiếm";
            this.btnSearchDG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchDG.UseVisualStyleBackColor = true;
            this.btnSearchDG.Click += new System.EventHandler(this.btnSearchDG_Click);
            // 
            // gbxDocGia
            // 
            this.gbxDocGia.Controls.Add(this.dateNgaysinh);
            this.gbxDocGia.Controls.Add(this.txtDiachi);
            this.gbxDocGia.Controls.Add(this.txtTendg);
            this.gbxDocGia.Controls.Add(this.txtMadg);
            this.gbxDocGia.Controls.Add(this.lblNgaysinh);
            this.gbxDocGia.Controls.Add(this.lblDiachi);
            this.gbxDocGia.Controls.Add(this.lblTendg);
            this.gbxDocGia.Controls.Add(this.lblMadg);
            this.gbxDocGia.Location = new System.Drawing.Point(12, 54);
            this.gbxDocGia.Name = "gbxDocGia";
            this.gbxDocGia.Size = new System.Drawing.Size(490, 107);
            this.gbxDocGia.TabIndex = 6;
            this.gbxDocGia.TabStop = false;
            this.gbxDocGia.Text = "Thông tin độc giả";
            // 
            // dateNgaysinh
            // 
            this.dateNgaysinh.Location = new System.Drawing.Point(322, 22);
            this.dateNgaysinh.Name = "dateNgaysinh";
            this.dateNgaysinh.Size = new System.Drawing.Size(149, 20);
            this.dateNgaysinh.TabIndex = 8;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(322, 57);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(149, 20);
            this.txtDiachi.TabIndex = 7;
            // 
            // txtTendg
            // 
            this.txtTendg.Location = new System.Drawing.Point(99, 60);
            this.txtTendg.Name = "txtTendg";
            this.txtTendg.Size = new System.Drawing.Size(133, 20);
            this.txtTendg.TabIndex = 6;
            // 
            // txtMadg
            // 
            this.txtMadg.Location = new System.Drawing.Point(99, 27);
            this.txtMadg.Name = "txtMadg";
            this.txtMadg.Size = new System.Drawing.Size(133, 20);
            this.txtMadg.TabIndex = 4;
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Location = new System.Drawing.Point(257, 30);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(54, 13);
            this.lblNgaysinh.TabIndex = 3;
            this.lblNgaysinh.Text = "Ngày sinh";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(257, 60);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(40, 13);
            this.lblDiachi.TabIndex = 2;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // lblTendg
            // 
            this.lblTendg.AutoSize = true;
            this.lblTendg.Location = new System.Drawing.Point(16, 60);
            this.lblTendg.Name = "lblTendg";
            this.lblTendg.Size = new System.Drawing.Size(65, 13);
            this.lblTendg.TabIndex = 1;
            this.lblTendg.Text = "Tên độc giả";
            // 
            // lblMadg
            // 
            this.lblMadg.AutoSize = true;
            this.lblMadg.Location = new System.Drawing.Point(16, 30);
            this.lblMadg.Name = "lblMadg";
            this.lblMadg.Size = new System.Drawing.Size(61, 13);
            this.lblMadg.TabIndex = 0;
            this.lblMadg.Text = "Mã độc giả";
            // 
            // gbxTimKiemDG
            // 
            this.gbxTimKiemDG.Controls.Add(this.txtTimkiem);
            this.gbxTimKiemDG.Controls.Add(this.lblTimkiem);
            this.gbxTimKiemDG.Controls.Add(this.btnSearchDG);
            this.gbxTimKiemDG.Location = new System.Drawing.Point(12, 180);
            this.gbxTimKiemDG.Name = "gbxTimKiemDG";
            this.gbxTimKiemDG.Size = new System.Drawing.Size(490, 76);
            this.gbxTimKiemDG.TabIndex = 7;
            this.gbxTimKiemDG.TabStop = false;
            this.gbxTimKiemDG.Text = "Tìm kiếm thông tin";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(142, 35);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(176, 20);
            this.txtTimkiem.TabIndex = 8;
            this.txtTimkiem.Text = "Nhập thông tin cần tìm kiếm";
            this.txtTimkiem.Click += new System.EventHandler(this.txtTimkiem_Click);
            // 
            // lblTimkiem
            // 
            this.lblTimkiem.AutoSize = true;
            this.lblTimkiem.Location = new System.Drawing.Point(28, 38);
            this.lblTimkiem.Name = "lblTimkiem";
            this.lblTimkiem.Size = new System.Drawing.Size(88, 13);
            this.lblTimkiem.TabIndex = 4;
            this.lblTimkiem.Text = "Tìm kiếm độc giả";
            // 
            // lblThongtin
            // 
            this.lblThongtin.AutoSize = true;
            this.lblThongtin.Location = new System.Drawing.Point(228, 273);
            this.lblThongtin.Name = "lblThongtin";
            this.lblThongtin.Size = new System.Drawing.Size(91, 13);
            this.lblThongtin.TabIndex = 5;
            this.lblThongtin.Text = "Thông tin độc giả";
            // 
            // dgvDocgia
            // 
            this.dgvDocgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocgia.Location = new System.Drawing.Point(12, 305);
            this.dgvDocgia.Name = "dgvDocgia";
            this.dgvDocgia.Size = new System.Drawing.Size(490, 112);
            this.dgvDocgia.TabIndex = 8;
            this.dgvDocgia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocgia_CellClick);
            // 
            // FrmDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 429);
            this.Controls.Add(this.dgvDocgia);
            this.Controls.Add(this.lblThongtin);
            this.Controls.Add(this.gbxTimKiemDG);
            this.Controls.Add(this.gbxDocGia);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHome);
            this.Name = "FrmDocGia";
            this.Text = "DocGia";
            this.Load += new System.EventHandler(this.FrmDocGia_Load);
            this.gbxDocGia.ResumeLayout(false);
            this.gbxDocGia.PerformLayout();
            this.gbxTimKiemDG.ResumeLayout(false);
            this.gbxTimKiemDG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocgia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSearchDG;
        private System.Windows.Forms.GroupBox gbxDocGia;
        private System.Windows.Forms.GroupBox gbxTimKiemDG;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblTendg;
        private System.Windows.Forms.Label lblMadg;
        private System.Windows.Forms.Label lblTimkiem;
        private System.Windows.Forms.Label lblThongtin;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTendg;
        private System.Windows.Forms.TextBox txtMadg;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.DateTimePicker dateNgaysinh;
        private System.Windows.Forms.DataGridView dgvDocgia;
    }
}