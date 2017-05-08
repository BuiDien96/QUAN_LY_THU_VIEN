namespace QuanLyThuVien
{
    partial class FrmTheDocGia
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
            this.gbxThongtinthedocgia = new System.Windows.Forms.GroupBox();
            this.cbxMadg = new System.Windows.Forms.ComboBox();
            this.cbxMatt = new System.Windows.Forms.ComboBox();
            this.dateNgayhethan = new System.Windows.Forms.DateTimePicker();
            this.dateNgaylam = new System.Windows.Forms.DateTimePicker();
            this.lblMatt = new System.Windows.Forms.Label();
            this.lblMadg = new System.Windows.Forms.Label();
            this.lblNgayhethan = new System.Windows.Forms.Label();
            this.lblNgaylam = new System.Windows.Forms.Label();
            this.lblMathe = new System.Windows.Forms.Label();
            this.txtMathe = new System.Windows.Forms.TextBox();
            this.gbxTimkiem = new System.Windows.Forms.GroupBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.lblTimkiem = new System.Windows.Forms.Label();
            this.lblThongtin = new System.Windows.Forms.Label();
            this.dgvThedocgia = new System.Windows.Forms.DataGridView();
            this.gbxThongtinthedocgia.SuspendLayout();
            this.gbxTimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThedocgia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Image = global::QuanLyThuVien.Properties.Resources.home_icon;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(23, 12);
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
            this.btnThem.Location = new System.Drawing.Point(119, 12);
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
            this.btnSua.Location = new System.Drawing.Point(210, 12);
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
            this.btnXoa.Location = new System.Drawing.Point(303, 12);
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
            this.btnLuu.Location = new System.Drawing.Point(407, 12);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 33);
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
            this.btnTimkiem.Location = new System.Drawing.Point(465, 34);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 5;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // gbxThongtinthedocgia
            // 
            this.gbxThongtinthedocgia.Controls.Add(this.cbxMadg);
            this.gbxThongtinthedocgia.Controls.Add(this.cbxMatt);
            this.gbxThongtinthedocgia.Controls.Add(this.dateNgayhethan);
            this.gbxThongtinthedocgia.Controls.Add(this.dateNgaylam);
            this.gbxThongtinthedocgia.Controls.Add(this.lblMatt);
            this.gbxThongtinthedocgia.Controls.Add(this.lblMadg);
            this.gbxThongtinthedocgia.Controls.Add(this.lblNgayhethan);
            this.gbxThongtinthedocgia.Controls.Add(this.lblNgaylam);
            this.gbxThongtinthedocgia.Controls.Add(this.lblMathe);
            this.gbxThongtinthedocgia.Controls.Add(this.txtMathe);
            this.gbxThongtinthedocgia.Location = new System.Drawing.Point(12, 51);
            this.gbxThongtinthedocgia.Name = "gbxThongtinthedocgia";
            this.gbxThongtinthedocgia.Size = new System.Drawing.Size(598, 131);
            this.gbxThongtinthedocgia.TabIndex = 6;
            this.gbxThongtinthedocgia.TabStop = false;
            this.gbxThongtinthedocgia.Text = "Thông tin thẻ độc giả";
            // 
            // cbxMadg
            // 
            this.cbxMadg.FormattingEnabled = true;
            this.cbxMadg.Location = new System.Drawing.Point(419, 76);
            this.cbxMadg.Name = "cbxMadg";
            this.cbxMadg.Size = new System.Drawing.Size(160, 21);
            this.cbxMadg.TabIndex = 9;
            // 
            // cbxMatt
            // 
            this.cbxMatt.FormattingEnabled = true;
            this.cbxMatt.Location = new System.Drawing.Point(419, 29);
            this.cbxMatt.Name = "cbxMatt";
            this.cbxMatt.Size = new System.Drawing.Size(160, 21);
            this.cbxMatt.TabIndex = 8;
            // 
            // dateNgayhethan
            // 
            this.dateNgayhethan.Location = new System.Drawing.Point(122, 89);
            this.dateNgayhethan.Name = "dateNgayhethan";
            this.dateNgayhethan.Size = new System.Drawing.Size(189, 20);
            this.dateNgayhethan.TabIndex = 7;
            // 
            // dateNgaylam
            // 
            this.dateNgaylam.Location = new System.Drawing.Point(122, 56);
            this.dateNgaylam.Name = "dateNgaylam";
            this.dateNgaylam.Size = new System.Drawing.Size(189, 20);
            this.dateNgaylam.TabIndex = 6;
            // 
            // lblMatt
            // 
            this.lblMatt.AutoSize = true;
            this.lblMatt.Location = new System.Drawing.Point(338, 29);
            this.lblMatt.Name = "lblMatt";
            this.lblMatt.Size = new System.Drawing.Size(58, 13);
            this.lblMatt.TabIndex = 5;
            this.lblMatt.Text = "Mã thủ thư";
            // 
            // lblMadg
            // 
            this.lblMadg.AutoSize = true;
            this.lblMadg.Location = new System.Drawing.Point(338, 79);
            this.lblMadg.Name = "lblMadg";
            this.lblMadg.Size = new System.Drawing.Size(61, 13);
            this.lblMadg.TabIndex = 4;
            this.lblMadg.Text = "Mã độc giả";
            // 
            // lblNgayhethan
            // 
            this.lblNgayhethan.AutoSize = true;
            this.lblNgayhethan.Location = new System.Drawing.Point(24, 95);
            this.lblNgayhethan.Name = "lblNgayhethan";
            this.lblNgayhethan.Size = new System.Drawing.Size(71, 13);
            this.lblNgayhethan.TabIndex = 3;
            this.lblNgayhethan.Text = "Ngày hết hạn";
            // 
            // lblNgaylam
            // 
            this.lblNgaylam.AutoSize = true;
            this.lblNgaylam.Location = new System.Drawing.Point(24, 56);
            this.lblNgaylam.Name = "lblNgaylam";
            this.lblNgaylam.Size = new System.Drawing.Size(51, 13);
            this.lblNgaylam.TabIndex = 2;
            this.lblNgaylam.Text = "Ngày làm";
            // 
            // lblMathe
            // 
            this.lblMathe.AutoSize = true;
            this.lblMathe.Location = new System.Drawing.Point(24, 25);
            this.lblMathe.Name = "lblMathe";
            this.lblMathe.Size = new System.Drawing.Size(40, 13);
            this.lblMathe.TabIndex = 1;
            this.lblMathe.Text = "Mã thẻ";
            // 
            // txtMathe
            // 
            this.txtMathe.Location = new System.Drawing.Point(122, 22);
            this.txtMathe.Name = "txtMathe";
            this.txtMathe.Size = new System.Drawing.Size(189, 20);
            this.txtMathe.TabIndex = 0;
            // 
            // gbxTimkiem
            // 
            this.gbxTimkiem.Controls.Add(this.txtTimkiem);
            this.gbxTimkiem.Controls.Add(this.lblTimkiem);
            this.gbxTimkiem.Controls.Add(this.btnTimkiem);
            this.gbxTimkiem.Location = new System.Drawing.Point(12, 188);
            this.gbxTimkiem.Name = "gbxTimkiem";
            this.gbxTimkiem.Size = new System.Drawing.Size(598, 84);
            this.gbxTimkiem.TabIndex = 7;
            this.gbxTimkiem.TabStop = false;
            this.gbxTimkiem.Text = "Tìm kiếm";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(131, 36);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(235, 20);
            this.txtTimkiem.TabIndex = 7;
            this.txtTimkiem.Text = "Nhập thông tin cần tìm kiếm...";
            this.txtTimkiem.Click += new System.EventHandler(this.txtTimkiem_Click);
            // 
            // lblTimkiem
            // 
            this.lblTimkiem.AutoSize = true;
            this.lblTimkiem.Location = new System.Drawing.Point(29, 39);
            this.lblTimkiem.Name = "lblTimkiem";
            this.lblTimkiem.Size = new System.Drawing.Size(49, 13);
            this.lblTimkiem.TabIndex = 6;
            this.lblTimkiem.Text = "Tìm kiếm";
            // 
            // lblThongtin
            // 
            this.lblThongtin.AutoSize = true;
            this.lblThongtin.Location = new System.Drawing.Point(225, 286);
            this.lblThongtin.Name = "lblThongtin";
            this.lblThongtin.Size = new System.Drawing.Size(109, 13);
            this.lblThongtin.TabIndex = 7;
            this.lblThongtin.Text = "Thông tin thẻ độc giả";
            // 
            // dgvThedocgia
            // 
            this.dgvThedocgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThedocgia.Location = new System.Drawing.Point(12, 312);
            this.dgvThedocgia.Name = "dgvThedocgia";
            this.dgvThedocgia.Size = new System.Drawing.Size(598, 94);
            this.dgvThedocgia.TabIndex = 8;
            this.dgvThedocgia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThedocgia_CellClick);
            // 
            // FrmTheDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 418);
            this.Controls.Add(this.dgvThedocgia);
            this.Controls.Add(this.lblThongtin);
            this.Controls.Add(this.gbxTimkiem);
            this.Controls.Add(this.gbxThongtinthedocgia);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHome);
            this.Name = "FrmTheDocGia";
            this.Text = "TheDocGia";
            this.Load += new System.EventHandler(this.FrmTheDocGia_Load);
            this.gbxThongtinthedocgia.ResumeLayout(false);
            this.gbxThongtinthedocgia.PerformLayout();
            this.gbxTimkiem.ResumeLayout(false);
            this.gbxTimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThedocgia)).EndInit();
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
        private System.Windows.Forms.GroupBox gbxThongtinthedocgia;
        private System.Windows.Forms.TextBox txtMathe;
        private System.Windows.Forms.GroupBox gbxTimkiem;
        private System.Windows.Forms.ComboBox cbxMadg;
        private System.Windows.Forms.ComboBox cbxMatt;
        private System.Windows.Forms.DateTimePicker dateNgayhethan;
        private System.Windows.Forms.DateTimePicker dateNgaylam;
        private System.Windows.Forms.Label lblMatt;
        private System.Windows.Forms.Label lblMadg;
        private System.Windows.Forms.Label lblNgayhethan;
        private System.Windows.Forms.Label lblNgaylam;
        private System.Windows.Forms.Label lblMathe;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label lblTimkiem;
        private System.Windows.Forms.Label lblThongtin;
        private System.Windows.Forms.DataGridView dgvThedocgia;
    }
}