using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WAPasantia.SWLNPasantia;
namespace WAPasantia.WebForm
{
    public partial class PFormularioPasantia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //DateTime FechaRegistro = DateTime.Now;
            //SWLNPasantiaClient swLNAdicionarEmpresa = new SWLNPasantiaClient();
            //swLNAdicionarEmpresa.Adicionar_PInstitucion("HOlAMundo", "HOlAMundo", "HOlAMundo", "HOlAMundo", "HOlAMundo", "HOlAMundo", "HOlAMundo", "HOlAMundo", "1", "Ac", DateTime.Now, DateTime.Now);



            DesabilitarControladoresEstudiante();
            //CargarEmpresa();


            datosE1.Style["Visibility"] = "hidden";
            datosE1.Style["Display"] = "none";
            txtResponsable.Disabled = true;
            txtCargo.Disabled = true;
            txtEmpresa.Disabled = true;
            txtDireccion.Disabled = true;
            txtTelefono.Disabled = true;
            txtCiudad.Disabled = true;
            txtEmail.Disabled = true;




            // inicio forech para llenar el dropdownlist
            ddlBuscarEmpresa.Items.Add("Seleccione una Empresa");
            //foreach (var item in users_list)
            //{
            //    ddlBuscarEmpresa.Items.Add(item.Nombre.ToString());
            //}
            ddlBuscarEmpresa.Items.Add("Agregar Nueva Empresa");



            //CargarModalidad();

            //CargarCiudad();



            //final llenado dropdownlist



            modalidadT.Visible = false;



