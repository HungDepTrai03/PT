using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface Ilichlamviecservice
    {
        public string Add(LichLamViec llv);

        public string Remove(LichLamViec llv);

        public string Update(LichLamViec llv);

        public List<LichLamViec> GetLichLamViecs(string search);

    }
}
