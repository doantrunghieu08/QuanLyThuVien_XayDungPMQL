using System;
using System.Data;
using System.Data.SqlClient;
using DTO; // Đảm bảo class ChiTietMuonTra nằm trong namespace này

namespace DAL
{
    public class CTMuonTra_DAL : Connect
    {
        public DataTable Load(string maPhieuMuon)
        {
            // Câu lệnh SELECT giữ nguyên vì có vẻ đã đúng
            SqlCommand cmd = new SqlCommand(@"SELECT 
                ChiTietMuonTra_HieuDT_3725_LTMT5.MaMuonTra_HieuDT_3725_LTMT5, 
                ChiTietMuonTra_HieuDT_3725_LTMT5.MaSach_HieuDT_3725_LTMT5, 
                Sach_HieuDT_3725_LTMT5.TenSach_HieuDT_3725_LTMT5, 
                ChiTietMuonTra_HieuDT_3725_LTMT5.NgayTra_HieuDT_3725_LTMT5, 
                ChiTietMuonTra_HieuDT_3725_LTMT5.TienPhat_HieuDT_3725_LTMT5, 
                ChiTietMuonTra_HieuDT_3725_LTMT5.GhiChu_HieuDT_3725_LTMT5
            FROM ChiTietMuonTra_HieuDT_3725_LTMT5 
            INNER JOIN Sach_HieuDT_3725_LTMT5 
            ON ChiTietMuonTra_HieuDT_3725_LTMT5.MaSach_HieuDT_3725_LTMT5 = Sach_HieuDT_3725_LTMT5.MaSach_HieuDT_3725_LTMT5
            WHERE (ChiTietMuonTra_HieuDT_3725_LTMT5.MaMuonTra_HieuDT_3725_LTMT5 = @MaPhieuMuon)");

            cmd.Parameters.AddWithValue(@"MaPhieuMuon", maPhieuMuon);
            return loadDataByParameter(cmd);
        }

        public void Insert(ChiTietMuonTra ob)
        {
            // SỬA LỖI: Thêm cột MaMuonTra vào câu lệnh INSERT
            SqlCommand cmd = new SqlCommand(@"INSERT INTO ChiTietMuonTra_HieuDT_3725_LTMT5
                  (MaMuonTra_HieuDT_3725_LTMT5, MaSach_HieuDT_3725_LTMT5, NgayTra_HieuDT_3725_LTMT5, TienPhat_HieuDT_3725_LTMT5, GhiChu_HieuDT_3725_LTMT5)
            VALUES (@MaMuonTra, @MaSach, @NgayTra, @TienPhat, @GhiChu)");

            // Lưu ý: DTO ChiTietMuonTra của bạn cần có thuộc tính maMuonTra
            cmd.Parameters.AddWithValue(@"MaMuonTra", ob.maMuonTra);
            cmd.Parameters.AddWithValue(@"MaSach", ob.maSach);
            cmd.Parameters.AddWithValue(@"NgayTra", ob.ngayTra);
            cmd.Parameters.AddWithValue(@"TienPhat", ob.tienPhat);
            cmd.Parameters.AddWithValue(@"GhiChu", ob.ghiChu);

            ExcuteNonQuery(cmd);
        }

        // Hàm Update cần nhận cả ID cũ của sách nếu cho phép sửa mã sách, 
        // nhưng ở đây tôi giả sử Mã Sách là một phần của khóa chính nên không sửa mã sách, chỉ sửa thông tin khác.
        public void Update(ChiTietMuonTra ob)
        {
            // SỬA LỖI: WHERE phải kẹp cả MaMuonTra VÀ MaSach
            // Nếu không có AND MaSach, nó sẽ update tất cả sách trong phiếu mượn đó.
            SqlCommand cmd = new SqlCommand(@"UPDATE ChiTietMuonTra_HieuDT_3725_LTMT5
            SET 
                NgayTra_HieuDT_3725_LTMT5 = @NgayTra, 
                TienPhat_HieuDT_3725_LTMT5 = @TienPhat, 
                GhiChu_HieuDT_3725_LTMT5 = @GhiChu
            WHERE MaMuonTra_HieuDT_3725_LTMT5 = @MaMuonTra 
              AND MaSach_HieuDT_3725_LTMT5 = @MaSach");

            // Tham số WHERE
            cmd.Parameters.AddWithValue(@"MaMuonTra", ob.maMuonTra);
            cmd.Parameters.AddWithValue(@"MaSach", ob.maSach);

            // Tham số SET
            cmd.Parameters.AddWithValue(@"NgayTra", ob.ngayTra);
            cmd.Parameters.AddWithValue(@"TienPhat", ob.tienPhat);
            cmd.Parameters.AddWithValue(@"GhiChu", ob.ghiChu);

            ExcuteNonQuery(cmd);
        }

        public void Delete(string maPhieuMuon, string maSach)
        {
            // Hàm Delete của bạn logic đã đúng (có AND), tôi chỉ format lại cho đẹp
            SqlCommand cmd = new SqlCommand(@"DELETE FROM ChiTietMuonTra_HieuDT_3725_LTMT5
            WHERE MaMuonTra_HieuDT_3725_LTMT5 = @MaMuonTra 
              AND MaSach_HieuDT_3725_LTMT5 = @MaSach");

            cmd.Parameters.AddWithValue("@MaMuonTra", maPhieuMuon);
            cmd.Parameters.AddWithValue("@MaSach", maSach);

            ExcuteNonQuery(cmd);
        }
    }
}