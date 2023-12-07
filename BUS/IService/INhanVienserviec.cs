using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface INhanVienserviec
    {
        public string Add(NhanVien11 nv);

        public string Remove(NhanVien11 nv);

        public string Update(NhanVien11 nv);

        public List<NhanVien11> GetNhanViens(string search);
    }
}
