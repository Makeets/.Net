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
    public partial class QLTK : Form
    {
        public QLTK()
        {
            InitializeComponent();
        }
        void loatdata()
        {
            string ketnoi;
            ketnoi = @"Data Source=DESKTOP-LO0N98Q\SQLEXPRESS;Initial Catalog=qlsp_19_PPLongPDThangNCViet;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(ketnoi);
            sqlcon.Open();
            string sql;
            sql = "select * from DangNhap";
            SqlDataAdapter sqlData = new SqlDataAdapter(sql, sqlcon);
            DataSet ds = new DataSet();
            sqlData.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        /* thông tin nhóm 19
     * Phan Đức Thắng 18103100073  
     * Phạm Phúc Long   18103100016
     * Nguyễn Cao Việt  18103100072
     * DHTI12A1Hn

     */
        private void button13_Click(object sender, EventArgs e)
        {
            txtDn2.Text = "";
            txtMk2.Text = "";
            txtName.Text = "";
            txtMail2.Text = "";
            txtQuyen.Text = "";
            txtStatus.Text = "";
            txtDn2.Focus();
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            try
            {
                string ketnoi;
                ketnoi = "Data Source=DESKTOP-LO0N98Q\\SQLEXPRESS;Initial Catalog=qlsp_19_PPLongPDThangNCViet;Integrated Security=True";
                SqlConnection sqlcon = new SqlConnection(ketnoi);
                sqlcon.Open();
                string sql;
                sql = "insert into DangNhap values('" + txtDn2.Text + "','" + txtMk2.Text + "',N'" + txtName.Text + "','" + txtMail2.Text + "','" + txtQuyen.Text + "',N'" + txtStatus.Text + "')";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                int kq = sqlcom.ExecuteNonQuery();
                if (kq > 0)

                {
                    MessageBox.Show("Đã thêm thành công ", "thêm dữ liệu");
                    loatdata();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công");
                MessageBox.Show("nguyên nhân " + ex.Message);
            }
        }
        /* thông tin nhóm 19
        * Phan Đức Thắng 18103100073  
        * Phạm Phúc Long   18103100016
        * Nguyễn Cao Việt  18103100072
        * DHTI12A1Hn

        */
        private void QLTK_Load(object sender, EventArgs e)
        {   //Hiển thị dữ liệu ra dạng lưới 
            string ketnoi;
            ketnoi = @"Data Source=DESKTOP-LO0N98Q\SQLEXPRESS;Initial Catalog=qlsp_19_PPLongPDThangNCViet;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(ketnoi);
            sqlcon.Open();
            string sql;
            sql = "select * from DangNhap";
            SqlDataAdapter sqlData = new SqlDataAdapter(sql, sqlcon);
            DataSet ds = new DataSet();
            sqlData.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
            //Hiện thị ra textbox
            txtDn2.DataBindings.Add("text", ds.Tables[0], "USERNAME");
            txtMk2.DataBindings.Add("text", ds.Tables[0], "MatKhau");
            txtName.DataBindings.Add("text", ds.Tables[0], "FullName");
            txtMail2.DataBindings.Add("text", ds.Tables[0], "Email");
            txtQuyen.DataBindings.Add("text", ds.Tables[0], "PhanQuyen");
            txtStatus.DataBindings.Add("text", ds.Tables[0], "TrangThai");
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDn2.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            txtMk2.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            txtMail2.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            txtQuyen.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
            txtStatus.Text = dataGridView3.CurrentRow.Cells[5].Value.ToString();
        }
        
        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                string ketnoi;

                ketnoi = @"Data Source=DESKTOP-LO0N98Q\SQLEXPRESS;Initial Catalog=qlsp_19_PPLongPDThangNCViet;Integrated Security=True";
                SqlConnection sqlcon = new SqlConnection(ketnoi);
                sqlcon.Open();
                string sql;
                sql = "Update DangNhap set  MatKhau='" + txtMk2.Text + "', FullName= N'" + txtName.Text + "', Email='" + txtMail2.Text + "', PhanQuyen='" + txtQuyen.Text + "', TrangThai= N'" + txtStatus.Text + "' where USERNAME= '" + txtDn2.Text + "'";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                int kq = sqlcom.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã sửa thành công!");
                    loatdata();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi" + ex.Message);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {

            //DELETE dangnhap WHERE username = '"+username+"'

            try
            {
                string ketnoi;

                ketnoi = @"Data Source=DESKTOP-LO0N98Q\SQLEXPRESS;Initial Catalog=qlsp_19_PPLongPDThangNCViet;Integrated Security=True";
                SqlConnection sqlcon = new SqlConnection(ketnoi);
                sqlcon.Open();
                string sql;
                sql = "Delete DangNhap where  USERNAME='" + txtDn2.Text + "'";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                int kq = sqlcom.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã xóa thành công!");
                    loatdata();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi" + ex.Message);
            }


        }
    }
}
