using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CWEmpleado
/// </summary>
public class CWEmpleado
{
    ADWEmpleado adwEmpleado;

    public CWEmpleado()
    {
        adwEmpleado = new ADWEmpleado();
    }
    public List<ENEmpleadoSimple> Obtener_NEmpleadoSimple()
    {
        ENEmpleadoSimple enEmpleadoSimple = new ENEmpleadoSimple();
        List<ENEmpleadoSimple> lstENEmpleadoSimples = new List<ENEmpleadoSimple>();
        DTONEmpleado dtoNEmpleado = adwEmpleado.Obtener_NEmpleadoSimple();
        foreach (DTONEmpleado.WEmpleadoRow drWEmpleado in dtoNEmpleado.WEmpleado.Rows)
        {
            enEmpleadoSimple = new ENEmpleadoSimple();
            enEmpleadoSimple.Id_Empleado = drWEmpleado.Id_Empleado;
            enEmpleadoSimple.Id_Emp = drWEmpleado.Id_Emp;
            enEmpleadoSimple.Id_Cargo = drWEmpleado.Id_Cargo;
            enEmpleadoSimple.Nombres = drWEmpleado.Nombres;
            enEmpleadoSimple.PrimerApellido = drWEmpleado.PrimerApellido;
            enEmpleadoSimple.SegundoApellido = drWEmpleado.SegundoApellido;
            enEmpleadoSimple.FechaRegistro = drWEmpleado.FechaRegistro;
            enEmpleadoSimple.FechaModificacion = drWEmpleado.FechaModificacion;
            enEmpleadoSimple.Estado = drWEmpleado.Estado;
            lstENEmpleadoSimples.Add(enEmpleadoSimple);

        }
        return lstENEmpleadoSimples;
    }
    public ENEmpleadoSimple Obtener_NEmpleado_Id_Empleado(string Id_Empleado)
    {
        ENEmpleadoSimple enEmpleadoSimple = new ENEmpleadoSimple();
        DTONEmpleado dtoNEmpleado = adwEmpleado.Obtener_NEmpleado_Id_Empleado(Id_Empleado);
        foreach (DTONEmpleado.WEmpleadoRow drWEmpleado in dtoNEmpleado.WEmpleado.Rows)
        {
            enEmpleadoSimple = new ENEmpleadoSimple();
            enEmpleadoSimple.Id_Empleado = drWEmpleado.Id_Empleado;
            enEmpleadoSimple.Id_Emp = drWEmpleado.Id_Emp;
            enEmpleadoSimple.Id_Cargo = drWEmpleado.Id_Cargo;
            enEmpleadoSimple.Nombres = drWEmpleado.Nombres;
            enEmpleadoSimple.PrimerApellido = drWEmpleado.PrimerApellido;
            enEmpleadoSimple.SegundoApellido = drWEmpleado.SegundoApellido;
            enEmpleadoSimple.FechaRegistro = drWEmpleado.FechaRegistro;
            enEmpleadoSimple.FechaModificacion = drWEmpleado.FechaModificacion;
            enEmpleadoSimple.Estado = drWEmpleado.Estado;
        }
        return enEmpleadoSimple;
    }
}