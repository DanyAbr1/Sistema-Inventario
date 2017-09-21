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

namespace Facturacion
{
    public partial class FrmImprimirFactura : Form
    {
        int Id=0;
        public FrmImprimirFactura()
        {
            InitializeComponent();
        }
        public FrmImprimirFactura(int ID_Factura)
            :this()
        {
           this.Id = ID_Factura;
        }
        private void FrmImprimirFactura_Load(object sender, EventArgs e)
        {
            ReportDocument rep = new ReportDocument();
            ParameterField pf = new ParameterField();
            ParameterFields pfs = new ParameterFields();
            ParameterDiscreteValue pv = new ParameterDiscreteValue();
            pf.Name = "@ID_Factura";
            pv.Value = Id;
            pf.CurrentValues.Add(pv);
            pfs.Add(pf);
            crystalReportViewer1.ParameterFieldInfo = pfs;
            rep.Load(@"C:\Users\djgre\documents\visual studio 2013\Projects\SistemaTienda\Login\ImprimirFactura.rpt");
            crystalReportViewer1.ReportSource = rep;

        }
    }
}
