using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IHoadonrepo
    {
        public bool Addhd(HoaDon hd);
        public bool Removehd(HoaDon hd);
        public bool Updatehd(HoaDon hd);
        public List<HoaDon> GetAllHD();
    
}
}
