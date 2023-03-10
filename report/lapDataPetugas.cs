using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace UKMS.report
{
    public partial class lapDataPetugas : Form
    {
        ReportDocument repDok = new ReportDocument();

        public lapDataPetugas()
        {
            InitializeComponent();
        }

        private void lapDataPetugas_Load(object sender, EventArgs e)
        {
            repDok.Load(@"D:\DATA DITO\Mata Kuliah PNC\Praktikum Pemrograman Berorientasi Obyek\PBO II\UKMS\report\dataPetugas.rpt");
            repDok.SetDatabaseLogon("root", " ");
            repDok.Refresh();

            crystalReportViewer1.ReportSource = repDok;
            crystalReportViewer1.Refresh();
        }
    }
}
