namespace QuanLyThuVien
{
    partial class FrmChiTietPhieuMuon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxMaphieu = new System.Windows.Forms.ComboBox();
            this.cbxMasach = new System.Windows.Forms.ComboBox();
            this.txtTinhtrangsau = new System.Windows.Forms.TextBox();
            this.txtTinhtrangtruoc = new System.Windows.Forms.TextBox();
            this.lblTinhtrangsau = new System.Windows.Forms.Label();
            this.lblTinhtrangtruoc = new System.Windows.Forms.Label();
            this.lblMaphieu = new System.Windows.Forms.Label();
            this.lblMasach = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.lblTimkiem = new System.Windows.Forms.Label();
            this.lblThongtin = new System.Windows.Forms.Label();
            this.dgvChitietphieumuon = new System.Windows.Forms.DataGridView();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitietphieumuon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxMaphieu);
            this.groupBox1.Controls.Add(this.cbxMasach);
            this.groupBox1.Controls.Add(this.txtTinhtrangsau);
            this.groupBox1.Controls.Add(this.txtTinhtrangtruoc);
            this.groupBox1.Controls.Add(this.lblTinhtrangsau);
            this.groupBox1.Controls.Add(this.lblTinhtrangtruoc);
            this.groupBox1.Controls.Add(this.lblMaphieu);
            this.groupBox1.Controls.Add(this.lblMasach);
            this.groupBox1.Location = new System.Drawing.Point(8, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 132);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu mượn";
            // 
            // cbxMaphieu
            // 
            this.cbxMaphieu.FormattingEnabled = true;
            this.cbxMaphieu.Location = new System.Drawing.Point(78, 84);
            this.cbxMaphieu.Name = "cbxMaphieu";
            this.cbxMaphieu.Size = new System.Drawing.Size(152, 21);
            this.cbxMaphieu.TabIndex = 7;
            // 
            // cbxMasach
            // 
            this.cbxMasach.FormattingEnabled = true;
            this.cbxMasach.Location = new System.Drawing.Point(78, 31);
            this.cbxMasach.Name = "cbxMasach";
            this.cbxMasach.Size = new System.Drawing.Size(152, 21);
            this.cbxMasach.TabIndex = 6;
            // 
            // txtTinhtrangsau
            // 
            this.txtTinhtrangsau.Location = new System.Drawing.Point(337, 81);
            this.txtTinhtrangsau.Name = "txtTinhtrangsau";
            this.txtTinhtrangsau.Size = new System.Drawing.Size(148, 20);
            this.txtTinhtrangsau.TabIndex = 5;
            // 
            // txtTinhtrangtruoc
            // 
            this.txtTinhtrangtruoc.Location = new System.Drawing.Point(337, 34);
            this.txtTinhtrangtruoc.Name = "txtTinhtrangtruoc";
            this.txtTinhtrangtruoc.Size = new System.Drawing.Size(148, 20);
            this.txtTinhtrangtruoc.TabIndex = 4;
            // 
            // lblTinhtrangsau
            // 
            this.lblTinhtrangsau.AutoSize = true;
            this.lblTinhtrangsau.Location = new System.Drawing.Point(236, 88);
            this.lblTinhtrangsau.Name = "lblTinhtrangsau";
            this.lblTinhtrangsau.Size = new System.Drawing.Size(75, 13);
            this.lblTinhtrangsau.TabIndex = 3;
            this.lblTinhtrangsau.Text = "Tình trạng sau";
            // 
            // lblTinhtrangtruoc
            // 
            this.lblTinhtrangtruoc.AutoSize = true;
            this.lblTinhtrangtruoc.Location = new System.Drawing.Point(236, 34);
            this.lblTinhtrangtruoc.Name = "lblTinhtrangtruoc";
            this.lblTinhtrangtruoc.Size = new System.Drawing.Size(82, 13);
            this.lblTinhtrangtruoc.TabIndex = 2;
            this.lblTinhtrangtruoc.Text = "Tình trạng trước";
            // 
            // lblMaphieu
            // 
            this.lblMaphieu.AutoSize = true;
            this.lblMaphieu.Location = new System.Drawing.Point(21, 84);
            this.lblMaphieu.Name = "lblMaphieu";
            this.lblMaphieu.Size = new System.Drawing.Size(51, 13);
            this.lblMaphieu.TabIndex = 1;
            this.lblMaphieu.Text = "Mã phiếu";
            // 
            // lblMasach
            // 
            this.lblMasach.AutoSize = true;
            this.lblMasach.Location = new System.Drawing.Point(21, 34);
            this.lblMasach.Name = "lblMasach";
            this.lblMasach.Size = new System.Drawing.Size(48, 13);
            this.lblMasach.TabIndex = 0;
            this.lblMasach.Text = "Mã sách";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTimkiem);
            this.groupBox2.Controls.Add(this.lblTimkiem);
            this.groupBox2.Controls.Add(this.btnTimkiem);
            this.groupBox2.Location = new System.Drawing.Point(8, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 66);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(101, 26);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(265, 20);
            this.txtTimkiem.TabIndex = 6;
            this.txtTimkiem.Text = "Nhập thông tin tìm kiếm...";
            this.txtTimkiem.Click += new System.EventHandler(this.txtTimkiem_Click);
            // 
            // lblTimkiem
            // 
            this.lblTimkiem.AutoSize = true;
            this.lblTimkiem.Location = new System.Drawing.Point(21, 29);
            this.lblTimkiem.Name = "lblTimkiem";
            this.lblTimkiem.Size = new System.Drawing.Size(49, 13);
            this.lblTimkiem.TabIndex = 4;
            this.lblTimkiem.Text = "Tìm kiếm";
            // 
            // lblThongtin
            // 
            this.lblThongtin.AutoSize = true;
            this.lblThongtin.Location = new System.Drawing.Point(202, 276);
            this.lblThongtin.Name = "lblThongtin";
            this.lblThongtin.Size = new System.Drawing.Size(110, 13);
            this.lblThongtin.TabIndex = 5;
            this.lblThongtin.Text = "Thông tin phiếu mượn";
            // 
            // dgvChitietphieumuon
            // 
            this.dgvChitietphieumuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChitietphieumuon.Location = new System.Drawing.Point(8, 301);
            this.dgvChitietphieumuon.Name = "dgvChitietphieumuon";
            this.dgvChitietphieumuon.Size = new System.Drawing.Size(500, 105);
            this.dgvChitietphieumuon.TabIndex = 8;
            this.dgvChitietphieumuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChitietphieumuon_CellClick);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Image = global::QuanLyThuVien.Properties.Resources.Search_icon11;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(405, 26);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(80, 23);
            this.btnTimkiem.TabIndex = 5;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLyThuVien.Properties.Resources.Save_icon;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(413, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 32);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyThuVien.Properties.Resources.Delete_icon;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(299, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 32);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyThuVien.Properties.Resources.edit_icon;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(205, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 32);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyThuVien.Properties.Resources.Add_icon;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(109, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 32);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = global::QuanLyThuVien.Properties.Resources.home_icon;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 32);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // FrmChiTietPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 409);
            this.Controls.Add(this.dgvChitietphieumuon);
            this.Controls.Add(this.lblThongtin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHome);
            this.Name = "FrmChiTietPhieuMuon";
            this.Text = "Chi tiết phiếu mượn";
            this.Load += new System.EventHandler(this.FrmChiTietPhieuMuon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitietphieumuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTinhtrangsau;
        private System.Windows.Forms.Label lblTinhtrangtruoc;
        private System.Windows.Forms.Label lblMaphieu;
        private System.Windows.Forms.Label lblMasach;
        private System.Windows.Forms.Label lblTimkiem;
        private System.Windows.Forms.Label lblThongtin;
        private System.Windows.Forms.ComboBox cbxMaphieu;
        private System.Windows.Forms.ComboBox cbxMasach;
        private System.Windows.Forms.TextBox txtTinhtrangsau;
        private System.Windows.Forms.TextBox txtTinhtrangtruoc;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.DataGridView dgvChitietphieumuon;
    }
}