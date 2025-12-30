using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class Sach_DAL:Connect
    {
        public DataTable load()
        {
            return loadData(@"
                SELECT MaSach_HieuDT_3725_LTMT5, TenSach_HieuDT_3725_LTMT5, NhaXuatBan_HieuDT_3725_LTMT5, TheLoai_HieuDT_3725_LTMT5, TacGia_HieuDT_3725_LTMT5, NamXuatBan_HieuDT_3725_LTMT5
FROM     Sach_HieuDT_3725_LTMT5
            ");
        }

        public void InsertSach(Sach ob) {
            SqlCommand cmd = new SqlCommand(@"
                INSERT INTO Sach_HieuDT_3725_LTMT5
                  (MaSach_HieuDT_3725_LTMT5, TenSach_HieuDT_3725_LTMT5, NhaXuatBan_HieuDT_3725_LTMT5, TheLoai_HieuDT_3725_LTMT5, TacGia_HieuDT_3725_LTMT5, NamXuatBan_HieuDT_3725_LTMT5)
VALUES (@MaSach_HieuDT_3725_LTMT5,@TenSach_HieuDT_3725_LTMT5,@NhaXuatBan_HieuDT_3725_LTMT5,@TheLoai_HieuDT_3725_LTMT5,@TacGia_HieuDT_3725_LTMT5,@NamXuatBan_HieuDT_3725_LTMT5)
            ");
            cmd.Parameters.AddWithValue("@MaSach_HieuDT_3725_LTMT5", ob.maSach);
            cmd.Parameters.AddWithValue("@TenSach_HieuDT_3725_LTMT5", ob.tenSach);
            cmd.Parameters.AddWithValue("@NhaXuatBan_HieuDT_3725_LTMT5", ob.nhaXuatBan);
            cmd.Parameters.AddWithValue("@TheLoai_HieuDT_3725_LTMT5", ob.theLoai);
            cmd.Parameters.AddWithValue("@TacGia_HieuDT_3725_LTMT5", ob.tacGia);
            cmd.Parameters.AddWithValue("@NamXuatBan_HieuDT_3725_LTMT5", ob.namXuatBan);
            ExcuteNonQuery(cmd);

        }
        public void DeleteSach(string maSach) { 
            SqlCommand cmd = new SqlCommand(@" DELETE FROM Sach_HieuDT_3725_LTMT5
WHERE  (MaSach_HieuDT_3725_LTMT5 = @Original_MaSach_HieuDT_3725_LTMT5)");
            cmd.Parameters.AddWithValue("@Original_MaSach_HieuDT_3725_LTMT5", maSach);
            ExcuteNonQuery(cmd);
        }

        public void UpdateSach(Sach ob, string maSach)
        {
            SqlCommand cmd = new SqlCommand(@"
                UPDATE Sach_HieuDT_3725_LTMT5
SET          TenSach_HieuDT_3725_LTMT5 = @TenSach_HieuDT_3725_LTMT5, NhaXuatBan_HieuDT_3725_LTMT5 = @NhaXuatBan_HieuDT_3725_LTMT5, TheLoai_HieuDT_3725_LTMT5 = @TheLoai_HieuDT_3725_LTMT5, 
                  TacGia_HieuDT_3725_LTMT5 = @TacGia_HieuDT_3725_LTMT5, NamXuatBan_HieuDT_3725_LTMT5 = @NamXuatBan_HieuDT_3725_LTMT5
WHERE  (MaSach_HieuDT_3725_LTMT5 = @Original_MaSach_HieuDT_3725_LTMT5)
            ");
            cmd.Parameters.AddWithValue("@TenSach_HieuDT_3725_LTMT5", ob.tenSach);
            cmd.Parameters.AddWithValue("@NhaXuatBan_HieuDT_3725_LTMT5", ob.nhaXuatBan);
            cmd.Parameters.AddWithValue("@TheLoai_HieuDT_3725_LTMT5", ob.theLoai);
            cmd.Parameters.AddWithValue("@TacGia_HieuDT_3725_LTMT5", ob.tacGia);
            cmd.Parameters.AddWithValue("@NamXuatBan_HieuDT_3725_LTMT5", ob.namXuatBan);
            cmd.Parameters.AddWithValue("@Original_MaSach_HieuDT_3725_LTMT5", maSach);
            ExcuteNonQuery(cmd);
        }


    }
}
