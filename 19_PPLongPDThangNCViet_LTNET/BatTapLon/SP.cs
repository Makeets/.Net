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
using System.Data.OleDb;
namespace BatTapLon
{
    public partial class SP : Form
    {
        public SP()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        void loatdata2()
        {
            string ketnoi;
            ketnoi = @"Data Source=DESKTOP-LO0N98Q\SQLEXPRESS;Initial Catalog=qlsp_19_PPLongPDThangNCViet;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(ketnoi);
            sqlcon.Open();
            string sql;
            sql = "select * from SanPham";
            SqlDataAdapter sqlData = new SqlDataAdapter(sql, sqlcon);
              ds = new DataSet();
            sqlData.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
        
        private void SP_Load(object sender, EventArgs e)
        {
            string ketnoi;
            ketnoi = @"Data Source=DESKTOP-LO0N98Q\SQLEXPRESS;Initial Catalog=qlsp_19_PPLongPDThangNCViet;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(ketnoi);
            sqlcon.Open();
            string sql2;
            sql2 = "select * from SanPham";
            SqlDataAdapter sqlData2 = new SqlDataAdapter(sql2, sqlcon);
            DataSet ds2 = new DataSet();
            sqlData2.Fill(ds2);
            dataGridView1.DataSource = ds2.Tables[0];

            txtMa.DataBindings.Add("text", ds2.Tables[0], "MaSP");
            txtTen.DataBindings.Add("text", ds2.Tables[0], "TenSP");
            txtSL.DataBindings.Add("text", ds2.Tables[0], "SoLuong");
            txtGia.DataBindings.Add("text", ds2.Tables[0], "DonGia");
            txtHang.DataBindings.Add("text", ds2.Tables[0], "HangSanPham");
            txtNcc.DataBindings.Add("text", ds2.Tables[0], "MaNhaCC");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtSL.Text = "";
            txtGia.Text = "";
            txtHang.Text = "";
            txtNcc.Text = "";
            txtMa.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSL.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtGia.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtHang.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtNcc.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            try
            {
                string ketnoi;
                ketnoi = @"Data Source=DESKTOP-LO0N98Q\SQLEXPRESS;Initial Catalog=qlsp_19_PPLongPDThangNCViet;Integrated Security=True";
                SqlConnection sqlcon = new SqlConnection(ketnoi);
                sqlcon.Open();
                string sql;
                sql = "insert into SanPham values('" + txtMa.Text + "',N'" + txtTen.Text + "','" + txtSL.Text + "','" + txtGia.Text + "',N'" + txtHang.Text + "','" + txtNcc.Text + "')";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                int kq = sqlcom.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Đã thêm thành công ", "thêm dữ liệu");
                    loatdata2();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công");
                MessageBox.Show("nguyên nhân " + ex.Message);
            }
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ketnoi;

                ketnoi = @"Data Source=DESKTOP-LO0N98Q\SQLEXPRESS;Initial Catalog=qlsp_19_PPLongPDThangNCViet;Integrated Security=True";
                SqlConnection sqlcon = new SqlConnection(ketnoi);
                sqlcon.Open();
                string sql;
                sql = "Delete SanPham where  MaSP='" + txtMa.Text + "'";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                int kq = sqlcom.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã xóa thành công!");
                    loatdata2();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi" + ex.Message);
            }
        }
       
        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                string ketnoi;

                ketnoi = @"Data Source=DESKTOP-LO0N98Q\SQLEXPRESS;Initial Catalog=qlsp_19_PPLongPDThangNCViet;Integrated Security=True";
                SqlConnection sqlcon = new SqlConnection(ketnoi);
                sqlcon.Open();
                string sql;
                sql = "Update SanPham set  TenSP= N'" + txtTen.Text + "', SoLuong=  '" + txtSL.Text + "', DonGia='" + txtGia.Text + "', HangSanPham= N'" + txtHang.Text + "', MaNhaCC= N'" + txtNcc.Text + "' where MaSP= '" + txtMa.Text + "'";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                int kq = sqlcom.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã sửa thành công!");
                    loatdata2();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi" + ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /* thông tin nhóm 19
        * Phan Đức Thắng 18103100073  
        * Phạm Phúc Long   18103100016
        * Nguyễn Cao Việt  18103100072
        * DHTI12A1Hn
         */
        private void button16_Click(object sender, EventArgs e)
        {
            string ketnoi;
            ketnoi = @"Data Source=DESKTOP-LO0N98Q\SQLEXPRESS;Initial Catalog=qlsp_19_PPLongPDThangNCViet;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(ketnoi);
            sqlcon.Open();
            string timkiem;
            timkiem = "select * from SanPham where TenSP like '%' + @TenSP + '%'  ";
            SqlCommand cmd = new SqlCommand(timkiem, sqlcon);
            cmd.Parameters.AddWithValue("MaSP", txtTK.Text);
            cmd.Parameters.AddWithValue("TenSP", txtTK.Text);
            cmd.Parameters.AddWithValue("SoLuong", txtTK.Text);
            cmd.Parameters.AddWithValue("DonGia", txtTK.Text);
            cmd.Parameters.AddWithValue("HangSanPham", txtTK.Text);
            cmd.Parameters.AddWithValue("MaNhaCC", txtTK.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string ketnoi;
            ketnoi = @"Data Source=DESKTOP-LO0N98Q\SQLEXPRESS;Initial Catalog=qlsp_19_PPLongPDThangNCViet;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(ketnoi);
            sqlcon.Open();
            string sql;
            sql = "select * from SanPham";
            SqlDataAdapter sqlData = new SqlDataAdapter(sql, sqlcon);
              DataSet ds = new DataSet();
            sqlData.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //đầu
          // this.BindingContext[ds.Tables[0]].Position = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //trước
          // this.BindingContext[ds.Tables[0]].Position --;
        }


        private void btnSau_Click(object sender, EventArgs e)
        {
            //this.BindingContext[ds.Tables[0]].Position++;
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            //this.BindingContext[ds.Tables[0]].Position = ds.Tables[0].Rows.Count - 1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
