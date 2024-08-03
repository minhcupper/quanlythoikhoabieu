using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mai_Văn_Minh_pd09444_SD18302_DuAnQuanLyThoiKhoaBieu
{
    public partial class TrangQuanLyMonHoc : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        string str = @"Data Source=LAPTOP-CKN1UE62\MAIVANMINH;Initial Catalog=QuanLyThoiKhoaBieu;Integrated Security=True;Encrypt=False";
        DataTable dt = new DataTable();
        void load()
        {
            command = connection.CreateCommand();
            command.CommandText = "select *from MonHoc";
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public TrangQuanLyMonHoc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TrangQuanLyMonHoc_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            load();

        }

        private void dữLiệuMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangQuanLyMonHoc n = new TrangQuanLyMonHoc();
            n.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.CreateCommand();
            command.CommandText = "update MonHoc set MaMon=N'" + textBox1.Text + "',TenMon=N'" + textBox2.Text + "'where MaMon='" + textBox1.Text + "' ";
            command.ExecuteNonQuery();
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.CreateCommand();
            command.CommandText = "insert into MonHoc values (N'" + textBox1.Text + "',N'" + textBox2.Text + "')";
            command.ExecuteNonQuery();
            load();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.CreateCommand();
            command.CommandText = "delete from MonHoc where MaMon='" + textBox1.Text + "' ";
            command.ExecuteNonQuery();
            load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dataGridView1.CurrentRow.Index;

            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            /* textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
             textBox4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
             textBox5.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
             textBox6.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();*/
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

        private void button5_Click(object sender, EventArgs e)
        {
            command.CommandText = "select   * from MonHoc where  MaMon=N'" + textBox1.Text + "'";
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

        private void thờiKhóaBiểuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangChonThoiKhoaBieu min = new TrangChonThoiKhoaBieu();
            min.Show();
            this.Hide();
        }

        private void trangNhậpDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangChu min=new TrangChu();    
            min.Show();
            min.Hide();
        }
    }
}
