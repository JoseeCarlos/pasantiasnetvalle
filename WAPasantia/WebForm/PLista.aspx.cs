using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WAPasantia.SWLNPasantia;

namespace WAPasantia.WebForm
{
    public partial class PLista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarPasantias("Ap");//finalizado
            }
        }

        private void CargarPasantias(string Estado)

        {
            GVPasantia.DataSource = null;
            SWLNPasantiaClient swLNPasantia = new SWLNPasantiaClient();
            List<EPPostulacionCompleja> lstEPPostulacionCompleja = new List<EPPostulacionCompleja>();

            lstEPPostulacionCompleja = swLNPasantia.Obtener_PPostulacion_Estado(Estado).ToList();

            GVPasantia.DataSource = lstEPPostulacionCompleja;
            GVPasantia.DataBind();
        }

        private void Imprimir()
        {
            //ReportDocument rprt = new ReportDocument();
            //rprt.Load(Server.MapPath("~/Reportes/Report.rpt"));
            //rprt.PrintToPrinter(1, false, 0, 0);
            //-------------------------------------------------------------------
            //PrintDialog print = new PrintDialog();
            //if (print.ShowDialog() == DialogResult.OK)
            //{
            //    ReportDocument rep = new ReportDocument();
            //    rep.Load(Server.MapPath("~/Reportes/Report.rpt"));
            //    rep.PrintOptions.PrinterName = print.PrinterSettings.PrinterName;
            //    rep.PrintToPrinter(print.PrinterSettings.Copies, print.PrinterSettings.Collate, print.PrinterSettings.FromPage, print.PrinterSettings.ToPage);
            //}
        }

    }
}