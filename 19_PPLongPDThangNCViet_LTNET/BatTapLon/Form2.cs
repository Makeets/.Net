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
    public partial class fAdmin : Form
    {
        public fAdmin(string Mod,string Us)
        {
            InitializeComponent();
            if (Mod == "1")
            {
                quảnLýTàiKhoảnToolStripMenuItem1.Visible = true;
            }
            else
            {
                quảnLýTàiKhoảnToolStripMenuItem1.Visible = false;
            }
            getUs.Text = Us;
        }
       
        
        

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {      
          
        }

        private void button17_Click(object sender, EventArgs e)
        {
        
        }

        private void button16_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }
      
        private void quảnLýTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QLTK tk = new QLTK();
            tk.MdiParent = this;
            tk.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Us = getUs.Text;
            DMK mk = new DMK(Us);
            mk.MdiParent = this;
            mk.Show();
        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        /* thông tin nhóm 19
      * Phan Đức Thắng 18103100073  
      * Phạm Phúc Long   18103100016
      * Nguyễn Cao Việt  18103100072
      * DHTI12A1Hn
      */
        private void sảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SP sp = new SP();
            sp.MdiParent = this;
            sp.Show();
        }

        private void nhàCungCấpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ncc ncc = new Ncc();
            ncc.MdiParent = this;
            ncc.Show();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Phan Đức Thắng 18103100073 22/12/2000 phanducthang789@gmail.com\n Phạm Phúc Long 18103100016 23/10/2000 phuclong2310.lp@gmail.com \n Nguyễn cao Việt 18103100072 19/10/2000 ncv1910@gmail.com");

        }

        private void sảnPhẩmToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BaoCaoSP bc = new BaoCaoSP();
            bc.MdiParent = this;
            bc.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoNcc ncc = new BaoCaoNcc();
            ncc.MdiParent = this;
            ncc.Show();
        }
    }
}
