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
    public partial class Thietbi : Form
    {
        private Thietbiservice _service;
        private int _idwhenclick;
        public Thietbi()
        {
            InitializeComponent();
            _service = new Thietbiservice();
            LoadData(null);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var tbi = new ThietBi();
            tbi.MauSac = txtmausac.Text;
            tbi.MaLoaiThietBi = txtloaithietbi
                .Text;
            tbi.MauSac = txtmausac.Text;
            tbi.ViTri = txtvitri.Text;
            tbi.TenThietBi = txttentbi.Text;
            tbi.Gia = decimal.Parse(txtgiatien.Text);
            tbi.TrangThai = txttrangthai.Text;
            tbi.KhoiLuong = int.Parse(txtkhoiluong.Text);





            var option = MessageBox.Show("Xác nhận muốn thêm?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Add(tbi));
            }
            else
            {
                return;
            }
        }

        private void Thietbi_Load(object sender, EventArgs e)
        {

        }
        public void LoadData(string search)
        {
            int stt = 1;
            dataGridView1.ColumnCount = 8;

            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Loại Thiết Bị ";
            dataGridView1.Columns[2].Name = "Tên Thiết Bị";
            dataGridView1.Columns[3].Name = "Vị Trí";
            dataGridView1.Columns[4].Name = "Màu Sắc";

            dataGridView1.Columns[5].Name = "Khối Lượng";
            dataGridView1.Columns[6].Name = "Gía Tiền ";
            dataGridView1.Columns[7].Name = "Trạng Thái";
            dataGridView1.Rows.Clear();
            foreach (var tbi in _service.GetThietBis(txtsearch.Text))
            {
                dataGridView1.Rows.Add(stt++, tbi.MaLoaiThietBi, tbi.TenThietBi, tbi.ViTri, tbi.MauSac, tbi.KhoiLuong, tbi.Gia, tbi.TrangThai);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowindex = e.RowIndex;

            _idwhenclick = int.Parse(dataGridView1.Rows[rowindex].Cells[1].Value.ToString());


        }

        private void button4_Click(object sender, EventArgs e)
        {
            var tbi = new ThietBi();
            tbi.MauSac = txtmausac.Text;
            tbi.MaLoaiThietBi = txtloaithietbi
                .Text;
            tbi.MauSac = txtmausac.Text;
            tbi.ViTri = txtvitri.Text;
            tbi.TenThietBi = txttentbi.Text;
            tbi.Gia = decimal.Parse(txtgiatien.Text);
            tbi.TrangThai = txttrangthai.Text;
            tbi.KhoiLuong = int.Parse(txtkhoiluong.Text);

            var option = MessageBox.Show("Xác nhận muốn Sửa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Update(tbi));
            }
            else
            {
                return;
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            var tbi = new ThietBi();



            var option = MessageBox.Show("Xác nhận muốn Xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Remove(tbi));
            }
            else
            {
                return;
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtsearch.Text);
        }
    }
}
