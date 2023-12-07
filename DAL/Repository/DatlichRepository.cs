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
    public class DatlichRepository : IDatLichrepo
    {
        private DBContext _dbContext;
        public DatlichRepository()
        {
            _dbContext = new DBContext();
        }
        public bool Adddate(DatLich1 dl)
        {
            _dbContext.Add(dl);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Deletedate(DatLich1 dl)
        {
            _dbContext.Remove(dl);
            _dbContext.SaveChanges();
            return true;
        }

        public List<DatLich1> GetAllDatlich()
        {
            return _dbContext.DatLiches.ToList();
        }
    }
}
