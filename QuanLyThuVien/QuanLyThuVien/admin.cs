using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Server=DESKTOP-KBSLCQ1\SQLEXPRESS;Database=QuanLyThuVien;Trusted_Connection=true");
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from admin  where name = '" + txtTendangnhap.Text + "' and  pass ='" + txtPassword.Text + " '  ", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                FrmTrangchu trangchu = new FrmTrangchu();
                trangchu.Show();
            }
            else
            {
                MessageBox.Show("sai mật khẩu hoặc tên đăng nhập ");

            }
            txtTendangnhap.Clear();
            txtPassword.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
