using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CWCarrera
/// </summary>
public class CWCarrera
{
    private ADWCarrera adwCarrera;
    public CWCarrera()
    {
        adwCarrera = new ADWCarrera();
    }

    public ENCarrera Obtener_NCarrera_Id_Carrera(string Id_Carrera)
    {
        ENCarrera enCarrera = new ENCarrera();
        DTONCarrera dtoNCarrera = adwCarrera.Obtener_NCarrera_Id_Carrera(Id_Carrera);
        foreach (DTONCarrera.WCarreraRow drWCarrera in dtoNCarrera.WCarrera.Rows)
        {
            enCarrera = new ENCarrera();
            enCarrera.Id_Carrera = drWCarrera.Id_Carrera;
            enCarrera.NombreCarrera = drWCarrera.NombreCarrera;
            enCarrera.Id_Facultad = drWCarrera.Id_Facultad;
            enCarrera.Id_Emp = drWCarrera.Id_Emp;
            enCarrera.Estado = drWCarrera.Estado;
            enCarrera.FechaRegistro = drWCarrera.FechaRegistro;
            enCarrera.FechaModificacion = drWCarrera.FechaModificacion;

        }
        return enCarrera;
    }
}