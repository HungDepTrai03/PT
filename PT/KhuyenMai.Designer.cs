namespace PRL
{
    partial class KhuyenMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhuyenMai));
            dataGridView1 = new DataGridView();
            txtmota = new TextBox();
            label5 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            dateTimePicker2 = new DateTimePicker();
            txtmakm = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtsearch = new TextBox();
            txtgiatri = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 267);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(821, 320);
            dataGridView1.TabIndex = 50;
            // 
            // txtmota
            // 
            txtmota.Location = new Point(304, 180);
            txtmota.Margin = new Padding(3, 4, 3, 4);
            txtmota.Name = "txtmota";
            txtmota.Size = new Size(359, 27);
            txtmota.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(132, 180);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 48;
            label5.Text = "Mô tả:";
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(733, 220);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 47;
            button4.Text = "Update";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(641, 220);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 46;
            button3.Text = "Delete";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(563, 220);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(72, 31);
            button2.TabIndex = 45;
            button2.Text = "Add";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(304, 102);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(359, 27);
            dateTimePicker2.TabIndex = 44;
            // 
            // txtmakm
            // 
            txtmakm.Location = new Point(304, 49);
            txtmakm.Margin = new Padding(3, 4, 3, 4);
            txtmakm.Name = "txtmakm";
            txtmakm.Size = new Size(359, 27);
            txtmakm.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(132, 137);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 38;
            label4.Text = "Giá trị:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 107);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 36;
            label2.Text = "Ngày hết hạn:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 56);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 35;
            label1.Text = "Mã khuyến mại:";
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(157, 224);
            txtsearch.Margin = new Padding(3, 4, 3, 4);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(359, 27);
            txtsearch.TabIndex = 51;
            txtsearch.Text = "Bộ lọc tìm kiếm mã";
            // 
            // txtgiatri
            // 
            txtgiatri.Location = new Point(304, 137);
            txtgiatri.Margin = new Padding(3, 4, 3, 4);
            txtgiatri.Name = "txtgiatri";
            txtgiatri.Size = new Size(359, 27);
            txtgiatri.TabIndex = 52;
            // 
            // KhuyenMai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 605);
            Controls.Add(txtgiatri);
            Controls.Add(txtsearch);
            Controls.Add(dataGridView1);
            Controls.Add(txtmota);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dateTimePicker2);
            Controls.Add(txtmakm);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KhuyenMai";
            Text = "KhuyenMai";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private TextBox txtmota;
        private Label label5;
        private Button button4;
        private Button button3;
        private Button button2;
        private DateTimePicker dateTimePicker2;
        private TextBox txtmakm;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtsearch;
        private TextBox txtgiatri;
    }
}