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
    public partial class TrangChonThuDeXepThoiKhoaBieu : Form
    {
        public TrangChonThuDeXepThoiKhoaBieu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TrangChu min = new TrangChu();
            min.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "2" || comboBox1.Text == "4" || comboBox1.Text == "6")
            {
               TrangXepThoiKhoaBieuTuDong min=new TrangXepThoiKhoaBieuTuDong();
                min.Show();
                this.Hide();
            }
            else
            {
                TrangXepThoiKhoaBieuTuDongNgayLe min = new TrangXepThoiKhoaBieuTuDongNgayLe();
                min.Show();
                this.Hide();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
