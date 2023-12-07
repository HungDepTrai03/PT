using BUS;
using BUS.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class GiaoDich : Form
    {
        private Hoadonservice _service;

        public GiaoDich()
        {
            InitializeComponent();
            _service = new Hoadonservice();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {

            int stt = 1;

            DT_HoaDon.ColumnCount = 11;

            DT_HoaDon.Columns[0].Name = "STT";
            DT_HoaDon.Columns[1].Name = "Mã Hóa Đơn";
            DT_HoaDon.Columns[2].Name = "Mã Nhân Viên";
            DT_HoaDon.Columns[3].Name = "Mã Khách Hàng";
            DT_HoaDon.Columns[4].Name = "Mã Thanh Toán";
            DT_HoaDon.Columns[5].Name = "Ngày Lập";
            DT_HoaDon.Columns[6].Name = "Tổng Tiền";
            DT_HoaDon.Columns[7].Name = "Gỉam Gía";
            DT_HoaDon.Columns[8].Name = "Thành Tiền";
            DT_HoaDon.Columns[9].Name = "Trạng thái hóa đơn";
            DT_HoaDon.Columns[10].Name = "Trạng Thái Thanh Toán";



            DT_HoaDon.Columns[1].Visible = false;

            DT_HoaDon.Rows.Clear();
            foreach (var sv in _service.GetHoaDons(txt_TimKiemHoaDon.Text))
            {
                DT_HoaDon.Rows.Add(stt++, sv.MaHoaDon, sv.MaNhanVien, sv.MaKhachHang, sv.MaThanhToan, sv.NgayLap, sv.TongTien, sv.GiamGia, sv.ThanhTien, sv.TrangThaiHoaDon, sv.TrangThaiHoaDon);
            }
        }

        private void btn_TimKiemHoaDon_Click(object sender, EventArgs e)
        {
            
        }
    }
}
