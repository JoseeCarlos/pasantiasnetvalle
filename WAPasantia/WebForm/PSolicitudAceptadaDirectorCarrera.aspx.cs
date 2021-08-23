using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WAPasantia.SWLNPasantia;

namespace WAPasantia.WebForm
{
    public partial class PSolicitudAceptadaDirectorCarrera : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarPasantias("Ap");//ACEPTADO
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
            if (ddlBuscarEstado.Text == "Aceptado")
            {
                CargarPasantias("Ap");
            }
            else
            {
                CargarPasantias("Re");
            }
        }

        protected void GVPasantia_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            string Id_Estudiante = GVPasantia.Rows[index].Cells[0].Text;
            string Id_Postulacion = GVPasantia.Rows[index].Cells[1].Text;
            if (e.CommandName == "Select")
            {
                Session["Id_Estudiante"] = Id_Estudiante;
                Session["Id_Postulacion"] = Id_Postulacion;
                Response.Redirect("PInicioCartaConvenio.aspx");
            }
        }

        protected void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarNombre.Text != string.Empty)
            {
                SWLNPasantiaClient sWLNPasantiaClient = new SWLNPasantiaClient();

                List<EPPostulacionCompleja3> lstEPPostulacionCompleja = new List<EPPostulacionCompleja3>();
                lstEPPostulacionCompleja = sWLNPasantiaClient.BuscarEstududiante_NombreCompleto(txtBuscarNombre.Text).ToList();

                GVPasantia.DataSource = lstEPPostulacionCompleja;
                GVPasantia.DataBind();
            }
        }
    }
}