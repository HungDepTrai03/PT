using DAL.IRepository;
using PRL.Context;
using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PTRepository : IPTRepository

    {
        private DBContext dBContext;

        public PTRepository()
        {
            dBContext = new DBContext();
        }
        public bool AddPT(Pt pt)
        {
            dBContext.Add(pt);
            dBContext.SaveChanges();
            return true;
        }

        public List<Pt> GetAllPTs()
        {
           return dBContext.Pts.ToList();
        }

        public bool RemovePT(Pt pt)
        {
           dBContext.Remove(pt);
            dBContext.SaveChanges();
            return true;

        }

        public bool UpdatePT(Pt pt)
        {
           dBContext.Update(pt);
            dBContext.SaveChanges();
            return true;
        }
    }
}
