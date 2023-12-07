using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface ILichlamviec
    {
        public bool Addlichlamviec(LichLamViec llv);
        public bool Removelichlamviec(LichLamViec llv);
        public bool Updatelichlamviec(LichLamViec llv);
        public List<LichLamViec> GetAlllichlamviec();
    }
}
