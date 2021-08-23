using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CWSedeAcademica
/// </summary>
public class CWSedeAcademica
{
    ADWSedeAcademica adwSedeAcademica;
    public CWSedeAcademica()
    {
        adwSedeAcademica = new ADWSedeAcademica();
    }
    public List<ENSedeAcademica> Obtener_NSedeAcademica()
    {
        ENSedeAcademica enSedeAcademica = new ENSedeAcademica();
        List<ENSedeAcademica> lstENSedeAcademica = new List<ENSedeAcademica>();
        DTONSedeAcademica dtoNSedeAcademica = adwSedeAcademica.Obtener_NSedeAcademica();
        foreach (DTONSedeAcademica.WSedeAcademicaRow drNSedeAcademica in dtoNSedeAcademica.WSedeAcademica.Rows)
        {

            enSedeAcademica.Id_Ciudad = drNSedeAcademica.Id_Ciudad;
            enSedeAcademica.Id_Emp = drNSedeAcademica.Id_Emp;
            enSedeAcademica.Id_SedeAcademica = drNSedeAcademica.Id_SedeAcademica;
            enSedeAcademica.Estado = drNSedeAcademica.Estado;
            enSedeAcademica.FechaRegistro = drNSedeAcademica.FechaREgistro;
            enSedeAcademica.FechaModificacion = drNSedeAcademica.FechaModificacion;

            lstENSedeAcademica.Add(enSedeAcademica);
        }
        return lstENSedeAcademica;
    }
    public ENSedeAcademica Obtener_NSedeAcademica_Id_SedeAcademica(string Id_SedeAcademica)
    {
        ENSedeAcademica enSedeAcademica = new ENSedeAcademica();

        DTONSedeAcademica dtoNSedeAcademica = adwSedeAcademica.Obtener_NSedeAcademica_Id_SedeAcademica(Id_SedeAcademica);
        foreach (DTONSedeAcademica.WSedeAcademicaRow drNSedeAcademica in dtoNSedeAcademica.WSedeAcademica.Rows)
        {

            enSedeAcademica.Id_Ciudad = drNSedeAcademica.Id_Ciudad;
            enSedeAcademica.Id_Emp = drNSedeAcademica.Id_Emp;
            enSedeAcademica.Id_SedeAcademica = drNSedeAcademica.Id_SedeAcademica;
            enSedeAcademica.Estado = drNSedeAcademica.Estado;
            enSedeAcademica.FechaRegistro = drNSedeAcademica.FechaREgistro;
            enSedeAcademica.FechaModificacion = drNSedeAcademica.FechaModificacion;


        }
        return enSedeAcademica;
    }
}