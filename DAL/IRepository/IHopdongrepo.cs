using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IHopdongrepo
    {
        public bool Addhd(HopDong hd);
        public bool Removehd(HopDong hd);
        public bool Updatehd(HopDong hd);
        public List<HopDong> GetAllHD();
    }
}
