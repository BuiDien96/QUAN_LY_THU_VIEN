using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyThuVien.Model;

namespace QuanLyThuVien.DataAccessLayer
{
     class Dao
    {
        //thu thu

        public static DataTable GetListThuthu()
        {
            return DataProvider.GetData("select * from thuthu");
        }

        public static int Insert(ThuThu1 tt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@matt", tt.matt),
                new SqlParameter("@tentt", tt.tentt),
                new SqlParameter("@ngaysinh", tt.ngaysinh),
                new SqlParameter("@diachi", tt.diachi)
            };
            return DataProvider.ExecuteNonQuery("themthuthu", para);
        }

        public static int Update(ThuThu1 tt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@matt", tt.matt),
                new SqlParameter("@tentt", tt.tentt),
                new SqlParameter("@ngaysinh", tt.ngaysinh),
                new SqlParameter("@diachi", tt.diachi)
            };
            return DataProvider.ExecuteNonQuery("suathuthu", para);
        }

        public static int Delete(ThuThu1 tt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@matt", tt.matt)
                
            };
            return DataProvider.ExecuteNonQuery("xoathuthu", para);
        }

        public static DataTable SearchTT(string ten)
        {
            return DataProvider.GetData("select * from thuthu " + ten);
        }


        //độc giả

        public static DataTable GetListDocGia()
        {
            return DataProvider.GetData("select * from docgia");
        }

        public static int InsertDG(DocGia1 dg)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@madg", dg.madg),
                new SqlParameter("@tendg", dg.tendg),
                new SqlParameter("@ngaysinh", dg.ngaysinh),
                new SqlParameter("@diachi", dg.diachi)
            };
            return DataProvider.ExecuteNonQuery("themdocgia", para);
        }

        public static int UpdateDG(DocGia1 dg)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@madg", dg.madg),
                new SqlParameter("@tendg", dg.tendg),
                new SqlParameter("@ngaysinh", dg.ngaysinh),
                new SqlParameter("@diachi", dg.diachi)
            };
            return DataProvider.ExecuteNonQuery("suadocgia", para);
        }

        public static int DeleteDG(DocGia1 dg)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@madg", dg.madg)
                
            };
            return DataProvider.ExecuteNonQuery("xoadocgia", para);
        }

        public static DataTable SearchDG(string ten)
        {
            return DataProvider.GetData("select * from docgia " + ten);
        }

        //sách

        public static DataTable GetListSach()
        {
            return DataProvider.GetData("select * from sach ");
        }


        public static DataTable GetListTheloai()
        {
            return DataProvider.GetData("select * from theloai ");
        }

        public static int InsertSach(Sach1 sach)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@masach", sach.masach),
                new SqlParameter("@tensach", sach.tensach),
                new SqlParameter("@tinhtrang", sach.tinhtrang),
                new SqlParameter("@matt", sach.matt),
                new SqlParameter("@vitri", sach.vitri),
                new SqlParameter("@matl", sach.matl)
            };
            return DataProvider.ExecuteNonQuery("themsach", para);
        }

        public static int UpdateSach(Sach1 sach)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@masach", sach.masach),
                new SqlParameter("@tensach", sach.tensach),
                new SqlParameter("@tinhtrang", sach.tinhtrang),
                new SqlParameter("@matt", sach.matt),
                new SqlParameter("@vitri", sach.vitri),
                new SqlParameter("@matl", sach.matl)
            };
            return DataProvider.ExecuteNonQuery("susach", para);
        }

        public static int DeleteSach(Sach1 sach)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@masach", sach.masach)
                
            };
            return DataProvider.ExecuteNonQuery("xoasach", para);
        }

        public static DataTable SearchSach(string ten)
        {
            return DataProvider.GetData("select * from sach " + ten);
        }


        //the doc gia

        public static DataTable GetListThedg()
        {
            return DataProvider.GetData(" select * from thedocgia ");
        }

        public static int InsertThedg(TheDocGia1 thedg)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mathe", thedg.mathe),
                new SqlParameter("@ngaylam", thedg.ngaylam),
                new SqlParameter("@ngayhethan", thedg.ngayhethan),
                new SqlParameter("@matt", thedg.matt),
                new SqlParameter("@madg", thedg.madg)
                
            };
            return DataProvider.ExecuteNonQuery("themthedocgia", para);
        }

        public static int UpdateThedg(TheDocGia1 thedg)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mathe", thedg.mathe),
                new SqlParameter("@ngaylam", thedg.ngaylam),
                new SqlParameter("@ngayhethan", thedg.ngayhethan),
                new SqlParameter("@matt", thedg.matt),
                new SqlParameter("@madg", thedg.madg)

            };
            return DataProvider.ExecuteNonQuery("suathedocgia", para);
        }

        public static int DeleteThedg(TheDocGia1 thedg)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mathe", thedg.mathe)
                
            };
            return DataProvider.ExecuteNonQuery("xoathedocgia", para);
        }

        public static DataTable SearchThedg(string ten)
        {
            return DataProvider.GetData("select * from thedocgia " + ten);
        }

        //kệ sách

        public static DataTable GetListKesach()
        {
            return DataProvider.GetData("select * from kesach ");
        }

        public static int InsertKesach(KeSach1 kesach)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@vitri", kesach.vitri),
                new SqlParameter("@songan", kesach.songan),
                new SqlParameter("@matt", kesach.matt)            
            };
            return DataProvider.ExecuteNonQuery("themkesach", para);
        }

        public static int UpdateKesach(KeSach1 kesach)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@vitri", kesach.vitri),
                new SqlParameter("@songan", kesach.songan),
                new SqlParameter("@matt", kesach.matt)
            };
            return DataProvider.ExecuteNonQuery("suakesach", para);
        }

        public static int DeleteKesach(KeSach1 kesach)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@vitri", kesach.vitri),
               
            };
            return DataProvider.ExecuteNonQuery("xoakesach", para);
        }

        public static DataTable SearchKesach(string ten)
        {
            return DataProvider.GetData("select * from kesach " + ten);
        }


        //phiếu mượn trả

        public static DataTable GetListPhieumuontra()
        {
            return DataProvider.GetData("select * from phieumuontra ");
        }

        public static int InsertPhieumuontra(PhieuMuonTra1 phieumt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphieu", phieumt.maphieu),
                new SqlParameter("@ngaymuon", phieumt.ngaymuon),
                new SqlParameter("@ngaytra", phieumt.ngaytra),
                new SqlParameter("@ngayhentra", phieumt.ngayhentra),
                new SqlParameter("@matt", phieumt.matt),
                new SqlParameter("@madg", phieumt.madg)
            };
            return DataProvider.ExecuteNonQuery("themphieumuontra", para);
        }

        public static int UpdatePhieumuontra(PhieuMuonTra1 phieumt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphieu", phieumt.maphieu),
                new SqlParameter("@ngaymuon", phieumt.ngaymuon),
                new SqlParameter("@ngaytra", phieumt.ngaytra),
                new SqlParameter("@ngayhentra", phieumt.ngayhentra),
                new SqlParameter("@matt", phieumt.matt),
                new SqlParameter("@madg", phieumt.madg)
            };
            return DataProvider.ExecuteNonQuery("suaphieumuontra", para);
        }

        public static int DeletePhieumuontra(PhieuMuonTra1 phieumt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphieu", phieumt.maphieu)
                
            };
            return DataProvider.ExecuteNonQuery("xoaphieumuontra", para);
        }

        public static DataTable SearchPhieumuontra(string ten)
        {
            return DataProvider.GetData("select * from phieumuontra " + ten);
        }


        //thể loại 
        public static DataTable GetListTheLoai()
        {
            return DataProvider.GetData("select * from theloai ");
        }

        public static int InsertTheloai(TheLoai1 theloai)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@matheloai", theloai.matl),
                new SqlParameter("@tentheloai", theloai.tentl)
                
            };
            return DataProvider.ExecuteNonQuery("themtheloai", para);
        }


        public static int UpdateTheloai(TheLoai1 theloai)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@matheloai", theloai.matl),
                new SqlParameter("@tentheloai", theloai.tentl)

            };
            return DataProvider.ExecuteNonQuery("suatheloai", para);
        }

        public static int DeleteTheloai(TheLoai1 theloai)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@matheloai", theloai.matl)
               

            };
            return DataProvider.ExecuteNonQuery("xoatheloai", para);
        }

        public static DataTable SearchTheLoai(string ten)
        {
            return DataProvider.GetData("select * from theloai " + ten);
        }

        //chi tiets phiếu mượn

        public static DataTable GetListChiTietPM()
        {
            return DataProvider.GetData("select * from chitietphieumuon ");
        }

        public static int InsertChitietPM(ChiTietPhieuMuon1 chitiet)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@masach", chitiet.masach),
                new SqlParameter("@maphieu", chitiet.maphieu),
                new SqlParameter("@tinhtrangtruoc", chitiet.tinhtrangtruoc),
                new SqlParameter("@tinhtrangsau", chitiet.tinhtrangsau)
               
            };
            return DataProvider.ExecuteNonQuery("themchitietphieumuon", para);
        }

        public static int UpdateChitietPM(ChiTietPhieuMuon1 chitiet)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@masach", chitiet.masach),
                new SqlParameter("@maphieu", chitiet.maphieu),
                new SqlParameter("@tinhtrangtruoc", chitiet.tinhtrangtruoc),
                new SqlParameter("@tinhtrangsau", chitiet.tinhtrangsau)

            };
            return DataProvider.ExecuteNonQuery("suachitietphieumuon", para);
        }

        public static int DeleteChitietPM(ChiTietPhieuMuon1 chitiet)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@masach", chitiet.masach),
                new SqlParameter("@maphieu", chitiet.maphieu)

            };
            return DataProvider.ExecuteNonQuery("xoachitietphieumuon", para);
        }

        public static DataTable SearchChitietPM(string ten)
        {
            return DataProvider.GetData("select * from chitietphieumuon " + ten);
        }
    }
}
