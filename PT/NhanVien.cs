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
    public partial class NhanVien : Form
    {
        private NhanVienservice _service;

        public NhanVien()
        {
            InitializeComponent();
            _service = new NhanVienservice();
            LoadGrid(null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nv = new NhanVien11();
            DateTime dt = this.dateTimePicker1.Value.Date;
            nv.TenNhanVien = txtten.Text;
            nv.ChucVu = txtchucvu.Text;
            nv.Email = txtemail.Text;
            nv.SoDienThoai = txtsdt.Text;
            nv.TrangThai = txttrangthai.Text;
            nv.NgaySinh = dt;
            nv.DiaChi = txtdiachi.Text;
            nv.GioiTinh = txtgioitinh.Text;
            var option = MessageBox.Show("Xác nhận muốn thêm ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Add(nv));
            }
            else
            {
                return;
            }


        }
        public void LoadGrid(string search)
        {
            int stt = 1;
            dataGridView1.ColumnCount = 10;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "ID";
            dataGridView1.Columns[2].Name = "Họ Và Tên";
            dataGridView1.Columns[3].Name = "Ngày Sinh";
            dataGridView1.Columns[4].Name = "Địa Chỉ";
            dataGridView1.Columns[5].Name = "Giới Tính";
            dataGridView1.Columns[6].Name = "Chức Vụ";
            dataGridView1.Columns[7].Name = "Số Điện Thoại";
            dataGridView1.Columns[8].Name = "Email";
            dataGridView1.Columns[9].Name = "Trạng Thái";
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Rows.Clear();
            foreach (var nv in _service.GetNhanViens(textBox1.Text))
            {
                dataGridView1.Rows.Add(stt++, nv.TenNhanVien, nv.NgaySinh, nv.DiaChi, nv.GioiTinh, nv.ChucVu, nv.SoDienThoai, nv.Email, nv.TrangThai);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadGrid(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var nv = new NhanVien11();

            nv.TenNhanVien = txtten.Text;
            nv.ChucVu = txtchucvu.Text;
            nv.Email = txtemail.Text;
            nv.DiaChi = txtdiachi.Text;
            nv.GioiTinh = txtgioitinh.Text;
            nv.SoDienThoai = txtsdt.Text;
            nv.TrangThai = txttrangthai.Text;
            DateTime dt = this.dateTimePicker1.Value.Date;
            nv.NgaySinh = dt;
            var option = MessageBox.Show("Xác nhận muốn sửa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Update(nv));
            }
            else
            {
                return;
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            var nv = new NhanVien11();
            var option = MessageBox.Show("Xác nhận muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Remove(nv));
            }
            else
            {
                return;
            }
        }
    }
}
