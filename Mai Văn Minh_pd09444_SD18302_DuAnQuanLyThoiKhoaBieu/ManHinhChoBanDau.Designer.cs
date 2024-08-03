namespace Mai_Văn_Minh_pd09444_SD18302_DuAnQuanLyThoiKhoaBieu
{
    partial class ManHinhChoBanDau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManHinhChoBanDau));
            Input = new Button();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // Input
            // 
            Input.BackColor = Color.LemonChiffon;
            Input.FlatAppearance.BorderSize = 5;
            Input.FlatStyle = FlatStyle.Popup;
            Input.Font = new Font("Times New Roman", 12F);
            Input.Location = new Point(906, 17);
            Input.Name = "Input";
            Input.Size = new Size(194, 56);
            Input.TabIndex = 0;
            Input.Text = "Trang Login";
            Input.UseVisualStyleBackColor = false;
            Input.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Snow;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(111, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1116, 535);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(32, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(955, 404);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SandyBrown;
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(Input);
            groupBox2.Location = new Point(111, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1116, 90);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(32, 30);
            label1.Name = "label1";
            label1.Size = new Size(307, 46);
            label1.TabIndex = 1;
            label1.Text = "Wealcome Back ! ";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.SandyBrown;
            groupBox3.Location = new Point(0, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(113, 614);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            // 
            // ManHinhChoBanDau
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1312, 655);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ManHinhChoBanDau";
            Text = "?";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Input;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private Label label1;
        private GroupBox groupBox3;
    }
}