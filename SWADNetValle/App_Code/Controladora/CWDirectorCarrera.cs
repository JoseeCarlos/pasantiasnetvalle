using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CWDirectorCarrera
/// </summary>
public class CWDirectorCarrera
{
    private ADWDirectorCarrera adwDirectorCarrera;
    public CWDirectorCarrera()
    {
        adwDirectorCarrera = new ADWDirectorCarrera();
    }
    public ENDirectorCarrera Obtener_NDirectorCarrera_Id_DirectorCarrera(string Id_DirectorCarrera)
    {
        ENDirectorCarrera enDirectorCarrera = new ENDirectorCarrera();
        DTONDirectorCarrera dtoNDirectorCarrera = adwDirectorCarrera.Obtener_NDirectorCarrera_Id_DirectorCarrera(Id_DirectorCarrera);
        foreach (DTONDirectorCarrera.WDirectorCarreraRow drWDirectorCarrera in dtoNDirectorCarrera.WDirectorCarrera.Rows)
        {
            enDirectorCarrera = new ENDirectorCarrera();
            enDirectorCarrera.Id_DirectorCarrera = drWDirectorCarrera.Id_DirectorCarrera;
            enDirectorCarrera.Id_Carrera = drWDirectorCarrera.Id_Carrera;

            enDirectorCarrera.Id_Emp = drWDirectorCarrera.Id_Emp;
            enDirectorCarrera.Estado = drWDirectorCarrera.Estado;
            enDirectorCarrera.FechaRegistro = drWDirectorCarrera.FechaRegistro;
            enDirectorCarrera.FechaModificacion = drWDirectorCarrera.FechaModificacion;

        }
        return enDirectorCarrera;
    }
}