using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.BusinessLogicLayer;
using QuanLyThuVien.DataAccessLayer;
using QuanLyThuVien.Model;
using System.Data;

namespace QuanLyThuVien
{
    public partial class FrmTrangchu : Form
    {
        public FrmTrangchu()
        {
            InitializeComponent();
        }

        private void thủThưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThuThu thuthu = new FrmThuThu();
            thuthu.Show();
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDocGia docgia = new FrmDocGia();
            docgia.Show();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSach sach = new FrmSach();
            sach.Show();
        }

        private void thẻĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTheDocGia thedg = new FrmTheDocGia();
            thedg.Show();
        }

        private void kệSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKeSach kesach = new FrmKeSach();
            kesach.Show();
        }

        private void phiếuMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhieuMuonTra phieumt = new FrmPhieuMuonTra();
            phieumt.Show();
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTheLoai theloai = new FrmTheLoai();
            theloai.Show();
        }

        private void chiTiếtPhiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChiTietPhieuMuon chitietphieumuon = new FrmChiTietPhieuMuon();
            chitietphieumuon.Show();
        }
    }
}
