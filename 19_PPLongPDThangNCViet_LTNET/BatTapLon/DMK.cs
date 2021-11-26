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
    public partial class DMK : Form
    {
        public DMK(string Us)
        {
            InitializeComponent();
            txtDn.Text = Us;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            txtMk.Text = "";
            txtNMk.Text = "";
            txtMk.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DMK_Load(object sender, EventArgs e)
        {

        }

        /* thông tin nhóm 19
        * Phan Đức Thắng 18103100073  
        * Phạm Phúc Long   18103100016
        * Nguyễn Cao Việt  18103100072
        * DHTI12A1Hn
        */
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ketnoi;
                ketnoi = @"Data Source=DESKTOP-LO0N98Q\SQLEXPRESS;Initial Catalog=qlsp_19_PPLongPDThangNCViet;Integrated Security=True";
                SqlConnection sqlcon = new SqlConnection(ketnoi);
                sqlcon.Open();
                string sql;
                sql = "Update DangNhap set  MatKhau='" + txtNMk.Text + "' where USERNAME= '" + txtDn.Text + "'";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                int kq = sqlcom.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã đổi mật khẩu  thành công!");
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi" + ex.Message);
            }
        }
    }
}
