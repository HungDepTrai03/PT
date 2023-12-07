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
    public class Thietbirepo : IThietbirepo
    {
        private DBContext _dbcontext;
        public Thietbirepo()
        {
            _dbcontext = new DBContext();

        }

        public bool Addtbi(ThietBi tbi)
        {
            _dbcontext.Add(tbi);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<ThietBi> GetAlltbi()
        {
            return _dbcontext.ThietBis.ToList();
        }

        public bool Removetbi(ThietBi tbi)
        {
           _dbcontext.Remove(tbi);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Updatetbi(ThietBi tbi)
        {
            _dbcontext.Update(tbi);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
