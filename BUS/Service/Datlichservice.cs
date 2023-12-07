using BUS.IService;
using DAL.Repository;
using PRL.DomainClass;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class Datlichservice : IDatlichservice
    {
        private DatlichRepository _repos;
        public Datlichservice()
        {
            _repos = new DatlichRepository();
        }
        public string Addlich(DatLich1 dl)
        {
            if (_repos.Adddate(dl) == true)
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public string Deletelich(DatLich1 dl)
        {
            var clone = _repos.GetAllDatlich().FirstOrDefault(x => x.MaPhieuDatLich == dl.MaPhieuDatLich);
           
            if (_repos.Deletedate(clone) == true)
            {
                return "Xóa thành công";
            }
            else
            {
                return "Xóa thất bại";
            }
        }

        public List<DatLich1> GetDatLich(string search)
        {
            if (search == null) 
            {
                return _repos.GetAllDatlich();
            }
            else
            {
                return _repos.GetAllDatlich().Where(x => x.MaPhieuDatLich.Contains(search)).ToList();
            }
        }
    }
}
