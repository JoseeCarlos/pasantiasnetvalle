using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WAPasantia.SWLNPasantia;

namespace WAPasantia.WebForm
{
    public partial class PMenuJefeDeCarrera : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarNotificaciones();
        }

        protected void CargarNotificaciones()
        {
            List<EPPostulacionCompleja> lstEPPostulacionCompleja = new List<EPPostulacionCompleja>();
            SWLNPasantiaClient sWLNPasantiaClient = new SWLNPasantiaClient();
            lstEPPostulacionCompleja = sWLNPasantiaClient.Obtener_PPostulacion_Estado("PE").ToList();
            int cantidadPostulacion;
            cantidadPostulacion = lstEPPostulacionCompleja.Count;
            if (cantidadPostulacion > 0)
            {
                lblNotificacion.Text = cantidadPostulacion.ToString();
            }
            else
            {
                lblIcono.InnerText = "";
                lblNotificacion.Text = "";
            }


        }
    }
}