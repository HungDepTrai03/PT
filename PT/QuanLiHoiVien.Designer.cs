namespace PRL
{
    partial class QuanLiHoiVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLiHoiVien));
            tabControl1 = new TabControl();
            tbThongTin = new TabPage();
            txtgioitinh = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btn_Add = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            pictureBox1 = new PictureBox();
            date_NgaySinh = new DateTimePicker();
            tb_TenHoiVien = new TextBox();
            tb_SoDienThoai = new TextBox();
            tb_Email = new TextBox();
            tb_MaHoiVien = new TextBox();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbHopDong = new TabPage();
            btn_Update_HopDong = new Button();
            btn_Delete_HopDong = new Button();
            btn_Add_HopDong = new Button();
            btn_TimKiem_HOpDong = new Button();
            txt_TimKiem_HopDong = new TextBox();
            dataGridView2 = new DataGridView();
            date_NgayHetHan = new DateTimePicker();
            date_NgayDangKi = new DateTimePicker();
            txt_MaHopDong = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            tabControl1.SuspendLayout();
            tbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tbHopDong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.None;
            tabControl1.Controls.Add(tbThongTin);
            tabControl1.Controls.Add(tbHopDong);
            tabControl1.Location = new Point(23, 6);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1062, 656);
            tabControl1.TabIndex = 2;
            // 
            // tbThongTin
            // 
            tbThongTin.Controls.Add(txtgioitinh);
            tbThongTin.Controls.Add(btnUpdate);
            tbThongTin.Controls.Add(btnDelete);
            tbThongTin.Controls.Add(btn_Add);
            tbThongTin.Controls.Add(btnTimKiem);
            tbThongTin.Controls.Add(txtTimKiem);
            tbThongTin.Controls.Add(pictureBox1);
            tbThongTin.Controls.Add(date_NgaySinh);
            tbThongTin.Controls.Add(tb_TenHoiVien);
            tbThongTin.Controls.Add(tb_SoDienThoai);
            tbThongTin.Controls.Add(tb_Email);
            tbThongTin.Controls.Add(tb_MaHoiVien);
            tbThongTin.Controls.Add(dataGridView1);
            tbThongTin.Controls.Add(label6);
            tbThongTin.Controls.Add(label5);
            tbThongTin.Controls.Add(label4);
            tbThongTin.Controls.Add(label3);
            tbThongTin.Controls.Add(label2);
            tbThongTin.Controls.Add(label1);
            tbThongTin.Location = new Point(4, 29);
            tbThongTin.Margin = new Padding(3, 4, 3, 4);
            tbThongTin.Name = "tbThongTin";
            tbThongTin.Padding = new Padding(3, 4, 3, 4);
            tbThongTin.Size = new Size(1054, 623);
            tbThongTin.TabIndex = 0;
            tbThongTin.Text = "Thông tin";
            tbThongTin.UseVisualStyleBackColor = true;
            // 
            // txtgioitinh
            // 
            txtgioitinh.Location = new Point(109, 186);
            txtgioitinh.Name = "txtgioitinh";
            txtgioitinh.Size = new Size(321, 27);
            txtgioitinh.TabIndex = 24;
            // 
            // btnUpdate
            // 
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(815, 221);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 45);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update";
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(722, 221);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 45);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btn_Add
            // 
            btn_Add.Image = (Image)resources.GetObject("btn_Add.Image");
            btn_Add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Add.Location = new Point(641, 221);
            btn_Add.Margin = new Padding(3, 4, 3, 4);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(72, 45);
            btn_Add.TabIndex = 20;
            btn_Add.Text = "Add";
            btn_Add.TextAlign = ContentAlignment.MiddleRight;
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(559, 231);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(81, 31);
            btnTimKiem.TabIndex = 19;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(23, 231);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm hội viên";
            txtTimKiem.Size = new Size(529, 27);
            txtTimKiem.TabIndex = 18;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(918, 33);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 180);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // date_NgaySinh
            // 
            date_NgaySinh.Format = DateTimePickerFormat.Custom;
            date_NgaySinh.Location = new Point(109, 132);
            date_NgaySinh.Margin = new Padding(3, 4, 3, 4);
            date_NgaySinh.Name = "date_NgaySinh";
            date_NgaySinh.Size = new Size(321, 27);
            date_NgaySinh.TabIndex = 14;
            // 
            // tb_TenHoiVien
            // 
            tb_TenHoiVien.Location = new Point(109, 83);
            tb_TenHoiVien.Margin = new Padding(3, 4, 3, 4);
            tb_TenHoiVien.Name = "tb_TenHoiVien";
            tb_TenHoiVien.PlaceholderText = "Nhập tên hội viên";
            tb_TenHoiVien.Size = new Size(321, 27);
            tb_TenHoiVien.TabIndex = 13;
            // 
            // tb_SoDienThoai
            // 
            tb_SoDienThoai.Location = new Point(559, 33);
            tb_SoDienThoai.Margin = new Padding(3, 4, 3, 4);
            tb_SoDienThoai.Name = "tb_SoDienThoai";
            tb_SoDienThoai.PlaceholderText = "Nhập số điện thoại";
            tb_SoDienThoai.Size = new Size(341, 27);
            tb_SoDienThoai.TabIndex = 12;
            // 
            // tb_Email
            // 
            tb_Email.Location = new Point(559, 83);
            tb_Email.Margin = new Padding(3, 4, 3, 4);
            tb_Email.Name = "tb_Email";
            tb_Email.PlaceholderText = "Nhập Email";
            tb_Email.Size = new Size(341, 27);
            tb_Email.TabIndex = 11;
            // 
            // tb_MaHoiVien
            // 
            tb_MaHoiVien.Location = new Point(109, 33);
            tb_MaHoiVien.Margin = new Padding(3, 4, 3, 4);
            tb_MaHoiVien.Name = "tb_MaHoiVien";
            tb_MaHoiVien.PlaceholderText = "Nhập mã hội viên ";
            tb_MaHoiVien.Size = new Size(321, 27);
            tb_MaHoiVien.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 276);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1053, 347);
            dataGridView1.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(468, 93);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(468, 41);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 4;
            label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 197);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Giới tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 145);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 93);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên hội viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 41);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã hội viên";
            // 
            // tbHopDong
            // 
            tbHopDong.Controls.Add(btn_Update_HopDong);
            tbHopDong.Controls.Add(btn_Delete_HopDong);
            tbHopDong.Controls.Add(btn_Add_HopDong);
            tbHopDong.Controls.Add(btn_TimKiem_HOpDong);
            tbHopDong.Controls.Add(txt_TimKiem_HopDong);
            tbHopDong.Controls.Add(dataGridView2);
            tbHopDong.Controls.Add(date_NgayHetHan);
            tbHopDong.Controls.Add(date_NgayDangKi);
            tbHopDong.Controls.Add(txt_MaHopDong);
            tbHopDong.Controls.Add(label12);
            tbHopDong.Controls.Add(label11);
            tbHopDong.Controls.Add(label9);
            tbHopDong.Location = new Point(4, 29);
            tbHopDong.Margin = new Padding(3, 4, 3, 4);
            tbHopDong.Name = "tbHopDong";
            tbHopDong.Padding = new Padding(3, 4, 3, 4);
            tbHopDong.Size = new Size(1054, 623);
            tbHopDong.TabIndex = 1;
            tbHopDong.Text = "Hợp đồng";
            tbHopDong.UseVisualStyleBackColor = true;
            tbHopDong.Click += tbHopDong_Click;
            // 
            // btn_Update_HopDong
            // 
            btn_Update_HopDong.Image = (Image)resources.GetObject("btn_Update_HopDong.Image");
            btn_Update_HopDong.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Update_HopDong.Location = new Point(917, 128);
            btn_Update_HopDong.Margin = new Padding(3, 4, 3, 4);
            btn_Update_HopDong.Name = "btn_Update_HopDong";
            btn_Update_HopDong.Size = new Size(86, 45);
            btn_Update_HopDong.TabIndex = 27;
            btn_Update_HopDong.Text = "Update";
            btn_Update_HopDong.TextAlign = ContentAlignment.MiddleRight;
            btn_Update_HopDong.UseVisualStyleBackColor = true;
            btn_Update_HopDong.Click += btn_Update_HopDong_Click;
            // 
            // btn_Delete_HopDong
            // 
            btn_Delete_HopDong.Image = (Image)resources.GetObject("btn_Delete_HopDong.Image");
            btn_Delete_HopDong.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Delete_HopDong.Location = new Point(917, 73);
            btn_Delete_HopDong.Margin = new Padding(3, 4, 3, 4);
            btn_Delete_HopDong.Name = "btn_Delete_HopDong";
            btn_Delete_HopDong.Size = new Size(86, 45);
            btn_Delete_HopDong.TabIndex = 26;
            btn_Delete_HopDong.Text = "Delete";
            btn_Delete_HopDong.TextAlign = ContentAlignment.MiddleRight;
            btn_Delete_HopDong.UseVisualStyleBackColor = true;
            btn_Delete_HopDong.Click += btn_Delete_HopDong_Click;
            // 
            // btn_Add_HopDong
            // 
            btn_Add_HopDong.Image = (Image)resources.GetObject("btn_Add_HopDong.Image");
            btn_Add_HopDong.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Add_HopDong.Location = new Point(917, 19);
            btn_Add_HopDong.Margin = new Padding(3, 4, 3, 4);
            btn_Add_HopDong.Name = "btn_Add_HopDong";
            btn_Add_HopDong.Size = new Size(86, 45);
            btn_Add_HopDong.TabIndex = 25;
            btn_Add_HopDong.Text = "Add";
            btn_Add_HopDong.TextAlign = ContentAlignment.MiddleRight;
            btn_Add_HopDong.UseVisualStyleBackColor = true;
            btn_Add_HopDong.Click += btn_Add_HopDong_Click;
            // 
            // btn_TimKiem_HOpDong
            // 
            btn_TimKiem_HOpDong.Location = new Point(917, 183);
            btn_TimKiem_HOpDong.Margin = new Padding(3, 4, 3, 4);
            btn_TimKiem_HOpDong.Name = "btn_TimKiem_HOpDong";
            btn_TimKiem_HOpDong.Size = new Size(86, 31);
            btn_TimKiem_HOpDong.TabIndex = 24;
            btn_TimKiem_HOpDong.Text = "Tìm kiếm";
            btn_TimKiem_HOpDong.UseVisualStyleBackColor = true;
            btn_TimKiem_HOpDong.Click += btn_TimKiem_HOpDong_Click;
            // 
            // txt_TimKiem_HopDong
            // 
            txt_TimKiem_HopDong.Location = new Point(11, 184);
            txt_TimKiem_HopDong.Margin = new Padding(3, 4, 3, 4);
            txt_TimKiem_HopDong.Name = "txt_TimKiem_HopDong";
            txt_TimKiem_HopDong.PlaceholderText = "Tìm kiếm hợp đồng";
            txt_TimKiem_HopDong.Size = new Size(867, 27);
            txt_TimKiem_HopDong.TabIndex = 23;
            txt_TimKiem_HopDong.TextChanged += txt_TimKiem_HopDong_TextChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 228);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(1053, 387);
            dataGridView2.TabIndex = 14;
            // 
            // date_NgayHetHan
            // 
            date_NgayHetHan.Location = new Point(105, 133);
            date_NgayHetHan.Margin = new Padding(3, 4, 3, 4);
            date_NgayHetHan.Name = "date_NgayHetHan";
            date_NgayHetHan.Size = new Size(325, 27);
            date_NgayHetHan.TabIndex = 13;
            // 
            // date_NgayDangKi
            // 
            date_NgayDangKi.Location = new Point(105, 91);
            date_NgayDangKi.Margin = new Padding(3, 4, 3, 4);
            date_NgayDangKi.Name = "date_NgayDangKi";
            date_NgayDangKi.Size = new Size(324, 27);
            date_NgayDangKi.TabIndex = 12;
            // 
            // txt_MaHopDong
            // 
            txt_MaHopDong.Location = new Point(105, 8);
            txt_MaHopDong.Margin = new Padding(3, 4, 3, 4);
            txt_MaHopDong.Name = "txt_MaHopDong";
            txt_MaHopDong.Size = new Size(324, 27);
            txt_MaHopDong.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 145);
            label12.Name = "label12";
            label12.Size = new Size(97, 20);
            label12.TabIndex = 3;
            label12.Text = "Ngày hết hạn";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 104);
            label11.Name = "label11";
            label11.Size = new Size(97, 20);
            label11.TabIndex = 2;
            label11.Text = "Ngày đăng kí";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 23);
            label9.Name = "label9";
            label9.Size = new Size(99, 20);
            label9.TabIndex = 0;
            label9.Text = "Mã hợp đồng";
            // 
            // QuanLiHoiVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 669);
            Controls.Add(tabControl1);
            Name = "QuanLiHoiVien";
            Text = "QuanLiHoiVien";
            tabControl1.ResumeLayout(false);
            tbThongTin.ResumeLayout(false);
            tbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tbHopDong.ResumeLayout(false);
            tbHopDong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbThongTin;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btn_Add;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private PictureBox pictureBox1;
        private DateTimePicker date_NgaySinh;
        private TextBox tb_TenHoiVien;
        private TextBox tb_SoDienThoai;
        private TextBox tb_Email;
        private TextBox tb_MaHoiVien;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tbHopDong;
        private Button btn_Update_HopDong;
        private Button btn_Delete_HopDong;
        private Button btn_Add_HopDong;
        private Button btn_TimKiem_HOpDong;
        private TextBox txt_TimKiem_HopDong;
        private DataGridView dataGridView2;
        private DateTimePicker date_NgayHetHan;
        private DateTimePicker date_NgayDangKi;
        private TextBox txt_MaHopDong;
        private Label label12;
        private Label label11;
        private Label label9;
        private TextBox txtgioitinh;
    }
}