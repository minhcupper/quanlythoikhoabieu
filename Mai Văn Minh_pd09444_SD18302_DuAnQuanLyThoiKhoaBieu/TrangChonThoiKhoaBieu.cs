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
    public partial class TrangChonThoiKhoaBieu : Form
    {
        public TrangChonThoiKhoaBieu()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "2" || comboBox1.Text == "4" || comboBox1.Text == "6")
            {
                ThoiKhoaBieuNgayChan min = new ThoiKhoaBieuNgayChan();
                min.Show();
                this.Hide();
            }

            else
            {
                ThoiKhoaBieu min = new ThoiKhoaBieu();
                min.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TrangChu min = new TrangChu();
            min.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
