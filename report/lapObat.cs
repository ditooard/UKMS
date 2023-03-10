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
    public partial class lapObat : Form
    {
        ReportDocument repDok = new ReportDocument();

        public lapObat()
        {
            InitializeComponent();
        }

        private void lapObat_Load(object sender, EventArgs e)
        {
            repDok.Load(@"D:\DATA DITO\Mata Kuliah PNC\Praktikum Pemrograman Berorientasi Obyek\PBO II\UKMS\report\obat1.rpt");
            repDok.SetDatabaseLogon("root", " ");
            repDok.Refresh();

            crystalReportViewer1.ReportSource = repDok;
            crystalReportViewer1.Refresh();
        }
    }
}
