using System.Data.SqlClient;
using System.Data;

namespace DTO
{
    public class Connect
    {
        SqlConnection conn = new SqlConnection("Data Source=TrungHieu\\SQLEXPRESS;Initial Catalog=QLTV_HieuDT_3725_LTMT5;User ID=sa;Password=1234567890;Encrypt=False");
        SqlCommand cmd = new SqlCommand();
        public DataTable loadData(string sql)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }

        }

        public void ExcuteNonQuery(SqlCommand cmd)
        {
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
