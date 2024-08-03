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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mai_Văn_Minh_pd09444_SD18302_DuAnQuanLyThoiKhoaBieu
{
    public partial class TrangQuanLyTaiKhoan : Form
    {
        public TrangQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
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
            command.CommandText = "select * from Taikhoan";
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void TrangQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.CreateCommand();
            command.CommandText = "insert into Taikhoan values('" + textBox1.Text + "','" + textBox2.Text + "'))";
            command.ExecuteNonQuery();
            load();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.CreateCommand();
            command.CommandText = "update Taikhoan set UserName=N'" + textBox1.Text + "',Pass=N'" + textBox2.Text + "' where UserName='" + textBox1.Text + "' ";
            command.ExecuteNonQuery();
            load();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            connection.CreateCommand();
            command.CommandText = "delete from Taikhoan where UserName='" + textBox1.Text + "' ";
            command.ExecuteNonQuery();
            load();
        }

        private void trangDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangQuanlyGiaoVien min = new TrangQuanlyGiaoVien();
            min.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TrangChu trangChu = new TrangChu();
            trangChu.Show();
            this.Hide();
        }

        private void dữLiệuLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TrangQuanLyLopHoc n = new TrangQuanLyLopHoc();
            n.Show();
            this.Hide();
        }

        private void dữLiệuMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangQuanLyMonHoc n = new TrangQuanLyMonHoc();
            n.Show();
            this.Hide();
        }

        private void thờiKhóaBiểuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangChonThoiKhoaBieu min = new TrangChonThoiKhoaBieu();
            min.Show();
            this.Hide();
        }
    }
}
