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
    public class Dichvurepo : IDichvuRepo
    {
        private DBContext _dbcontext;
        public Dichvurepo()
        {
            _dbcontext = new DBContext();
        }
        public bool Adddv(DichVu dv)
        {
            _dbcontext.Add(dv);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Deletedv(DichVu dv)
        {
            _dbcontext.Remove(dv);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<DichVu> GetAlldv()
        {
           return _dbcontext.DichVus.ToList();
        }

        public bool Updatedv(DichVu dv)
        {
           _dbcontext.Update(dv);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
