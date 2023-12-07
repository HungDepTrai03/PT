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
    public class ThanhToanrepo : IThanhToanrepo
    {
        private DBContext _dbContext;

        public ThanhToanrepo()
        {
            _dbContext = new DBContext();
        }

        public bool Addtt(ThanhToan tt)
        {
            _dbContext.Add(tt);
            _dbContext.SaveChanges();
            return true;
        }

        public List<ThanhToan> GetAllthanhtoan()
        {
           return _dbContext.ThanhToans.ToList();
        }
    }
}
