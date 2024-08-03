using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mai_Văn_Minh_pd09444_SD18302_DuAnQuanLyThoiKhoaBieu
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }
        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TrangQuanLyMonHoc min = new TrangQuanLyMonHoc();
            min.Show(); this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrangQuanlyGiaoVien min = new TrangQuanlyGiaoVien();
            min.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TrangQuanLyLopHoc min = new TrangQuanLyLopHoc();
            min.Show(); this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TrangQuanLyCaGiaoVien min = new TrangQuanLyCaGiaoVien();
            min.Show(); this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TrangXepThoiKhoaBieu min = new TrangXepThoiKhoaBieu();
            min.Show(); this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TrangChonThoiKhoaBieu min = new TrangChonThoiKhoaBieu();
            min.Show(); this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TrangChonThuDeXepThoiKhoaBieu min = new TrangChonThuDeXepThoiKhoaBieu();
            min.Show(); this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            TrangQuanLyTaiKhoan min = new TrangQuanLyTaiKhoan();
            min.Show(); this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TrangDangNhap min = new TrangDangNhap();    
            min.Show(); this.Hide();    
        }
    }
}
