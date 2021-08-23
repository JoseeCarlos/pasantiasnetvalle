using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WAPasantia.WebForm
{
    public partial class PSeguimiento : System.Web.UI.Page
    {
        string idPostulacion = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            //LoadItems();
        }

        protected void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtBuscarCarrera_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlBuscarEstado_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GVPasantia_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            idPostulacion = GVPasantia.Rows[index].Cells[0].Text;
            //ChangeStatus(idPostulacion)
        }
    }
}