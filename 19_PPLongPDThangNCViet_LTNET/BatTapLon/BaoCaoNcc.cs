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
    public partial class BaoCaoNcc : Form
    {
        public BaoCaoNcc()
        {
            InitializeComponent();
        }

        private void BaoCaoNcc_Load(object sender, EventArgs e)
        {
            reportViewer1.Reset();


            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer1.ZoomPercent = 75;

            DataSet2 dataset = new DataSet2();
            dataset.BeginInit();
            this.reportViewer1.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", dataset.Tables["NhaCungCap"]));
            this.reportViewer1.LocalReport.ReportPath = "../../Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            dataset.EndInit();


            string ketnoi;
            ketnoi = @"Data Source=DESKTOP-LO0N98Q\SQLEXPRESS;Initial Catalog=qlsp_19_PPLongPDThangNCViet;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(ketnoi);
            sqlcon.Open();



            DataSet2TableAdapters.NhaCungCapTableAdapter bcncc = new DataSet2TableAdapters.NhaCungCapTableAdapter();
            bcncc.Connection.ConnectionString = ketnoi;
            bcncc.ClearBeforeFill = true;
            bcncc.Fill(dataset.NhaCungCap);


            this.reportViewer1.RefreshReport();
        }
    }
}
