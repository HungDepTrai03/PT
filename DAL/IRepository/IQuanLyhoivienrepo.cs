using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
   public interface IQuanLyhoivienrepo
    {
        public bool Addhv(KhachHang kh);

        public bool Removehv(KhachHang kh);

        public bool Update(KhachHang kh);

        public List<KhachHang> GetAllkh();
    }
}
