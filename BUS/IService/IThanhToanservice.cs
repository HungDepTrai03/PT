using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IThanhToanservice
    {
        public string Add(ThanhToan tt);

      

        public List<ThanhToan> GetThanhToans(string search);
    }
}
