using BUS.IService;
using DAL.Repository;
using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class Thanhtoanservice : IThanhToanservice
    {
        private ThanhToanrepo _repos;
        public Thanhtoanservice()
        {
            _repos = new ThanhToanrepo();
        }
        public string Add(ThanhToan tt)
        {
            if (_repos.Addtt(tt) == true)
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public List<ThanhToan> GetThanhToans(string search)
        {
            if (search == null)
            {
                return _repos.GetAllthanhtoan();
            }
            else
            {
                return _repos.GetAllthanhtoan().Where(x => x.MaThanhToan.Contains(search)).ToList();
            }
        }

    
    }
}
