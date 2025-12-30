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
    
    public class DocGia_BUS
    {
        DocGia_DAL docGia_DAL = new DocGia_DAL();
        public DataTable loadData()
        {
            return docGia_DAL.load();
        }

        public void InsertDocGia(DocGia ob)
        {
            docGia_DAL.InsertDocGia(ob);
        }
        public void UpdateDocGia(string maDocGia, DocGia ob)
        {
            docGia_DAL.UpdateDocGia(maDocGia, ob);
        }
        public void DeleteDocGia(string maDocGia)
        {
            docGia_DAL.DeleteDocGia(maDocGia);
        }
    }
}
