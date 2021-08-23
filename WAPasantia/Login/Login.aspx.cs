using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WAPasantia.SWLNPasantia;
namespace WAPasantia.Login
{



    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.RemoveAll();
        }



        static string password = "";
        static string mostrar = "";
        public void Anadir(string num)
        {
            password = password + num;
            mostrar = mostrar + "*";
            txtPIN.Text = mostrar;



        }



        public void Limpiar()
        {
            password = string.Empty;
            mostrar = string.Empty;
            txtPIN.Text = password;



        }



        protected void Btn1_Click(object sender, ImageClickEventArgs e)
        {
            Anadir("1");
        }



        protected void Btn2_Click(object sender, ImageClickEventArgs e)
        {
            Anadir("2");
        }



        protected void Btn3_Click1(object sender, ImageClickEventArgs e)
        {
            Anadir("3");
        }
        protected void Btn4_Click1(object sender, ImageClickEventArgs e)
        {
            Anadir("4");
        }
        protected void Btn5_Click(object sender, ImageClickEventArgs e)
        {
            Anadir("5");
        }



        protected void Btn6_Click1(object sender, ImageClickEventArgs e)
        {
            Anadir("6");
        }
        protected void Btn7_Click1(object sender, ImageClickEventArgs e)
        {
            Anadir("7");
        }




        protected void Btn8_Click1(object sender, ImageClickEventArgs e)
        {
            Anadir("8");
        }



        protected void Btn9_Click1(object sender, ImageClickEventArgs e)
        {
            Anadir("9");



        }



        protected void Btn0_Click1(object sender, ImageClickEventArgs e)
        {
            Anadir("0");
        }

        protected void BtnLimpiar_Click1(object sender, ImageClickEventArgs e)
        {
            Limpiar();
        }
        protected void BtnIniciar_Click(object sender, ImageClickEventArgs e)
        {
            //SWLNPasantiaClient sWLNPasantiaClient = new SWLNPasantiaClient();
            //string id;
            //id=sWLNPasantiaClient.InicioSesion_CodigoEstudiante_Contrasena_Estudiante("tmc3217856", "843254");
            //txtCuenta.Text = id;
            //Session["IdUsuario"] = "3";
            //jonathan init
            //ES DA JE SC SE JE
            string id = string.Empty;
            SWLNPasantiaClient sWLNPasantiaClient = new SWLNPasantiaClient();
            string tipo = ddlSelectUser.Text;
            string user = txtCuenta.Text;
            string password = txtPIN.Text;
            ENEstudiante datosEstudiante = new ENEstudiante();
            switch (tipo)
            {
                case "ES":
                    //llamar metodo estudiante
                    Session["IdUsuario"] = "6";
                    Session["IdSedeAcademica"] = "1";
                    Response.Redirect("../WebForm/PMenu.aspx");
                    //}
                    break;
                case "DA":
                    //docente administrativo
                    Response.Redirect("../WebForm/PMenuSecretariaCarrera.aspx");
                    break;
                case "JC":
                    //jefe de carrera
                    List<EPPostulacionCompleja> lstEPPostulacionCompleja = new List<EPPostulacionCompleja>();
                    lstEPPostulacionCompleja = sWLNPasantiaClient.Obtener_PPostulacion_Estado("PE").ToList();
                    int cantidadPostulacion = lstEPPostulacionCompleja.Count;
                    if (cantidadPostulacion > 0)
                    {
                        Response.Redirect("../WebForm/PMenuJefeDeCarrera.aspx?tienePostulacion=1&&cantidadPostulacion=" + cantidadPostulacion);
                    }
                    else
                    {
                        Response.Redirect("../WebForm/PMenuJefeDeCarrera.aspx");
                    }
                    break;
                case "SC":
                    //secretaria de carrera
                    Response.Redirect("../WebForm/PMenuSecretariaCarrera.aspx");
                    break;
                case "SE":
                    //secretaria de Educacion Internacional
                    Response.Redirect("../WebForm/PMenuSecretariaInternacional.aspx");
                    break;
                case "JE":
                    //jefe internacional
                    Response.Redirect("../WebForm/PMenuJefeDeCarrera.aspx");
                    break;
                default:
                    break;
            }
        }



        protected void ddlSelectUser_TextChanged(object sender, EventArgs e)
        {
            string id = string.Empty;
            SWLNPasantiaClient sWLNPasantiaClient = new SWLNPasantiaClient();
            string tipo = ddlSelectUser.Text;
            string user = txtCuenta.Text;
            string password = txtPIN.Text;
            ENEstudiante datosEstudiante = new ENEstudiante();
            switch (tipo)
            {
                case "ES":
                    txtCuenta.Text = "mcg007675";
                    txtPIN.Text = "12345";
                    break;
                case "DA":
                    txtCuenta.Text = "jp12234";
                    txtPIN.Text = "12345";
                    break;
                case "JC":
                    txtCuenta.Text = "Lp12234";
                    txtPIN.Text = "12345";
                    break;
                case "SC":
                    txtCuenta.Text = "hfp12234";
                    txtPIN.Text = "12345";
                    break;
                case "SE":
                    txtCuenta.Text = "jpt12234";
                    txtPIN.Text = "12345";
                    break;
                case "JE":
                    txtCuenta.Text = "jp12234";
                    txtPIN.Text = "12345";
                    break;
                default:
                    break;
            }
        }
    }
}