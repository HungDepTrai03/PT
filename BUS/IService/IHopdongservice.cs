using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IHopdongservice
    {
        public string Add(HopDong hd);
        public string Remove(HopDong hd);
        public string Update(HopDong hd);
        public List<HopDong> GetHopDongs(string search);
    }
}
