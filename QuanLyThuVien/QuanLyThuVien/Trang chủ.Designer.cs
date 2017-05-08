namespace QuanLyThuVien
{
    partial class FrmTrangchu
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
            this.lbltrangchu = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HomeToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thủThưToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.độcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muontraToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuMượnTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtPhiếuMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýChiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thẻĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kệSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thểLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltrangchu
            // 
            this.lbltrangchu.AutoSize = true;
            this.lbltrangchu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrangchu.ForeColor = System.Drawing.Color.Blue;
            this.lbltrangchu.Location = new System.Drawing.Point(102, 34);
            this.lbltrangchu.Name = "lbltrangchu";
            this.lbltrangchu.Size = new System.Drawing.Size(328, 21);
            this.lbltrangchu.TabIndex = 0;
            this.lbltrangchu.Text = "CHƯƠNG TRÌNH QUẢN LÝ THƯ VIỆN";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeToolStrip,
            this.quảnLýDanhMụcToolStripMenuItem,
            this.muontraToolStrip,
            this.quảnLýChiTiếtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HomeToolStrip
            // 
            this.HomeToolStrip.Name = "HomeToolStrip";
            this.HomeToolStrip.Size = new System.Drawing.Size(72, 20);
            this.HomeToolStrip.Text = "Trang chủ";
            // 
            // quảnLýDanhMụcToolStripMenuItem
            // 
            this.quảnLýDanhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thủThưToolStripMenuItem,
            this.độcGiảToolStripMenuItem,
            this.sáchToolStripMenuItem});
            this.quảnLýDanhMụcToolStripMenuItem.Name = "quảnLýDanhMụcToolStripMenuItem";
            this.quảnLýDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.quảnLýDanhMụcToolStripMenuItem.Text = "Quản lý danh mục";
            // 
            // thủThưToolStripMenuItem
            // 
            this.thủThưToolStripMenuItem.Name = "thủThưToolStripMenuItem";
            this.thủThưToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.thủThưToolStripMenuItem.Text = "Thủ thư";
            this.thủThưToolStripMenuItem.Click += new System.EventHandler(this.thủThưToolStripMenuItem_Click);
            // 
            // độcGiảToolStripMenuItem
            // 
            this.độcGiảToolStripMenuItem.Name = "độcGiảToolStripMenuItem";
            this.độcGiảToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.độcGiảToolStripMenuItem.Text = "Độc giả";
            this.độcGiảToolStripMenuItem.Click += new System.EventHandler(this.độcGiảToolStripMenuItem_Click);
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.sáchToolStripMenuItem.Text = "Sách";
            this.sáchToolStripMenuItem.Click += new System.EventHandler(this.sáchToolStripMenuItem_Click);
            // 
            // muontraToolStrip
            // 
            this.muontraToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phiếuMượnTrảToolStripMenuItem,
            this.chiTiếtPhiếuMượnToolStripMenuItem});
            this.muontraToolStrip.Name = "muontraToolStrip";
            this.muontraToolStrip.Size = new System.Drawing.Size(112, 20);
            this.muontraToolStrip.Text = "Quản lý mượn trả";
            // 
            // phiếuMượnTrảToolStripMenuItem
            // 
            this.phiếuMượnTrảToolStripMenuItem.Name = "phiếuMượnTrảToolStripMenuItem";
            this.phiếuMượnTrảToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.phiếuMượnTrảToolStripMenuItem.Text = "Phiếu mượn trả";
            this.phiếuMượnTrảToolStripMenuItem.Click += new System.EventHandler(this.phiếuMượnTrảToolStripMenuItem_Click);
            // 
            // chiTiếtPhiếuMượnToolStripMenuItem
            // 
            this.chiTiếtPhiếuMượnToolStripMenuItem.Name = "chiTiếtPhiếuMượnToolStripMenuItem";
            this.chiTiếtPhiếuMượnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chiTiếtPhiếuMượnToolStripMenuItem.Text = "Chi tiết phiếu mượn";
            this.chiTiếtPhiếuMượnToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtPhiếuMượnToolStripMenuItem_Click);
            // 
            // quảnLýChiTiếtToolStripMenuItem
            // 
            this.quảnLýChiTiếtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thẻĐộcGiảToolStripMenuItem,
            this.kệSáchToolStripMenuItem,
            this.thểLoạiToolStripMenuItem});
            this.quảnLýChiTiếtToolStripMenuItem.Name = "quảnLýChiTiếtToolStripMenuItem";
            this.quảnLýChiTiếtToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.quảnLýChiTiếtToolStripMenuItem.Text = "Quản lý chi tiết";
            // 
            // thẻĐộcGiảToolStripMenuItem
            // 
            this.thẻĐộcGiảToolStripMenuItem.Name = "thẻĐộcGiảToolStripMenuItem";
            this.thẻĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.thẻĐộcGiảToolStripMenuItem.Text = "Thẻ độc giả";
            this.thẻĐộcGiảToolStripMenuItem.Click += new System.EventHandler(this.thẻĐộcGiảToolStripMenuItem_Click);
            // 
            // kệSáchToolStripMenuItem
            // 
            this.kệSáchToolStripMenuItem.Name = "kệSáchToolStripMenuItem";
            this.kệSáchToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.kệSáchToolStripMenuItem.Text = "Kệ sách";
            this.kệSáchToolStripMenuItem.Click += new System.EventHandler(this.kệSáchToolStripMenuItem_Click);
            // 
            // thểLoạiToolStripMenuItem
            // 
            this.thểLoạiToolStripMenuItem.Name = "thểLoạiToolStripMenuItem";
            this.thểLoạiToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.thểLoạiToolStripMenuItem.Text = "Thể loại";
            this.thểLoạiToolStripMenuItem.Click += new System.EventHandler(this.thểLoạiToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyThuVien.Properties.Resources.thuvien;
            this.pictureBox1.Location = new System.Drawing.Point(29, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 309);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmTrangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 392);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbltrangchu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmTrangchu";
            this.Text = "Trang chủ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltrangchu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStrip;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDanhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thủThưToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem độcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muontraToolStrip;
        private System.Windows.Forms.ToolStripMenuItem phiếuMượnTrảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtPhiếuMượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýChiTiếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thẻĐộcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kệSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thểLoạiToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

