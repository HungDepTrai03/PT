using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
   public interface IThanhToanrepo
    {
        public bool Addtt(ThanhToan tt);
        
        public List<ThanhToan> GetAllthanhtoan();
    }
}
