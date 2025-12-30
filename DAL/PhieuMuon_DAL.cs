using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PhieuMuon_DAL:Connect
    {
        public DataTable Load()
        {
            return loadData(@"
                SELECT MuonTra_HieuDT_3725_LTMT5.MaMuonTra_HieuDT_3725_LTMT5, MuonTra_HieuDT_3725_LTMT5.MaDocGia_HieuDT_3725_LTMT5, DocGia_HieuDT_3725_LTMT5.TenDocGia_HieuDT_3725_LTMT5, 
                  MuonTra_HieuDT_3725_LTMT5.MaNhanVien_HieuDT_3725_LTMT5, NhanVien_HieuDT_3725_LTMT5.TenNhanVien_HieuDT_3725_LTMT5, MuonTra_HieuDT_3725_LTMT5.NgayMuon_HieuDT_3725_LTMT5, 
                  MuonTra_HieuDT_3725_LTMT5.TienCoc_HieuDT_3725_LTMT5, MuonTra_HieuDT_3725_LTMT5.NgayHenTra_HieuDT_3725_LTMT5
FROM     MuonTra_HieuDT_3725_LTMT5 INNER JOIN
                  NhanVien_HieuDT_3725_LTMT5 ON MuonTra_HieuDT_3725_LTMT5.MaNhanVien_HieuDT_3725_LTMT5 = NhanVien_HieuDT_3725_LTMT5.MaNhanVien_HieuDT_3725_LTMT5 INNER JOIN
                  DocGia_HieuDT_3725_LTMT5 ON MuonTra_HieuDT_3725_LTMT5.MaDocGia_HieuDT_3725_LTMT5 = DocGia_HieuDT_3725_LTMT5.MaDocGia_HieuDT_3725_LTMT5
            ");

        }

        public void Insert(MuonTra ob)
        {
            SqlCommand cmd = new SqlCommand(@"
                INSERT INTO MuonTra_HieuDT_3725_LTMT5
                  (MaMuonTra_HieuDT_3725_LTMT5, MaDocGia_HieuDT_3725_LTMT5, MaNhanVien_HieuDT_3725_LTMT5, NgayMuon_HieuDT_3725_LTMT5, TienCoc_HieuDT_3725_LTMT5, NgayHenTra_HieuDT_3725_LTMT5)
VALUES (@MaMuonTra_HieuDT_3725_LTMT5,@MaDocGia_HieuDT_3725_LTMT5,@MaNhanVien_HieuDT_3725_LTMT5,@NgayMuon_HieuDT_3725_LTMT5,@TienCoc_HieuDT_3725_LTMT5,@NgayHenTra_HieuDT_3725_LTMT5)
            ");
            cmd.Parameters.AddWithValue(@"MaMuonTra_HieuDT_3725_LTMT5", ob.maMuonTra);
            cmd.Parameters.AddWithValue(@"MaDocGia_HieuDT_3725_LTMT5", ob.maDocGia);
            cmd.Parameters.AddWithValue(@"MaNhanVien_HieuDT_3725_LTMT5", ob.maNhanVien);
            cmd.Parameters.AddWithValue(@"NgayMuon_HieuDT_3725_LTMT5", ob.ngayMuon);
            cmd.Parameters.AddWithValue(@"TienCoc_HieuDT_3725_LTMT5", ob.tienCoc);
            cmd.Parameters.AddWithValue(@"NgayHenTra_HieuDT_3725_LTMT5", ob.ngayHenTra);
            ExcuteNonQuery(cmd);
        }

        public void Delete(string maPhieuMuon)
        {
            SqlCommand cmd = new SqlCommand(@"DELETE FROM MuonTra_HieuDT_3725_LTMT5
WHERE  (MaMuonTra_HieuDT_3725_LTMT5 = @Original_MaMuonTra_HieuDT_3725_LTMT5)");
            cmd.Parameters.AddWithValue(@"Original_MaMuonTra_HieuDT_3725_LTMT5", maPhieuMuon);
            ExcuteNonQuery(cmd);
        }

        public void Update(string maPhieuMuon, MuonTra ob)
        {
            SqlCommand cmd = new SqlCommand(@"
                UPDATE MuonTra_HieuDT_3725_LTMT5
SET          MaDocGia_HieuDT_3725_LTMT5 = @MaDocGia_HieuDT_3725_LTMT5, MaNhanVien_HieuDT_3725_LTMT5 = @MaNhanVien_HieuDT_3725_LTMT5, NgayMuon_HieuDT_3725_LTMT5 = @NgayMuon_HieuDT_3725_LTMT5, 
                  TienCoc_HieuDT_3725_LTMT5 = @TienCoc_HieuDT_3725_LTMT5, NgayHenTra_HieuDT_3725_LTMT5 = @NgayHenTra_HieuDT_3725_LTMT5
WHERE  (MaMuonTra_HieuDT_3725_LTMT5 = @Original_MaMuonTra_HieuDT_3725_LTMT5)
            ");
            cmd.Parameters.AddWithValue("@MaDocGia_HieuDT_3725_LTMT5", ob.maDocGia);
            cmd.Parameters.AddWithValue("@MaNhanVien_HieuDT_3725_LTMT5", ob.maNhanVien);
            cmd.Parameters.AddWithValue("@NgayMuon_HieuDT_3725_LTMT5", ob.ngayMuon);
            cmd.Parameters.AddWithValue("@TienCoc_HieuDT_3725_LTMT5", ob.tienCoc);
            cmd.Parameters.AddWithValue("@NgayHenTra_HieuDT_3725_LTMT5", ob.ngayHenTra);
            cmd.Parameters.AddWithValue("@Original_MaMuonTra_HieuDT_3725_LTMT5", maPhieuMuon);
            ExcuteNonQuery(cmd);
        }
    }
}
