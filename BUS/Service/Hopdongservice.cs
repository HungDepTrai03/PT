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
    public class Hopdongservice : IHopdongservice
    {
        private Hopdongrepo _repos;
        public Hopdongservice()
        {
            _repos = new Hopdongrepo();
        }
        public string Add(HopDong hd)
        {
            if (_repos.Addhd(hd) == true)
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public List<HopDong> GetHopDongs(string search)
        {
            if (search == null) 
            {
                return _repos.GetAllHD();
            }
            else
            {
                return _repos.GetAllHD().Where(x => x.MaHopDong.Contains(search)).ToList();
            }
        }

        public string Remove(HopDong hd)
        {
            var clone = _repos.GetAllHD().FirstOrDefault(x => x.MaHopDong == hd.MaHopDong);
         
            if (_repos.Removehd(clone) == true)
            {
                return "Xóa thành công";
            }
            else
            {
                return "Xóa thất bại";
            }
        }

        public string Update(HopDong hd)
        {
            var clone = _repos.GetAllHD().FirstOrDefault(x => x.MaHopDong == hd.MaHopDong);
            clone.MaHopDong = hd.MaHopDong;
            clone.MaKhachHang = hd.MaKhachHang;
            clone.MaPt = hd.MaPt;
            clone.NgayDangKi = hd.NgayDangKi;
            clone.NgayKetThuc = hd.NgayKetThuc;
            clone.DichVus = hd.DichVus;
            if (_repos.Updatehd(clone) == true)
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }


        }
    }
}
