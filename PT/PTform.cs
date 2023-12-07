using BUS;
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
    public partial class ptform : Form
    {
        private PTservice _sevice;

        private int _idWhenclick;
        public ptform()
        {
            InitializeComponent();
            _sevice = new PTservice();
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pt = new Pt();
            DateTime dt = this.dateTimePicker1.Value.Date;
            pt.MaPt = txtma.Text;
            pt.TenPt = txtten.Text;
            pt.Email = txtemail.Text;
            pt.DiaChi = txtdiacchi.Text;
            pt.GioiTinh = comboBox1.Text;
            pt.SoDienThoai = txtsdt.Text;
            pt.NgaySinh = dt;
            var option = MessageBox.Show("Xac Nhan Muon Them?", "Xac Nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_sevice.AddPT(pt));
            }
            else
            {
                return;
            }


        }
        public void LoadData()
        {
            int stt = 1;
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "MaPT";
            dataGridView1.Columns[2].Name = "TenPT";
            dataGridView1.Columns[3].Name = "NgaySinh";
            dataGridView1.Columns[4].Name = "GioiTinh";
            dataGridView1.Columns[5].Name = "DiaChi";
            dataGridView1.Columns[6].Name = "SDT";
            dataGridView1.Columns[7].Name = "Email";
            dataGridView1.Columns[8].Name = "Calam";
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Rows.Clear();
            foreach (var pt in _sevice.GetPTs(textBox7.Text))
            {
                dataGridView1.Rows.Add(stt++, pt.MaPt, pt.TenPt, pt.NgaySinh, pt.GioiTinh, pt.DiaChi, pt.SoDienThoai, pt.Email, pt.LichLamViecs);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void button3_Click(object sender, EventArgs e)
        {

            var pt = new Pt();



            var option = MessageBox.Show("Xác nhận muốn Xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_sevice.RemovePT(pt));
            }
            else
            {
                return;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            var PT = new Pt();
            PT.MaPt = txtma.Text;
            PT.TenPt = txtten.Text;
            PT.Email = txtemail.Text;
            PT.DiaChi = txtdiacchi.Text;
            PT.GioiTinh = comboBox1.Text;
            PT.SoDienThoai = txtsdt.Text;
            DateTime dt = this.dateTimePicker1.Value.Date;
            PT.NgaySinh = dt;



            var option = MessageBox.Show("Xác nhận muốn Sửa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_sevice.UpdatePT(PT));
            }
            else
            {
                return;
            }

        }
    }
}
