namespace QuanLyThuVien
{
    partial class FrmKeSach
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
            this.gbxThongtinkesach = new System.Windows.Forms.GroupBox();
            this.cbxMatt = new System.Windows.Forms.ComboBox();
            this.txtSongan = new System.Windows.Forms.TextBox();
            this.txtVitri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxTimkiem = new System.Windows.Forms.GroupBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvKesach = new System.Windows.Forms.DataGridView();
            this.gbxThongtinkesach.SuspendLayout();
            this.gbxTimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKesach)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Image = global::QuanLyThuVien.Properties.Resources.home_icon;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(13, 1);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 35);
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
            this.btnThem.Location = new System.Drawing.Point(121, 1);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 35);
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
            this.btnSua.Location = new System.Drawing.Point(228, 1);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 35);
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
            this.btnXoa.Location = new System.Drawing.Point(332, 1);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 35);
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
            this.btnLuu.Location = new System.Drawing.Point(447, 1);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 35);
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
            this.btnTimkiem.Location = new System.Drawing.Point(392, 32);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 5;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // gbxThongtinkesach
            // 
            this.gbxThongtinkesach.Controls.Add(this.cbxMatt);
            this.gbxThongtinkesach.Controls.Add(this.txtSongan);
            this.gbxThongtinkesach.Controls.Add(this.txtVitri);
            this.gbxThongtinkesach.Controls.Add(this.label5);
            this.gbxThongtinkesach.Controls.Add(this.label2);
            this.gbxThongtinkesach.Controls.Add(this.label1);
            this.gbxThongtinkesach.Location = new System.Drawing.Point(12, 51);
            this.gbxThongtinkesach.Name = "gbxThongtinkesach";
            this.gbxThongtinkesach.Size = new System.Drawing.Size(547, 113);
            this.gbxThongtinkesach.TabIndex = 6;
            this.gbxThongtinkesach.TabStop = false;
            this.gbxThongtinkesach.Text = "Thông tin kệ sách";
            // 
            // cbxMatt
            // 
            this.cbxMatt.FormattingEnabled = true;
            this.cbxMatt.Location = new System.Drawing.Point(345, 37);
            this.cbxMatt.Name = "cbxMatt";
            this.cbxMatt.Size = new System.Drawing.Size(165, 21);
            this.cbxMatt.TabIndex = 5;
            // 
            // txtSongan
            // 
            this.txtSongan.Location = new System.Drawing.Point(99, 65);
            this.txtSongan.Name = "txtSongan";
            this.txtSongan.Size = new System.Drawing.Size(162, 20);
            this.txtSongan.TabIndex = 4;
            // 
            // txtVitri
            // 
            this.txtVitri.Location = new System.Drawing.Point(99, 28);
            this.txtVitri.Name = "txtVitri";
            this.txtVitri.Size = new System.Drawing.Size(162, 20);
            this.txtVitri.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã thủ thư";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số ngăn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vị trí";
            // 
            // gbxTimkiem
            // 
            this.gbxTimkiem.Controls.Add(this.txtTimkiem);
            this.gbxTimkiem.Controls.Add(this.label3);
            this.gbxTimkiem.Controls.Add(this.btnTimkiem);
            this.gbxTimkiem.Location = new System.Drawing.Point(13, 182);
            this.gbxTimkiem.Name = "gbxTimkiem";
            this.gbxTimkiem.Size = new System.Drawing.Size(546, 69);
            this.gbxTimkiem.TabIndex = 7;
            this.gbxTimkiem.TabStop = false;
            this.gbxTimkiem.Text = "Tìm kiếm";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(85, 35);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(218, 20);
            this.txtTimkiem.TabIndex = 5;
            this.txtTimkiem.Text = "Nhập thông tin cần tìm kiếm...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tìm kiếm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thông tin kệ sách";
            // 
            // dgvKesach
            // 
            this.dgvKesach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKesach.Location = new System.Drawing.Point(12, 295);
            this.dgvKesach.Name = "dgvKesach";
            this.dgvKesach.Size = new System.Drawing.Size(547, 84);
            this.dgvKesach.TabIndex = 8;
            this.dgvKesach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKesach_CellClick);
            // 
            // FrmKeSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 391);
            this.Controls.Add(this.dgvKesach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbxTimkiem);
            this.Controls.Add(this.gbxThongtinkesach);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHome);
            this.Name = "FrmKeSach";
            this.Text = "Kệ Sách";
            this.Load += new System.EventHandler(this.FrmKeSach_Load);
            this.gbxThongtinkesach.ResumeLayout(false);
            this.gbxThongtinkesach.PerformLayout();
            this.gbxTimkiem.ResumeLayout(false);
            this.gbxTimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKesach)).EndInit();
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
        private System.Windows.Forms.GroupBox gbxThongtinkesach;
        private System.Windows.Forms.GroupBox gbxTimkiem;
        private System.Windows.Forms.ComboBox cbxMatt;
        private System.Windows.Forms.TextBox txtSongan;
        private System.Windows.Forms.TextBox txtVitri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvKesach;
    }
}