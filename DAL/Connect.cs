using System.Data.SqlClient;
using System.Data;

namespace DTO
{
    public class Connect
    {
        // Giữ chuỗi kết nối, nhưng NÊN tạo mới connection mỗi lần dùng để tránh lỗi
        private string strConn = "Data Source=TrungHieu\\SQLEXPRESS;Initial Catalog=QLTV_HieuDT_3725_LTMT5;User ID=sa;Password=1234567890;Encrypt=False";

        // Hàm hỗ trợ lấy kết nối mới
        public SqlConnection GetConnection()
        {
            return new SqlConnection(strConn);
        }

        public DataTable loadData(string sql)
        {
            DataTable dt = new DataTable();
            // Dùng 'using' để tự động Đóng kết nối khi xong (tránh treo máy)
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable loadDataByParameter(SqlCommand cmd)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConnection()) // Tạo kết nối mới
            {
                conn.Open();

                // --- ĐÂY LÀ DÒNG BẠN THIẾU ---
                cmd.Connection = conn; // <== Phải gán kết nối cho lệnh cmd
                // -----------------------------

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            } // Tự động đóng kết nối ở đây
            return dt;
        }

        public void ExcuteNonQuery(SqlCommand cmd)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                cmd.Connection = conn; // Gán kết nối
                cmd.ExecuteNonQuery();
            }
        }
    }
}