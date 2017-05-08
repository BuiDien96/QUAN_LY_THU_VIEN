using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyThuVien.DataAccessLayer;
using QuanLyThuVien.Model;

namespace QuanLyThuVien.BusinessLogicLayer
{
    class Bus
    {
        //thu thu 
        public static DataTable GetListThuthu()
        {
            return Dao.GetListThuthu();
        }

        public static int Insert(ThuThu1 tt)
        {
            return Dao.Insert(tt);
        }

        public static int Update(ThuThu1 tt)
        {
            return Dao.Update(tt);
        }

        public static int Delete(ThuThu1 tt)
        {
            return Dao.Delete(tt);
        }

        public static DataTable SearchTT(string ten)
        {
            return Dao.SearchTT(ten);
        }

        //doc gia

        public static DataTable GetListDocGia()
        {
            return Dao.GetListDocGia();
        }

        public static int Update(DocGia1 dg)
        {
            return Dao.UpdateDG(dg);
        }

        public static int InsertDG(DocGia1 dg)
        {
            return Dao.InsertDG(dg);
        }

        public static int DeleteDG(DocGia1 dg)
        {
            return Dao.DeleteDG(dg);
        }

        public static DataTable SearchDG(string ten)
        {
            return Dao.SearchDG(ten);
        }

        //sach

        public static DataTable GetListSach()
        {
            return Dao.GetListSach();
        }


        public static DataTable GetListTheloai()
        {
            return Dao.GetListTheloai();
        }

        public static int InsertSach(Sach1 sach)
        {
            return Dao.InsertSach(sach);
        }

        public static int UpdateSach(Sach1 sach)
        {
            return Dao.UpdateSach(sach);
        }

        public static int DeleteSach(Sach1 sach)
        {
            return Dao.DeleteSach(sach);
        }

        public static DataTable SearchSach(string ten)
        {
            return Dao.SearchSach(ten);
        }

        //the doc gia
        public static DataTable GetListThedg()
        {
            return Dao.GetListThedg();
        }

        public static int InsertThedg(TheDocGia1 thedg)
        {
            return Dao.InsertThedg(thedg);
        }

        public static int UpdateThedg(TheDocGia1 thedg)
        {
            return Dao.UpdateThedg(thedg);
        }

        public static int DeleteThedg(TheDocGia1 thedg)
        {
            return Dao.DeleteThedg(thedg);
        }

        public static DataTable SearchThedg(string ten)
        {
            return Dao.SearchThedg(ten);
        }

        //kệ sách

        public static int InsertKesach(KeSach1 kesach)
        {
            return Dao.InsertKesach(kesach);
        }

        public static DataTable GetListKesach()
        {
            return Dao.GetListKesach();
        }

        public static int UpdateKesach(KeSach1 kesach)
        {
            return Dao.UpdateKesach(kesach);
        }

        public static int DeleteKesach(KeSach1 kesach)
        {
            return Dao.DeleteKesach(kesach);
        }

        public static DataTable SearchKesach(string ten)
        {
            return Dao.SearchKesach(ten);
        }

        //phieu muon tra
        public static DataTable GetListPhieumuontra()
        {
            return Dao.GetListPhieumuontra();
        }

        public static int InsertPhieumuontra(PhieuMuonTra1 phieumt)
        {
            return Dao.InsertPhieumuontra(phieumt);
        }

        public static int UpdatePhieumuontra(PhieuMuonTra1 phieumt)
        {
            return Dao.UpdatePhieumuontra(phieumt);
        }

        public static int DeletePhieumuontra(PhieuMuonTra1 phieumt)
        {
            return Dao.DeletePhieumuontra(phieumt);
        }

        public static DataTable SearchPhieumuontra(string ten)
        {
            return Dao.SearchPhieumuontra(ten);
        }

        //the loai
        public static DataTable GetListTheLoai()
        {
            return Dao.GetListTheloai();
        }

        public static int InsertTheloai(TheLoai1 theloai)
        {
            return Dao.InsertTheloai(theloai);
        }

        public static int UpdateTheloai(TheLoai1 theloai)
        {
            return Dao.UpdateTheloai(theloai);
        }

        public static int DeleteTheloai(TheLoai1 theloai)
        {
            return Dao.DeleteTheloai(theloai);
        }

        public static DataTable SearchTheLoai(string ten)
        {
            return Dao.SearchTheLoai(ten);
        }

        //chi tiêt phiếu mượn

        public static DataTable GetListChiTietPM()
        {
            return Dao.GetListChiTietPM();
        }

        public static int InsertChitietPM(ChiTietPhieuMuon1 chitiet)
        {
            return Dao.InsertChitietPM(chitiet);
        }

        public static int UpdateChitietPM(ChiTietPhieuMuon1 chitiet)
        {
            return Dao.UpdateChitietPM(chitiet);
        }

        public static int DeleteChitietPM(ChiTietPhieuMuon1 chitiet)
        {
            return Dao.DeleteChitietPM(chitiet);
        }

        public static DataTable SearchChitietPM(string ten)
        {
            return Dao.SearchChitietPM(ten);
        }
    }
}
