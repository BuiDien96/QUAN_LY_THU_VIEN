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
    public partial class FrmPhieuMuonTra : Form
    {
        public FrmPhieuMuonTra()
        {
            InitializeComponent();
        }

        private void FrmPhieuMuonTra_Load(object sender, EventArgs e)
        {
            dgvPhieumuontra.DataSource = Bus.GetListPhieumuontra();
            dgvPhieumuontra.Columns["maphieu"].HeaderText = "Mã phiếu";
            dgvPhieumuontra.Columns["ngaymuon"].HeaderText = "Ngày mượn";
            dgvPhieumuontra.Columns["ngaytra"].HeaderText = "Ngày trả";
            dgvPhieumuontra.Columns["ngayhentra"].HeaderText = "Ngày hẹn trả";
            dgvPhieumuontra.Columns["matt"].HeaderText = "Mã thủ thư";
            dgvPhieumuontra.Columns["madg"].HeaderText = "Mã độc giả";

            cbxMatt.DataSource = Bus.GetListThuthu();
            cbxMatt.ValueMember = "matt";

            cbxMadg.DataSource = Bus.GetListKesach();
            cbxMadg.ValueMember = "vitri";
        }

        private void dgvPhieumuontra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaphieu.Text = dgvPhieumuontra.CurrentRow.Cells["maphieu"].Value.ToString();
            dateNgaymuon.Text = dgvPhieumuontra.CurrentRow.Cells["ngaymuon"].Value.ToString();
            dateNgaytra.Text = dgvPhieumuontra.CurrentRow.Cells["ngaytra"].Value.ToString();
            dateNgayhentra.Text = dgvPhieumuontra.CurrentRow.Cells["ngayhentra"].Value.ToString();
            cbxMatt.Text = dgvPhieumuontra.CurrentRow.Cells["matt"].Value.ToString();
            cbxMadg.Text = dgvPhieumuontra.CurrentRow.Cells["madg"].Value.ToString();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaphieu.Text = string.Empty;
            dateNgaymuon.Value = DateTime.Now;
            dateNgaytra.Value = DateTime.Now;
            dateNgayhentra.Value = DateTime.Now;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaphieu.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            PhieuMuonTra1 phieumt = new PhieuMuonTra1();
            phieumt.maphieu = txtMaphieu.Text;
            phieumt.ngaymuon = dateNgaymuon.Value;
            phieumt.ngaytra = dateNgaytra.Value;
            phieumt.ngayhentra = dateNgayhentra.Value;
            phieumt.matt = cbxMatt.Text;
            phieumt.madg = cbxMadg.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn sửa phiếu {0}", phieumt.maphieu),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdatePhieumuontra(phieumt) > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    FrmPhieuMuonTra_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaphieu.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            PhieuMuonTra1 phieumt = new PhieuMuonTra1();
            phieumt.maphieu = txtMaphieu.Text;
            phieumt.ngaymuon = dateNgaymuon.Value;
            phieumt.ngaytra = dateNgaytra.Value;
            phieumt.ngayhentra = dateNgayhentra.Value;
            phieumt.matt = cbxMatt.Text;
            phieumt.madg = cbxMadg.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn xoa phiếu {0}", phieumt.maphieu),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeletePhieumuontra(phieumt) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    FrmPhieuMuonTra_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaphieu.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            PhieuMuonTra1 phieumt = new PhieuMuonTra1();
            phieumt.maphieu = txtMaphieu.Text;
            phieumt.ngaymuon = dateNgaymuon.Value;
            phieumt.ngaytra = dateNgaytra.Value;
            phieumt.ngayhentra = dateNgayhentra.Value;
            phieumt.matt = cbxMatt.Text;
            phieumt.madg = cbxMadg.Text;
            if (MessageBox.Show(string.Format("Bạn có thêm sửa phiếu {0}", phieumt.maphieu),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertPhieumuontra(phieumt) > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    FrmPhieuMuonTra_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            txtTimkiem.Text = string.Empty;
        }

        public void Hienthi(string phieumt)
        {
            dgvPhieumuontra.DataSource = Bus.SearchPhieumuontra(phieumt);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            Hienthi("where maphieu like N'%" + txtTimkiem.Text + "%'");
        }
    }
}
