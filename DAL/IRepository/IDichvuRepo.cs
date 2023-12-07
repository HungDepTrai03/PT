using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public  interface IDichvuRepo
    {
        public bool Adddv(DichVu dv);

        public bool Updatedv(DichVu dv);

        public bool Deletedv(DichVu dv);

        public List<DichVu> GetAlldv();
    }
}
