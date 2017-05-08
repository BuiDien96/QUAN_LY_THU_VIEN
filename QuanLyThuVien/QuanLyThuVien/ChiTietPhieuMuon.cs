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
using QuanLyThuVien.Model;

namespace QuanLyThuVien
{
    public partial class FrmChiTietPhieuMuon : Form
    {
        public FrmChiTietPhieuMuon()
        {
            InitializeComponent();
        }

        private void FrmChiTietPhieuMuon_Load(object sender, EventArgs e)
        {
            dgvChitietphieumuon.DataSource = Bus.GetListChiTietPM();
            dgvChitietphieumuon.Columns["masach"].HeaderText = "Mã sách";
            dgvChitietphieumuon.Columns["maphieu"].HeaderText = "Mã phiếu";
            dgvChitietphieumuon.Columns["tinhtrangtruoc"].HeaderText = "Tình trạng trước";
            dgvChitietphieumuon.Columns["tinhtrangsau"].HeaderText = "Tình trạng sau";

            cbxMasach.DataSource = Bus.GetListSach();
            cbxMasach.ValueMember = "masach";

            cbxMaphieu.DataSource = Bus.GetListPhieumuontra();
            cbxMaphieu.ValueMember = "maphieu";

        }

        private void dgvChitietphieumuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbxMasach.Text = dgvChitietphieumuon.CurrentRow.Cells["masach"].Value.ToString();
            cbxMaphieu.Text = dgvChitietphieumuon.CurrentRow.Cells["maphieu"].Value.ToString();
            txtTinhtrangtruoc.Text = dgvChitietphieumuon.CurrentRow.Cells["tinhtrangtruoc"].Value.ToString();
            txtTinhtrangsau.Text = dgvChitietphieumuon.CurrentRow.Cells["tinhtrangsau"].Value.ToString();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTinhtrangtruoc.Text = string.Empty;
            txtTinhtrangsau.Text = string.Empty;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cbxMasach.Text == "" || cbxMaphieu.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            ChiTietPhieuMuon1 chitiet = new ChiTietPhieuMuon1();
            chitiet.masach = cbxMasach.Text;
            chitiet.maphieu = cbxMaphieu.Text;
            chitiet.tinhtrangtruoc = txtTinhtrangtruoc.Text;
            chitiet.tinhtrangsau = txtTinhtrangsau.Text;
            
            if (MessageBox.Show(string.Format("Bạn có muốn sửa chi tiết phiếu có mã sách {0}", chitiet.masach ),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateChitietPM(chitiet) > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    FrmChiTietPhieuMuon_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cbxMasach.Text == "" || cbxMaphieu.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            ChiTietPhieuMuon1 chitiet = new ChiTietPhieuMuon1();
            chitiet.masach = cbxMasach.Text;
            chitiet.maphieu = cbxMaphieu.Text;
            chitiet.tinhtrangtruoc = txtTinhtrangtruoc.Text;
            chitiet.tinhtrangsau = txtTinhtrangsau.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn xóa chi tiết phiếu có mã sách {0}", chitiet.masach),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteChitietPM(chitiet) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    FrmChiTietPhieuMuon_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cbxMasach.Text == "" || cbxMaphieu.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            ChiTietPhieuMuon1 chitiet = new ChiTietPhieuMuon1();
            chitiet.masach = cbxMasach.Text;
            chitiet.maphieu = cbxMaphieu.Text;
            chitiet.tinhtrangtruoc = txtTinhtrangtruoc.Text;
            chitiet.tinhtrangsau = txtTinhtrangsau.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn lưu chi tiết phiếu có mã sách {0}", chitiet.masach),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertChitietPM(chitiet) > 0)
                {
                    MessageBox.Show("Lưu thành công!");
                    FrmChiTietPhieuMuon_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            txtTimkiem.Text = string.Empty;
        }

        public void Hienthi(string sach)
        {
            dgvChitietphieumuon.DataSource = Bus.SearchSach(sach);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            Hienthi("where masach like N'%" + txtTimkiem.Text + "%'");
        }
    }
}
