using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IQuanlyhoivienservice
    {
        public string Add(KhachHang kh);

        public string Update(KhachHang kh);

        public string Delete(KhachHang kh);

        public List<KhachHang> GetKhachHangs(string search);
    }
}
