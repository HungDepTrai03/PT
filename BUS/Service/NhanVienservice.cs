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
    public class NhanVienservice : INhanVienserviec
    {
        private NhanVienRepo _repos;
        public NhanVienservice()
        {
            _repos = new NhanVienRepo();
        }
        public string Add(NhanVien11 nv)
        {
            if (_repos.Addnv(nv) == true)
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public List<NhanVien11> GetNhanViens(string search)
        {
            if (search == null) 
            {
                return _repos.GetAllnv();
            }
            else
            {
                return _repos.GetAllnv().Where(x => x.MaNhanVien.Contains(search)).ToList();
            }
        }

        public string Remove(NhanVien11 nv)
        {
            var clone = _repos.GetAllnv().FirstOrDefault(x => x.MaNhanVien == nv.MaNhanVien);
         
            if (_repos.Removenv(clone) == true)
            {
                return "Xóa thành công";
            }
            else
            {
                return "Xóa thất bại";
            }
        }

        public string Update(NhanVien11 nv)
        {
            var repo = _repos.GetAllnv().FirstOrDefault(x => x.MaNhanVien == nv.MaNhanVien);

            repo.MaNhanVien = nv.MaNhanVien;
            repo.TenNhanVien = nv.TenNhanVien;
            repo.ChucVu = nv.ChucVu;
            repo.SoDienThoai = nv.SoDienThoai;
            repo.GioiTinh = nv.GioiTinh;
            repo.NgaySinh = nv.NgaySinh;
            repo.DiaChi = nv.DiaChi;
            repo.TrangThai = nv.TrangThai;
           
            if (_repos.Updatenv(repo) == true)
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
