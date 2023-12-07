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
    public class Thietbiservice : IThietbiservice
    {
        private Thietbirepo _repos;

        public Thietbiservice()
        {
            _repos = new Thietbirepo();
        }
        public string Add(ThietBi thbi)
        {
            if (_repos.Addtbi(thbi) == true)
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public List<ThietBi> GetThietBis(string search)
        {
            if (search == null) 
            {
                return _repos.GetAlltbi();
            }
            else
            {
                return _repos.GetAlltbi().Where(x => x.MaThietBi.Contains(search)).ToList();
            }
        }

        public string Remove(ThietBi thiet)
        {
            var clone = _repos.GetAlltbi().FirstOrDefault(x => x.MaThietBi == thiet.MaThietBi);
            
            if (_repos.Removetbi(clone) == true)
            {
                return "Xóa thành công";
            }
            else
            {
                return "Xóa thất bại";
            }
        }

        public string Update(ThietBi thiet)
        {
            
            var clone = _repos.GetAlltbi().FirstOrDefault(x => x.MaThietBi == thiet.MaThietBi);
            clone.TenThietBi = thiet.TenThietBi;
            clone.ViTri = thiet.ViTri;
            clone.MauSac = thiet.MauSac;
            clone.KhoiLuong = thiet.KhoiLuong;
            clone.Gia = thiet.Gia;
            clone.MaLoaiThietBi = thiet.MaLoaiThietBi;
            clone.TrangThai = thiet.TrangThai;
            
           
            if (_repos.Updatetbi(clone) == true)
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
