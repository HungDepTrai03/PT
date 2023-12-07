namespace PRL
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnThoat = new Button();
            btnLogin = new Button();
            label2 = new Label();
            txtID = new TextBox();
            txtPassword = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold);
            label1.Location = new Point(541, 97);
            label1.Name = "label1";
            label1.Size = new Size(210, 38);
            label1.TabIndex = 16;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // panel1
            // 
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(11, 8);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 615);
            panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(35, 152);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 316);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.MistyRose;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Location = new Point(465, 412);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(355, 43);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.PaleGreen;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(465, 345);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(355, 43);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, -35);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 12;
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.None;
            txtID.Location = new Point(465, 169);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.PlaceholderText = "Nhập ID Đăng nhập tại đây ...";
            txtID.Size = new Size(355, 49);
            txtID.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(465, 237);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Nhập Password tại đây ... ";
            txtPassword.Size = new Size(355, 44);
            txtPassword.TabIndex = 10;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 635);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnThoat);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(txtPassword);
            Name = "DangNhap";
            Text = "DangNhap";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnThoat;
        private Button btnLogin;
        private Label label2;
        private TextBox txtID;
        private TextBox txtPassword;
    }
}