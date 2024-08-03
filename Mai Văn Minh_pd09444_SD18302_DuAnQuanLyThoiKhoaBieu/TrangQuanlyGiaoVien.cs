using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Common;

namespace Mai_Văn_Minh_pd09444_SD18302_DuAnQuanLyThoiKhoaBieu
{
    public partial class TrangQuanlyGiaoVien : Form
    {

        public TrangQuanlyGiaoVien()
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
            command.CommandText = "select *from ThongTinGiaoVien";
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        /* void LoadTrangGiaoVien()
         {
             command = connection.CreateCommand();
             command.CommandText = "select *from GiaoVien";
             adapter.SelectCommand = command;
             dt.Clear();
             adapter.Fill(dt);
             dataGridView1.DataSource = dt;
         }*/
        private void trangDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.CreateCommand();
            command.CommandText = "delete from ThongTinGiaoVien where TenGiangVien='" + comboBox8.Text + "' ";
            command.ExecuteNonQuery();
            load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TrangChu min = new TrangChu();
            min.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dataGridView1.CurrentRow.Index;

            comboBox8.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            comboBox4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            comboBox5.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            comboBox6.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            comboBox7.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            comboBox3.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TrangQuanlyGiaoVien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.CreateCommand();
            command.CommandText = "insert into ThongTinGiaoVien values (N'" + comboBox8.Text + "',N'" + comboBox1.Text + "',N'" + comboBox2.Text + "',N'" + comboBox4.Text + "',N'" + comboBox5.Text + "','" + comboBox6.Text + "',N'" + comboBox7.Text + "',N'" + comboBox3.Text + "')";
            command.ExecuteNonQuery();
            load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.CreateCommand();
            command.CommandText = "update ThongTinGiaoVien set TenGiangVien=N'" + comboBox8.Text + "',MaMon=N'" + comboBox1.Text + "',TenMon=N'" + comboBox2.Text + "',NgayDay=N'" + comboBox4.Text + "',Slot=N'" + comboBox5.Text + "',LopDay=N'" + comboBox6.Text + "',PhongDay=N'" + comboBox7.Text + "',TangDay=N'" + comboBox3.Text + "'where TenGiangVien='" + comboBox8.Text + "' ";
            command.ExecuteNonQuery();
            load();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TrangQuanlyGiaoVien_Load_1(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            load();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void trangDữLiệuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TrangQuanlyGiaoVien min = new TrangQuanlyGiaoVien();
            min.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            command.CommandText = "select *from ThongTinGiaoVien where  TenGiangVien=N'" + comboBox8.Text + "'";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void thờiKhóaBiểuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangChonThoiKhoaBieu min = new TrangChonThoiKhoaBieu();
            min.Show();
            this.Hide();
        }
    }
}
