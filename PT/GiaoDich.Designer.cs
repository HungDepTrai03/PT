namespace PRL
{
    partial class GiaoDich
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            btnshow = new Button();
            btn_TimKiemHoaDon = new Button();
            txt_TimKiemHoaDon = new TextBox();
            label13 = new Label();
            DT_HoaDon = new DataGridView();
            tabPage1 = new TabPage();
            dateTimePicker1 = new DateTimePicker();
            label11 = new Label();
            dataGridView2 = new DataGridView();
            rd_QR = new RadioButton();
            rd_TienMat = new RadioButton();
            label12 = new Label();
            btnThanhToan = new Button();
            cb_LocMa = new ComboBox();
            btnApDungMa = new Button();
            dataGridView1 = new DataGridView();
            txt_HienThiGiaTien = new Label();
            txtKhuyenMai = new TextBox();
            txt_TongTien = new TextBox();
            txt_Giora = new TextBox();
            txt_GioVao = new TextBox();
            txtTenkhachHang = new TextBox();
            txt_DichVu = new TextBox();
            txt_MaHoaDon = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage3 = new TabPage();
            panel1 = new Panel();
            btnXoaDichVu = new Button();
            btn_ThemDichVu = new Button();
            txtTenDichVu = new TextBox();
            txtGia = new TextBox();
            txtThoiHan = new TextBox();
            txtGhiChu = new TextBox();
            txtMaDichVu = new TextBox();
            dataGridView3 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DT_HoaDon).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.None;
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(37, 13);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1173, 732);
            tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1165, 699);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Hóa đơn";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnshow);
            panel2.Controls.Add(btn_TimKiemHoaDon);
            panel2.Controls.Add(txt_TimKiemHoaDon);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(DT_HoaDon);
            panel2.Location = new Point(6, 7);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1160, 684);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // btnshow
            // 
            btnshow.Location = new Point(913, 10);
            btnshow.Margin = new Padding(3, 4, 3, 4);
            btnshow.Name = "btnshow";
            btnshow.Size = new Size(141, 31);
            btnshow.TabIndex = 5;
            btnshow.Text = "Show";
            btnshow.UseVisualStyleBackColor = true;
            btnshow.Click += btnshow_Click;
            // 
            // btn_TimKiemHoaDon
            // 
            btn_TimKiemHoaDon.Location = new Point(751, 10);
            btn_TimKiemHoaDon.Margin = new Padding(3, 4, 3, 4);
            btn_TimKiemHoaDon.Name = "btn_TimKiemHoaDon";
            btn_TimKiemHoaDon.Size = new Size(141, 31);
            btn_TimKiemHoaDon.TabIndex = 4;
            btn_TimKiemHoaDon.Text = "Tìm kiếm";
            btn_TimKiemHoaDon.UseVisualStyleBackColor = true;
            btn_TimKiemHoaDon.Click += btn_TimKiemHoaDon_Click;
            // 
            // txt_TimKiemHoaDon
            // 
            txt_TimKiemHoaDon.Location = new Point(147, 12);
            txt_TimKiemHoaDon.Margin = new Padding(3, 4, 3, 4);
            txt_TimKiemHoaDon.Name = "txt_TimKiemHoaDon";
            txt_TimKiemHoaDon.PlaceholderText = "Tìm kiếm hóa đơn";
            txt_TimKiemHoaDon.Size = new Size(598, 27);
            txt_TimKiemHoaDon.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label13.Location = new Point(5, 16);
            label13.Name = "label13";
            label13.Size = new Size(140, 23);
            label13.TabIndex = 2;
            label13.Text = "Tra cứu hóa đơn";
            label13.Click += label13_Click;
            // 
            // DT_HoaDon
            // 
            DT_HoaDon.BackgroundColor = SystemColors.ButtonHighlight;
            DT_HoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DT_HoaDon.Location = new Point(7, 43);
            DT_HoaDon.Margin = new Padding(3, 4, 3, 4);
            DT_HoaDon.Name = "DT_HoaDon";
            DT_HoaDon.RowHeadersWidth = 51;
            DT_HoaDon.RowTemplate.Height = 25;
            DT_HoaDon.Size = new Size(1146, 629);
            DT_HoaDon.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Controls.Add(rd_QR);
            tabPage1.Controls.Add(rd_TienMat);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(btnThanhToan);
            tabPage1.Controls.Add(cb_LocMa);
            tabPage1.Controls.Add(btnApDungMa);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(txt_HienThiGiaTien);
            tabPage1.Controls.Add(txtKhuyenMai);
            tabPage1.Controls.Add(txt_TongTien);
            tabPage1.Controls.Add(txt_Giora);
            tabPage1.Controls.Add(txt_GioVao);
            tabPage1.Controls.Add(txtTenkhachHang);
            tabPage1.Controls.Add(txt_DichVu);
            tabPage1.Controls.Add(txt_MaHoaDon);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1165, 699);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Thanh toán";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(159, 172);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(359, 27);
            dateTimePicker1.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label11.ForeColor = Color.DeepSkyBlue;
            label11.Location = new Point(728, 347);
            label11.Name = "label11";
            label11.Size = new Size(308, 37);
            label11.TabIndex = 28;
            label11.Text = "LỊCH SỬ THANH TOÁN";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(551, 399);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(606, 259);
            dataGridView2.TabIndex = 27;
            // 
            // rd_QR
            // 
            rd_QR.AutoSize = true;
            rd_QR.Location = new Point(442, 403);
            rd_QR.Margin = new Padding(3, 4, 3, 4);
            rd_QR.Name = "rd_QR";
            rd_QR.Size = new Size(86, 24);
            rd_QR.TabIndex = 26;
            rd_QR.TabStop = true;
            rd_QR.Text = "Quét QR";
            rd_QR.UseVisualStyleBackColor = true;
            // 
            // rd_TienMat
            // 
            rd_TienMat.AutoSize = true;
            rd_TienMat.Location = new Point(49, 403);
            rd_TienMat.Margin = new Padding(3, 4, 3, 4);
            rd_TienMat.Name = "rd_TienMat";
            rd_TienMat.Size = new Size(109, 24);
            rd_TienMat.TabIndex = 25;
            rd_TienMat.TabStop = true;
            rd_TienMat.Text = "Trả tiền mặt";
            rd_TienMat.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(30, 367);
            label12.Name = "label12";
            label12.Size = new Size(148, 20);
            label12.TabIndex = 24;
            label12.Text = "Hình thức thanh toán";
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.LawnGreen;
            btnThanhToan.Location = new Point(27, 432);
            btnThanhToan.Margin = new Padding(3, 4, 3, 4);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(491, 33);
            btnThanhToan.TabIndex = 23;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            // 
            // cb_LocMa
            // 
            cb_LocMa.FormattingEnabled = true;
            cb_LocMa.Items.AddRange(new object[] { "Thời gian", "Mã giảm giá" });
            cb_LocMa.Location = new Point(551, 13);
            cb_LocMa.Margin = new Padding(3, 4, 3, 4);
            cb_LocMa.Name = "cb_LocMa";
            cb_LocMa.Size = new Size(473, 28);
            cb_LocMa.TabIndex = 22;
            cb_LocMa.Text = "Bộ lọc tìm kiếm mã";
            // 
            // btnApDungMa
            // 
            btnApDungMa.BackColor = Color.LawnGreen;
            btnApDungMa.Location = new Point(1046, 13);
            btnApDungMa.Margin = new Padding(3, 4, 3, 4);
            btnApDungMa.Name = "btnApDungMa";
            btnApDungMa.Size = new Size(111, 33);
            btnApDungMa.TabIndex = 21;
            btnApDungMa.Text = "Áp dụng";
            btnApDungMa.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(551, 59);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(606, 259);
            dataGridView1.TabIndex = 19;
            // 
            // txt_HienThiGiaTien
            // 
            txt_HienThiGiaTien.AutoSize = true;
            txt_HienThiGiaTien.Location = new Point(450, 333);
            txt_HienThiGiaTien.Name = "txt_HienThiGiaTien";
            txt_HienThiGiaTien.Size = new Size(78, 20);
            txt_HienThiGiaTien.TabIndex = 18;
            txt_HienThiGiaTien.Text = "Thành tiền";
            // 
            // txtKhuyenMai
            // 
            txtKhuyenMai.Location = new Point(159, 248);
            txtKhuyenMai.Margin = new Padding(3, 4, 3, 4);
            txtKhuyenMai.Name = "txtKhuyenMai";
            txtKhuyenMai.Size = new Size(359, 27);
            txtKhuyenMai.TabIndex = 17;
            // 
            // txt_TongTien
            // 
            txt_TongTien.Location = new Point(159, 287);
            txt_TongTien.Margin = new Padding(3, 4, 3, 4);
            txt_TongTien.Name = "txt_TongTien";
            txt_TongTien.Size = new Size(359, 27);
            txt_TongTien.TabIndex = 15;
            // 
            // txt_Giora
            // 
            txt_Giora.Location = new Point(159, 132);
            txt_Giora.Margin = new Padding(3, 4, 3, 4);
            txt_Giora.Name = "txt_Giora";
            txt_Giora.Size = new Size(359, 27);
            txt_Giora.TabIndex = 9;
            // 
            // txt_GioVao
            // 
            txt_GioVao.Location = new Point(159, 93);
            txt_GioVao.Margin = new Padding(3, 4, 3, 4);
            txt_GioVao.Name = "txt_GioVao";
            txt_GioVao.Size = new Size(359, 27);
            txt_GioVao.TabIndex = 8;
            // 
            // txtTenkhachHang
            // 
            txtTenkhachHang.Location = new Point(159, 55);
            txtTenkhachHang.Margin = new Padding(3, 4, 3, 4);
            txtTenkhachHang.Name = "txtTenkhachHang";
            txtTenkhachHang.Size = new Size(359, 27);
            txtTenkhachHang.TabIndex = 7;
            // 
            // txt_DichVu
            // 
            txt_DichVu.Location = new Point(159, 209);
            txt_DichVu.Margin = new Padding(3, 4, 3, 4);
            txt_DichVu.Name = "txt_DichVu";
            txt_DichVu.Size = new Size(359, 27);
            txt_DichVu.TabIndex = 6;
            // 
            // txt_MaHoaDon
            // 
            txt_MaHoaDon.Location = new Point(159, 16);
            txt_MaHoaDon.Margin = new Padding(3, 4, 3, 4);
            txt_MaHoaDon.Name = "txt_MaHoaDon";
            txt_MaHoaDon.Size = new Size(359, 27);
            txt_MaHoaDon.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 256);
            label9.Name = "label9";
            label9.Size = new Size(86, 20);
            label9.TabIndex = 16;
            label9.Text = "Khuyến mãi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 295);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 14;
            label8.Text = "Tổng tiền";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 333);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 12;
            label7.Text = "Thanh toán";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 179);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 10;
            label6.Text = "Ngày";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 217);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 4;
            label5.Text = "Dịch vụ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 140);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Giờ ra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 101);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Giờ vào";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 63);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 24);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(panel1);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(1165, 699);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Dịch vụ";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnXoaDichVu);
            panel1.Controls.Add(btn_ThemDichVu);
            panel1.Controls.Add(txtTenDichVu);
            panel1.Controls.Add(txtGia);
            panel1.Controls.Add(txtThoiHan);
            panel1.Controls.Add(txtGhiChu);
            panel1.Controls.Add(txtMaDichVu);
            panel1.Location = new Point(856, 9);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 683);
            panel1.TabIndex = 1;
            // 
            // btnXoaDichVu
            // 
            btnXoaDichVu.BackColor = Color.OrangeRed;
            btnXoaDichVu.Location = new Point(8, 371);
            btnXoaDichVu.Margin = new Padding(3, 4, 3, 4);
            btnXoaDichVu.Name = "btnXoaDichVu";
            btnXoaDichVu.Size = new Size(291, 44);
            btnXoaDichVu.TabIndex = 9;
            btnXoaDichVu.Text = "Xóa dịch vụ";
            btnXoaDichVu.UseVisualStyleBackColor = false;
            // 
            // btn_ThemDichVu
            // 
            btn_ThemDichVu.BackColor = Color.GreenYellow;
            btn_ThemDichVu.Location = new Point(8, 321);
            btn_ThemDichVu.Margin = new Padding(3, 4, 3, 4);
            btn_ThemDichVu.Name = "btn_ThemDichVu";
            btn_ThemDichVu.Size = new Size(291, 41);
            btn_ThemDichVu.TabIndex = 8;
            btn_ThemDichVu.Text = "Thêm dịch vụ";
            btn_ThemDichVu.UseVisualStyleBackColor = false;
            // 
            // txtTenDichVu
            // 
            txtTenDichVu.Location = new Point(7, 60);
            txtTenDichVu.Margin = new Padding(3, 4, 3, 4);
            txtTenDichVu.Name = "txtTenDichVu";
            txtTenDichVu.PlaceholderText = "Tên dịch vụ";
            txtTenDichVu.Size = new Size(292, 27);
            txtTenDichVu.TabIndex = 7;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(8, 99);
            txtGia.Margin = new Padding(3, 4, 3, 4);
            txtGia.Name = "txtGia";
            txtGia.PlaceholderText = "Giá";
            txtGia.Size = new Size(292, 27);
            txtGia.TabIndex = 6;
            // 
            // txtThoiHan
            // 
            txtThoiHan.Location = new Point(8, 137);
            txtThoiHan.Margin = new Padding(3, 4, 3, 4);
            txtThoiHan.Name = "txtThoiHan";
            txtThoiHan.PlaceholderText = "Thời hạn";
            txtThoiHan.Size = new Size(292, 27);
            txtThoiHan.TabIndex = 5;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(8, 176);
            txtGhiChu.Margin = new Padding(3, 4, 3, 4);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.PlaceholderText = "Ghi chú";
            txtGhiChu.Size = new Size(292, 119);
            txtGhiChu.TabIndex = 4;
            // 
            // txtMaDichVu
            // 
            txtMaDichVu.Location = new Point(8, 21);
            txtMaDichVu.Margin = new Padding(3, 4, 3, 4);
            txtMaDichVu.Name = "txtMaDichVu";
            txtMaDichVu.PlaceholderText = "Mã dịch vụ";
            txtMaDichVu.Size = new Size(292, 27);
            txtMaDichVu.TabIndex = 0;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(3, 8);
            dataGridView3.Margin = new Padding(3, 4, 3, 4);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(845, 683);
            dataGridView3.TabIndex = 0;
            // 
            // GiaoDich
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 710);
            Controls.Add(tabControl1);
            Name = "GiaoDich";
            Text = "GiaoDich";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DT_HoaDon).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private Panel panel2;
        private Button btn_TimKiemHoaDon;
        private TextBox txt_TimKiemHoaDon;
        private Label label13;
        private DataGridView DT_HoaDon;
        private TabPage tabPage1;
        private DateTimePicker dateTimePicker1;
        private Label label11;
        private DataGridView dataGridView2;
        private RadioButton rd_QR;
        private RadioButton rd_TienMat;
        private Label label12;
        private Button btnThanhToan;
        private ComboBox cb_LocMa;
        private Button btnApDungMa;
        private DataGridView dataGridView1;
        private Label txt_HienThiGiaTien;
        private TextBox txtKhuyenMai;
        private TextBox txt_TongTien;
        private TextBox txt_Giora;
        private TextBox txt_GioVao;
        private TextBox txtTenkhachHang;
        private TextBox txt_DichVu;
        private TextBox txt_MaHoaDon;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage3;
        private Panel panel1;
        private Button btnXoaDichVu;
        private Button btn_ThemDichVu;
        private TextBox txtTenDichVu;
        private TextBox txtGia;
        private TextBox txtThoiHan;
        private TextBox txtGhiChu;
        private TextBox txtMaDichVu;
        private DataGridView dataGridView3;
        private Button btnshow;
    }
}