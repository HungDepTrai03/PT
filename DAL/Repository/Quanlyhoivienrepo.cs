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
    public class Quanlyhoivienrepo : IQuanLyhoivienrepo
    {
        private DBContext _DBContext;
        public Quanlyhoivienrepo()
        {
            _DBContext = new DBContext();
        }
        public bool Addhv(KhachHang kh)
        {
            _DBContext.Add(kh);
            _DBContext.SaveChanges();
            return true;

        }

        public List<KhachHang> GetAllkh()
        {
            return _DBContext.KhachHangs.ToList();
        }

        public bool Removehv(KhachHang kh)
        {
           _DBContext.Remove(kh);
            _DBContext.SaveChanges();
            return true;
        }

        public bool Update(KhachHang kh)
        {
            _DBContext.Update(kh);
            _DBContext.SaveChanges();
            return true;
        }
    }
}
