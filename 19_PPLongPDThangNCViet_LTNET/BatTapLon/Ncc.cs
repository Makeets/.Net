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
    public partial class Ncc : Form
    {
        public Ncc()
        {
            InitializeComponent();
            
        }
        
        void loatdata3()
        {
            string ketnoi;
            ketnoi = @"Data Source=DESKTOP-LO0N98Q\SQLEXPRESS;Initial Catalog=qlsp_19_PPLongPDThangNCViet;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(ketnoi);
            sqlcon.Open();
            string sql;
            sql = "select * from NhaCungCap";
            SqlDataAdapter sqlData = new SqlDataAdapter(sql, sqlcon);
            DataSet ds = new DataSet();
            sqlData.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            
        }

        private void Ncc_Load(object sender, EventArgs e)
        {
            string ketnoi;
            ketnoi = @"Data Source=DESKTOP-LO0N98Q\SQLEXPRESS;Initial Catalog=qlsp_19_PPLongPDThangNCViet;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(ketnoi);
            sqlcon.Open();
            string sql3;
            sql3 = "select * from NhaCungCap";
            SqlDataAdapter sqlData3 = new SqlDataAdapter(sql3, sqlcon);
            DataSet ds3 = new DataSet();
            sqlData3.Fill(ds3);
            dataGridView2.DataSource = ds3.Tables[0];

            txtNcc2.DataBindings.Add("text", ds3.Tables[0], "MaNhaCC");
            txtTenNcc.DataBindings.Add("text", ds3.Tables[0], "TenNhaCC");
            txtMail.DataBindings.Add("text", ds3.Tables[0], "EmailNhaCC");
            txtDt.DataBindings.Add("text", ds3.Tables[0], "DienThoai");
        }
  
        private void button9_Click(object sender, EventArgs e)
        {
            txtNcc2.Text = "";
            txtTenNcc.Text = "";
            txtMail.Text = "";
            txtDt.Text = "";
            txtNcc2.Focus();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNcc2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtTenNcc.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtMail.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txtDt.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }
        
        private void btnThemNcc_Click(object sender, EventArgs e)
        {
            try
            {
                string ketnoi;
                ketnoi = @"Data Source=DESKTOP-LO0N98Q\SQLEXPRESS;Initial Catalog=qlsp_19_PPLongPDThangNCViet;Integrated Security=True";
                SqlConnection sqlcon = new SqlConnection(ketnoi);
                sqlcon.Open();
                string sql;
                sql = "insert into NhaCungCap values('" + txtNcc2.Text + "', N'" + txtTenNcc.Text + "','" + txtMail.Text + "','" + txtDt.Text + "')";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                int kq = sqlcom.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Đã thêm thành công ", "thêm dữ liệu");
                    loatdata3();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công");
                MessageBox.Show("nguyên nhân " + ex.Message);
            }
        }
    
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                string ketnoi;

                ketnoi = @"Data Source=DESKTOP-LO0N98Q\SQLEXPRESS;Initial Catalog=qlsp_19_PPLongPDThangNCViet;Integrated Security=True";
                SqlConnection sqlcon = new SqlConnection(ketnoi);
                sqlcon.Open();
                string sql;
                sql = "Update NhaCungCap set  TenNhaCC= N'" + txtTenNcc.Text + "', EmailNhaCC= N'" + txtMail.Text + "', DienThoai='" + txtDt.Text + "' where MaNhaCC= '" + txtNcc2.Text + "'";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                int kq = sqlcom.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã sửa thành công!");
                    loatdata3();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi" + ex.Message);
            }
        }
     
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string ketnoi;

                ketnoi = @"Data Source=DESKTOP-LO0N98Q\SQLEXPRESS;Initial Catalog=qlsp_19_PPLongPDThangNCViet;Integrated Security=True";
                SqlConnection sqlcon = new SqlConnection(ketnoi);
                sqlcon.Open();
                string sql;
                sql = "Delete NhaCungCap where  MaNhaCC='" + txtNcc2.Text + "'";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                int kq = sqlcom.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã xóa thành công!");
                    loatdata3();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi" + ex.Message);
            }
        }
        /* thông tin nhóm 19
* Phan Đức Thắng 18103100073  
* Phạm Phúc Long   18103100016
* Nguyễn Cao Việt  18103100072
* DHTI12A1Hn
*/
        private void button17_Click(object sender, EventArgs e)
        {
            
                string ketnoi;
                ketnoi = @"Data Source=DESKTOP-LO0N98Q\SQLEXPRESS;Initial Catalog=qlsp_19_PPLongPDThangNCViet;Integrated Security=True";
                SqlConnection sqlcon = new SqlConnection(ketnoi);
                sqlcon.Open();
                string timkiem;
                timkiem = "select * from NhaCungCap where TenNhaCC like '%' + @TenNhaCC + '%'  ";
                SqlCommand cmd = new SqlCommand(timkiem, sqlcon);
                cmd.Parameters.AddWithValue("MaNhaCC", txtTK.Text);
                cmd.Parameters.AddWithValue("TenNhaCC", txtTK.Text);
                cmd.Parameters.AddWithValue("EmailNhaCC", txtTK.Text);
                cmd.Parameters.AddWithValue("DienThoai", txtTK.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView2.DataSource = dt;
            

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string ketnoi;
            ketnoi = @"Data Source=DESKTOP-LO0N98Q\SQLEXPRESS;Initial Catalog=qlsp_19_PPLongPDThangNCViet;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(ketnoi);
            sqlcon.Open();
            string sql;
            sql = "select * from NhaCungCap";
            SqlDataAdapter sqlData = new SqlDataAdapter(sql, sqlcon);
            DataSet ds = new DataSet();
            sqlData.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
