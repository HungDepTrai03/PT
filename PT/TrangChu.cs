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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void btn_HoiVien_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã vào chức năng quản lí hội viên !");
            QuanLiHoiVien QLHV = new QuanLiHoiVien();
            QLHV.Show();
        }

        private void btn_PT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã vào chức năng quản lí PT !");
            ptform ptform = new ptform();
            ptform.Show();
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã vào chức năng quản lí đặt lịch !");
            DatLich dl = new DatLich();
            dl.Show();
        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã vào chức năng quản lí thiết bị !");
            Thietbi tbi = new Thietbi();
            tbi.Show();
        }

        private void btnGiaoDich_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã vào chức năng quản lí giao dịch !");
            GiaoDich dl = new GiaoDich();
            dl.Show();
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã vào chức năng quản lí khuyến mãi !");
            KhuyenMai dl = new KhuyenMai();
            dl.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã vào chức năng quản lí nhân viên !");
            NhanVien dl = new NhanVien();
            dl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn đăng xuất không ?","Xác nhận",MessageBoxButtons.YesNo);
            Close();
        }
    }
}
