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
 
namespace Facturacion
{
    public partial class FrmReporteCliente : Form
    {
        public FrmReporteCliente()
        {
            InitializeComponent();
        }

        private void FrmClienteReporte_Load(object sender, EventArgs e)
        {
            ReportDocument rep = new ReportDocument();
            rep.Load(@"C:\Users\djgre\documents\visual studio 2013\Projects\SistemaTienda\Login\ReporteCliente.rpt");
            crystalReportViewer1.ReportSource=rep;
            crystalReportViewer1.Refresh();

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
