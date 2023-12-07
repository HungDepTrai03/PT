using DAL.IRepository;
using PRL.Context;
using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class NhanVienRepo : INhanvienrepo
    {
        private DBContext _dbcontext;
        public NhanVienRepo()
        {
            _dbcontext = new DBContext();
        }
        public bool Addnv(NhanVien11 nv)
        {
            _dbcontext.Add(nv);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<NhanVien11> GetAllnv()
        {
            return _dbcontext.NhanViens.ToList();
        }

        public bool Removenv(NhanVien11 nv)
        {
           _dbcontext.Remove(nv);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Updatenv(NhanVien11 nv)
        {
           _dbcontext.Update(nv);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
