using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mai_Văn_Minh_pd09444_SD18302_DuAnQuanLyThoiKhoaBieu
{
    public partial class TrangXepThoiKhoaBieu : Form
    {
        public TrangXepThoiKhoaBieu()
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
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TrangXepThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            load();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            command.CommandText = "select * from ThongTinGiaoVien where Slot = '" + comboBox3.Text + "' or NgayDay = '" + comboBox2.Text + "'";
            command.ExecuteNonQuery();
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

            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            comboBox3.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox6.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            /* textBox7.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            command.CommandText = "insert into Ca_GiaoVien values ('" + comboBox1.Text + "','" + textBox1.Text + "','" + comboBox3.Text + "','" + comboBox2.Text + "','" + textBox2.Text + "',N'" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            MessageBox.Show("Đã Thêm Ca Học ");
            //
            /*   connection.CreateCommand();
               command.CommandText = "insert into Ca_GiaoVien values (N'" + comboBox1.Text + "',N'" + textBox1.Text + "',N'" + comboBox3.Text + "',N'" + comboBox2.Text + "'N'" + textBox2.Text + "',N'" + textBox3.Text + "',N'" + textBox4.Text + "',N'" + textBox5.Text + "',N'" + textBox6.Text + "')";
               command.ExecuteNonQuery();
               load();*/

        }
        private bool KiemTraTonTaiTrongCoSoDuLieu(string data)
        {
            // Thực hiện kiểm tra dữ liệu trong cơ sở dữ liệu và trả về kết quả
            // Ở đây giả sử là hàm kiểm tra dữ liệu trong cơ sở dữ liệu đã tồn tại
            // Bạn cần thay thế phần này bằng kết nối và truy vấn thực tế
            return true; // Nếu dữ liệu đã tồn tại
        }

        private void trangDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangQuanlyGiaoVien min = new TrangQuanlyGiaoVien();
            min.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TrangChu min = new TrangChu();
            min.Show();
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
