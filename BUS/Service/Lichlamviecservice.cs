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
    public class Lichlamviecservice : Ilichlamviecservice
    {
        private LichlamviecRepo _repos;
        public Lichlamviecservice()
        {
            _repos = new LichlamviecRepo();
        }
        public string Add(LichLamViec llv)
        {
            if (_repos.Addlichlamviec(llv) == true)
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public List<LichLamViec> GetLichLamViecs(string search)
        {
            if (search == null) 
            {
                return _repos.GetAlllichlamviec();
            }
            else
            {
                return _repos.GetAlllichlamviec().Where(x => x.MaLich.Contains(search)).ToList();
            }
        }

        public string Remove(LichLamViec llv)
        {
            var clone = _repos.GetAlllichlamviec().FirstOrDefault(x => x.MaLich == llv.MaLich);
            //Gọi repos để xóa clone
            if (_repos.Removelichlamviec(clone) == true)
            {
                return "Xóa thành công";
            }
            else
            {
                return "Xóa thất bại";
            }
        }

        public string Update(LichLamViec llv)
        {
            var clone = _repos.GetAlllichlamviec().FirstOrDefault(x => x.MaLich == llv.MaLich);
            clone.MaLich = llv.MaLich;
            clone.Ca = llv.Ca;
            clone.NgayTap = llv.NgayTap;
            clone.TrangThai = llv.TrangThai;
            clone.MaPt = llv.MaPt;
           
            if (_repos.Updatelichlamviec(clone) == true)
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
