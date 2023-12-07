using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IThietbirepo
    {
        public bool Addtbi(ThietBi tbi);

        public bool Removetbi(ThietBi tbi);

        public bool Updatetbi(ThietBi tbi);

        public List<ThietBi> GetAlltbi();
    }
}
