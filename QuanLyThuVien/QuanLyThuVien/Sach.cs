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
    public partial class FrmSach : Form
    {
        public FrmSach()
        {
            InitializeComponent();
        }

        private void FrmSach_Load(object sender, EventArgs e)
        {
            dgvSach.DataSource = Bus.GetListSach();
            dgvSach.Columns["masach"].HeaderText = "Mã sách";
            dgvSach.Columns["tensach"].HeaderText = "Tên sách";
            dgvSach.Columns["tinhtrang"].HeaderText = "Tình trạng";
            dgvSach.Columns["matt"].HeaderText = "Mã thủ thư";
            dgvSach.Columns["vitri"].HeaderText = "Vị trí";
            dgvSach.Columns["matheloai"].HeaderText = "Mã thể loại";
            //hien thi cbx
            cbxMatt.DataSource = Bus.GetListThuthu();
            cbxMatt.ValueMember = "matt";

            cbxVitri.DataSource = Bus.GetListKesach();
            cbxVitri.ValueMember = "vitri";

            cbxMatheloai.DataSource = Bus.GetListTheloai();
            cbxMatheloai.ValueMember = "matheloai";
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMasach.Text = dgvSach.CurrentRow.Cells["masach"].Value.ToString();
            txtTensach.Text = dgvSach.CurrentRow.Cells["tensach"].Value.ToString();
            txtTinhtrang.Text = dgvSach.CurrentRow.Cells["tinhtrang"].Value.ToString();
            cbxMatt.Text = dgvSach.CurrentRow.Cells["matt"].Value.ToString();
            cbxVitri.Text = dgvSach.CurrentRow.Cells["vitri"].Value.ToString();
            cbxMatheloai.Text = dgvSach.CurrentRow.Cells["matheloai"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMasach.Text = string.Empty;
            txtTensach.Text = string.Empty;
            txtTinhtrang.Text = string.Empty;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMasach.Text == "" || txtTensach.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            Sach1 sach = new Sach1();
            sach.masach = txtMasach.Text;
            sach.tensach = txtTensach.Text;
            sach.tinhtrang = txtTinhtrang.Text;
            sach.matt = cbxMatt.Text;
            sach.vitri = cbxVitri.Text;
            sach.matl = cbxMatheloai.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn thêm  sách {0} tên  sách {1}", sach.masach, sach.tensach),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertSach(sach) > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    FrmSach_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMasach.Text == "" || txtTensach.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            Sach1 sach = new Sach1();
            sach.masach = txtMasach.Text;
            sach.tensach = txtTensach.Text;
            sach.tinhtrang = txtTinhtrang.Text;
            sach.matt = cbxMatt.Text;
            sach.vitri = cbxVitri.Text;
            sach.matl = cbxMatheloai.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn sửa sách {0} tên sách {1}", sach.masach, sach.tensach),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateSach(sach) > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    FrmSach_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMasach.Text == "" || txtTensach.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            Sach1 sach = new Sach1();
            sach.masach = txtMasach.Text;
            sach.tensach = txtTensach.Text;
            sach.tinhtrang = txtTinhtrang.Text;
            sach.matt = cbxMatt.Text;
            sach.vitri = cbxVitri.Text;
            sach.matl = cbxMatheloai.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn xóa  sách {0} tên  sách {1}", sach.masach, sach.tensach),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteSach(sach) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    FrmSach_Load(sender, e);
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
            dgvSach.DataSource = Bus.SearchSach(sach);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            Hienthi("where masach like N'%" + txtTimkiem.Text + "%'");
        }
    }
}
