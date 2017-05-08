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
    public partial class FrmTheLoai : Form
    {
        public FrmTheLoai()
        {
            InitializeComponent();
        }

        private void FrmTheLoai_Load(object sender, EventArgs e)
        {
            dgvTheloai.DataSource = Bus.GetListTheLoai();
            dgvTheloai.Columns["matheloai"].HeaderText = "Mã thể loại";
            dgvTheloai.Columns["tentheloai"].HeaderText = "Tên thể loại";
        }

        private void dgvTheloai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMatl.Text = dgvTheloai.CurrentRow.Cells["matheloai"].Value.ToString();
            txtTentl.Text = dgvTheloai.CurrentRow.Cells["tentheloai"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMatl.Text = string.Empty;
            txtTentl.Text = string.Empty;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMatl.Text == "" || txtTentl.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            TheLoai1 theloai = new TheLoai1();
            theloai.matl = txtMatl.Text;
            theloai.tentl = txtTentl.Text;
            
            if (MessageBox.Show(string.Format("Bạn có muốn sửa mã thể loại {0} tên thể loại {1}", theloai.matl, theloai.tentl),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateTheloai(theloai) > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    FrmTheLoai_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMatl.Text == "" || txtTentl.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            TheLoai1 theloai = new TheLoai1();
            theloai.matl = txtMatl.Text;
            theloai.tentl = txtTentl.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn xoa mã thể loại {0} tên thể loại {1}", theloai.matl, theloai.tentl),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteTheloai(theloai) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    FrmTheLoai_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMatl.Text == "" || txtTentl.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            TheLoai1 theloai = new TheLoai1();
            theloai.matl = txtMatl.Text;
            theloai.tentl = txtTentl.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn lưu mã thể loại {0} tên thể loại {1}", theloai.matl, theloai.tentl),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertTheloai(theloai) > 0)
                {
                    MessageBox.Show("Lưu thành công!");
                    FrmTheLoai_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        public void Hienthi(string theloai)
        {
            dgvTheloai.DataSource = Bus.SearchTheLoai(theloai);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            Hienthi("where matheloai like N'%" + txtTimkiem.Text + "%'");
        }

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            txtTimkiem.Text = string.Empty;
        }
    }
}
