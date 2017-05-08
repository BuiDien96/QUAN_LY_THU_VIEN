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
    public partial class FrmKeSach : Form
    {
        public FrmKeSach()
        {
            InitializeComponent();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            Hienthi("where vitri like N'%" + txtTimkiem.Text + "%'");
        }

        private void FrmKeSach_Load(object sender, EventArgs e)
        {
            dgvKesach.DataSource = Bus.GetListKesach();
            dgvKesach.Columns["vitri"].HeaderText = "Vị trí";
            dgvKesach.Columns["songan"].HeaderText = "Số ngăn";
            dgvKesach.Columns["matt"].HeaderText = "Mã thủ thư";

            cbxMatt.DataSource = Bus.GetListThuthu();
            cbxMatt.ValueMember = "matt";
        }

        private void dgvKesach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtVitri.Text = dgvKesach.CurrentRow.Cells["vitri"].Value.ToString();
            txtSongan.Text = dgvKesach.CurrentRow.Cells["songan"].Value.ToString();
            cbxMatt.Text = dgvKesach.CurrentRow.Cells["matt"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtVitri.Text = string.Empty;
            txtSongan.Text = string.Empty;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtVitri.Text == "" || txtSongan.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            KeSach1 kesach = new KeSach1();
            kesach.vitri = txtVitri.Text;
            kesach.songan = int.Parse( txtSongan.Text);
            kesach.matt = cbxMatt.Text;
            
            if (MessageBox.Show(string.Format("Bạn có muốn sửa vị trí kệ sách {0} ", kesach.vitri),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateKesach(kesach) > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    FrmKeSach_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtVitri.Text == "" || txtSongan.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            KeSach1 kesach = new KeSach1();
            kesach.vitri = txtVitri.Text;
            kesach.songan = int.Parse(txtSongan.Text);
            kesach.matt = cbxMatt.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn xóa vị trí kệ sách {0} ", kesach.vitri),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteKesach(kesach) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    FrmKeSach_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtVitri.Text == "" || txtSongan.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            KeSach1 kesach = new KeSach1();
            kesach.vitri = txtVitri.Text;
            kesach.songan = int.Parse(txtSongan.Text);
            kesach.matt = cbxMatt.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn thêm vị trí kệ sách {0} ", kesach.vitri),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertKesach(kesach) > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    FrmKeSach_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void Hienthi(string kesach)
        {
            dgvKesach.DataSource = Bus.SearchKesach(kesach);
        }


    }
}
