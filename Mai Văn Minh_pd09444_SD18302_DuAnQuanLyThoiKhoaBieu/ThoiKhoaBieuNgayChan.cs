using Microsoft.Data.SqlClient.DataClassification;
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
    public partial class ThoiKhoaBieuNgayChan : Form
    {
        public ThoiKhoaBieuNgayChan()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        string str = @"Data Source=LAPTOP-CKN1UE62\MAIVANMINH;Initial Catalog=QuanLyThoiKhoaBieu;Integrated Security=True;Encrypt=False";
        DataTable dt = new DataTable();
        void load()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Ca_GiaoVien where NgayDay='246' ";
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);

        }
        public void sapxep()
        {
            connection = new SqlConnection(str);
            connection.Open();
            load();
            SqlDataReader reader = command.ExecuteReader();
            List<string> Phong = new List<string>();
            List<string> MaLop = new List<string>();
            List<string> MonDay = new List<string>();
            List<string> GiaoVien = new List<string>();
            List<string> Slot = new List<string>();
            while (reader.Read())
            {
                Slot.Add(reader["Slot"].ToString());
                Phong.Add(reader["PhongDay"].ToString());
                MaLop.Add(reader["LopDay"].ToString());
                GiaoVien.Add(reader["TenGiangVien"].ToString());
                MonDay.Add(reader["MaMonDay"].ToString());
            }

            List<cahoc> ListCaHoc = new List<cahoc>()
    {
        new cahoc(){Slot=Slot[0].ToString(),Phong=Phong[0].ToString(),LopDay=MaLop[0].ToString(),TenGiangVien=GiaoVien[0].ToString(),MonDay=MonDay[0].ToString()},
        new cahoc(){Slot=Slot[1].ToString(),Phong=Phong[1].ToString(),LopDay=MaLop[1].ToString(),TenGiangVien=GiaoVien[1].ToString(),MonDay=MonDay[1].ToString()},
        new cahoc(){Slot=Slot[2].ToString(),Phong=Phong[2].ToString(),LopDay=MaLop[2].ToString(),TenGiangVien=GiaoVien[2].ToString(),MonDay=MonDay[2].ToString()},
        new cahoc(){Slot=Slot[3].ToString(),Phong=Phong[3].ToString(),LopDay=MaLop[3].ToString(),TenGiangVien=GiaoVien[3].ToString(),MonDay=MonDay[3].ToString()},
       new cahoc(){Slot=Slot[4].ToString(),Phong=Phong[4].ToString(),LopDay=MaLop[4].ToString(),TenGiangVien=GiaoVien[4].ToString(),MonDay=MonDay[5].ToString()},
       new cahoc(){Slot=Slot[5].ToString(),Phong=Phong[5].ToString(),LopDay=MaLop[5].ToString(),TenGiangVien=GiaoVien[5].ToString(),MonDay=MonDay[5].ToString()},
         new cahoc(){Slot=Slot[6].ToString(),Phong=Phong[6].ToString(),LopDay=MaLop[6].ToString(),TenGiangVien=GiaoVien[6].ToString(),MonDay=MonDay[6].ToString()},
        new cahoc(){Slot=Slot[7].ToString(),Phong=Phong[7].ToString(),LopDay=MaLop[7].ToString(),TenGiangVien=GiaoVien[7].ToString(),MonDay=MonDay[7].ToString()},
        new cahoc(){Slot=Slot[8].ToString(),Phong=Phong[8].ToString(),LopDay=MaLop[8].ToString(),TenGiangVien=GiaoVien[8].ToString(),MonDay=MonDay[8].ToString()},
        new cahoc(){Slot=Slot[9].ToString(),Phong=Phong[9].ToString(),LopDay=MaLop[9].ToString(),TenGiangVien=GiaoVien[9].ToString(),MonDay=MonDay[9].ToString()},
       new cahoc(){Slot=Slot[10].ToString(),Phong=Phong[10].ToString(),LopDay=MaLop[10].ToString(),TenGiangVien=GiaoVien[10].ToString(),MonDay=MonDay[10].ToString()},
       new cahoc(){Slot=Slot[11].ToString(),Phong=Phong[11].ToString(),LopDay=MaLop[11].ToString(),TenGiangVien=GiaoVien[11].ToString(),MonDay=MonDay[11].ToString()}
            };
            int i = 0;
            while (i < ListCaHoc.Count)
            {
                if (ListCaHoc[i].Slot == "S1")
                {
                    label17.Text = ListCaHoc[i].Phong;
                    label18.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                    // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp

                }
                if (i >= 0)
                {
                    if (ListCaHoc[i].Slot == "S2" && label17.Text == ListCaHoc[i].Phong)
                    {

                        label19.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S2" && label24.Text == ListCaHoc[i].Phong)
                    {

                        label26.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S2")
                    {
                        label24.Text = ListCaHoc[i].Phong;
                        label26.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                }
                if (i >= 0)
                {
                    if (ListCaHoc[i].Slot == "S3" && label17.Text == ListCaHoc[i].Phong)
                    {

                        label20.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S3" && label24.Text == ListCaHoc[i].Phong)
                    {

                        label27.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S3" && label27.Text == "0")
                    {
                        label24.Text = ListCaHoc[i].Phong;
                        label27.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S3")
                    {
                        label31.Text = ListCaHoc[i].Phong;
                        label34.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                }
                if (i >= 0)
                {
                    if (ListCaHoc[i].Slot == "S4" && label17.Text == ListCaHoc[i].Phong)
                    {

                        label21.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S4" && label24.Text == ListCaHoc[i].Phong)
                    {

                        label28.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S4" && label34.Text == "0")
                    {
                        label31.Text = ListCaHoc[i].Phong;
                        label34.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    if (ListCaHoc[i].Slot == "S4")
                    {
                        label38.Text = ListCaHoc[i].Phong;
                        label43.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                }
                if (i >= 0)
                {
                    if (ListCaHoc[i].Slot == "S5" && label17.Text == ListCaHoc[i].Phong)
                    {

                        label22.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        break;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S5" && label24.Text == ListCaHoc[i].Phong)
                    {

                        label29.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S5" && label43.Text == "0")
                    {
                        label38.Text = ListCaHoc[i].Phong;
                        label43.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S5")
                    {
                        label51.Text = ListCaHoc[i].Phong;
                        label49.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp

                    }
                }

                if (i >= 0)
                {
                    if (ListCaHoc[i].Slot == "S6" && label17.Text == ListCaHoc[i].Phong)
                    {

                        label23.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S6" && label24.Text == ListCaHoc[i].Phong)
                    {

                        label30.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S6" && label49.Text == "0")
                    {
                        label51.Text = ListCaHoc[i].Phong;
                        label49.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S6")
                    {
                        label56.Text = ListCaHoc[i].Phong;
                        label54.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp

                    }
                }
                if (i >= 0)
                {
                    if (ListCaHoc[i].Slot == "S1" && label17.Text != ListCaHoc[i].Phong)
                    {

                        label59.Text = ListCaHoc[i].Phong;
                        label60.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S1" && label24.Text == ListCaHoc[i].Phong)
                    {

                        label25.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S1" && label38.Text == ListCaHoc[i].Phong)
                    {

                        label39.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S1" && label56.Text == "0")
                    {
                        label56.Text = ListCaHoc[i].Phong;
                        label54.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }

                }
                if (i >= 0)
                {
                    if (ListCaHoc[i].Slot == "S2" && label17.Text != ListCaHoc[i].Phong)
                    {

                        label70.Text = ListCaHoc[i].Phong;
                        label72.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S2" && label38.Text == ListCaHoc[i].Phong)
                    {

                        label40.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S2" && label24.Text == ListCaHoc[i].Phong)
                    {

                        label26.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S2" && label56.Text == "0")
                    {
                        label56.Text = ListCaHoc[i].Phong;
                        label54.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S2" && label59.Text == "0")
                    {
                        label59.Text = ListCaHoc[i].Phong;
                        label62.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                }
                if (i >= 0)
                {
                    if (ListCaHoc[i].Slot == "S3" && label17.Text != ListCaHoc[i].Phong)

                    {
                        label59.Text = ListCaHoc[i].Phong;
                        label61.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S3" && label24.Text == ListCaHoc[i].Phong)
                    {

                        label27.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S3" && label38.Text == ListCaHoc[i].Phong)
                    {

                        label41.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S3" && label56.Text == "0")
                    {
                        label56.Text = ListCaHoc[i].Phong;
                        label54.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }

                }
                if (i >= 0)
                {
                    if (ListCaHoc[i].Slot == "S4" && label17.Text != ListCaHoc[i].Phong)
                    {

                        label70.Text = ListCaHoc[i].Phong;
                        label66.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S4" && label24.Text == ListCaHoc[i].Phong)
                    {

                        label28.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S4" && label38.Text == ListCaHoc[i].Phong)
                    {

                        label42.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S4" && label56.Text == "0")
                    {
                        label56.Text = ListCaHoc[i].Phong;
                        label54.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }

                }
                if (i >= 0)
                {
                    /* if (ListCaHoc[i].Slot == "S4" && label17.Text != ListCaHoc[i].Phong)
                     {

                         label59.Text = ListCaHoc[i].Phong;
                         label60.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                         // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                     }*/
                    if (ListCaHoc[i].Slot == "S5" && label24.Text == ListCaHoc[i].Phong)
                    {

                        label29.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    else if (ListCaHoc[i].Slot == "S5" && label38.Text == ListCaHoc[i].Phong)
                    {

                        label43.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }
                    /*else if (ListCaHoc[i].Slot == "S4" && label56.Text == "0")
                    {
                        label56.Text = ListCaHoc[i].Phong;
                        label54.Text = ListCaHoc[i].LopDay + "\n" + ListCaHoc[i].TenGiangVien + "\n" + ListCaHoc[i].MonDay;
                        // Thoát khỏi vòng lặp sau khi tìm thấy phần tử thích hợp
                    }*/

                }
                i++;
            }
            if (label20.Text != null && label19.Text == "0")
            {
                label20.Text = label19.Text;
                label20.Text = "0";
            }
            if (label27.Text != null && label26.Text == "0")
            {
                label27.Text = label26.Text;
                label27.Text = "0";
            }
            if (label34.Text != null && label33.Text == "0")
            {
                label34.Text = label26.Text;
                label33.Text = "0";
            }
            if (label27.Text != null && label28.Text == "0")
            {
                label27.Text = label28.Text;
                label27.Text = "0";
            }
            if (label34.Text != null && label35.Text == "0")
            {
                label34.Text = label35.Text;
                label34.Text = "0";
            }
            if (label48.Text != null && label50.Text == "0")
            {
                label50.Text = label48.Text;
                label48.Text = "0";
            }
            if (label57.Text != null && label55.Text == "0")
            {
                label55.Text = label48.Text;
                label57.Text = "0";
            }
            if (label61.Text != null && label62.Text == "0")
            {
                label62.Text = label61.Text;
                label61.Text = "0";
            }
            if (label34.Text != null && label35.Text == "0")
            {
                label34.Text = label35.Text;
                label34.Text = "0";
            }
            if (label41.Text != null && label40.Text == "0")
            {
                label41.Text = label42.Text;
                label41.Text = "0";
            }
            if (label41.Text != null && label42.Text == "0")
            {
                label41.Text = label42.Text;
                label41.Text = "0";
            }
            if (label50.Text != null && label47.Text == "0")
            {
                label50.Text = label47.Text;
                label50.Text = "0";
            }
        }
        public class cahoc
        {

            public string Slot { get; set; }
            public string Phong { get; set; }
            public string LopDay { get; set; }
            public string MonDay { get; set; }
            public string TenGiangVien { get; set; }


        }

        private void ThoiKhoaBieuNgayChan_Load(object sender, EventArgs e)
        {
            sapxep();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrangChu trangChu = new TrangChu();
            trangChu.Show();
            this.Hide();
        }

        private void label59_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
