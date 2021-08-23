using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WAPasantia.Email;
using WAPasantia.SWLNPasantia;
namespace WAPasantia.WebForm
{
    public partial class PSolicitudPasantia : System.Web.UI.Page
    {
        string idPostulacion = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarPasantias("PE");
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

        protected void GVPasantia_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            idPostulacion = GVPasantia.Rows[0].Cells[0].Text;
            if (e.CommandName == "Select")
            {
                Session["idPostulacion"] = idPostulacion;
                Response.Redirect("PVerDetallePasantia.aspx");
            }
        }
        protected void ddlBuscarEstado_TextChanged(object sender, EventArgs e)
        {
            if (ddlBuscarEstado.Text == "Pendiente")
            {
                CargarPasantias("PE");
            }
            else
            {
                CargarPasantias("RE");
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

        protected void btnAceptarHoras_Click(object sender, EventArgs e)
        {

            idPostulacion = GVPasantia.Rows[0].Cells[0].Text;

            Correo correo = new Correo();
            string nombreCompl = GVPasantia.Rows[0].Cells[1].Text;
            string email = GVPasantia.Rows[0].Cells[3].Text;
            if (correo.EnviarCorreo_Horas(email, nombreCompl) == true)
            {
                SWLNPasantiaClient sWLNPasantiaClient = new SWLNPasantiaClient();
                EPPasantiaSimple ePPasantiaSimple = new EPPasantiaSimple();


                sWLNPasantiaClient.Actualizar_PPostulacion_EstadoAprobado(idPostulacion);
                sWLNPasantiaClient.Adicionar_PPasantia(idPostulacion, txtHoras.Value, "Av", DateTime.Now, DateTime.Now);
                Response.Redirect("PSolicitudPasantia.aspx?mensaje=1");
            }
        }

        protected void btnEnviarObservaciones_Click(object sender, EventArgs e)
        {
            idPostulacion = GVPasantia.Rows[0].Cells[0].Text;

            Correo correo = new Correo();
            string nombreCompl = GVPasantia.Rows[0].Cells[1].Text;
            string email = GVPasantia.Rows[0].Cells[3].Text;
            string obs = txtObservaciones.Value;
            if (correo.EnviarCorreo_R(email, nombreCompl, obs) == true)
            {
                SWLNPasantiaClient sWLNPasantiaClient = new SWLNPasantiaClient();
                sWLNPasantiaClient.Actualizar_PPostulacion_EstadoObservado(idPostulacion);
                Response.Redirect(HttpContext.Current.Request.Url.ToString(), true);
                Response.Redirect("PSolicitudPasantia.aspx?mensaje=0");
            }
        }
    }

}
