using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public  interface IGiamgiarepo
    {
        public bool AddKm(GiamGium gg);

        public bool UpdateKm(GiamGium gg);

        public bool DeleteKm(GiamGium gg);

        public List<GiamGium> GetAllKm();
    }
}
