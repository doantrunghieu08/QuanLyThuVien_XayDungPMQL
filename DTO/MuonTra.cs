using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MuonTra
    {
        public string maMuonTra {  get; set; }
        public string maDocGia {  get; set; }
        public string maNhanVien {  get; set; }

        public DateTime ngayMuon { get; set; }

        public int tienCoc {  get; set; }

        public DateTime ngayHenTra { get; set; }
    }
}
