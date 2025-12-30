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
    public class MuonTra_BUS
    {
        public PhieuMuon_DAL phieuMuon_DAL = new PhieuMuon_DAL();
        public DataTable LoadMuonTra()
        {
            return phieuMuon_DAL.Load();
        }

        public void InsertMuonTra(MuonTra ob)
        {
            phieuMuon_DAL.Insert(ob);
        }

        public void DeleteMuonTra(string maphieumuon)
        {
            phieuMuon_DAL.Delete(maphieumuon);
        }

        public void UpdateMuonTra(string maPhieuMuon, MuonTra ob)
        {
            phieuMuon_DAL.Update(maPhieuMuon, ob);
        }
    }
}
