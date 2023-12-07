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
    public class Hopdongrepo : IHopdongrepo
    {
        private DBContext _dbcontext;
        public Hopdongrepo()
        {
            _dbcontext = new DBContext();
        }
        public bool Addhd(HopDong hd)
        {
          _dbcontext.Add(hd);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<HopDong> GetAllHD()
        {
            return _dbcontext.HopDongs.ToList();
        }

        public bool Removehd(HopDong hd)
        {_dbcontext.Remove(hd);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Updatehd(HopDong hd)
        {
            _dbcontext.Update(hd);
            _dbcontext.SaveChanges() ;
            return true;
        }
    }
}
