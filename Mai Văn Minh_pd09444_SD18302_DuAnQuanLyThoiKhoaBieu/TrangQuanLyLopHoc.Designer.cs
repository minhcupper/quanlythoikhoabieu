namespace Mai_Văn_Minh_pd09444_SD18302_DuAnQuanLyThoiKhoaBieu
{
    partial class TrangQuanLyLopHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangQuanLyLopHoc));
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            comboBox6 = new ComboBox();
            label2 = new Label();
            button2 = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thờiKhóaBiểuToolStripMenuItem = new ToolStripMenuItem();
            xếpThờiKhóaBiểuToolStripMenuItem = new ToolStripMenuItem();
            dữLiệuMônHọcToolStripMenuItem = new ToolStripMenuItem();
            dữLiệuLớpHọcToolStripMenuItem = new ToolStripMenuItem();
            trangDữLiệuToolStripMenuItem = new ToolStripMenuItem();
            trangNhậpDữLiệuToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            DanhSách = new MenuStrip();
            groupBox3 = new GroupBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            DanhSách.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(516, 78);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 5;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(365, 78);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 2;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(32, 78);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(636, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(642, 146);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "WD", "SD", "GA", "MD", "WD", "SA" });
            comboBox6.Location = new Point(756, 62);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(139, 33);
            comboBox6.TabIndex = 34;
            comboBox6.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(627, 65);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 3;
            label2.Text = "Mã Lớp";
     
            // 
            // button2
            // 
            button2.Location = new Point(205, 78);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(comboBox6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(346, 281);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(932, 301);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Trang Thông Tin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(627, 188);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 32;
            label4.Text = "Tên Môn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(627, 126);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 7;
            label3.Text = "Mã Môn";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Xây dựng Trang Web", "Cơ sở dữ liệu  ", "Lập trình Java 1", "Hệ quản trị cơ sở dữ liệu", "Lập trình C#1", "Nhập môn lập trình game", "Kiểm thử cơ bản", "front-End Frameworks" });
            comboBox2.Location = new Point(756, 188);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(139, 33);
            comboBox2.TabIndex = 31;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "WEB1013", "COM2012", "MOB1014", "SOA101", "NET101", "GAM104", "SOF3031", "WEB207" });
            comboBox1.Location = new Point(756, 126);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(139, 33);
            comboBox1.TabIndex = 30;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(26, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(544, 201);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.Margin = new Padding(20, 0, 0, 20);
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(140, 33);
            tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // thờiKhóaBiểuToolStripMenuItem
            // 
            thờiKhóaBiểuToolStripMenuItem.Font = new Font("Times New Roman", 13F);
            thờiKhóaBiểuToolStripMenuItem.Margin = new Padding(20, 0, 0, 20);
            thờiKhóaBiểuToolStripMenuItem.Name = "thờiKhóaBiểuToolStripMenuItem";
            thờiKhóaBiểuToolStripMenuItem.Size = new Size(187, 33);
            thờiKhóaBiểuToolStripMenuItem.Text = "Thời khóa biểu";
            // 
            // xếpThờiKhóaBiểuToolStripMenuItem
            // 
            xếpThờiKhóaBiểuToolStripMenuItem.Font = new Font("Times New Roman", 13F);
            xếpThờiKhóaBiểuToolStripMenuItem.Margin = new Padding(20, 0, 0, 20);
            xếpThờiKhóaBiểuToolStripMenuItem.Name = "xếpThờiKhóaBiểuToolStripMenuItem";
            xếpThờiKhóaBiểuToolStripMenuItem.Size = new Size(229, 33);
            xếpThờiKhóaBiểuToolStripMenuItem.Text = "Xếp thời khóa biểu";
            // 
            // dữLiệuMônHọcToolStripMenuItem
            // 
            dữLiệuMônHọcToolStripMenuItem.Font = new Font("Times New Roman", 13F);
            dữLiệuMônHọcToolStripMenuItem.Margin = new Padding(20, 0, 0, 20);
            dữLiệuMônHọcToolStripMenuItem.Name = "dữLiệuMônHọcToolStripMenuItem";
            dữLiệuMônHọcToolStripMenuItem.Size = new Size(204, 33);
            dữLiệuMônHọcToolStripMenuItem.Text = "Dữ liệu môn học";
            dữLiệuMônHọcToolStripMenuItem.Click += dữLiệuMônHọcToolStripMenuItem_Click;
            // 
            // dữLiệuLớpHọcToolStripMenuItem
            // 
            dữLiệuLớpHọcToolStripMenuItem.Font = new Font("Times New Roman", 13F);
            dữLiệuLớpHọcToolStripMenuItem.Margin = new Padding(20, 0, 0, 20);
            dữLiệuLớpHọcToolStripMenuItem.Name = "dữLiệuLớpHọcToolStripMenuItem";
            dữLiệuLớpHọcToolStripMenuItem.Size = new Size(191, 33);
            dữLiệuLớpHọcToolStripMenuItem.Text = "Dữ liệu lớp học";
            dữLiệuLớpHọcToolStripMenuItem.Click += dữLiệuLớpHọcToolStripMenuItem_Click;
            // 
            // trangDữLiệuToolStripMenuItem
            // 
            trangDữLiệuToolStripMenuItem.Font = new Font("Times New Roman", 13F);
            trangDữLiệuToolStripMenuItem.Margin = new Padding(20, 0, 0, 20);
            trangDữLiệuToolStripMenuItem.Name = "trangDữLiệuToolStripMenuItem";
            trangDữLiệuToolStripMenuItem.Size = new Size(205, 33);
            trangDữLiệuToolStripMenuItem.Text = "Dữ liệu giáo viên";
            trangDữLiệuToolStripMenuItem.Click += trangDữLiệuToolStripMenuItem_Click;
            // 
            // trangNhậpDữLiệuToolStripMenuItem
            // 
            trangNhậpDữLiệuToolStripMenuItem.CheckOnClick = true;
            trangNhậpDữLiệuToolStripMenuItem.Font = new Font("Times New Roman", 13F);
            trangNhậpDữLiệuToolStripMenuItem.Image = (Image)resources.GetObject("trangNhậpDữLiệuToolStripMenuItem.Image");
            trangNhậpDữLiệuToolStripMenuItem.ImageAlign = ContentAlignment.MiddleRight;
            trangNhậpDữLiệuToolStripMenuItem.Margin = new Padding(20, 0, 0, 20);
            trangNhậpDữLiệuToolStripMenuItem.Name = "trangNhậpDữLiệuToolStripMenuItem";
            trangNhậpDữLiệuToolStripMenuItem.Size = new Size(164, 33);
            trangNhậpDữLiệuToolStripMenuItem.Text = "Trang Chủ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(58, 27);
            label1.Name = "label1";
            label1.Size = new Size(218, 33);
            label1.TabIndex = 6;
            label1.Text = "Dữ Liệu Lớp Học ";
            // 
            // DanhSách
            // 
            DanhSách.AllowDrop = true;
            DanhSách.BackColor = Color.SeaShell;
            DanhSách.Dock = DockStyle.Left;
            DanhSách.Font = new Font("Times New Roman", 13F);
            DanhSách.ImageScalingSize = new Size(24, 24);
            DanhSách.Items.AddRange(new ToolStripItem[] { trangNhậpDữLiệuToolStripMenuItem, trangDữLiệuToolStripMenuItem, dữLiệuLớpHọcToolStripMenuItem, dữLiệuMônHọcToolStripMenuItem, xếpThờiKhóaBiểuToolStripMenuItem, thờiKhóaBiểuToolStripMenuItem, tàiKhoảnToolStripMenuItem });
            DanhSách.LayoutStyle = ToolStripLayoutStyle.Table;
            DanhSách.Location = new Point(0, 0);
            DanhSách.Margin = new Padding(20, 0, 0, 20);
            DanhSách.Name = "DanhSách";
            DanhSách.Padding = new Padding(3, 0, 2, 3);
            DanhSách.RenderMode = ToolStripRenderMode.Professional;
            DanhSách.Size = new Size(254, 594);
            DanhSách.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox3.BackColor = Color.Chocolate;
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(257, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1091, 112);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            // 
            // TrangQuanLyLopHoc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1349, 594);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(DanhSách);
            Name = "TrangQuanLyLopHoc";
            Text = "TrangQuanLyLopHoc";
            Load += TrangQuanLyLopHoc_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            DanhSách.ResumeLayout(false);
            DanhSách.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button4;
        private Button button3;
        private Button button1;
        private GroupBox groupBox2;
        private Label label2;
        private Button button2;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thờiKhóaBiểuToolStripMenuItem;
        private ToolStripMenuItem xếpThờiKhóaBiểuToolStripMenuItem;
        private ToolStripMenuItem dữLiệuMônHọcToolStripMenuItem;
        private ToolStripMenuItem dữLiệuLớpHọcToolStripMenuItem;
        private ToolStripMenuItem trangDữLiệuToolStripMenuItem;
        private ToolStripMenuItem trangNhậpDữLiệuToolStripMenuItem;
        private Label label1;
        private MenuStrip DanhSách;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label4;
        private Label label3;
        private ComboBox comboBox6;
        private GroupBox groupBox3;
    }
}