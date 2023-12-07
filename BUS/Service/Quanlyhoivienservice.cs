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
    public class Quanlyhoivienservice : IQuanlyhoivienservice
    {
        private Quanlyhoivienrepo _repos;

        public Quanlyhoivienservice()
        {
            _repos = new Quanlyhoivienrepo();
        }
        public string Add(KhachHang kh)
        {
            if (_repos.Addhv(kh) == true)
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public string Delete(KhachHang kh)
        {
            var clone = _repos.GetAllkh().FirstOrDefault(x => x.MaKhachHang == kh.MaKhachHang);
            
            if (_repos.Removehv(clone) == true)
            {
                return "Xóa thành công";
            }
            else
            {
                return "Xóa thất bại";
            }
        }

        public List<KhachHang> GetKhachHangs(string search)
        {
            if (search == null) 
            {
                return _repos.GetAllkh();
            }
            else
            {
                return _repos.GetAllkh().Where(x => x.MaKhachHang.Contains(search)).ToList();
            }
        }

        public string Update(KhachHang kh)
        {
            var clone = _repos.GetAllkh().FirstOrDefault(x => x.MaKhachHang == kh.MaKhachHang);
            clone.TenKhachHang = kh.TenKhachHang;
            clone.MaKhachHang = kh.MaKhachHang;
            clone.NgaySinh = kh.NgaySinh;
            clone.DiaChi =kh.DiaChi;
            clone.GioiTinh = kh.GioiTinh;
            clone.Email = kh.Email;
            clone.NgaySinh = kh.NgaySinh;
            clone.SoDienThoai = kh.SoDienThoai;
            

           
            if (_repos.Update(clone) == true)
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
