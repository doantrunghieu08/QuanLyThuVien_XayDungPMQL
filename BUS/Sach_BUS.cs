using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class Sach_BUS
    {
        Sach_DAL sach_DAL = new Sach_DAL();
        public DataTable LoadDataSach()
        {
            return sach_DAL.load();
        }

        public void InsertSach(Sach ob)
        {
            sach_DAL.InsertSach(ob);
        }

        public void DeleteSach(string maSach) {
            sach_DAL.DeleteSach(maSach);
        }

        public void UpdateSach(string maSach, Sach ob)
        {
            sach_DAL.UpdateSach(ob, maSach);
        }
    }
}