            if (Session["IdUsuario"] != null)
            {
                SWLNPasantiaClient sWLNPasantiaClient = new SWLNPasantiaClient();
                ENEstudiante eNEstudiante = new ENEstudiante();
                eNEstudiante = sWLNPasantiaClient.Obtener_NEstudiante_Id_Estudiante(Session["IdUsuario"].ToString());
                txtNombreEstudiante.Value = eNEstudiante.Nombres;
                txtApellidoEstudiante.Value = eNEstudiante.PrimerApellido + " " + eNEstudiante.SegundoApellido;
                txtCi.Value = eNEstudiante.CedulaIdentidad;
                txtEmitido.Value = eNEstudiante.EmitidoEn;
                txtCelularEstudiante.Value = eNEstudiante.Celular;
                txtTelefonoEstudiante.Value = eNEstudiante.Telefono;
                txtEmailEstudiante.Value = eNEstudiante.CorreoElectronico;
            }
            //datosE1.Style["Visibility"] = "hidden";



        }



        private void DesabilitarControladoresEstudiante()
        {
            txtNombreEstudiante.Disabled = true;
            txtApellidoEstudiante.Disabled = true;
            txtCi.Disabled = true;
            txtEmitido.Disabled = true;
            txtCelularEstudiante.Disabled = true;
            txtTelefonoEstudiante.Disabled = true;
            txtEmailEstudiante.Disabled = true;
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            string valorModalidad = "1";



            SWLNPasantiaClient sWLNPasantiaClient = new SWLNPasantiaClient();
            //sWLNPasantiaClient.Adicionar_PInstitucion(txtResponsable.Value, txtResponsable.Value, txtResponsable.Value, txtCargo.Value, txtEmpresa.Value, txtDireccion.Value, txtTelefono.Value, txtEmail.Value, "1", "PE", DateTime.Now, DateTime.Now);
            sWLNPasantiaClient.Adicionar_PPostulacion(Session["IdUsuario"].ToString(), "4", valorModalidad, Session["IdSedeAcademica"].ToString(), DateTime.Now, "PE", DateTime.Now, DateTime.Now);
        }



        /// <summary>
        /// evento de la seleccion de empresa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddlBuscarEmpresa_TextChanged(object sender, EventArgs e)
        {



            if (ddlBuscarEmpresa.Text == "Agregar Nueva Empresa")
            {
                txtResponsable.Disabled = false;
                txtCargo.Disabled = false;
                txtEmpresa.Disabled = false;
                txtDireccion.Disabled = false;
                txtTelefono.Disabled = false;
                txtCiudad.Disabled = false;
                txtEmail.Disabled = false;
            }
            // ddlBuscarEmpresa.SelectedIndex = 2;
        }



        protected void practica_TextChanged(object sender, EventArgs e)
        {



            if (practicaM.Text == "Modalidad de titulacion")
            {
                modalidadT.Visible = true;
            }
            // ddlBuscarEmpresa.SelectedIndex = 2;
        }



        protected void modalidad_TextChanged(object sender, EventArgs e)
        {
            SWLNPasantiaClient swLNPasantia = new SWLNPasantiaClient();



            List<EPModalidadSimple> lstEPInstitucionCompleja = new List<EPModalidadSimple>();



            lstEPInstitucionCompleja = swLNPasantia.Obtener_PModalidad().ToList();



            if (!IsPostBack)
            {
                ddlBuscarEmpresa.Items.Add("Seleccione una modalidad");
                foreach (var item in lstEPInstitucionCompleja)
                {
                    ddlBuscarEmpresa.Items.Add(item.NombreModalidad.ToString());
                    //ddlBuscarEmpresa.Items.Add.inde
                }



            }



            // ddlBuscarEmpresa.SelectedIndex = 2;
        }




        private void CargarEmpresa()
        {
            SWLNPasantiaClient swLNPasantia = new SWLNPasantiaClient();
            List<EPInstitucionCompleja> lstEPInstitucionCompleja = new List<EPInstitucionCompleja>();
            lstEPInstitucionCompleja = swLNPasantia.Obtener_PInstitucion().ToList();
            //if (!IsPostBack)
            //{
            // ddlBuscarEmpresa.Items.Add("Seleccione una empresa");
            // foreach (var item in lstEPInstitucionCompleja)
            // {
            // ddlBuscarEmpresa.Items.Add(item.NombreInstitucion.ToString());
            // }
            // ddlBuscarEmpresa.Items.Add("Agregar Nueva Empresa");
            //}
        }
        private void CargarModalidad()
        {
            SWLNPasantiaClient swLNNombreModalidad = new SWLNPasantiaClient();
            List<EPModalidadSimple> lstEPInstitucionCompleja = new List<EPModalidadSimple>();
            lstEPInstitucionCompleja = swLNNombreModalidad.Obtener_PModalidad().ToList();
            if (!IsPostBack)
            {
                ddlBuscarEmpresa.Items.Add("Seleccione una modalidad");
                foreach (var item in lstEPInstitucionCompleja)
                {
                    ddlBuscarEmpresa.Items.Add(item.NombreModalidad.ToString());
                }



            }
        }




        private void CargarCiudad()
        {
            SWLNPasantiaClient swLNNombreCiudad = new SWLNPasantiaClient();
            List<EPModalidadSimple> lstEPInstitucionCompleja = new List<EPModalidadSimple>();
            lstEPInstitucionCompleja = swLNNombreCiudad.Obtener_PModalidad().ToList();
            if (!IsPostBack)
            {
                ddlBuscarEmpresa.Items.Add("Seleccione una ciudad");
                foreach (var item in lstEPInstitucionCompleja)
                {
                    ddlBuscarEmpresa.Items.Add(item.NombreModalidad.ToString());
                }



            }
        }
        protected void btnCancelarModal_Click(object sender, EventArgs e)
        {
            ddlBuscarEmpresa.SelectedIndex = 0;
        }



        protected void registrarEmpresa_Click(object sender, EventArgs e)
        {
            DateTime FechaRegistro = DateTime.Now;
            SWLNPasantiaClient swLNAdicionarEmpresa = new SWLNPasantiaClient();
            swLNAdicionarEmpresa.Adicionar_PInstitucion(txtNombreResponsable.Text, txtApellido1Responsable.Text, txtApellido2Responsable.Text, txtCargoIntitucion.Text, txtNombreInstitucion.Text, txtDireccionInstitucion.Text, txtTelefonoInstitucion.Text, txtEmailInstitucion.Text, "1", "Ac", FechaRegistro, FechaRegistro);
            //CargarEmpresa();



        }
    }
}