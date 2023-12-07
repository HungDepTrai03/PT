using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IPTRepository
    {
        public bool AddPT(Pt pt);
        public bool RemovePT(Pt pt);

        public bool UpdatePT(Pt pt);

        public List<Pt> GetAllPTs();
    }
}
