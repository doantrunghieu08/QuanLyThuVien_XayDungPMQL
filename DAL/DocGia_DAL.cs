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
    public class DocGia_DAL:Connect
    {
        public DataTable load()
        {
            return loadData(@"SELECT MaDocGia_HieuDT_3725_LTMT5, TenDocGia_HieuDT_3725_LTMT5, SoDienThoai_HieuDT_3725_LTMT5, Email_HieuDT_3725_LTMT5, DiaChi_HieuDT_3725_LTMT5
FROM     DocGia_HieuDT_3725_LTMT5");
        }

        public void InsertDocGia(DocGia ob)
        {
            SqlCommand cmd = new SqlCommand(@"'
                INSERT INTO DocGia_HieuDT_3725_LTMT5
                  (TenDocGia_HieuDT_3725_LTMT5, SoDienThoai_HieuDT_3725_LTMT5, Email_HieuDT_3725_LTMT5, DiaChi_HieuDT_3725_LTMT5)
VALUES (@TenDocGia_HieuDT_3725_LTMT5,@SoDienThoai_HieuDT_3725_LTMT5,@Email_HieuDT_3725_LTMT5,@DiaChi_HieuDT_3725_LTMT5)
                
            ");
            cmd.Parameters.AddWithValue("@TenDocGia_HieuDT_3725_LTMT5", ob.Name);
            cmd.Parameters.AddWithValue("@SoDienThoai_HieuDT_3725_LTMT5", ob.SDT);
            cmd.Parameters.AddWithValue("@Email_HieuDT_3725_LTMT5", ob.email);
            cmd.Parameters.AddWithValue("@DiaChi_HieuDT_3725_LTMT5", ob.diaChi);
            ExcuteNonQuery(cmd);
        }

        public void DeleteDocGia(string maDocGia)
        {
            SqlCommand cmd = new SqlCommand(@"
                 DELETE FROM DocGia_HieuDT_3725_LTMT5
WHERE  (MaDocGia_HieuDT_3725_LTMT5 = @Original_MaDocGia_HieuDT_3725_LTMT5)
            ");
            cmd.Parameters.AddWithValue("@Original_MaDocGia_HieuDT_3725_LTMT5", maDocGia);
            ExcuteNonQuery(cmd) ;
        }

        public void UpdateDocGia(string maDocGia, DocGia ob)
        {
            SqlCommand cmd = new SqlCommand(@"
                UPDATE DocGia_HieuDT_3725_LTMT5
SET          TenDocGia_HieuDT_3725_LTMT5 = @TenDocGia_HieuDT_3725_LTMT5, SoDienThoai_HieuDT_3725_LTMT5 = @SoDienThoai_HieuDT_3725_LTMT5, Email_HieuDT_3725_LTMT5 = @Email_HieuDT_3725_LTMT5, 
                  DiaChi_HieuDT_3725_LTMT5 = @DiaChi_HieuDT_3725_LTMT5
WHERE  (MaDocGia_HieuDT_3725_LTMT5 = @Original_MaDocGia_HieuDT_3725_LTMT5)
            ");
            cmd.Parameters.AddWithValue("@TenDocGia_HieuDT_3725_LTMT5", ob.Name);
            cmd.Parameters.AddWithValue("@SoDienThoai_HieuDT_3725_LTMT5", ob.SDT);
            cmd.Parameters.AddWithValue("@Email_HieuDT_3725_LTMT5", ob.email);
            cmd.Parameters.AddWithValue("@DiaChi_HieuDT_3725_LTMT5", ob.diaChi);
            cmd.Parameters.AddWithValue("@Original_MaDocGia_HieuDT_3725_LTMT5", maDocGia);
            ExcuteNonQuery(cmd);
        }


    }
}
