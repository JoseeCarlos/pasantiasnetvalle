using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WAPasantia.SWLNPasantia;

namespace WAPasantia.WebForm
{
    public partial class PSolicitudFinalizada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarPasantias("Ap");//FINALIZADO
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

        protected void ddlBuscarEstado_TextChanged(object sender, EventArgs e)
        {
            if (ddlBuscarEstado.Text == "Pendiente")
            {
                CargarPasantias("Pe");
            }
            else
            {
                CargarPasantias("Re");
            }
        }
    }
}