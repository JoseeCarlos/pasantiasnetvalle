using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADWSedeAcademica
/// </summary>
public class ADWSedeAcademica
{
    public DTONSedeAcademica Obtener_NSedeAcademica()
    {
        DTONSedeAcademica dtoNSedeAcademica = new DTONSedeAcademica();
        try
        {
            Database DBSWADNETVALLE = SBaseDatos.BDSWADNETValle;
            DbCommand dbCommand = DBSWADNETVALLE.GetStoredProcCommand("NSedeAcademica_O");
            DBSWADNETVALLE.LoadDataSet(dbCommand, dtoNSedeAcademica, "WSedeAcademica");
        }
        catch (Exception ex)
        {

            throw;
        }
        return dtoNSedeAcademica;
    }

    public DTONSedeAcademica Obtener_NSedeAcademica_Id_SedeAcademica(string Id_SedeAcademica)
    {
        DTONSedeAcademica dtoNSedeAcademica = new DTONSedeAcademica();
        try
        {
            Database DBSWADNETVALLE = SBaseDatos.BDSWADNETValle;
            DbCommand dbCommand = DBSWADNETVALLE.GetStoredProcCommand("NSedeAcademica_O_Id_SedeAcademica");
            DBSWADNETVALLE.AddInParameter(dbCommand, "Id_Estudiante", DbType.String, Id_SedeAcademica);
            DBSWADNETVALLE.LoadDataSet(dbCommand, dtoNSedeAcademica, "WSedeAcademica");
        }
        catch (Exception ex)
        {

            throw;
        }
        return dtoNSedeAcademica;
    }
}