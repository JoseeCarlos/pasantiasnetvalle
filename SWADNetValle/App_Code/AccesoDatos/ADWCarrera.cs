using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADWCarrera
/// </summary>
public class ADWCarrera
{
    public ADWCarrera()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public DTONCarrera Obtener_NCarrera_Id_Carrera(string Id_Carrera)
    {
        DTONCarrera dtoNCarrera = new DTONCarrera();
        try
        {
            Database DBSWADNETVALLE = SBaseDatos.BDSWADNETValle;
            DbCommand dbCommand = DBSWADNETVALLE.GetStoredProcCommand("NCarrera_O_Id_Carrera");
            DBSWADNETVALLE.AddInParameter(dbCommand, "Id_Carrera", DbType.String, Id_Carrera);
            DBSWADNETVALLE.LoadDataSet(dbCommand, dtoNCarrera, "WCarrera");
        }
        catch (Exception ex)
        {

            throw;
        }
        return dtoNCarrera;
    }
}