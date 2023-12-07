using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface INhanvienrepo
    {
        public bool Addnv(NhanVien11 nv);

        public bool Removenv(NhanVien11 nv);

        public bool Updatenv(NhanVien11 nv);

        public List<NhanVien11> GetAllnv();
    }
}
