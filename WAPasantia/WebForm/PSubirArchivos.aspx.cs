using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WAPasantia.WebForm
{
    public partial class PSubirArchivos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubirArchivos_Click(object sender, EventArgs e)
        {
            //Verificar que subio los archivos
            if (SubirCartaCarrera.HasFile && SubirCartaEmpresa.HasFile)
            {
                string extCartaCarrera = System.IO.Path.GetExtension(SubirCartaCarrera.FileName);
                string extCartaEmpresa = System.IO.Path.GetExtension(SubirCartaEmpresa.FileName);
                //convertir en minusculas para 
                extCartaCarrera = extCartaCarrera.ToLower();
                extCartaEmpresa = extCartaEmpresa.ToLower();

                //Archivo.PostedFile.ContentLength; verifica la longitud del archivo en BYTES 1048576=1mb



                if (extCartaCarrera == ".pdf" && extCartaEmpresa == ".pdf")
                {

                    string rutaCarpeta;

                    rutaCarpeta = Server.MapPath("~/Documentos/" + 1);
                    bool exsiste = Directory.Exists(rutaCarpeta);
                    if (!exsiste)
                    {
                        Directory.CreateDirectory(rutaCarpeta);
                        SubirCartaCarrera.SaveAs(Server.MapPath("~/Documentos/1/" + 1 + "CartaCarrera" + extCartaCarrera));
                        SubirCartaEmpresa.SaveAs(Server.MapPath("~/Documentos/1/" + 1 + "CartaEmpresa" + extCartaEmpresa));
                        if (SubirNIT.HasFile)
                        {
                            SubirNIT.SaveAs(Server.MapPath("~/Documentos/1/" + 1 + "NITEmpresa" + System.IO.Path.GetExtension(SubirNIT.FileName)));
                        }

                        MensageDeError.InnerText = "correcto";
                    }
                    else
                    {
                        MensageDeError.InnerText = "error";
                    }

                    Response.Write("Se subio correctamente");
                }
                else
                {
                    MensageDeError.InnerText = "error1 /  " + extCartaEmpresa;
                }
            }
            else
            {
                Response.Write("Verifique que los archivos oligatorios esten selecionados");
            }
        }
    }
}