using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IDichvuservice
    {
        public string Addd(DichVu dichVu);
        public string Remove(DichVu dichVu);
        public string Update(DichVu dichVu);
        public List<DichVu> GetDichvu(string search);
    }
}

