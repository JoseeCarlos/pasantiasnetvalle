using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WAPasantia.SWLNPasantia;
using CrystalDecisions.CrystalReports.Engine;

namespace WAPasantia.WebForm
{
    public partial class PInicioCartaConvenio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            SWLNPasantiaClient sWLNPasantiaClient = new SWLNPasantiaClient();
            EPPostulacionCompleja2 ePPostulacionCompleja2 = new EPPostulacionCompleja2();

            ePPostulacionCompleja2 = sWLNPasantiaClient.Obtener_PPostulacion_Id_Postulacion2(Session["Id_Postulacion"].ToString());
            sPostulacion.InnerText = ePPostulacionCompleja2.Nombres + " " + ePPostulacionCompleja2.Apellidos;
            sEstudiante.InnerText = ePPostulacionCompleja2.NombreInstitucion;
        }

        protected void btnVisualizar_Click(object sender, EventArgs e)
        {
            //Hablar con jimena para optener el IdEstudiante
            #region Visualizar datos antes de enviar
            string CodigoCarta = codigoCarta.ToString();
            string todo = "Codigo carta:  " + CodigoCarta + "  Fecha Actual: " + fechaActual.Value + "  Fecha Final: " + fechaPlazo.Value;
            string msg = todo;
            ScriptManager.RegisterStartupScript(this, this.GetType(),
                "alert",
                "alert('" + msg + "');", true);

            //SWLNPasantiaClient p = new SWLNPasantiaClient();
            //EPSolicitud ep = new EPSolicitud();


            //string idEstudiante = Session["Id_Estudiante"].ToString();
            //ep = p.Obtener_Datos_Soilicitud_Id_Estudiante(idEstudiante);
            //ReportDocument rpt = new ReportDocument();

            //rpt.Load(Server.MapPath("../Creacion_Cartas/CConvenio_Proyecto_Grado.rpt"));
            //rpt.SetParameterValue("Nombre_Institucion", ep.NombreInstitucion);
            //rpt.SetParameterValue("Nombre_Responsable", ep.NombreResposable);
            //// rpt.SetParameterValue("", ep.);
            //CrystalReportViewer1.ReportSource = rpt;
            //rpt.Load(Server.MapPath("../Creacion_Cartas/CConvenio_Proyecto_Grado.rpt"));

            //rpt.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "Person Information");

            #endregion
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            //Boton para enviar a base de datos y para imprimir 
            #region Logica para insertar fecha
            DateTime fechaDeModificacion = DateTime.Now;

            SWLNPasantiaClient sWLNPasantiaClient = new SWLNPasantiaClient();
            EPPasantiaSimple ePPasantiaSimple = new EPPasantiaSimple();

            string CodigoCarta = codigoCarta.ToString();
            ePPasantiaSimple.Id_Pasantia = Session["Id_Postulacion"].ToString();
            ePPasantiaSimple.FechaInicioPasantia = Convert.ToDateTime(fechaActual.Value);
            ePPasantiaSimple.FechaModificacion = fechaDeModificacion;
            sWLNPasantiaClient.Actualizar_PPasantia_FechaInicio(ePPasantiaSimple);
            #endregion
        }
    }
}