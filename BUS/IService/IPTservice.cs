using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public interface IPTservice
    {
        public string AddPT(Pt pt);
        public string RemovePT(Pt pt);

        public List<Pt> GetPTs(string search);

        public string UpdatePT(Pt pt);
    }
}
