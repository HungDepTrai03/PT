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
    public class Giamgiarepo : IGiamgiarepo
    {
        private DBContext _DBContext;
        public Giamgiarepo()
        {
            _DBContext = new DBContext();
        }
        public bool AddKm(GiamGium gg)
        {
            _DBContext.Add(gg);
            _DBContext.SaveChanges();
            return true;
        }

        public bool DeleteKm(GiamGium gg)
        {
            _DBContext.Remove(gg);
            _DBContext.SaveChanges();
            return true;
        }

        public List<GiamGium> GetAllKm()
        {
            return _DBContext.GiamGia.ToList();
        }

        public bool UpdateKm(GiamGium gg)
        {
            _DBContext.Update(gg);
            _DBContext.SaveChanges();
            return true;
        }
    }
}
