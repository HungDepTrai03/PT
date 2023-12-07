
using DAL;
using PRL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PTservice : IPTservice
    {
        private PTRepository _repos;
        public PTservice()
        {
            _repos = new PTRepository();
        }
        public string AddPT(Pt pt)
        {
            if(_repos.AddPT(pt) == true) {
                return "Thêm thành công";
                   
            }
            else
            {
                return "Them that bai";
            }
        }

        public List<Pt> GetPTs(string search)
        {
            if(search == null)
            {
                return _repos.GetAllPTs();
            }
            else
            {
                return _repos.GetAllPTs().Where(x => x.TenPt.Contains(search)).ToList();
            }
        }

        public string RemovePT(Pt pt)
        {
            var clone = _repos.GetAllPTs().FirstOrDefault(x => x.MaPt == pt.MaPt);

            if(_repos.RemovePT(clone) == true)
            {
                return "Xoa Thanh cong";
            }
            else
            {
                return "Xoa That Bai";
            }
        }

        public string UpdatePT(Pt pt)
        {
            var clone = _repos.GetAllPTs().FirstOrDefault(x => x.MaPt == pt.MaPt);
            clone.TenPt = pt.TenPt;
            clone.SoDienThoai = pt.SoDienThoai;
            clone.HopDongs = pt.HopDongs;
            clone.DiaChi = pt.DiaChi;
            clone.NgaySinh = pt.NgaySinh;
            clone.Email = pt.Email;
            clone.GioiTinh = pt.GioiTinh;
            clone.LichLamViecs = pt.LichLamViecs;
            if(_repos.UpdatePT(clone) == true)
            {
                return "Update Than Cong";
            }
            else
            {
                return "Sua That Bai";
            }
        }
    }
}
