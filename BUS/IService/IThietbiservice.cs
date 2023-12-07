using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
   public interface IThietbiservice
    {
        public string Add(ThietBi thbi);

        public string Remove(ThietBi thiet);

        public string Update(ThietBi thiet);

        public List<ThietBi> GetThietBis(string search);
    }
}
