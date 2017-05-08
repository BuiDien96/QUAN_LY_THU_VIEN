namespace QuanLyThuVien
{
    partial class FrmSach
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
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.lblMasach = new System.Windows.Forms.Label();
            this.gbxThongtinsach = new System.Windows.Forms.GroupBox();
            this.cbxMatheloai = new System.Windows.Forms.ComboBox();
            this.cbxVitri = new System.Windows.Forms.ComboBox();
            this.cbxMatt = new System.Windows.Forms.ComboBox();
            this.txtTinhtrang = new System.Windows.Forms.TextBox();
            this.txtTensach = new System.Windows.Forms.TextBox();
            this.txtMasach = new System.Windows.Forms.TextBox();
            this.lblMatheloai = new System.Windows.Forms.Label();
            this.lblVitri = new System.Windows.Forms.Label();
            this.lblMathuthu = new System.Windows.Forms.Label();
            this.lblTinhtrang = new System.Windows.Forms.Label();
            this.lblTensach = new System.Windows.Forms.Label();
            this.gbxTimkiemsach = new System.Windows.Forms.GroupBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.lblTimkiem = new System.Windows.Forms.Label();
            this.lblThongtin = new System.Windows.Forms.Label();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.gbxThongtinsach.SuspendLayout();
            this.gbxTimkiemsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Image = global::QuanLyThuVien.Properties.Resources.home_icon;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(24, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 36);
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
            this.btnThem.Location = new System.Drawing.Point(127, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 36);
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
            this.btnSua.Location = new System.Drawing.Point(234, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 36);
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
            this.btnXoa.Location = new System.Drawing.Point(351, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 36);
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
            this.btnLuu.Location = new System.Drawing.Point(476, 12);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 36);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Image = global::QuanLyThuVien.Properties.Resources.Search_icon11;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(500, 29);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 5;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // lblMasach
            // 
            this.lblMasach.AutoSize = true;
            this.lblMasach.Location = new System.Drawing.Point(29, 33);
            this.lblMasach.Name = "lblMasach";
            this.lblMasach.Size = new System.Drawing.Size(48, 13);
            this.lblMasach.TabIndex = 6;
            this.lblMasach.Text = "Mã sách";
            // 
            // gbxThongtinsach
            // 
            this.gbxThongtinsach.Controls.Add(this.cbxMatheloai);
            this.gbxThongtinsach.Controls.Add(this.cbxVitri);
            this.gbxThongtinsach.Controls.Add(this.cbxMatt);
            this.gbxThongtinsach.Controls.Add(this.txtTinhtrang);
            this.gbxThongtinsach.Controls.Add(this.txtTensach);
            this.gbxThongtinsach.Controls.Add(this.txtMasach);
            this.gbxThongtinsach.Controls.Add(this.lblMatheloai);
            this.gbxThongtinsach.Controls.Add(this.lblVitri);
            this.gbxThongtinsach.Controls.Add(this.lblMathuthu);
            this.gbxThongtinsach.Controls.Add(this.lblTinhtrang);
            this.gbxThongtinsach.Controls.Add(this.lblTensach);
            this.gbxThongtinsach.Controls.Add(this.lblMasach);
            this.gbxThongtinsach.Location = new System.Drawing.Point(12, 69);
            this.gbxThongtinsach.Name = "gbxThongtinsach";
            this.gbxThongtinsach.Size = new System.Drawing.Size(651, 135);
            this.gbxThongtinsach.TabIndex = 7;
            this.gbxThongtinsach.TabStop = false;
            this.gbxThongtinsach.Text = "Thông tin sách";
            // 
            // cbxMatheloai
            // 
            this.cbxMatheloai.FormattingEnabled = true;
            this.cbxMatheloai.Location = new System.Drawing.Point(418, 102);
            this.cbxMatheloai.Name = "cbxMatheloai";
            this.cbxMatheloai.Size = new System.Drawing.Size(196, 21);
            this.cbxMatheloai.TabIndex = 18;
            // 
            // cbxVitri
            // 
            this.cbxVitri.FormattingEnabled = true;
            this.cbxVitri.Location = new System.Drawing.Point(418, 65);
            this.cbxVitri.Name = "cbxVitri";
            this.cbxVitri.Size = new System.Drawing.Size(196, 21);
            this.cbxVitri.TabIndex = 17;
            // 
            // cbxMatt
            // 
            this.cbxMatt.FormattingEnabled = true;
            this.cbxMatt.Location = new System.Drawing.Point(418, 33);
            this.cbxMatt.Name = "cbxMatt";
            this.cbxMatt.Size = new System.Drawing.Size(196, 21);
            this.cbxMatt.TabIndex = 16;
            // 
            // txtTinhtrang
            // 
            this.txtTinhtrang.Location = new System.Drawing.Point(115, 102);
            this.txtTinhtrang.Name = "txtTinhtrang";
            this.txtTinhtrang.Size = new System.Drawing.Size(182, 20);
            this.txtTinhtrang.TabIndex = 15;
            // 
            // txtTensach
            // 
            this.txtTensach.Location = new System.Drawing.Point(115, 66);
            this.txtTensach.Name = "txtTensach";
            this.txtTensach.Size = new System.Drawing.Size(182, 20);
            this.txtTensach.TabIndex = 14;
            // 
            // txtMasach
            // 
            this.txtMasach.Location = new System.Drawing.Point(115, 33);
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.Size = new System.Drawing.Size(182, 20);
            this.txtMasach.TabIndex = 13;
            // 
            // lblMatheloai
            // 
            this.lblMatheloai.AutoSize = true;
            this.lblMatheloai.Location = new System.Drawing.Point(336, 102);
            this.lblMatheloai.Name = "lblMatheloai";
            this.lblMatheloai.Size = new System.Drawing.Size(59, 13);
            this.lblMatheloai.TabIndex = 12;
            this.lblMatheloai.Text = "Mã thể loại";
            // 
            // lblVitri
            // 
            this.lblVitri.AutoSize = true;
            this.lblVitri.Location = new System.Drawing.Point(336, 69);
            this.lblVitri.Name = "lblVitri";
            this.lblVitri.Size = new System.Drawing.Size(29, 13);
            this.lblVitri.TabIndex = 11;
            this.lblVitri.Text = "Vị trí";
            // 
            // lblMathuthu
            // 
            this.lblMathuthu.AutoSize = true;
            this.lblMathuthu.Location = new System.Drawing.Point(336, 33);
            this.lblMathuthu.Name = "lblMathuthu";
            this.lblMathuthu.Size = new System.Drawing.Size(58, 13);
            this.lblMathuthu.TabIndex = 10;
            this.lblMathuthu.Text = "Mã thủ thư";
            // 
            // lblTinhtrang
            // 
            this.lblTinhtrang.AutoSize = true;
            this.lblTinhtrang.Location = new System.Drawing.Point(29, 102);
            this.lblTinhtrang.Name = "lblTinhtrang";
            this.lblTinhtrang.Size = new System.Drawing.Size(55, 13);
            this.lblTinhtrang.TabIndex = 9;
            this.lblTinhtrang.Text = "Tình trạng";
            // 
            // lblTensach
            // 
            this.lblTensach.AutoSize = true;
            this.lblTensach.Location = new System.Drawing.Point(29, 69);
            this.lblTensach.Name = "lblTensach";
            this.lblTensach.Size = new System.Drawing.Size(52, 13);
            this.lblTensach.TabIndex = 8;
            this.lblTensach.Text = "Tên sách";
            // 
            // gbxTimkiemsach
            // 
            this.gbxTimkiemsach.Controls.Add(this.txtTimkiem);
            this.gbxTimkiemsach.Controls.Add(this.lblTimkiem);
            this.gbxTimkiemsach.Controls.Add(this.btnTimkiem);
            this.gbxTimkiemsach.Location = new System.Drawing.Point(12, 210);
            this.gbxTimkiemsach.Name = "gbxTimkiemsach";
            this.gbxTimkiemsach.Size = new System.Drawing.Size(651, 71);
            this.gbxTimkiemsach.TabIndex = 8;
            this.gbxTimkiemsach.TabStop = false;
            this.gbxTimkiemsach.Text = "Tìm kiếm thông tin";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(135, 29);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(279, 20);
            this.txtTimkiem.TabIndex = 14;
            this.txtTimkiem.Text = "Nhập thông tin cần tìm kiếm";
            this.txtTimkiem.Click += new System.EventHandler(this.txtTimkiem_Click);
            // 
            // lblTimkiem
            // 
            this.lblTimkiem.AutoSize = true;
            this.lblTimkiem.Location = new System.Drawing.Point(9, 29);
            this.lblTimkiem.Name = "lblTimkiem";
            this.lblTimkiem.Size = new System.Drawing.Size(93, 13);
            this.lblTimkiem.TabIndex = 13;
            this.lblTimkiem.Text = "Tìm kiếm tên sách";
            // 
            // lblThongtin
            // 
            this.lblThongtin.AutoSize = true;
            this.lblThongtin.Location = new System.Drawing.Point(277, 295);
            this.lblThongtin.Name = "lblThongtin";
            this.lblThongtin.Size = new System.Drawing.Size(78, 13);
            this.lblThongtin.TabIndex = 14;
            this.lblThongtin.Text = "Thông tin sách";
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(12, 332);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.Size = new System.Drawing.Size(651, 95);
            this.dgvSach.TabIndex = 15;
            this.dgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellClick);
            // 
            // FrmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 459);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.lblThongtin);
            this.Controls.Add(this.gbxTimkiemsach);
            this.Controls.Add(this.gbxThongtinsach);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHome);
            this.Name = "FrmSach";
            this.Text = "Sach";
            this.Load += new System.EventHandler(this.FrmSach_Load);
            this.gbxThongtinsach.ResumeLayout(false);
            this.gbxThongtinsach.PerformLayout();
            this.gbxTimkiemsach.ResumeLayout(false);
            this.gbxTimkiemsach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
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
        private System.Windows.Forms.Label lblMasach;
        private System.Windows.Forms.GroupBox gbxThongtinsach;
        private System.Windows.Forms.Label lblMatheloai;
        private System.Windows.Forms.Label lblVitri;
        private System.Windows.Forms.Label lblMathuthu;
        private System.Windows.Forms.Label lblTinhtrang;
        private System.Windows.Forms.Label lblTensach;
        private System.Windows.Forms.GroupBox gbxTimkiemsach;
        private System.Windows.Forms.Label lblTimkiem;
        private System.Windows.Forms.Label lblThongtin;
        private System.Windows.Forms.ComboBox cbxMatheloai;
        private System.Windows.Forms.ComboBox cbxVitri;
        private System.Windows.Forms.ComboBox cbxMatt;
        private System.Windows.Forms.TextBox txtTinhtrang;
        private System.Windows.Forms.TextBox txtTensach;
        private System.Windows.Forms.TextBox txtMasach;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.DataGridView dgvSach;
    }
}