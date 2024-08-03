using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mai_Văn_Minh_pd09444_SD18302_DuAnQuanLyThoiKhoaBieu
{
    public partial class TrangXepThoiKhoaBieuTuDong : Form
    {
        public TrangXepThoiKhoaBieuTuDong()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        string str = @"Data Source=LAPTOP-CKN1UE62\MAIVANMINH;Initial Catalog=QuanLyThoiKhoaBieu;Integrated Security=True;Encrypt=False";
        DataTable dt = new DataTable();
        void load()
        {
            command = connection.CreateCommand();
            command.CommandText = "select *from Ca_GiaoVien where NgayDay='246' ";
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);

        }
        public class cahoc
        {

            public string Slot { get; set; }
            public string NgayDay { get; set; }
            public string Phong { get; set; }
            public string LopDay { get; set; }
            public string MonDay { get; set; }
            public string TenGiangVien { get; set; }


        }
        public void TrangXepThoiKhoaBieuTuDong_Load(object sender, EventArgs e)
        {

            connection = new SqlConnection(str);
            connection.Open();
            load();
            SqlDataReader reader = command.ExecuteReader();
            List<string> Thu = new List<string>();
            List<string> Slot = new List<string>();
            List<string> NgayDay = new List<string>();
            List<string> PhongDay = new List<string>();
            List<string> LopDay = new List<string>();
            List<string> MonDay = new List<string>();
            List<string> TenGiangVien = new List<string>();


            while (reader.Read())
            {
                Thu.Add(reader["Thu"].ToString());
                Slot.Add(reader["Slot"].ToString());
                NgayDay.Add(reader["NgayDay"].ToString());
                PhongDay.Add(reader["PhongDay"].ToString());
                LopDay.Add(reader["LopDay"].ToString());
                TenGiangVien.Add(reader["TenGiangVien"].ToString());
                MonDay.Add(reader["MaMonDay"].ToString());

            }
            List<cahoc> list = new List<cahoc>() {
                new cahoc() {Slot=Slot[0].ToString(),NgayDay=NgayDay[0].ToString(),Phong=PhongDay[0].ToString(),LopDay=LopDay[0].ToString(),MonDay=MonDay[0].ToString(),TenGiangVien=TenGiangVien[0].ToString() },
                  new cahoc() {Slot=Slot[1].ToString(),NgayDay=NgayDay[1].ToString(),Phong=PhongDay[1].ToString(),LopDay=LopDay[1].ToString(),MonDay=MonDay[1].ToString(),TenGiangVien=TenGiangVien[1].ToString() },
                     new cahoc() { Slot=Slot[2].ToString(),NgayDay=NgayDay[2].ToString(),Phong=PhongDay[2].ToString(),LopDay=LopDay[2].ToString(),MonDay=MonDay[2].ToString(),TenGiangVien=TenGiangVien[2].ToString() },
                      new cahoc() {Slot=Slot[3].ToString(),NgayDay=NgayDay[3].ToString(),Phong=PhongDay[3].ToString(),LopDay=LopDay[3].ToString(),MonDay=MonDay[3].ToString(),TenGiangVien=TenGiangVien[3].ToString() },
                       new cahoc() {Slot=Slot[4].ToString(),NgayDay=NgayDay[4].ToString(),Phong=PhongDay[4].ToString(),LopDay=LopDay[4].ToString(),MonDay=MonDay[4].ToString(),TenGiangVien=TenGiangVien[4].ToString() },
                           new cahoc() {Slot=Slot[5].ToString(),NgayDay=NgayDay[5].ToString(),Phong=PhongDay[5].ToString(),LopDay=LopDay[5].ToString(),MonDay=MonDay[5].ToString(),TenGiangVien=TenGiangVien[5].ToString() }
            };
            Random BanDau = new Random();
            int so = BanDau.Next(0, 3);

            label11.Text = list[so].Phong.ToString();
            label12.Text = list[so].LopDay.ToString();
            label13.Text = list[so].MonDay.ToString();
            label14.Text = list[so].TenGiangVien.ToString();
            label15.Text = list[so].Slot.ToString();
            label16.Text = list[so].NgayDay.ToString();
            label23.Text = list[so].Phong.ToString();
            label24.Text = list[so].LopDay.ToString();
            label25.Text = list[so].MonDay.ToString();
            label26.Text = list[so].TenGiangVien.ToString();
            label27.Text = list[so].Slot.ToString();
            label28.Text = list[so].NgayDay.ToString();
            label2.Text = list[so].Phong.ToString();
            label3.Text = list[so].LopDay.ToString();
            label29.Text = list[so].MonDay.ToString();
            label30.Text = list[so].TenGiangVien.ToString();
            label31.Text = list[so].Slot.ToString();
            label32.Text = list[so].NgayDay.ToString();


            if (so + 1 < list.Count) // Kiểm tra xem phần tử tiếp theo có nằm trong phạm vi của danh sách không
            {
                label17.Text = list[so + 1].Phong.ToString();
                label18.Text = list[so + 1].LopDay.ToString();
                label19.Text = list[so + 1].MonDay.ToString();
                label20.Text = list[so + 1].TenGiangVien.ToString();
                label21.Text = list[so + 1].Slot.ToString();
                label22.Text = list[so + 1].NgayDay.ToString();

            }
            else // Kiểm tra xem phần tử tiếp theo có nằm trong phạm vi của danh sách không
            {
                label17.Text = list[so - 1].Phong.ToString();
                label18.Text = list[so - 1].LopDay.ToString();
                label19.Text = list[so - 1].MonDay.ToString();
                label20.Text = list[so - 1].TenGiangVien.ToString();
                label21.Text = list[so - 1].Slot.ToString();
                label22.Text = list[so - 1].NgayDay.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            load();
            SqlDataReader reader = command.ExecuteReader();
            List<string> Thu = new List<string>();
            List<string> Slot = new List<string>();
            List<string> NgayDay = new List<string>();
            List<string> PhongDay = new List<string>();
            List<string> LopDay = new List<string>();
            List<string> MonDay = new List<string>();
            List<string> TenGiangVien = new List<string>();


            while (reader.Read())
            {
                Thu.Add(reader["Thu"].ToString());
                Slot.Add(reader["Slot"].ToString());
                NgayDay.Add(reader["NgayDay"].ToString());
                PhongDay.Add(reader["PhongDay"].ToString());
                LopDay.Add(reader["LopDay"].ToString());
                TenGiangVien.Add(reader["TenGiangVien"].ToString());
                MonDay.Add(reader["MaMonDay"].ToString());

            }
            List<cahoc> list = new List<cahoc>() {
                new cahoc() {Slot=Slot[0].ToString(),NgayDay=NgayDay[0].ToString(),Phong=PhongDay[0].ToString(),LopDay=LopDay[0].ToString(),MonDay=MonDay[0].ToString(),TenGiangVien=TenGiangVien[0].ToString() },
                  new cahoc() {Slot=Slot[1].ToString(),NgayDay=NgayDay[1].ToString(),Phong=PhongDay[1].ToString(),LopDay=LopDay[1].ToString(),MonDay=MonDay[1].ToString(),TenGiangVien=TenGiangVien[1].ToString() },
                     new cahoc() { Slot=Slot[2].ToString(),NgayDay=NgayDay[2].ToString(),Phong=PhongDay[2].ToString(),LopDay=LopDay[2].ToString(),MonDay=MonDay[2].ToString(),TenGiangVien=TenGiangVien[2].ToString() },
                       new cahoc() {Slot=Slot[3].ToString(),NgayDay=NgayDay[3].ToString(),Phong=PhongDay[3].ToString(),LopDay=LopDay[3].ToString(),MonDay=MonDay[3].ToString(),TenGiangVien=TenGiangVien[3].ToString() },
                         new cahoc() {Slot=Slot[4].ToString(),NgayDay=NgayDay[4].ToString(),Phong=PhongDay[4].ToString(),LopDay=LopDay[4].ToString(),MonDay=MonDay[4].ToString(),TenGiangVien=TenGiangVien[4].ToString() },
                           new cahoc() {Slot=Slot[5].ToString(),NgayDay=NgayDay[5].ToString(),Phong=PhongDay[5].ToString(),LopDay=LopDay[5].ToString(),MonDay=MonDay[5].ToString(),TenGiangVien=TenGiangVien[5].ToString() },
                            new cahoc() {Slot=Slot[6].ToString(),NgayDay=NgayDay[6].ToString(),Phong=PhongDay[6].ToString(),LopDay=LopDay[6].ToString(),MonDay=MonDay[6].ToString(),TenGiangVien=TenGiangVien[6].ToString() },
                  new cahoc() {Slot=Slot[7].ToString(),NgayDay=NgayDay[7].ToString(),Phong=PhongDay[7].ToString(),LopDay=LopDay[7].ToString(),MonDay=MonDay[7].ToString(),TenGiangVien=TenGiangVien[7].ToString() },
                     new cahoc() { Slot=Slot[8].ToString(),NgayDay=NgayDay[8].ToString(),Phong=PhongDay[8].ToString(),LopDay=LopDay[8].ToString(),MonDay=MonDay[8].ToString(),TenGiangVien=TenGiangVien[8].ToString() },
                       new cahoc() {Slot=Slot[9].ToString(),NgayDay=NgayDay[9].ToString(),Phong=PhongDay[9].ToString(),LopDay=LopDay[9].ToString(),MonDay=MonDay[9].ToString(),TenGiangVien=TenGiangVien[9].ToString() },
                         new cahoc() {Slot=Slot[10].ToString(),NgayDay=NgayDay[10].ToString(),Phong=PhongDay[10].ToString(),LopDay=LopDay[10].ToString(),MonDay=MonDay[10].ToString(),TenGiangVien=TenGiangVien[10].ToString() },
                           new cahoc() {Slot=Slot[11].ToString(),NgayDay=NgayDay[11].ToString(),Phong=PhongDay[11].ToString(),LopDay=LopDay[11].ToString(),MonDay=MonDay[11].ToString(),TenGiangVien=TenGiangVien[11].ToString() }
            };

            Random random = new Random();
            int coun;

            //hang1
            do
            {
                coun = random.Next(0, list.Count);

                if (list[coun].Slot.ToString() == "S1" && list[coun].NgayDay.ToString() == "246" && list[coun].LopDay.ToString() != null && list[coun].TenGiangVien.ToString() != null && list[coun].MonDay.ToString() != null && list[coun].Phong.ToString() != null)
                {

                    label11.Text = list[coun].Phong.ToString();
                    label12.Text = list[coun].LopDay.ToString();
                    label13.Text = list[coun].MonDay.ToString();
                    label14.Text = list[coun].TenGiangVien.ToString();
                    label15.Text = list[coun].Slot.ToString();
                    label16.Text = list[coun].NgayDay.ToString();
                    break;
                }


            } while (list[coun].Slot.ToString() == "S1" && list[coun].NgayDay.ToString() == "246" && list[coun].LopDay.ToString() != null && list[coun].TenGiangVien.ToString() != null && list[coun].MonDay.ToString() != null && list[coun].Phong.ToString() != null);

            //hang2
            coun = random.Next(0, list.Count);
            do
            {
                coun = random.Next(0, list.Count);

                if (list[coun].Slot.ToString() == "S2" && list[coun].NgayDay.ToString() == "246" && list[coun].LopDay.ToString() != null && list[coun].TenGiangVien.ToString() != null && list[coun].MonDay.ToString() != null && list[coun].Phong.ToString() != null)
                {

                    label17.Text = list[coun].Phong.ToString();
                    label18.Text = list[coun].LopDay.ToString();
                    label19.Text = list[coun].MonDay.ToString();
                    label20.Text = list[coun].TenGiangVien.ToString();
                    label21.Text = list[coun].Slot.ToString();
                    label22.Text = list[coun].NgayDay.ToString();

                    break;
                }


            } while (list[coun].Slot.ToString() == "S2" && list[coun].NgayDay.ToString() == "246" && label21.Text != label15.Text);

            coun = random.Next(0, list.Count);
            //hang3
            do
            {
                coun = random.Next(0, list.Count);

                if (list[coun].Slot.ToString() == "S3" && list[coun].NgayDay.ToString() == "246" && list[coun].LopDay.ToString() != null && list[coun].TenGiangVien.ToString() != null && list[coun].MonDay.ToString() != null && list[coun].Phong.ToString() != null)
                {

                    label23.Text = list[coun].Phong.ToString();
                    label24.Text = list[coun].LopDay.ToString();
                    label25.Text = list[coun].MonDay.ToString();
                    label26.Text = list[coun].TenGiangVien.ToString();
                    label27.Text = list[coun].Slot.ToString();
                    label28.Text = list[coun].NgayDay.ToString();

                    break;
                }
                coun = random.Next(0, list.Count);

            } while (list[coun].Slot.ToString() == "S4" && list[coun].NgayDay.ToString() == "246" && label27.Text != label21.Text && label27.Text != label15.Text);
            //hang3
            do
            {
                coun = random.Next(0, list.Count);

                if (list[coun].Slot.ToString() == "S4" && list[coun].NgayDay.ToString() == "246" && list[coun].LopDay.ToString() != null && list[coun].TenGiangVien.ToString() != null && list[coun].MonDay.ToString() != null && list[coun].Phong.ToString() != null)
                {

                    label2.Text = list[coun].Phong.ToString();
                    label3.Text = list[coun].LopDay.ToString();
                    label29.Text = list[coun].MonDay.ToString();
                    label30.Text = list[coun].TenGiangVien.ToString();
                    label31.Text = list[coun].Slot.ToString();
                    label32.Text = list[coun].NgayDay.ToString();

                    break;
                }


            } while (list[coun].Slot.ToString() == "S4" && list[coun].NgayDay.ToString() == "246" && label27.Text != label21.Text && label27.Text != label15.Text);

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void thờiKhóaBiểuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThoiKhoaBieu min = new ThoiKhoaBieu();
            min.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ThoiKhoaBieuNgayChan min = new ThoiKhoaBieuNgayChan();
            min.sapxep();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            TrangChu min = new TrangChu();  
            min.Show();
            this.Hide();
        }
    }
}
