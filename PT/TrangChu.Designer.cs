﻿namespace PRL
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            panel_Body = new Panel();
            PanelControl = new Panel();
            label3 = new Label();
            txtChucNang = new Label();
            txtThoiGian = new Label();
            txtNguoiDung = new Label();
            panel_Menu = new Panel();
            button1 = new Button();
            btnDangXuat = new Button();
            btnGiaoDich = new Button();
            btnKhuyenMai = new Button();
            btnNhanVien = new Button();
            btnThietBi = new Button();
            btnDatLich = new Button();
            btn_PT = new Button();
            btn_HoiVien = new Button();
            pictureBox1 = new PictureBox();
            PanelControl.SuspendLayout();
            panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_Body
            // 
            panel_Body.BackColor = Color.Ivory;
            panel_Body.BackgroundImage = (Image)resources.GetObject("panel_Body.BackgroundImage");
            panel_Body.BackgroundImageLayout = ImageLayout.Stretch;
            panel_Body.Dock = DockStyle.Fill;
            panel_Body.Location = new Point(182, 61);
            panel_Body.Margin = new Padding(3, 4, 3, 4);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(1105, 994);
            panel_Body.TabIndex = 5;
            // 
            // PanelControl
            // 
            PanelControl.AutoSize = true;
            PanelControl.BackColor = Color.LavenderBlush;
            PanelControl.Controls.Add(label3);
            PanelControl.Controls.Add(txtChucNang);
            PanelControl.Controls.Add(txtThoiGian);
            PanelControl.Controls.Add(txtNguoiDung);
            PanelControl.Dock = DockStyle.Top;
            PanelControl.Location = new Point(182, 0);
            PanelControl.Margin = new Padding(3, 4, 3, 4);
            PanelControl.Name = "PanelControl";
            PanelControl.Size = new Size(1105, 61);
            PanelControl.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(363, 12);
            label3.Name = "label3";
            label3.Size = new Size(296, 41);
            label3.TabIndex = 3;
            label3.Text = "WOLFGYM FITNESS";
            // 
            // txtChucNang
            // 
            txtChucNang.AutoSize = true;
            txtChucNang.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtChucNang.ForeColor = Color.Red;
            txtChucNang.Location = new Point(0, 24);
            txtChucNang.Name = "txtChucNang";
            txtChucNang.Size = new Size(112, 28);
            txtChucNang.TabIndex = 2;
            txtChucNang.Text = "Chức năng";
            // 
            // txtThoiGian
            // 
            txtThoiGian.AutoSize = true;
            txtThoiGian.Location = new Point(882, 41);
            txtThoiGian.Name = "txtThoiGian";
            txtThoiGian.Size = new Size(42, 20);
            txtThoiGian.TabIndex = 1;
            txtThoiGian.Text = "Time";
            // 
            // txtNguoiDung
            // 
            txtNguoiDung.AutoSize = true;
            txtNguoiDung.Location = new Point(882, 12);
            txtNguoiDung.Name = "txtNguoiDung";
            txtNguoiDung.Size = new Size(113, 20);
            txtNguoiDung.TabIndex = 0;
            txtNguoiDung.Text = "Tên người dùng";
            // 
            // panel_Menu
            // 
            panel_Menu.Controls.Add(button1);
            panel_Menu.Controls.Add(btnDangXuat);
            panel_Menu.Controls.Add(btnGiaoDich);
            panel_Menu.Controls.Add(btnKhuyenMai);
            panel_Menu.Controls.Add(btnNhanVien);
            panel_Menu.Controls.Add(btnThietBi);
            panel_Menu.Controls.Add(btnDatLich);
            panel_Menu.Controls.Add(btn_PT);
            panel_Menu.Controls.Add(btn_HoiVien);
            panel_Menu.Controls.Add(pictureBox1);
            panel_Menu.Dock = DockStyle.Left;
            panel_Menu.Location = new Point(0, 0);
            panel_Menu.Margin = new Padding(3, 4, 3, 4);
            panel_Menu.Name = "panel_Menu";
            panel_Menu.Size = new Size(182, 1055);
            panel_Menu.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.BackColor = Color.Red;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(3, 826);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(171, 40);
            button1.TabIndex = 9;
            button1.Text = "Đăng Xuất";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Anchor = AnchorStyles.None;
            btnDangXuat.AutoSize = true;
            btnDangXuat.BackColor = Color.Red;
            btnDangXuat.ForeColor = SystemColors.ControlLightLight;
            btnDangXuat.Location = new Point(-3, 1221);
            btnDangXuat.Margin = new Padding(3, 4, 3, 4);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(171, 40);
            btnDangXuat.TabIndex = 8;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            // 
            // btnGiaoDich
            // 
            btnGiaoDich.BackColor = SystemColors.Control;
            btnGiaoDich.Location = new Point(3, 348);
            btnGiaoDich.Margin = new Padding(3, 4, 3, 4);
            btnGiaoDich.Name = "btnGiaoDich";
            btnGiaoDich.Size = new Size(171, 31);
            btnGiaoDich.TabIndex = 7;
            btnGiaoDich.Text = "Quản lý giao dịch";
            btnGiaoDich.UseVisualStyleBackColor = false;
            btnGiaoDich.Click += btnGiaoDich_Click;
            // 
            // btnKhuyenMai
            // 
            btnKhuyenMai.BackColor = SystemColors.Control;
            btnKhuyenMai.Location = new Point(3, 387);
            btnKhuyenMai.Margin = new Padding(3, 4, 3, 4);
            btnKhuyenMai.Name = "btnKhuyenMai";
            btnKhuyenMai.Size = new Size(171, 31);
            btnKhuyenMai.TabIndex = 6;
            btnKhuyenMai.Text = "Quản lý khuyến mại";
            btnKhuyenMai.UseVisualStyleBackColor = false;
            btnKhuyenMai.Click += btnKhuyenMai_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = SystemColors.Control;
            btnNhanVien.Location = new Point(3, 425);
            btnNhanVien.Margin = new Padding(3, 4, 3, 4);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(171, 31);
            btnNhanVien.TabIndex = 5;
            btnNhanVien.Text = "Quản lý nhân viên";
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnThietBi
            // 
            btnThietBi.BackColor = SystemColors.Control;
            btnThietBi.Location = new Point(3, 309);
            btnThietBi.Margin = new Padding(3, 4, 3, 4);
            btnThietBi.Name = "btnThietBi";
            btnThietBi.Size = new Size(171, 31);
            btnThietBi.TabIndex = 4;
            btnThietBi.Text = "Quản  lý thiết bị";
            btnThietBi.UseVisualStyleBackColor = false;
            btnThietBi.Click += btnThietBi_Click;
            // 
            // btnDatLich
            // 
            btnDatLich.BackColor = SystemColors.Control;
            btnDatLich.Location = new Point(3, 271);
            btnDatLich.Margin = new Padding(3, 4, 3, 4);
            btnDatLich.Name = "btnDatLich";
            btnDatLich.Size = new Size(171, 31);
            btnDatLich.TabIndex = 3;
            btnDatLich.Text = "Đặt lịch";
            btnDatLich.UseVisualStyleBackColor = false;
            btnDatLich.Click += btnDatLich_Click;
            // 
            // btn_PT
            // 
            btn_PT.BackColor = SystemColors.Control;
            btn_PT.Location = new Point(3, 232);
            btn_PT.Margin = new Padding(3, 4, 3, 4);
            btn_PT.Name = "btn_PT";
            btn_PT.Size = new Size(171, 31);
            btn_PT.TabIndex = 2;
            btn_PT.Text = "PT";
            btn_PT.UseVisualStyleBackColor = false;
            btn_PT.Click += btn_PT_Click;
            // 
            // btn_HoiVien
            // 
            btn_HoiVien.BackColor = SystemColors.Control;
            btn_HoiVien.Location = new Point(3, 193);
            btn_HoiVien.Margin = new Padding(3, 4, 3, 4);
            btn_HoiVien.Name = "btn_HoiVien";
            btn_HoiVien.Size = new Size(171, 31);
            btn_HoiVien.TabIndex = 1;
            btn_HoiVien.Text = "Quản lý hội viên";
            btn_HoiVien.UseVisualStyleBackColor = false;
            btn_HoiVien.Click += btn_HoiVien_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 185);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 1055);
            Controls.Add(panel_Body);
            Controls.Add(PanelControl);
            Controls.Add(panel_Menu);
            Name = "TrangChu";
            Text = "TrangChu";
            PanelControl.ResumeLayout(false);
            PanelControl.PerformLayout();
            panel_Menu.ResumeLayout(false);
            panel_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_Body;
        private Panel PanelControl;
        private Label label3;
        private Label txtChucNang;
        private Label txtThoiGian;
        private Label txtNguoiDung;
        private Panel panel_Menu;
        private Button button1;
        private Button btnDangXuat;
        private Button btnGiaoDich;
        private Button btnKhuyenMai;
        private Button btnNhanVien;
        private Button btnThietBi;
        private Button btnDatLich;
        private Button btn_PT;
        private Button btn_HoiVien;
        private PictureBox pictureBox1;
    }
}