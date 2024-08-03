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
    public partial class TrangQuanLyCaGiaoVien : Form
    {
        public TrangQuanLyCaGiaoVien()
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
            command.CommandText = "select *from Ca_GiaoVien";
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dataGridView1.CurrentRow.Index;
            TrangQuanlyGiaoVien min = new TrangQuanlyGiaoVien();

            comboBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            comboBox3.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            textBox6.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            /* textBox7.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();*/
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TrangQuanLyCaGiaoVien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            load();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            command.CommandText = "select * from Ca_GiaoVien where Slot = '" + comboBox3.Text + "' and NgayDay = '" + comboBox2.Text + "' and Thu='" + comboBox1.Text + "'";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.CreateCommand();
            command.CommandText = "update Ca_GiaoVie set Thu='" + comboBox1.Text + "',TenGiangVien=N'" + textBox1.Text + "',Slot = '" + comboBox3.Text + "', NgayDay = '" + comboBox2.Text + "', TenMon = '" + textBox3.Text + "', LopDay = '" + textBox4.Text + "' , PhongDay = '" + textBox5.Text + "', TangDay = '" + textBox6.Text + "'where Thu='" + comboBox1.Text + "' ";
            command.ExecuteNonQuery();
            load();
            MessageBox.Show("Dã Cập Nhạt Dữ Liệu");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.CreateCommand();
            command.CommandText = "delete from  Ca_GiaoVie where Thu='" + comboBox1.Text + "'";
            command.ExecuteNonQuery();
            load();
            MessageBox.Show("Dã Xóa Dữ Liệu");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TrangChu min = new TrangChu();
            min.Show();
            this.Hide();
        }

        private void trangDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangQuanLyCaGiaoVien min = new TrangQuanLyCaGiaoVien();
            min.Show();
            this.Hide();
        }

        private void dữLiệuMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangQuanLyMonHoc n = new TrangQuanLyMonHoc();
            n.Show();
            this.Hide();
        }

        private void dữLiệuLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TrangQuanLyLopHoc n = new TrangQuanLyLopHoc();
            n.Show();
            this.Hide();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangQuanLyTaiKhoan min = new TrangQuanLyTaiKhoan();
            min.Show();
            this.Hide();
        }

        private void thờiKhóaBiểuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangChonThoiKhoaBieu min=new TrangChonThoiKhoaBieu();
            min.Show();
            this.Hide();
        }
    }
}
