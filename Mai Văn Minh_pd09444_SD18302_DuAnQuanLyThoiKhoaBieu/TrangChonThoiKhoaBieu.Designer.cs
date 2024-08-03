namespace Mai_Văn_Minh_pd09444_SD18302_DuAnQuanLyThoiKhoaBieu
{
    partial class TrangChonThoiKhoaBieu
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
            groupBox2 = new GroupBox();
            button4 = new Button();
            comboBox1 = new ComboBox();
            button5 = new Button();
            label2 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(396, 49);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(817, 87);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
            // 
            // button4
            // 
            button4.Location = new Point(648, 30);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 8;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "2", "3", "4", "5", "6", "7" });
            comboBox1.Location = new Point(256, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button5
            // 
            button5.Location = new Point(481, 28);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 6;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 36);
            label2.Name = "label2";
            label2.Size = new Size(164, 25);
            label2.TabIndex = 3;
            label2.Text = "Thời Khóa Biểu Thứ";
            label2.Click += label2_Click;
            // 
            // TrangChonThoiKhoaBieu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1444, 602);
            Controls.Add(groupBox2);
            Name = "TrangChonThoiKhoaBieu";
            Text = "TrangChonThoiKhoaBieu";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button button4;
        private ComboBox comboBox1;
        private Button button5;
        private Label label2;
    }
}