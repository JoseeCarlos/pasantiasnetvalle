using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CWCargo
/// </summary>
public class CWCargo
{
    private ADWCargo adwCargo;
    public CWCargo()
    {
        adwCargo = new ADWCargo();
    }
    public ENCargo Obtener_NCargo_Id_Cargo(string Id_Cargo)
    {
        ENCargo enCargo = new ENCargo();
        DTONCargo dtoNCargo = adwCargo.Obtener_NCargo_Id_Cargo(Id_Cargo);
        foreach (DTONCargo.WCargoRow drWCargo in dtoNCargo.WCargo.Rows)
        {
            enCargo = new ENCargo();
            enCargo.Id_Cargo = drWCargo.Id_Cargo;
            enCargo.NombreCargo = drWCargo.NombreCargo;

            enCargo.Id_Emp = drWCargo.Id_Emp;
            enCargo.Estado = drWCargo.Estado;
            enCargo.FechaRegistro = drWCargo.FechaRegistro;
            enCargo.FechaModificacion = drWCargo.FechaModificiacion;

        }
        return enCargo;
    }
}