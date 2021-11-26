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
namespace BatTapLon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /* thông tin nhóm 19
         * Phan Đức Thắng 18103100073
         * Phạm Phúc Long   18103100016
         * Nguyễn Cao Việt  18103100072
         * DHTI12A1Hn
         
         */
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Mod=getMod(txtDN.Text,txtMK.Text);
            string Us = txtDN.Text;
            if(Mod == "1"||Mod == "0")
            {
                fAdmin admin = new fAdmin(Mod,Us);
                this.Hide();
                
                admin.ShowDialog();
                this.Show();
            }   
             
            else
            {
                MessageBox.Show("Mật khẩu hoặc tài khoản bạn bị sai");
            }    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LO0N98Q\\SQLEXPRESS;Initial Catalog=qlsp_19_PPLongPDThangNCViet;Integrated Security=True");
        private string getMod(string username, string pass)
        {
            string mod = "";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM DangNhap WHERE USERNAME ='"+username+"'AND MatKhau ='"+pass+"' ", con) ;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                { 
                foreach(DataRow dr in dt.Rows)
                    {
                        mod = dr["PhanQuyen"].ToString();
                    }    
                }    
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi");
            }
            finally
            {
                con.Close();
            }
            return mod;
        }
    }
}
