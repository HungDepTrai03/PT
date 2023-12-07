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
    public partial class KhuyenMai : Form
    {
        private GiamGiaservice _service;

        public KhuyenMai()
        {
            InitializeComponent();
            _service = new GiamGiaservice();
        }

        public void LoadGrid(string search)
        {
            int stt = 1;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Mã Khuyến Mại";

            dataGridView1.Columns[2].Name = "Ngày hết hạn";
            dataGridView1.Columns[3].Name = "Gía Trị";
            dataGridView1.Columns[4].Name = "Mô tả";

            dataGridView1.Rows.Clear();
            foreach (var km in _service.GetGiamGia(txtsearch.Text))
            {
                dataGridView1.Rows.Add(stt++, km.MaGiamGia, km.NgayHetHan, km.GiaGiam, km.MoTa);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var km = new GiamGium();
            DateTime dt = this.dateTimePicker2.Value.Date;
            km.MaGiamGia = txtmakm.Text;
            km.NgayHetHan = dt;
            km.MoTa = txtmota.Text;
            km.GiaGiam = decimal.Parse(txtgiatri.Text);
            var option = MessageBox.Show("Xác nhận muốn thêm?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Add(km));
            }
            else
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var gg = new GiamGium();


            var option = MessageBox.Show("Xác nhận muốn Xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Remove(gg));
            }
            else
            {
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var km = new GiamGium();
            DateTime dt = this.dateTimePicker2.Value.Date;
            km.MaGiamGia = txtmakm.Text;
            km.NgayHetHan = dt;
            km.MoTa = txtmota.Text;
            km.GiaGiam = decimal.Parse(txtgiatri.Text);
            var option = MessageBox.Show("Xác nhận muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Update(km));
            }
            else
            {
                return;
            }
        }
    }
}
