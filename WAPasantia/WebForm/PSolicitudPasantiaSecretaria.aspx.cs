using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    public partial class PSolicitudPasantiaSecretaria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarPasantias("Ap");
            }
        }

        private void CargarPasantias(string Estado)

        {
            GVPasantiaSecretaria.DataSource = null;
            SWLNPasantiaClient swLNPasantia = new SWLNPasantiaClient();
            List<EPPostulacionCompleja> lstEPPostulacionCompleja = new List<EPPostulacionCompleja>();

            lstEPPostulacionCompleja = swLNPasantia.Obtener_PPostulacion_Estado(Estado).ToList();

            GVPasantiaSecretaria.DataSource = lstEPPostulacionCompleja;
            GVPasantiaSecretaria.DataBind();
        }
        private void CDireccion_Carrera(string Id_Estudiante, string cite, string codigoCarta, string nombre)
        {
            ReportDocument rp = new ReportDocument();
            rp.Load(Server.MapPath("../Creacion_Cartas/CDireccion_Carrera.rpt"));
            rp.SetParameterValue("@Id_Estudiante", Id_Estudiante);
            rp.SetParameterValue("Nombre_Carrera", "Ing. en Sistemas");
            rp.SetParameterValue("Nombre_Estudiante", nombre);
            rp.SetParameterValue("Carnet_Identidad", "874756");
            rp.SetParameterValue("Nombre_Sede_Academica", "Cochabamba");
            rp.SetParameterValue("Cite", cite);
            rp.SetParameterValue("CodigoCarta", codigoCarta);
            rp.SetDatabaseLogon("usuarioAnonimo_SQLLogin_1", "o1gw7enajg", "NETPASANTIA.mssql.somee.com", "NETPASANTIA");
            rp.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "person information");

            rp.ExportToDisk(ExportFormatType.PortableDocFormat, Server.MapPath("../Cartas_Direccion_Carrera/" + Id_Estudiante + ".pdf"));
        }

        protected void GVPasantiaSecretaria_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "SelectPasantia")
            {
                if (txtCite.Value != "" && txtCodigoCarta.Value != "")
                {
                    int index = Convert.ToInt32(e.CommandArgument);
                    CDireccion_Carrera(GVPasantiaSecretaria.Rows[index].Cells[0].Text, txtCite.Value, txtCodigoCarta.Value, GVPasantiaSecretaria.Rows[index].Cells[1].Text);
                    Correo correo = new Correo();
                    correo.EnviarCorreo_CartaAceptacion(GVPasantiaSecretaria.Rows[index].Cells[2].Text, GVPasantiaSecretaria.Rows[index].Cells[1].Text, Server.MapPath("../Cartas_Direccion_Carrera/" + GVPasantiaSecretaria.Rows[index].Cells[0].Text + ".pdf"));
                }
            }
        }

        protected void txtBuscarNombre_TextChanged1(object sender, EventArgs e)
        {
            if (txtBuscarNombre.Text != string.Empty)
            {
                SWLNPasantiaClient sWLNPasantiaClient = new SWLNPasantiaClient();

                List<EPPostulacionCompleja3> lstEPPostulacionCompleja = new List<EPPostulacionCompleja3>();
                lstEPPostulacionCompleja = sWLNPasantiaClient.BuscarEstududiante_NombreCompleto(txtBuscarNombre.Text).ToList();

                GVPasantiaSecretaria.DataSource = lstEPPostulacionCompleja;
                GVPasantiaSecretaria.DataBind();
            }
        }
    }
}