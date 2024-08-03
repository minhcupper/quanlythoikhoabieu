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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mai_Văn_Minh_pd09444_SD18302_DuAnQuanLyThoiKhoaBieu
{
    public partial class TrangQuanLyLopHoc : Form
    {
        public TrangQuanLyLopHoc()
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
            command.CommandText = "select *from Lop_MonHoc";
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void TrangQuanLyLopHoc_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.CreateCommand();
            // Tạo các tham số
            command.Parameters.AddWithValue("@MaMon", comboBox1.Text);
            command.Parameters.AddWithValue("@TenMon", comboBox2.Text);
            command.Parameters.AddWithValue("@MaLopPattern", comboBox6.Text);

            // Thiết lập câu lệnh SQL với tham số
            command.CommandText = "INSERT INTO Lop_MonHoc (MaLop, MaMon, TenMon) " + "SELECT MaLop, @MaMon, @TenMon FROM Lop WHERE MaLop LIKE '%' + @MaLopPattern + '%'";
            command.ExecuteNonQuery();
            load();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.CreateCommand();
            // Tạo các tham số
            command.Parameters.AddWithValue("@MaMon", comboBox1.Text);
            command.Parameters.AddWithValue("@TenMon", comboBox2.Text);
            command.Parameters.AddWithValue("@MaLopPattern", comboBox6.Text);

            // Thiết lập câu lệnh SQL với tham số
            command.CommandText = "UPDATE Lop_MonHoc " + "SET MaMon = @MaMon, TenMon = @TenMon " + "WHERE MaLop IN (SELECT MaLop FROM Lop WHERE MaLop LIKE '%' + @MaLopPattern + '%')";
            command.ExecuteNonQuery();
            load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.CreateCommand();
            command.Parameters.AddWithValue("@MaLopPattern", "%" + comboBox6.Text + "%");

            // Thiết lập câu lệnh SQL với tham số
            command.CommandText = "DELETE FROM Lop_MonHoc WHERE MaLop IN (SELECT MaLop FROM Lop WHERE MaLop LIKE @MaLopPattern)";
            command.ExecuteNonQuery();
            load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int i;

            i = dataGridView1.CurrentRow.Index;

            comboBox6.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            /* textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
             textBox4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
             textBox5.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
             textBox6.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TrangChu min = new TrangChu();
            min.Show();
            this.Hide();
        }

        private void trangDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangQuanlyGiaoVien min = new TrangQuanlyGiaoVien();
            min.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            command.CommandText = "select  Lop_MonHoc *from  where MaMon = '" + comboBox1.Text + "'";
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

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
