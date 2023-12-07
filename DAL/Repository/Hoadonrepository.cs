using DAL.IRepository;
using Microsoft.EntityFrameworkCore;
using PRL.Context;
using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class Hoadonrepository : IHoadonrepo
    {
        private DBContext _dbContext;
        public Hoadonrepository()
        {
            _dbContext = new DBContext();
        }
        public bool Addhd(HoaDon hd)
        {
            _dbContext.Add(hd);
            _dbContext.SaveChanges();
            return true;
        }

        public List<HoaDon> GetAllHD()
        {
            return _dbContext.HoaDons.ToList();
        }

        public bool Removehd(HoaDon hd)
        {
            _dbContext.Remove(hd);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Updatehd(HoaDon hd)
        {

            _dbContext.Update(hd);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
