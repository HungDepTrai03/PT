using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IHoadonservice
    {
        public string Add(HoaDon hd);
        public string Remove(HoaDon hd);
        public string Update(HoaDon hd);
        public List<HoaDon> GetHoaDons (string search);
    }
}
