using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class ChiTietPhieuMuon_BUS
    {
        CTMuonTra_DAL cTMuonTra_DAL = new CTMuonTra_DAL();
        public DataTable loadChiTietPM(string maPhieuMuon)
        {
            return cTMuonTra_DAL.Load(maPhieuMuon);
        }

        public void InsertChiTietPM(ChiTietMuonTra ob)
        {
            cTMuonTra_DAL.Insert(ob);
        }

        public void UpdateChiTietPM(ChiTietMuonTra ob, string maPhieuMuon)
        {
            cTMuonTra_DAL.Update(ob);
        }
        public void DeleteChiTietPM(string maPhieuMuon, string maSach)
        {
            cTMuonTra_DAL.Delete(maPhieuMuon, maSach);
        }
    }
}
