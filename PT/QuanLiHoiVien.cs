using BUS.Service;
using PRL.DomainClass;
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
    public partial class QuanLiHoiVien : Form
    {
        private Quanlyhoivienservice _service;
        private Hopdongservice _hopdongservice;

        public QuanLiHoiVien()
        {
            InitializeComponent();
            _service = new Quanlyhoivienservice();
            _hopdongservice = new Hopdongservice();
            LoadData(null);
            LoadData2(null);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            DateTime dt = this.date_NgaySinh.Value.Date;
            var qlhv = new KhachHang();
            qlhv.MaKhachHang = tb_MaHoiVien.Text;
            qlhv.TenKhachHang = tb_TenHoiVien.Text;
            qlhv.NgaySinh = dt;
            qlhv.GioiTinh = txtgioitinh.Text;
            qlhv.SoDienThoai = tb_SoDienThoai.Text;
            qlhv.Email = tb_Email.Text;
            var option = MessageBox.Show("Xác nhận muốn thêm?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Add(qlhv));
            }
            else
            {
                return;
            }

        }
        public void LoadData(string search)
        {
            int stt = 1;
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Mã Hội Viên";
            dataGridView1.Columns[2].Name = "Tên Hội Viên";
            dataGridView1.Columns[3].Name = "Ngày Sinh";
            dataGridView1.Columns[4].Name = "Giới Tính";
            dataGridView1.Columns[5].Name = "Số Điện Thoại";
            dataGridView1.Columns[6].Name = "Email";
            dataGridView1.Rows.Clear();
            foreach (var hv in _service.GetKhachHangs(txtTimKiem.Text))
            {
                dataGridView1.Rows.Add(stt++, hv.MaKhachHang, hv.TenKhachHang, hv.NgaySinh, hv.GioiTinh, hv.SoDienThoai, hv.Email);
            }
            

        }
        public void LoadData2(string search)
        {
            int stt = 1;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Mã Hợp Đồng";

            dataGridView1.Columns[2].Name = "Ngày Đăng Kí";
            dataGridView1.Columns[3].Name = "Ngày Kết Thúc";


            dataGridView1.Rows.Clear();
            foreach (var hv in _hopdongservice.GetHopDongs(txtTimKiem.Text))
            {
                dataGridView1.Rows.Add(stt++, hv.MaHopDong, hv.NgayDangKi, hv.NgayKetThuc);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var sv = new KhachHang();



            var option = MessageBox.Show("Xác nhận muốn Xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Delete(sv));
            }
            else
            {
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime dt = this.date_NgaySinh.Value.Date;
            var qlhv = new KhachHang();
            qlhv.MaKhachHang = tb_MaHoiVien.Text;
            qlhv.TenKhachHang = tb_TenHoiVien.Text;
            qlhv.NgaySinh = dt;
            qlhv.GioiTinh = txtgioitinh.Text;
            qlhv.SoDienThoai = tb_SoDienThoai.Text;
            qlhv.Email = tb_Email.Text;
            var option = MessageBox.Show("Xác nhận muốn Sửa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Update(qlhv));
            }
            else
            {
                return;
            }

        }

        private void tbHopDong_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_HopDong_Click(object sender, EventArgs e)
        {
            var hd = new HopDong();
            DateTime dt = this.date_NgayDangKi.Value.Date;
            DateTime dt2 = this.date_NgayHetHan.Value.Date;

            hd.MaHopDong = txt_MaHopDong.Text;
            hd.NgayDangKi = dt;
            hd.NgayKetThuc = dt2;


            var option = MessageBox.Show("Xác nhận muốn thêm?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_hopdongservice.Add(hd));
            }
            else
            {
                return;
            }
            
        }

        private void btn_Delete_HopDong_Click(object sender, EventArgs e)
        {
            var hd = new HopDong();



            var option = MessageBox.Show("Xác nhận muốn Xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_hopdongservice.Remove(hd));
            }
            else
            {
                return;
            }
        }

        private void btn_Update_HopDong_Click(object sender, EventArgs e)
        {
            var hd = new HopDong();


            DateTime dt = this.date_NgayDangKi.Value.Date;
            DateTime dt2 = this.date_NgayHetHan.Value.Date;

            hd.MaHopDong = txt_MaHopDong.Text;
            hd.NgayDangKi = dt;
            hd.NgayKetThuc = dt2;
            var option = MessageBox.Show("Xác nhận muốn Sửa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_hopdongservice.Update(hd));
            }
            else
            {
                return;
            }

        }

        private void btn_TimKiem_HOpDong_Click(object sender, EventArgs e)
        {


        }

        private void txt_TimKiem_HopDong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtTimKiem.Text);
        }
    }
}
