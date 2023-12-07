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
    public class GiamGiaservice : IGiamgiaservice
    {
        private Giamgiarepo _repos;
        public GiamGiaservice()
        {
            _repos = new Giamgiarepo();
        }

        public string Add(GiamGium giamgia)
        {
            if (_repos.AddKm(giamgia) == true)
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public List<GiamGium> GetGiamGia(string search)
        {
            if (search == null) 
            {
                return _repos.GetAllKm();
            }
            else
            {
                return _repos.GetAllKm().Where(x => x.MaGiamGia.Contains(search)).ToList();
            }
        }

        public string Remove(GiamGium giamgia)
        {
            var clone = _repos.GetAllKm().FirstOrDefault(x => x.MaGiamGia == giamgia.MaGiamGia);
            
            if (_repos.DeleteKm(clone) == true)
            {
                return "Xóa thành công";
            }
            else
            {
                return "Xóa thất bại";
            }
        }

        public string Update(GiamGium giamgia)
        {
            var clone = _repos.GetAllKm().FirstOrDefault(x => x.MaGiamGia == giamgia.MaGiamGia);
            clone.MaGiamGia = giamgia.MaGiamGia;
            clone.NgayHetHan = giamgia.NgayHetHan;
            clone.MoTa = giamgia.MoTa;
            clone.HoaDonChiTiets = giamgia.HoaDonChiTiets;
            clone.GiaGiam = giamgia.GiaGiam;
            if (_repos.UpdateKm(clone) == true)
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
