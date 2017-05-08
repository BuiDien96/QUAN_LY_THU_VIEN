namespace QuanLyThuVien
{
    partial class FrmPhieuMuonTra
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
            this.gbxThongtinphieumt = new System.Windows.Forms.GroupBox();
            this.dateNgayhentra = new System.Windows.Forms.DateTimePicker();
            this.dateNgaytra = new System.Windows.Forms.DateTimePicker();
            this.dateNgaymuon = new System.Windows.Forms.DateTimePicker();
            this.cbxMadg = new System.Windows.Forms.ComboBox();
            this.cbxMatt = new System.Windows.Forms.ComboBox();
            this.txtMaphieu = new System.Windows.Forms.TextBox();
            this.lblMadg = new System.Windows.Forms.Label();
            this.lblMatt = new System.Windows.Forms.Label();
            this.lblNgayhentra = new System.Windows.Forms.Label();
            this.lblNgaytra = new System.Windows.Forms.Label();
            this.lblNgaymuon = new System.Windows.Forms.Label();
            this.lblMaphieu = new System.Windows.Forms.Label();
            this.gbxTimkiem = new System.Windows.Forms.GroupBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.lblTimkiem = new System.Windows.Forms.Label();
            this.lblThongtin = new System.Windows.Forms.Label();
            this.dgvPhieumuontra = new System.Windows.Forms.DataGridView();
            this.gbxThongtinphieumt.SuspendLayout();
            this.gbxTimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieumuontra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Image = global::QuanLyThuVien.Properties.Resources.home_icon;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(13, 5);
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
            this.btnThem.Location = new System.Drawing.Point(118, 5);
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
            this.btnSua.Location = new System.Drawing.Point(243, 5);
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
            this.btnXoa.Location = new System.Drawing.Point(352, 5);
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
            this.btnLuu.Location = new System.Drawing.Point(483, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 31);
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
            this.btnTimkiem.Location = new System.Drawing.Point(470, 34);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 5;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // gbxThongtinphieumt
            // 
            this.gbxThongtinphieumt.Controls.Add(this.dateNgayhentra);
            this.gbxThongtinphieumt.Controls.Add(this.dateNgaytra);
            this.gbxThongtinphieumt.Controls.Add(this.dateNgaymuon);
            this.gbxThongtinphieumt.Controls.Add(this.cbxMadg);
            this.gbxThongtinphieumt.Controls.Add(this.cbxMatt);
            this.gbxThongtinphieumt.Controls.Add(this.txtMaphieu);
            this.gbxThongtinphieumt.Controls.Add(this.lblMadg);
            this.gbxThongtinphieumt.Controls.Add(this.lblMatt);
            this.gbxThongtinphieumt.Controls.Add(this.lblNgayhentra);
            this.gbxThongtinphieumt.Controls.Add(this.lblNgaytra);
            this.gbxThongtinphieumt.Controls.Add(this.lblNgaymuon);
            this.gbxThongtinphieumt.Controls.Add(this.lblMaphieu);
            this.gbxThongtinphieumt.Location = new System.Drawing.Point(13, 58);
            this.gbxThongtinphieumt.Name = "gbxThongtinphieumt";
            this.gbxThongtinphieumt.Size = new System.Drawing.Size(612, 167);
            this.gbxThongtinphieumt.TabIndex = 6;
            this.gbxThongtinphieumt.TabStop = false;
            this.gbxThongtinphieumt.Text = "Thông tin phiếu mượn trả";
            // 
            // dateNgayhentra
            // 
            this.dateNgayhentra.Location = new System.Drawing.Point(399, 126);
            this.dateNgayhentra.Name = "dateNgayhentra";
            this.dateNgayhentra.Size = new System.Drawing.Size(187, 20);
            this.dateNgayhentra.TabIndex = 11;
            // 
            // dateNgaytra
            // 
            this.dateNgaytra.Location = new System.Drawing.Point(399, 79);
            this.dateNgaytra.Name = "dateNgaytra";
            this.dateNgaytra.Size = new System.Drawing.Size(187, 20);
            this.dateNgaytra.TabIndex = 10;
            // 
            // dateNgaymuon
            // 
            this.dateNgaymuon.Location = new System.Drawing.Point(399, 32);
            this.dateNgaymuon.Name = "dateNgaymuon";
            this.dateNgaymuon.Size = new System.Drawing.Size(187, 20);
            this.dateNgaymuon.TabIndex = 9;
            // 
            // cbxMadg
            // 
            this.cbxMadg.FormattingEnabled = true;
            this.cbxMadg.Location = new System.Drawing.Point(118, 126);
            this.cbxMadg.Name = "cbxMadg";
            this.cbxMadg.Size = new System.Drawing.Size(169, 21);
            this.cbxMadg.TabIndex = 8;
            // 
            // cbxMatt
            // 
            this.cbxMatt.FormattingEnabled = true;
            this.cbxMatt.Location = new System.Drawing.Point(118, 78);
            this.cbxMatt.Name = "cbxMatt";
            this.cbxMatt.Size = new System.Drawing.Size(169, 21);
            this.cbxMatt.TabIndex = 7;
            // 
            // txtMaphieu
            // 
            this.txtMaphieu.Location = new System.Drawing.Point(118, 35);
            this.txtMaphieu.Name = "txtMaphieu";
            this.txtMaphieu.Size = new System.Drawing.Size(169, 20);
            this.txtMaphieu.TabIndex = 6;
            // 
            // lblMadg
            // 
            this.lblMadg.AutoSize = true;
            this.lblMadg.Location = new System.Drawing.Point(33, 129);
            this.lblMadg.Name = "lblMadg";
            this.lblMadg.Size = new System.Drawing.Size(61, 13);
            this.lblMadg.TabIndex = 5;
            this.lblMadg.Text = "Mã độc giả";
            // 
            // lblMatt
            // 
            this.lblMatt.AutoSize = true;
            this.lblMatt.Location = new System.Drawing.Point(33, 78);
            this.lblMatt.Name = "lblMatt";
            this.lblMatt.Size = new System.Drawing.Size(58, 13);
            this.lblMatt.TabIndex = 4;
            this.lblMatt.Text = "Mã thủ thư";
            // 
            // lblNgayhentra
            // 
            this.lblNgayhentra.AutoSize = true;
            this.lblNgayhentra.Location = new System.Drawing.Point(308, 129);
            this.lblNgayhentra.Name = "lblNgayhentra";
            this.lblNgayhentra.Size = new System.Drawing.Size(68, 13);
            this.lblNgayhentra.TabIndex = 3;
            this.lblNgayhentra.Text = "Ngày hẹn trả";
            // 
            // lblNgaytra
            // 
            this.lblNgaytra.AutoSize = true;
            this.lblNgaytra.Location = new System.Drawing.Point(308, 78);
            this.lblNgaytra.Name = "lblNgaytra";
            this.lblNgaytra.Size = new System.Drawing.Size(47, 13);
            this.lblNgaytra.TabIndex = 2;
            this.lblNgaytra.Text = "Ngày trả";
            // 
            // lblNgaymuon
            // 
            this.lblNgaymuon.AutoSize = true;
            this.lblNgaymuon.Location = new System.Drawing.Point(308, 35);
            this.lblNgaymuon.Name = "lblNgaymuon";
            this.lblNgaymuon.Size = new System.Drawing.Size(61, 13);
            this.lblNgaymuon.TabIndex = 1;
            this.lblNgaymuon.Text = "Ngày mượn";
            // 
            // lblMaphieu
            // 
            this.lblMaphieu.AutoSize = true;
            this.lblMaphieu.Location = new System.Drawing.Point(33, 35);
            this.lblMaphieu.Name = "lblMaphieu";
            this.lblMaphieu.Size = new System.Drawing.Size(51, 13);
            this.lblMaphieu.TabIndex = 0;
            this.lblMaphieu.Text = "Mã phiếu";
            // 
            // gbxTimkiem
            // 
            this.gbxTimkiem.Controls.Add(this.txtTimkiem);
            this.gbxTimkiem.Controls.Add(this.lblTimkiem);
            this.gbxTimkiem.Controls.Add(this.btnTimkiem);
            this.gbxTimkiem.Location = new System.Drawing.Point(13, 242);
            this.gbxTimkiem.Name = "gbxTimkiem";
            this.gbxTimkiem.Size = new System.Drawing.Size(612, 74);
            this.gbxTimkiem.TabIndex = 7;
            this.gbxTimkiem.TabStop = false;
            this.gbxTimkiem.Text = "Tìm kiếm";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(135, 34);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(257, 20);
            this.txtTimkiem.TabIndex = 7;
            this.txtTimkiem.Click += new System.EventHandler(this.txtTimkiem_Click);
            // 
            // lblTimkiem
            // 
            this.lblTimkiem.AutoSize = true;
            this.lblTimkiem.Location = new System.Drawing.Point(33, 34);
            this.lblTimkiem.Name = "lblTimkiem";
            this.lblTimkiem.Size = new System.Drawing.Size(49, 13);
            this.lblTimkiem.TabIndex = 6;
            this.lblTimkiem.Text = "Tìm kiếm";
            // 
            // lblThongtin
            // 
            this.lblThongtin.AutoSize = true;
            this.lblThongtin.Location = new System.Drawing.Point(274, 333);
            this.lblThongtin.Name = "lblThongtin";
            this.lblThongtin.Size = new System.Drawing.Size(121, 13);
            this.lblThongtin.TabIndex = 7;
            this.lblThongtin.Text = "thông tin phiếu mượn trả";
            // 
            // dgvPhieumuontra
            // 
            this.dgvPhieumuontra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieumuontra.Location = new System.Drawing.Point(13, 354);
            this.dgvPhieumuontra.Name = "dgvPhieumuontra";
            this.dgvPhieumuontra.Size = new System.Drawing.Size(612, 99);
            this.dgvPhieumuontra.TabIndex = 8;
            this.dgvPhieumuontra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieumuontra_CellClick);
            // 
            // FrmPhieuMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 465);
            this.Controls.Add(this.dgvPhieumuontra);
            this.Controls.Add(this.lblThongtin);
            this.Controls.Add(this.gbxTimkiem);
            this.Controls.Add(this.gbxThongtinphieumt);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHome);
            this.Name = "FrmPhieuMuonTra";
            this.Text = "Phiếu mượn trả";
            this.Load += new System.EventHandler(this.FrmPhieuMuonTra_Load);
            this.gbxThongtinphieumt.ResumeLayout(false);
            this.gbxThongtinphieumt.PerformLayout();
            this.gbxTimkiem.ResumeLayout(false);
            this.gbxTimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieumuontra)).EndInit();
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
        private System.Windows.Forms.GroupBox gbxThongtinphieumt;
        private System.Windows.Forms.GroupBox gbxTimkiem;
        private System.Windows.Forms.DateTimePicker dateNgayhentra;
        private System.Windows.Forms.DateTimePicker dateNgaytra;
        private System.Windows.Forms.DateTimePicker dateNgaymuon;
        private System.Windows.Forms.ComboBox cbxMadg;
        private System.Windows.Forms.ComboBox cbxMatt;
        private System.Windows.Forms.TextBox txtMaphieu;
        private System.Windows.Forms.Label lblMadg;
        private System.Windows.Forms.Label lblMatt;
        private System.Windows.Forms.Label lblNgayhentra;
        private System.Windows.Forms.Label lblNgaytra;
        private System.Windows.Forms.Label lblNgaymuon;
        private System.Windows.Forms.Label lblMaphieu;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label lblTimkiem;
        private System.Windows.Forms.Label lblThongtin;
        private System.Windows.Forms.DataGridView dgvPhieumuontra;
    }
}