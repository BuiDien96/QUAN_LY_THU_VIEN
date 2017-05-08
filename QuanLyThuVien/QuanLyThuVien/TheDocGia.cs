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
    public partial class FrmTheDocGia : Form
    {
        public FrmTheDocGia()
        {
            InitializeComponent();
        }

        private void FrmTheDocGia_Load(object sender, EventArgs e)
        {
            dgvThedocgia.DataSource = Bus.GetListThedg();
            dgvThedocgia.Columns["mathe"].HeaderText = "Mã thẻ";
            dgvThedocgia.Columns["ngaylam"].HeaderText = "Ngày làm";
            dgvThedocgia.Columns["ngayhethan"].HeaderText = "Ngày hết hạn";
            dgvThedocgia.Columns["matt"].HeaderText = "Mã thủ thư";
            dgvThedocgia.Columns["madg"].HeaderText = "Mã độc giả";

            cbxMatt.DataSource = Bus.GetListThuthu();
            cbxMatt.ValueMember = "matt";

            cbxMadg.DataSource = Bus.GetListDocGia();
            cbxMadg.ValueMember = "madg";
        }

        private void dgvThedocgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMathe.Text = dgvThedocgia.CurrentRow.Cells["mathe"].Value.ToString();
            dateNgaylam.Text = dgvThedocgia.CurrentRow.Cells["ngaylam"].Value.ToString();
            dateNgayhethan.Text = dgvThedocgia.CurrentRow.Cells["ngayhethan"].Value.ToString();
            cbxMatt.Text = dgvThedocgia.CurrentRow.Cells["matt"].Value.ToString();
            cbxMadg.Text = dgvThedocgia.CurrentRow.Cells["madg"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMathe.Text = string.Empty;
            dateNgaylam.Value = DateTime.Now;
            dateNgayhethan.Value = DateTime.Now;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMathe.Text==" ")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            TheDocGia1 thedg = new TheDocGia1();
            thedg.mathe = txtMathe.Text;
            thedg.ngaylam = dateNgaylam.Value;
            thedg.ngayhethan = dateNgayhethan.Value;
            thedg.matt = cbxMatt.Text;
            thedg.madg = cbxMadg.Text;
            
            if (MessageBox.Show(string.Format("Bạn có muốn sửa thẻ độc giả {0} ", thedg.mathe),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateThedg(thedg) > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    FrmTheDocGia_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }



        private void btnHome_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMathe.Text == " ")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            TheDocGia1 thedg = new TheDocGia1();
            thedg.mathe = txtMathe.Text;
            thedg.ngaylam = dateNgaylam.Value;
            thedg.ngayhethan = dateNgayhethan.Value;
            thedg.matt = cbxMatt.Text;
            thedg.madg = cbxMadg.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn xoa thẻ độc giả {0} ", thedg.mathe),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteThedg(thedg) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    FrmTheDocGia_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMathe.Text == " ")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            TheDocGia1 thedg = new TheDocGia1();
            thedg.mathe = txtMathe.Text;
            thedg.ngaylam = dateNgaylam.Value;
            thedg.ngayhethan = dateNgayhethan.Value;
            thedg.matt = cbxMatt.Text;
            thedg.madg = cbxMadg.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn lưu thẻ độc giả {0} ", thedg.mathe),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertThedg(thedg) > 0)
                {
                    MessageBox.Show("Lưu thành công!");
                    FrmTheDocGia_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            txtTimkiem.Text = string.Empty;
        }

        public void Hienthi(string thedg)
        {
            dgvThedocgia.DataSource = Bus.SearchThedg(thedg);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            Hienthi("where mathe like N'%" + txtTimkiem.Text + "%'");
        }
    }
}
