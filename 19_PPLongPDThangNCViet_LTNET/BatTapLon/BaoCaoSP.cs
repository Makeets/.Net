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
    public partial class BaoCaoSP : Form
    {
        public BaoCaoSP()
        {
            InitializeComponent();
        }
        /* thông tin nhóm 19
* Phan Đức Thắng 18103100073  
* Phạm Phúc Long   18103100016
* Nguyễn Cao Việt  18103100072
* DHTI12A1Hn
*/
        private void BaoCaoSP_Load(object sender, EventArgs e)
        {
            reportViewer1.Reset();


            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer1.ZoomPercent = 75;

            DataSet1 dataset = new DataSet1();
            dataset.BeginInit();
            this.reportViewer1.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dataset.Tables["SanPham"]));
            this.reportViewer1.LocalReport.ReportPath = "../../Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            dataset.EndInit();


            string ketnoi;
            ketnoi = @"Data Source=DESKTOP-LO0N98Q\SQLEXPRESS;Initial Catalog=qlsp_19_PPLongPDThangNCViet;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(ketnoi);
            sqlcon.Open();



            DataSet1TableAdapters.SanPhamTableAdapter bcsp = new DataSet1TableAdapters.SanPhamTableAdapter();
            bcsp.Connection.ConnectionString = ketnoi;
            bcsp.ClearBeforeFill = true;
            bcsp.Fill(dataset.SanPham);


            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
