using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReporteTicketHRI
{
    public partial class frmrpt : Form
    {
        public frmrpt()
        {
            InitializeComponent();
        }

        public string NroSerie;
        public string NroDocumento;

        private void frmrpt_Load(object sender, EventArgs e)
        {
            CrystalReport2 rptRe = new CrystalReport2();
            rptRe.SetParameterValue("@NroSerie", NroSerie);
            rptRe.SetParameterValue("@NroDocumento", NroDocumento);
            crystalReportViewer1.ReportSource = rptRe;
            rptRe.SetDatabaseLogon("Sisgalenplus02", "Vannia1419");
               
        }
    }
}
