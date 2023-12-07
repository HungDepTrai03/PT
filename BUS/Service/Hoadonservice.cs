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
    public class Hoadonservice : IHoadonservice
    {
        private Hoadonrepository _repos;
        public Hoadonservice()
        {
            _repos = new Hoadonrepository();
        }
        public string Add(HoaDon hd)
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

        public List<HoaDon> GetHoaDons(string search)
        {
            if (search == null) 
            {
                return _repos.GetAllHD();
            }
            else
            {
                return _repos.GetAllHD().Where(x => x.MaHoaDon.Contains(search)).ToList();
            }
        }

        public string Remove(HoaDon hd)
        {
            var clone = _repos.GetAllHD().FirstOrDefault(x => x.MaHoaDon == hd.MaHoaDon);
            //Gọi repos để xóa clone
            if (_repos.Removehd(clone) == true)
            {
                return "Xóa thành công";
            }
            else
            {
                return "Xóa thất bại";
            }
        }

        public string Update(HoaDon hd)
        {
          var clone = _repos.GetAllHD().FirstOrDefault(x=>x .MaHoaDon == hd.MaHoaDon);
            clone.MaHoaDon = hd.MaHoaDon;
            clone.NgayLap = hd.NgayLap;
            clone.TrangThaiHoaDon = hd .TrangThaiHoaDon;
            clone.TrangThaiThanhToan = hd.TrangThaiThanhToan;
            clone.GiamGia = hd.GiamGia;
            clone.HoaDonChiTiets = hd.HoaDonChiTiets;
            clone.MaKhachHang = hd.MaKhachHang;
            clone.MaThanhToan = hd.MaThanhToan;
            clone.MaNhanVien = hd.MaNhanVien;
            clone.ThanhTien = hd.ThanhTien;
            clone.TongTien = hd.TongTien;
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
