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
    public class Dichvuservice : IDichvuservice
    {
        private Dichvurepo _repos;
        public Dichvuservice()
        {
            _repos = new Dichvurepo();
        }
        public string Addd(DichVu dichVu)
        {
            if (_repos.Adddv(dichVu) == true)
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public List<DichVu> GetDichvu(string search)
        {
            if (search == null) 
            {
                return _repos.GetAlldv();
            }
            else
            {
                return _repos.GetAlldv().Where(x => x.MaDichVu.Contains(search)).ToList();
            }
        }

        public string Remove(DichVu dichVu)
        {
            var clone = _repos.GetAlldv().FirstOrDefault(x => x.MaDichVu == dichVu.MaDichVu);
            
            if (_repos.Deletedv(clone) == true)
            {
                return "Xóa thành công";
            }
            else
            {
                return "Xóa thất bại";
            }
        }

        public string Update(DichVu dichVu)
        {
            var clone = _repos.GetAlldv().FirstOrDefault(x => x.MaDichVu == dichVu.MaDichVu);
          clone.MaDichVu = dichVu.MaDichVu;
            clone.TenDichVu = dichVu.TenDichVu;
            clone.MaHopDong = dichVu.MaHopDong;
            clone.Gia = dichVu.Gia;
            clone.ThoiHan = dichVu.ThoiHan;
            clone.GhiChu = dichVu.GhiChu;
            clone.MaHopDong = dichVu.MaHopDong;
            clone.HoaDonChiTiets = dichVu.HoaDonChiTiets;
            if (_repos.Updatedv(clone) == true)
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
