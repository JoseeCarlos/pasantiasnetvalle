using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADWEmpleado
/// </summary>
public class ADWEmpleado
{
    public DTONEmpleado Obtener_NEmpleadoSimple()
    {
        DTONEmpleado dtoNEmpleado = new DTONEmpleado();
        try
        {
            Database DBSWADNETVALLE = SBaseDatos.BDSWADNETValle;
            DbCommand dbCommand = DBSWADNETVALLE.GetStoredProcCommand("NEmpleado_O");
            DBSWADNETVALLE.LoadDataSet(dbCommand, dtoNEmpleado, "WEmpleado");
        }
        catch (Exception ex)
        {

            throw;
        }
        return dtoNEmpleado;
    }

    public DTONEmpleado Obtener_NEmpleado_Id_Empleado(string Id_Empleado)
    {
        DTONEmpleado dtoNEmpleado = new DTONEmpleado();
        try
        {
            Database DBSWADNETVALLE = SBaseDatos.BDSWADNETValle;
            DbCommand dbCommand = DBSWADNETVALLE.GetStoredProcCommand("NEmpleado_O_Id_Empleado");
            DBSWADNETVALLE.AddInParameter(dbCommand, "Id_Empleado", DbType.String, Id_Empleado);
            DBSWADNETVALLE.LoadDataSet(dbCommand, dtoNEmpleado, "WEmpleado");
        }
        catch (Exception ex)
        {

            throw;
        }
        return dtoNEmpleado;
    }
}