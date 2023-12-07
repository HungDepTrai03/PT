using DAL.IRepository;
using PRL.Context;
using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class LichlamviecRepo : ILichlamviec
    {
        private DBContext _dbcontext;
        public LichlamviecRepo()
        {
            _dbcontext = new DBContext();
        }

        public bool Addlichlamviec(LichLamViec llv)
        {
            _dbcontext.Add(llv);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<LichLamViec> GetAlllichlamviec()
        {
            return _dbcontext.LichLamViecs.ToList();
        }

        public bool Removelichlamviec(LichLamViec llv)
        {
            _dbcontext.Remove(llv);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Updatelichlamviec(LichLamViec llv)
        {
            _dbcontext.Update(llv);
            _dbcontext.SaveChanges() ; return true;
        }
    }
}
