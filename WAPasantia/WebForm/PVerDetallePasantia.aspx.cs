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
    public partial class PVerDetallePasantia : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDatos();
            }

        }

        protected void btnEnviarObservaciones_Click(object sender, EventArgs e)
        {
            Correo correo = new Correo();
            string nombreCompl = lblNombre.Text + " " + lblApellidos.Text;
            string email = lblEmail.Text;
            string obs = txtObservaciones.Value;
            if (correo.EnviarCorreo_R(email, nombreCompl, obs) == true)
            {
                SWLNPasantiaClient sWLNPasantiaClient = new SWLNPasantiaClient();
                sWLNPasantiaClient.Actualizar_PPostulacion_EstadoObservado(Session["idPostulacion"].ToString());
                Session.Remove("idPostulacion");
                Response.Redirect("PSolicitudPasantia.aspx?mensaje=0");
            }
        }

        protected void btnAceptarHoras_Click(object sender, EventArgs e)
        {
            Correo correo = new Correo();
            string nombreCompl = lblNombre.Text + " " + lblApellidos.Text;
            string email = lblEmail.Text;
            if (correo.EnviarCorreo_Horas(email, nombreCompl) == true)
            {
                SWLNPasantiaClient sWLNPasantiaClient = new SWLNPasantiaClient();
                sWLNPasantiaClient.Actualizar_PPostulacion_EstadoAprobado(Session["idPostulacion"].ToString());
                sWLNPasantiaClient.Adicionar_PPasantia(Session["idPostulacion"].ToString(), txtHoras.Value, "Av", DateTime.Now, DateTime.Now);
                Session.Remove("idPostulacion");
                Response.Redirect("PSolicitudPasantia.aspx?mensaje=1");
            }
        }

        protected void CargarDatos()
        {
            SWLNPasantiaClient sWLNPasantiaClient = new SWLNPasantiaClient();
            EPPostulacionCompleja2 ePPostulacionCompleja2 = new EPPostulacionCompleja2();

            ePPostulacionCompleja2 = sWLNPasantiaClient.Obtener_PPostulacion_Id_Postulacion2(Session["idPostulacion"].ToString());
            lblNombre.Text = ePPostulacionCompleja2.Nombres;
            lblApellidos.Text = ePPostulacionCompleja2.Apellidos;
            lblCedulaIdent.Text = ePPostulacionCompleja2.CedulaIdentidad;
            lblEmitido.Text = ePPostulacionCompleja2.EmitidoEn;
            lblCelular.Text = ePPostulacionCompleja2.Celular;
            lblTelefono.Text = ePPostulacionCompleja2.Telefono;
            lblEmail.Text = ePPostulacionCompleja2.Correo;

            lblEmpresa.Text = ePPostulacionCompleja2.NombreInstitucion;
            lblCartaDirigida.Text = ePPostulacionCompleja2.NombreEncargado;
            lblCargo.Text = ePPostulacionCompleja2.Cargo;
            lblDireccion.Text = ePPostulacionCompleja2.DireccionInstitucion;
            lblTelefonoEmpresa.Text = ePPostulacionCompleja2.TelefonoInstitucion;
            lblCiudad.Text = ePPostulacionCompleja2.CiudadInstitucion;
            lblEmailEmpresa.Text = ePPostulacionCompleja2.CorreoInstitucion;
        }
    }
}