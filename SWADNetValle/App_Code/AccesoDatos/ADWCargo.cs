using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADWCargo
/// </summary>
public class ADWCargo
{
    public ADWCargo()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public DTONCargo Obtener_NCargo_Id_Cargo(string Id_Cargo)
    {
        DTONCargo dtoNCargo = new DTONCargo();
        try
        {
            Database DBSWADNETVALLE = SBaseDatos.BDSWADNETValle;
            DbCommand dbCommand = DBSWADNETVALLE.GetStoredProcCommand("NCargo_O_Id_Cargo");
            DBSWADNETVALLE.AddInParameter(dbCommand, "Id_Cargo", DbType.String, Id_Cargo);
            DBSWADNETVALLE.LoadDataSet(dbCommand, dtoNCargo, "WCargo");
        }
        catch (Exception ex)
        {

            throw;
        }
        return dtoNCargo;
    }

}