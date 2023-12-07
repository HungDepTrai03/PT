namespace PRL
{
    partial class Thietbi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thietbi));
            btnUpdate = new Button();
            btndelete = new Button();
            btnadd = new Button();
            txtsearch = new TextBox();
            dataGridView1 = new DataGridView();
            txtkhoiluong = new TextBox();
            txtgiatien = new TextBox();
            txtvitri = new TextBox();
            txttentbi = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            txttrangthai = new TextBox();
            txtloaithietbi = new TextBox();
            txtmausac = new TextBox();
            label10 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(836, 261);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 45);
            btnUpdate.TabIndex = 53;
            btnUpdate.Text = "Update";
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += button4_Click;
            // 
            // btndelete
            // 
            btndelete.Image = (Image)resources.GetObject("btndelete.Image");
            btndelete.ImageAlign = ContentAlignment.MiddleLeft;
            btndelete.Location = new Point(743, 261);
            btndelete.Margin = new Padding(3, 4, 3, 4);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(86, 45);
            btndelete.TabIndex = 52;
            btndelete.Text = "Delete";
            btndelete.TextAlign = ContentAlignment.MiddleRight;
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnadd
            // 
            btnadd.Image = (Image)resources.GetObject("btnadd.Image");
            btnadd.ImageAlign = ContentAlignment.MiddleLeft;
            btnadd.Location = new Point(662, 261);
            btnadd.Margin = new Padding(3, 4, 3, 4);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(72, 45);
            btnadd.TabIndex = 51;
            btnadd.Text = "Add";
            btnadd.TextAlign = ContentAlignment.MiddleRight;
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += button2_Click;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(31, 270);
            txtsearch.Margin = new Padding(3, 4, 3, 4);
            txtsearch.Name = "txtsearch";
            txtsearch.PlaceholderText = "Tìm kiếm thiết bị";
            txtsearch.Size = new Size(390, 27);
            txtsearch.TabIndex = 49;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 321);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(912, 293);
            dataGridView1.TabIndex = 45;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtkhoiluong
            // 
            txtkhoiluong.Location = new Point(543, 78);
            txtkhoiluong.Margin = new Padding(3, 4, 3, 4);
            txtkhoiluong.Name = "txtkhoiluong";
            txtkhoiluong.Size = new Size(381, 27);
            txtkhoiluong.TabIndex = 42;
            // 
            // txtgiatien
            // 
            txtgiatien.Location = new Point(541, 132);
            txtgiatien.Margin = new Padding(3, 4, 3, 4);
            txtgiatien.Name = "txtgiatien";
            txtgiatien.Size = new Size(381, 27);
            txtgiatien.TabIndex = 41;
            // 
            // txtvitri
            // 
            txtvitri.Location = new Point(140, 136);
            txtvitri.Margin = new Padding(3, 4, 3, 4);
            txtvitri.Name = "txtvitri";
            txtvitri.Size = new Size(308, 27);
            txtvitri.TabIndex = 39;
            // 
            // txttentbi
            // 
            txttentbi.Location = new Point(140, 71);
            txttentbi.Margin = new Padding(3, 4, 3, 4);
            txttentbi.Name = "txttentbi";
            txttentbi.Size = new Size(308, 27);
            txttentbi.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(454, 192);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 36;
            label9.Text = "Trạng thái";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(462, 135);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 35;
            label8.Text = "Giá tiền";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 139);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 33;
            label6.Text = "Vị trí";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 81);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 29;
            label2.Text = "Tên thiết bị";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 30);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 28;
            // 
            // txttrangthai
            // 
            txttrangthai.Location = new Point(543, 192);
            txttrangthai.Margin = new Padding(3, 4, 3, 4);
            txttrangthai.Name = "txttrangthai";
            txttrangthai.Size = new Size(381, 27);
            txttrangthai.TabIndex = 54;
            // 
            // txtloaithietbi
            // 
            txtloaithietbi.Location = new Point(140, 23);
            txtloaithietbi.Margin = new Padding(3, 4, 3, 4);
            txtloaithietbi.Name = "txtloaithietbi";
            txtloaithietbi.Size = new Size(784, 27);
            txtloaithietbi.TabIndex = 55;
            // 
            // txtmausac
            // 
            txtmausac.Location = new Point(140, 192);
            txtmausac.Margin = new Padding(3, 4, 3, 4);
            txtmausac.Name = "txtmausac";
            txtmausac.Size = new Size(308, 27);
            txtmausac.TabIndex = 58;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(45, 199);
            label10.Name = "label10";
            label10.Size = new Size(63, 20);
            label10.TabIndex = 56;
            label10.Text = "Màu sắc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 30);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 59;
            label4.Text = "Loại thiết bị";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(455, 78);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 60;
            label5.Text = "Khối lượng";
            // 
            // Thietbi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 646);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtmausac);
            Controls.Add(label10);
            Controls.Add(txtloaithietbi);
            Controls.Add(txttrangthai);
            Controls.Add(btnUpdate);
            Controls.Add(btndelete);
            Controls.Add(btnadd);
            Controls.Add(txtsearch);
            Controls.Add(dataGridView1);
            Controls.Add(txtkhoiluong);
            Controls.Add(txtgiatien);
            Controls.Add(txtvitri);
            Controls.Add(txttentbi);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Thietbi";
            Text = "Thietbi";
            Load += Thietbi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Button btndelete;
        private Button btnadd;
        private TextBox txtsearch;
        private DataGridView dataGridView1;
        private TextBox txtkhoiluong;
        private TextBox txtgiatien;
        private TextBox txtvitri;
        private TextBox txttentbi;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label2;
        private Label label1;
        private TextBox txttrangthai;
        private TextBox txtloaithietbi;
        private TextBox txtmausac;
        private Label label10;
        private Label label4;
        private Label label5;
    }
}