using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADWDirectorCarrera
/// </summary>
public class ADWDirectorCarrera
{
    public ADWDirectorCarrera()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }


    public DTONDirectorCarrera Obtener_NDirectorCarrera_Id_DirectorCarrera(string Id_Carrera)
    {
        DTONDirectorCarrera dtoNDirectorCarrera = new DTONDirectorCarrera();
        try
        {
            Database DBSWADNETVALLE = SBaseDatos.BDSWADNETValle;
            DbCommand dbCommand = DBSWADNETVALLE.GetStoredProcCommand("NDirectorCarrera_O_Id_DirectorCarrera");
            DBSWADNETVALLE.AddInParameter(dbCommand, "Id_Carrera", DbType.String, Id_Carrera);
            DBSWADNETVALLE.LoadDataSet(dbCommand, dtoNDirectorCarrera, "WDirectorCarrera");
        }
        catch (Exception ex)
        {

            throw;
        }
        return dtoNDirectorCarrera;
    }
}