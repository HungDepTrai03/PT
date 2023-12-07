using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IGiamgiaservice
    {
        public string Add(GiamGium giamgia);

        public string Update(GiamGium giamgia);

        public string Remove(GiamGium giamgia);

        public List<GiamGium> GetGiamGia(string search);
    }
}
