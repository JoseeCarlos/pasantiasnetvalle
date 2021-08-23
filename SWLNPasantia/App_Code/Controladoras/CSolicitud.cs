using SWADNETPAS;
using SWADNetValle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CSolicitud
/// </summary>
public class CSolicitud
{
    #region Variables Miembro
    private ASNetPAs asNetPas;
    private ASNetValle asNetValle;

    #endregion

    #region Contructor


    public CSolicitud()
    {
        asNetPas = new ASNetPAs();
        asNetValle = new ASNetValle();
    }
    #endregion

    #region Metodos Publicos 

    #region Postulacion
    public void Adicionar_PPostulacion(string Id_Estudiante, string ID_Institucion, string Id_Modalidad, string Id_SedeAcademica, DateTime FechaAceptacion, string Estado, DateTime FechaRegistro, DateTime FechaModificacion)
    {

        EPPostulacionSimple ePPostulacionSimple = new EPPostulacionSimple();
        try
        {
            ePPostulacionSimple.Id_Estudiante = Id_Estudiante;
            ePPostulacionSimple.Id_Institucion = ID_Institucion;
            ePPostulacionSimple.Id_Modalidad = Id_Modalidad;
            ePPostulacionSimple.Id_SedeAcademica = Id_SedeAcademica;
            ePPostulacionSimple.FechaAceptacion = FechaAceptacion;
            ePPostulacionSimple.Estado = Estado;
            ePPostulacionSimple.FechaRegistro = FechaRegistro;
            ePPostulacionSimple.FechaModificacion = FechaModificacion;
            asNetPas.Adicionar_PPostulacion(ePPostulacionSimple);
        }
        catch (Exception eX)
        {

            throw eX;
        }
    }
    public void Actualizar_PPostulacion_EstadoAprobado(string Id_Postulacion)
    {

        try
        {
            asNetPas.Actualizar_PPostulacion_EstadoAprobado(Id_Postulacion);
        }
        catch (Exception eX)
        {

            throw eX;
        }
    }
    public void Actualizar_PPostulacion_EstadoObservado(string Id_Postulacion)
    {

        try
        {
            asNetPas.Actualizar_PPostulacion_EstadoObservado(Id_Postulacion);
        }
        catch (Exception eX)
        {

            throw eX;
        }
    }
    public void Actualizar_PPostulacion(string Id_Postulacion, string Id_Estudiante, string ID_Institucion, string Id_Modalidad, string Id_SedeAcademica, string Estado, DateTime FechaRegistro, DateTime FechaModificacion)
    {
        EPPostulacionSimple ePPostulacionSimple = new EPPostulacionSimple();
        try
        {
            ePPostulacionSimple.Id_Postulacion = Id_Postulacion;
            ePPostulacionSimple.Id_Estudiante = Id_Estudiante;
            ePPostulacionSimple.Id_Institucion = ID_Institucion;
            ePPostulacionSimple.Id_Modalidad = Id_Modalidad;
            ePPostulacionSimple.Id_SedeAcademica = Id_SedeAcademica;
            ePPostulacionSimple.Estado = Estado;
            ePPostulacionSimple.FechaRegistro = FechaRegistro;
            ePPostulacionSimple.FechaModificacion = FechaModificacion;
            asNetPas.Actualizar_PPostulacion(ePPostulacionSimple);
        }
        catch (Exception eX)
        {

            throw eX;
        }
    }

    public List<EPPostulacionCompleja> Obtener_PPostulacion()
    {
        List<EPPostulacionCompleja> lstEPPostulacionCompleja = new List<EPPostulacionCompleja>();
        EPPostulacionCompleja ePPostulacionCompleja = new EPPostulacionCompleja();
        List<EPPostulacionSimple> lstEPPostulacionSimple = new List<EPPostulacionSimple>();
        EPModalidadSimple ePModalidadSimple = new EPModalidadSimple();
        EPInstitucionSimple ePInstitucionSimple = new EPInstitucionSimple();
        ENCarrera eNCarrera = new ENCarrera();
        //AQUI TENDRIA QUE IR LAS ENTIDADES DE ESTUDIANTE Y SEDEACADEMICA
        try
        {
            lstEPPostulacionSimple = asNetPas.Obtener_PPostulacion().ToList();

            foreach (EPPostulacionSimple ePPostulacionSimple in lstEPPostulacionSimple)
            {
                SWADNetValleClient sWADNetValleClient = new SWADNetValleClient();
                ENEstudiante eNEstudiante = new ENEstudiante();
                eNEstudiante = sWADNetValleClient.Obtener_NEstudiante_Id_Estudiante(ePPostulacionSimple.Id_Estudiante);
                ePModalidadSimple = asNetPas.Obtener_PModalidad_Id_Modalidad(ePPostulacionSimple.Id_Modalidad);
                ePInstitucionSimple = asNetPas.Obtener_PInstitucion_Id_Institucion(ePPostulacionSimple.Id_Institucion);
                // obtener datos estudiante
                eNCarrera = sWADNetValleClient.Obtener_NCarrera_Id_Carrera(eNEstudiante.Id_Carrera);
                //Simulacion de nombre sede academica
                string NomnbreSedeAcademica = "Cochabamba";
                ePPostulacionCompleja.Id_Postulacion = ePPostulacionSimple.Id_Postulacion;
                ePPostulacionCompleja.Id_Estudiante = ePPostulacionSimple.Id_Estudiante;
                ePPostulacionCompleja.NombreCompleto = eNEstudiante.Nombres + " " + eNEstudiante.PrimerApellido + " " + eNEstudiante.SegundoApellido;
                ePPostulacionCompleja.Correo = eNEstudiante.CorreoElectronico;
                ePPostulacionCompleja.NombreCarrera = eNCarrera.NombreCarrera;
                ePPostulacionCompleja.Id_Institucion = ePPostulacionSimple.Id_Institucion;
                ePPostulacionCompleja.NombreInstitucion = ePInstitucionSimple.NombreInstitucion;
                ePPostulacionCompleja.Id_Modalidad = ePPostulacionSimple.Id_Modalidad;
                ePPostulacionCompleja.NombreModalidad = ePModalidadSimple.NombreModalidad;
                ePPostulacionCompleja.Id_SedeAcademica = ePPostulacionSimple.Id_SedeAcademica;
                ePPostulacionCompleja.NombreSedeAcademica = NomnbreSedeAcademica;
                ePPostulacionCompleja.FechaAceptacion = ePPostulacionSimple.FechaAceptacion;
                ePPostulacionCompleja.Estado = ePPostulacionSimple.Estado;
                ePPostulacionCompleja.FechaRegistro = ePPostulacionSimple.FechaRegistro;
                ePPostulacionCompleja.FechaModificacion = ePPostulacionSimple.FechaModificacion;
            }

            return lstEPPostulacionCompleja;
        }
        catch (Exception eX)
        {

            throw eX;
        }
    }

    public List<PasantiasCompleja> ObtenerPasantias()
    {
        List<PasantiasCompleja> ls = new List<PasantiasCompleja>();
        PasantiasCompleja pas = new PasantiasCompleja();
        List<Pasantias> pasan = new List<Pasantias>();
        try
        {
            pasan = asNetPas.ObtenerPasantias();

            foreach (var item in pasan)
            {
                pas = new PasantiasCompleja(item.IdPasantia, item.IdEstudiante, item.IdSedeAcademica,item.NombreModalidad);

                ls.Add(pas);
            }
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return ls; 
       
    }

    public List<PasantiasCompleja> ObtenerPasantiasFecha(DateTime fecha1,DateTime fecha2)
    {
        List<PasantiasCompleja> ls = new List<PasantiasCompleja>();
        PasantiasCompleja pas = new PasantiasCompleja();
        List<Pasantias> pasan = new List<Pasantias>();
        try
        {
            pasan = asNetPas.ObtenerPasantiasFecha(fecha1,fecha2);

            foreach (var item in pasan)
            {
                pas = new PasantiasCompleja(item.IdPasantia, item.IdEstudiante, item.IdSedeAcademica);

                ls.Add(pas);
            }
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return ls;

    }

    public List<EPPostulacionCompleja> Obtener_PPostulacion_Estado(string Estado)
    {
        List<EPPostulacionCompleja> lstEPPostulacionCompleja = new List<EPPostulacionCompleja>();
        EPPostulacionCompleja ePPostulacionCompleja = new EPPostulacionCompleja();
        List<EPPostulacionSimple> lstEPPostulacionSimple = new List<EPPostulacionSimple>();
        EPModalidadSimple ePModalidadSimple = new EPModalidadSimple();
        EPInstitucionSimple ePInstitucionSimple = new EPInstitucionSimple();
        //AQUI TENDRIA QUE IR LAS ENTIDADES DE ESTUDIANTE Y SEDEACADEMICA
        try
        {
            lstEPPostulacionSimple = asNetPas.Obtener_PPostulacion_Estado(Estado);
            SWADNetValleClient sWADNetValleClient = new SWADNetValleClient();
            ENEstudiante eNEstudiante = new ENEstudiante();
            ENCarrera eNCarrera = new ENCarrera();
            foreach (EPPostulacionSimple ePPostulacionSimple in lstEPPostulacionSimple)
            {
                ePPostulacionCompleja = new EPPostulacionCompleja();
                eNEstudiante = sWADNetValleClient.Obtener_NEstudiante_Id_Estudiante(ePPostulacionSimple.Id_Estudiante);
                ePModalidadSimple = asNetPas.Obtener_PModalidad_Id_Modalidad(ePPostulacionSimple.Id_Modalidad);
                ePInstitucionSimple = asNetPas.Obtener_PInstitucion_Id_Institucion(ePPostulacionSimple.Id_Institucion);
                //Simulacion de obtener datos estudiante
                eNCarrera = sWADNetValleClient.Obtener_NCarrera_Id_Carrera(eNEstudiante.Id_Carrera);
                //Simulacion de nombre sede academica
                string NomnbreSedeAcademica = "Cochabamba";
                ePPostulacionCompleja.Id_Postulacion = ePPostulacionSimple.Id_Postulacion;
                ePPostulacionCompleja.Id_Estudiante = ePPostulacionSimple.Id_Estudiante;
                ePPostulacionCompleja.NombreCompleto = eNEstudiante.Nombres + " " + eNEstudiante.PrimerApellido + " " + eNEstudiante.SegundoApellido;
                ePPostulacionCompleja.Correo = eNEstudiante.CorreoElectronico;
                ePPostulacionCompleja.NombreCarrera = eNCarrera.NombreCarrera;
                ePPostulacionCompleja.Id_Institucion = ePPostulacionSimple.Id_Institucion;
                ePPostulacionCompleja.NombreInstitucion = ePInstitucionSimple.NombreInstitucion;
                ePPostulacionCompleja.Id_Modalidad = ePPostulacionSimple.Id_Modalidad;
                ePPostulacionCompleja.NombreModalidad = ePModalidadSimple.NombreModalidad;
                ePPostulacionCompleja.Id_SedeAcademica = ePPostulacionSimple.Id_SedeAcademica;
                ePPostulacionCompleja.NombreSedeAcademica = NomnbreSedeAcademica;
                ePPostulacionCompleja.FechaAceptacion = ePPostulacionSimple.FechaAceptacion;
                ePPostulacionCompleja.Estado = ePPostulacionSimple.Estado;
                ePPostulacionCompleja.FechaRegistro = ePPostulacionSimple.FechaRegistro;
                ePPostulacionCompleja.FechaModificacion = ePPostulacionSimple.FechaModificacion;
                lstEPPostulacionCompleja.Add(ePPostulacionCompleja);
            }

            return lstEPPostulacionCompleja;
        }
        catch (Exception eX)
        {

            throw eX;
        }
    }

    public List<EPPasantiaCompleja> Obtener_PPasantia_Finalizado()
    {
        List<EPPasantiaCompleja> lstEPPasantiaCompleja = new List<EPPasantiaCompleja>();
        EPPasantiaCompleja ePPasantiaCompleja = new EPPasantiaCompleja();
        List<EPPasantiaSimple> lstEPPasantiaSimple = new List<EPPasantiaSimple>();
        EPModalidadSimple ePModalidadSimple = new EPModalidadSimple();
        EPInstitucionSimple ePInstitucionSimple = new EPInstitucionSimple();
        //AQUI TENDRIA QUE IR LAS ENTIDADES DE ESTUDIANTE Y SEDEACADEMICA
        try
        {
            lstEPPasantiaSimple = asNetPas.Obtener_PPasantia_Finalizado();
            EPPostulacionSimple enPostulacion;
            SWADNetValleClient sWADNetValleClient = new SWADNetValleClient();
            ENEstudiante eNEstudiante = new ENEstudiante();

            foreach (EPPasantiaSimple ePPasantiaSimple in lstEPPasantiaSimple)
            {
                ePPasantiaCompleja = new EPPasantiaCompleja();
                enPostulacion = asNetPas.Obtener_PPostulacion_Id_Postulacion(ePPasantiaSimple.Id_Postulacion);
                eNEstudiante = sWADNetValleClient.Obtener_NEstudiante_Id_Estudiante(enPostulacion.Id_Estudiante);
                ePModalidadSimple = asNetPas.Obtener_PModalidad_Id_Modalidad(enPostulacion.Id_Modalidad);
                ePInstitucionSimple = asNetPas.Obtener_PInstitucion_Id_Institucion(enPostulacion.Id_Institucion);
                //Simulacion de obtener datos estudiante
                string Nombres = eNEstudiante.Nombres;
                string PrimerApellido = eNEstudiante.PrimerApellido;
                string SegundoApellido = eNEstudiante.SegundoApellido;
                string correo = eNEstudiante.CorreoElectronico;
                //Simulacion de nombre sede academica
                string NomnbreSedeAcademica = "Cochabamba";
                ePPasantiaCompleja.Id_Postulacion = ePPasantiaSimple.Id_Postulacion;
                ePPasantiaCompleja.NombreCompleto = Nombres + " " + PrimerApellido + " " + SegundoApellido;
                ePPasantiaCompleja.FechaRegistro = ePPasantiaSimple.FechaRegistro;
                ePPasantiaCompleja.NombreInstitucion = ePInstitucionSimple.NombreInstitucion;
                lstEPPasantiaCompleja.Add(ePPasantiaCompleja);
            }

            return lstEPPasantiaCompleja;
        }
        catch (Exception eX)
        {

            throw eX;
        }
    }

    public EPPostulacionCompleja Obtener_PPostulacion_Id_Postulacion(string Id_Postulacion)
    {
        EPPostulacionCompleja ePPostulacionCompleja = new EPPostulacionCompleja();
        EPPostulacionSimple ePPostulacionSimple = new EPPostulacionSimple();
        EPModalidadSimple ePModalidadSimple = new EPModalidadSimple();
        EPInstitucionSimple ePInstitucionSimple = new EPInstitucionSimple();
        ENEstudiante eNEstudiante = new ENEstudiante();
        SWADNetValleClient sWADNetValleClient = new SWADNetValleClient();
        ENCarrera eNCarrera = new ENCarrera();
        //AQUI TENDRIA QUE IR LAS ENTIDADES DE ESTUDIANTE Y SEDEACADEMICA
        try
        {
            ePPostulacionSimple = asNetPas.Obtener_PPostulacion_Id_Postulacion(Id_Postulacion);
            ePModalidadSimple = asNetPas.Obtener_PModalidad_Id_Modalidad(ePPostulacionSimple.Id_Modalidad);
            ePInstitucionSimple = asNetPas.Obtener_PInstitucion_Id_Institucion(ePPostulacionSimple.Id_Institucion);
            //Simulacion de obtener datos estudiante
            eNEstudiante = sWADNetValleClient.Obtener_NEstudiante_Id_Estudiante(ePPostulacionSimple.Id_Estudiante);
            eNCarrera = sWADNetValleClient.Obtener_NCarrera_Id_Carrera(eNEstudiante.Id_Carrera);
            //Simulacion de nombre sede academica
            string NomnbreSedeAcademica = "Cochabamba";
            ePPostulacionCompleja.Id_Postulacion = ePPostulacionSimple.Id_Postulacion;
            ePPostulacionCompleja.Id_Estudiante = ePPostulacionSimple.Id_Estudiante;
            ePPostulacionCompleja.NombreCompleto = eNEstudiante.Nombres + " " + eNEstudiante.PrimerApellido + " " + eNEstudiante.SegundoApellido;
            ePPostulacionCompleja.Correo = eNEstudiante.CorreoElectronico;
            ePPostulacionCompleja.NombreCarrera = eNCarrera.NombreCarrera;
            ePPostulacionCompleja.Id_Institucion = ePPostulacionSimple.Id_Institucion;
            ePPostulacionCompleja.NombreInstitucion = ePInstitucionSimple.NombreInstitucion;
            ePPostulacionCompleja.Id_Modalidad = ePPostulacionSimple.Id_Modalidad;
            ePPostulacionCompleja.NombreModalidad = ePModalidadSimple.NombreModalidad;
            ePPostulacionCompleja.Id_SedeAcademica = ePPostulacionSimple.Id_SedeAcademica;
            ePPostulacionCompleja.NombreSedeAcademica = NomnbreSedeAcademica;
            ePPostulacionCompleja.FechaAceptacion = ePPostulacionSimple.FechaAceptacion;
            ePPostulacionCompleja.Estado = ePPostulacionSimple.Estado;
            ePPostulacionCompleja.FechaRegistro = ePPostulacionSimple.FechaRegistro;
            ePPostulacionCompleja.FechaModificacion = ePPostulacionSimple.FechaModificacion;

            return ePPostulacionCompleja;
        }
        catch (Exception eX)
        {

            throw eX;
        }
    }


    public EPPostulacionCompleja2 Obtener_PPostulacion_Id_Postulacion2(string Id_Postulacion)
    {
        EPPostulacionCompleja2 ePPostulacionCompleja = new EPPostulacionCompleja2();
        EPPostulacionSimple ePPostulacionSimple = new EPPostulacionSimple();
        EPModalidadSimple ePModalidadSimple = new EPModalidadSimple();
        EPInstitucionSimple ePInstitucionSimple = new EPInstitucionSimple();
        ENEstudiante eNEstudiante = new ENEstudiante();
        SWADNetValleClient sWADNetValleClient = new SWADNetValleClient();
        //AQUI TENDRIA QUE IR LAS ENTIDADES DE ESTUDIANTE Y SEDEACADEMICA
        try
        {
            ePPostulacionSimple = asNetPas.Obtener_PPostulacion_Id_Postulacion(Id_Postulacion);
            ePModalidadSimple = asNetPas.Obtener_PModalidad_Id_Modalidad(ePPostulacionSimple.Id_Modalidad);
            ePInstitucionSimple = asNetPas.Obtener_PInstitucion_Id_Institucion(ePPostulacionSimple.Id_Institucion);
            //Simulacion de obtener datos estudiante
            eNEstudiante = sWADNetValleClient.Obtener_NEstudiante_Id_Estudiante(ePPostulacionSimple.Id_Estudiante);
            //Simulacion de nombre sede academica
            string NomnbreSedeAcademica = "Cochabamba";


            ePPostulacionCompleja.Id_Postulacion = ePPostulacionSimple.Id_Postulacion;
            ePPostulacionCompleja.Id_Estudiante = ePPostulacionSimple.Id_Estudiante;
            ePPostulacionCompleja.Nombres = eNEstudiante.Nombres;
            ePPostulacionCompleja.Apellidos = eNEstudiante.PrimerApellido + " " + eNEstudiante.SegundoApellido;
            ePPostulacionCompleja.CedulaIdentidad = eNEstudiante.CedulaIdentidad;
            ePPostulacionCompleja.EmitidoEn = NomnbreSedeAcademica;
            ePPostulacionCompleja.Celular = eNEstudiante.Celular;
            ePPostulacionCompleja.Telefono = eNEstudiante.Telefono;
            ePPostulacionCompleja.Correo = eNEstudiante.CorreoElectronico;


            ePPostulacionCompleja.Id_Institucion = ePPostulacionSimple.Id_Institucion;
            ePPostulacionCompleja.NombreInstitucion = ePInstitucionSimple.NombreInstitucion;
            ePPostulacionCompleja.NombreEncargado = ePInstitucionSimple.NombreResponsable;
            ePPostulacionCompleja.Cargo = ePInstitucionSimple.CargoResponsable;


            ePPostulacionCompleja.DireccionInstitucion = ePInstitucionSimple.DireccionInstitucion;
            ePPostulacionCompleja.TelefonoInstitucion = ePInstitucionSimple.TelefonoInstitucion;
            ePPostulacionCompleja.CiudadInstitucion = NomnbreSedeAcademica;
            ePPostulacionCompleja.CorreoInstitucion = ePInstitucionSimple.CorreoInstitucion;











            return ePPostulacionCompleja;
        }
        catch (Exception eX)
        {

            throw eX;
        }
    }

    public DateTime Verificar_FechaInicio_Id_Estudiante(string Id_Estudiante)
    {

        EPPostulacionSimple ePPostulacionSimple = new EPPostulacionSimple();
        EPPasantiaSimple ePPasantiaSimple = new EPPasantiaSimple();
        DateTime fechaInicio = DateTime.Now;


        try
        {
            ePPostulacionSimple = asNetPas.Obtener_PPostulacion_Id_Estudiante(Id_Estudiante);
            ePPasantiaSimple = asNetPas.Obtener_PPasantia_Id_Postulacion(ePPostulacionSimple.Id_Postulacion);
            fechaInicio = ePPasantiaSimple.FechaInicioPasantia;



            return fechaInicio;
        }
        catch (Exception eX)
        {

            throw eX;
        }
    }



    public bool Verificar_FechaInicio_Id_Estudiante_Bool(string Id_Estudiante)
    {

        EPPostulacionSimple ePPostulacionSimple = new EPPostulacionSimple();
        EPPasantiaSimple ePPasantiaSimple = new EPPasantiaSimple();
        bool ban = false;
        DateTime fecha = DateTime.Parse("1900-01-01");

        try
        {
            ePPostulacionSimple = asNetPas.Obtener_PPostulacion_Id_Estudiante(Id_Estudiante);
            if (ePPostulacionSimple.Id_Postulacion != string.Empty)
            {
                ePPasantiaSimple = asNetPas.Obtener_PPasantia_Id_Postulacion(ePPostulacionSimple.Id_Postulacion);
                if (ePPasantiaSimple.FechaInicioPasantia != fecha)
                {
                    ban = true;
                }
            }
            return ban;
        }
        catch (Exception eX)
        {

            throw eX;
        }
    }


    public List<EPPostulacionCompleja3> BuscarEstududiante_NombreCompleto(string NombreCompleto)
    {


        //CREAMOS TODAS LAS ENTIDADES QUE SE NECESITARA
        List<EPPostulacionCompleja> lstEPPostulacionCompleja = new List<EPPostulacionCompleja>();
        EPPostulacionCompleja ePPostulacionCompleja = new EPPostulacionCompleja();
        EPModalidadSimple ePModalidadSimple = new EPModalidadSimple();
        EPInstitucionSimple ePInstitucionSimple = new EPInstitucionSimple();
        //UNA LISTA DE ESTUDIANTES QUE SERA DEVUELVA CON IDESTUDIANTE PARA LUEGO BUSCAR ESOS ID EN POSTULACION
        List<ENEstudiante> lstENEstudiante = new List<ENEstudiante>();
        ENEstudiante ePEstudiante = new ENEstudiante();
        ENEstudiante ePEstudiante2 = new ENEstudiante();
        EPPostulacionSimple ePPostulacionSimple = new EPPostulacionSimple();
        List<EPPostulacionSimple> ePPostulacionSimple2 = new List<EPPostulacionSimple>();

        List<EPPostulacionCompleja3> lstEPPostulacionCompleja3 = new List<EPPostulacionCompleja3>();
        EPPostulacionCompleja3 ePPostulacionCompleja3 = new EPPostulacionCompleja3();
        ENCarrera ePCarrera = new ENCarrera();

        lstENEstudiante = asNetValle.BuscarEstudiante_NombreCompleto(NombreCompleto);
        string verifica = "0";
        try
        {

            foreach (ENEstudiante enPEstudiante in lstENEstudiante)
            {
                ePEstudiante = new ENEstudiante();
                ePEstudiante2 = new ENEstudiante();
                ePEstudiante.Id_Estudiante = enPEstudiante.Id_Estudiante.Trim();
                ePEstudiante2 = asNetValle.Obtener_NEstudiante_Id_Estudiante(enPEstudiante.Id_Estudiante);
                ePPostulacionSimple2 = asNetPas.Obtener_PPostulacion_Id_Estudiante_Verificar(ePEstudiante2.Id_Estudiante.Trim());
                verifica = ePPostulacionSimple2[0].Id_Postulacion;
                if (verifica.Trim() != "1000")
                {
                    ePPostulacionCompleja3 = new EPPostulacionCompleja3();


                    ePCarrera = asNetValle.Obtener_NCarrera_Id_Carrera(ePEstudiante2.Id_Carrera);
                    ePPostulacionSimple = new EPPostulacionSimple();
                    //OBTENEMOS UNA ENTIDAD POSTULACION CON CADA UNO DE LOS IDESTUDIANTE QUE ENCUENTRE
                    ePPostulacionSimple = asNetPas.Obtener_PPostulacion_Id_Estudiante(ePEstudiante2.Id_Estudiante);

                    // DE LA MISMA FORMA OBTENERMOS MODALIDAD E INSTITUCION CON LOS DATOS DE POSTULACION
                    ePModalidadSimple = asNetPas.Obtener_PModalidad_Id_Modalidad(ePPostulacionSimple.Id_Modalidad);
                    ePInstitucionSimple = asNetPas.Obtener_PInstitucion_Id_Institucion(ePPostulacionSimple.Id_Institucion);


                    //CREAMOS LA ENTIDAD POSTULACION COMPLEJA CON TODOS LOS DATOS 
                    ePPostulacionCompleja3.Id_Postulacion = ePPostulacionSimple.Id_Postulacion;
                    ePPostulacionCompleja3.Id_Estudiante = ePPostulacionSimple.Id_Estudiante;

                    ePPostulacionCompleja3.NombreCompleto = ePEstudiante2.Nombres + " " + ePEstudiante2.PrimerApellido + " " + ePEstudiante2.SegundoApellido;
                    ePPostulacionCompleja3.NombreCarrera = ePCarrera.NombreCarrera;
                    ePPostulacionCompleja3.NombreInstitucion = ePInstitucionSimple.NombreInstitucion;
                    ePPostulacionCompleja3.Correo = ePEstudiante2.CorreoElectronico;
                    ePPostulacionCompleja3.FechaRegistro = ePPostulacionSimple.FechaRegistro;

                    lstEPPostulacionCompleja3.Add(ePPostulacionCompleja3);
                }
            }





            return lstEPPostulacionCompleja3;
        }
        catch (Exception)
        {

            throw;
        }


        //try
        //{
        //    //CREAMOS UNA VARIABLE STRING PARA SABER SI EXISTE O NO EL IDESTUDIANTE EN POSTULACION
        //    string verifica = "0";
        //    //DE TODOS LOS ESTUDIANTES DEVUELTOS POR BUSQUEDA DE NOMBRE RECORREMOS CADA UNO
        //    foreach (ENEstudiante lstePEstudiante in lstENEstudiante)
        //    {
        //        EPPostulacionSimple ePPostulacionSimple2 = new EPPostulacionSimple();
        //        ePEstudiante = new ENEstudiante();
        //        ePEstudiante.Id_Estudiante = lstePEstudiante.Id_Estudiante;


        //        //VERIFICAMOS SI EXISTE EL IDESTUDIANTE EN POSTULACION 
        //        // ESTE METODO DEVUELVE 0 SI NO EXISTE IDESTUDIANTE EN POSTULACION O SINO DEVUELVE EL ID DE LA POSTULACION
        //        ePPostulacionSimple2 = asNetPas.Obtener_PPostulacion_Id_Estudiante_Verificar(ePEstudiante.Id_Estudiante.Trim());
        //        verifica = ePPostulacionSimple2.Id_Estudiante;
        //        //SI ES DISTINTO DE 0 ENTONCES SI EXISTE EL IDESTUDIANTE EN POSTULACION
        //        if (verifica != "0")
        //        {

        //            ePPostulacionCompleja = new EPPostulacionCompleja();
        //            ePPostulacionSimple = new EPPostulacionSimple();
        //            //OBTENEMOS UNA ENTIDAD POSTULACION CON CADA UNO DE LOS IDESTUDIANTE QUE ENCUENTRE
        //            ePPostulacionSimple = asNetPas.Obtener_PPostulacion_Id_Estudiante(ePEstudiante.Id_Estudiante);

        //            // DE LA MISMA FORMA OBTENERMOS MODALIDAD E INSTITUCION CON LOS DATOS DE POSTULACION
        //            ePModalidadSimple = asNetPas.Obtener_PModalidad_Id_Modalidad(ePPostulacionSimple.Id_Modalidad);
        //            ePInstitucionSimple = asNetPas.Obtener_PInstitucion_Id_Institucion(ePPostulacionSimple.Id_Institucion);


        //            //CREAMOS LA ENTIDAD POSTULACION COMPLEJA CON TODOS LOS DATOS 
        //            ePPostulacionCompleja.Id_Postulacion = ePPostulacionSimple.Id_Postulacion;
        //            ePPostulacionCompleja.Id_Estudiante = ePPostulacionSimple.Id_Estudiante;
        //            ePPostulacionCompleja.NombreCompleto = ePEstudiante.Nombres + " " + ePEstudiante.PrimerApellido + " " + ePEstudiante.SegundoApellido;
        //            ePPostulacionCompleja.Correo = ePEstudiante.CorreoElectronico;
        //            ePPostulacionCompleja.Id_Institucion = ePPostulacionSimple.Id_Institucion;
        //            ePPostulacionCompleja.NombreInstitucion = ePInstitucionSimple.NombreInstitucion;
        //            ePPostulacionCompleja.Id_Modalidad = ePPostulacionSimple.Id_Modalidad;
        //            ePPostulacionCompleja.NombreModalidad = ePModalidadSimple.NombreModalidad;
        //            //COMO TODAIA NO EXISTE ESTE PROCESO LO SIMULAMOS CON UN STRING ESTATICO
        //            ////////////////////////REALIZAR PROCESO SEDEACADEMICA
        //            string NomnbreSedeAcademica = "Cochabamba";
        //            ePPostulacionCompleja.Id_SedeAcademica = ePPostulacionSimple.Id_SedeAcademica;
        //            ePPostulacionCompleja.NombreSedeAcademica = NomnbreSedeAcademica;
        //            ePPostulacionCompleja.FechaAceptacion = ePPostulacionSimple.FechaAceptacion;
        //            ePPostulacionCompleja.Estado = ePPostulacionSimple.Estado;
        //            ePPostulacionCompleja.FechaRegistro = ePPostulacionSimple.FechaRegistro;
        //            ePPostulacionCompleja.FechaModificacion = ePPostulacionSimple.FechaModificacion;
        //            //AGREGAMOS CADA UNA DE LAS ENTIDADES COMPLEJAS DE POSTULACION A LA LISTA
        //            lstEPPostulacionCompleja.Add(ePPostulacionCompleja);


        //        }

        //    }

        //    return lstEPPostulacionCompleja;
        //}
        //catch (Exception eX)
        //{

        //    throw eX;
        //}
    }

    public DataTable ReporteGeneral()
    {

        List<EPReporte1> ePReporte1s = new List<EPReporte1>();
        EPReporte1 ePReporte1 = new EPReporte1();
        List<EPPostulacionSimple> lstEPPostulacionSimple = new List<EPPostulacionSimple>();
        List<ENCiudad> eNCiudads = new List<ENCiudad>();
        List<ENFacultad> eNFacultads = new List<ENFacultad>();

        DataTable dt;

        try
        {
            eNCiudads = asNetValle.Obtener_ENCiudad();
            eNFacultads = asNetValle.Obtener_ENFacultad();

            for (int i = 0; i < 5; i++)
            {
                //EMPEZAMOS POR CADA CIUDAD HASTA EL 5 YA QUE SOLO SON 5 SEDES

                for (int j = 0; j < 5; j++)
                {
                    lstEPPostulacionSimple = asNetPas.Obtener_PPostulacion_Id_SedeAcademica(eNCiudads[i].Id_Ciudad);


                    ePReporte1.SedeAcademica = eNCiudads[i].NombreCiudad;
                    ePReporte1.Facultad = eNFacultads[j].NombreFacultad;
                    ePReporte1.Cantidad = lstEPPostulacionSimple.Count().ToString();
                    ePReporte1s.Add(ePReporte1);


                }


            }
            dt = ConvertListToDataTable(ePReporte1s);
            return dt;





        }
        catch (Exception eX)
        {

            throw eX;
        }
    }

    static DataTable ConvertListToDataTable(List<EPReporte1> list)
    {
        // New table.
        DataTable table = new DataTable();

        // Get max columns.
        int columns = 0;
        foreach (var array in list)
        {
            if (array.SedeAcademica.Length > columns)
            {
                columns = array.SedeAcademica.Length;
            }
        }

        // Add columns.
        for (int i = 0; i < columns; i++)
        {
            table.Columns.Add();
        }

        // Add rows.
        foreach (var array in list)
        {
            table.Rows.Add(array);
        }

        return table;
    }

    public string VerificarPostulacion(string Id_Estudiante)
    {
        //DEVUELVE 
        //0 = NO PUEDE POSTULAR
        //1 = SI PUEDE POSTULAR
        // LOS VALORES EN STRING

        string bandera = string.Empty;

        EPPostulacionSimple ePPostulacionSimple = new EPPostulacionSimple();
        ePPostulacionSimple = asNetPas.VerificarPostulacion(Id_Estudiante);
        string cantidad = ePPostulacionSimple.Id_Postulacion;
        if (cantidad == string.Empty)
        {
            bandera = "1";
        }
        else
        {
            bandera = "0";
        }
        return bandera;
    }


    #endregion

    #region Modalidad
    public void Actualizar_PModalidad(string Id_Modalidad, string NombreModalidad, string Id_Emp, string Estado, DateTime FechaRegistro, DateTime FechaModificacion)
    {
        try
        {
            EPModalidadSimple epModalidadSimple = new EPModalidadSimple();
            epModalidadSimple.Id_Modalidad = Id_Modalidad;
            epModalidadSimple.NombreModalidad = NombreModalidad;
            epModalidadSimple.Id_Emp = Id_Emp;
            epModalidadSimple.Estado = Estado;
            epModalidadSimple.FechaRegistro = FechaRegistro;
            epModalidadSimple.FechaModificacion = FechaModificacion;

            asNetPas.Actualizar_PModalidad(epModalidadSimple);
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }
    public void Adicionar_PModalidad(string NombreModalidad, string Id_Emp, string Estado, DateTime FechaRegistro, DateTime FechaModificacion)
    {
        try
        {
            EPModalidadSimple epModalidadSimple = new EPModalidadSimple();
            epModalidadSimple.NombreModalidad = NombreModalidad;
            epModalidadSimple.Id_Emp = Id_Emp;
            epModalidadSimple.Estado = Estado;
            epModalidadSimple.FechaRegistro = FechaRegistro;
            epModalidadSimple.FechaModificacion = FechaModificacion;
            asNetPas.Adicionar_PModalidad(epModalidadSimple);
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }
    public List<EPModalidadSimple> Obtener_PModalidad()
    {
        try
        {
            List<EPModalidadSimple> ePModalidadSimples = new List<EPModalidadSimple>();
            ePModalidadSimples = asNetPas.Obtener_PModalidad().ToList();
            return ePModalidadSimples;
        }
        catch (Exception Ex)
        {

            throw Ex;
        }

    }
    public EPModalidadSimple Obtener_PModalidad_Id_Modalidad(string Id_Modalidad)
    {
        try
        {
            EPModalidadSimple ePModalidadSimple = new EPModalidadSimple();
            ePModalidadSimple = asNetPas.Obtener_PModalidad_Id_Modalidad(Id_Modalidad);
            return ePModalidadSimple;
        }
        catch (Exception Ex)
        {

            throw Ex;
        }

    }
    #endregion

    #region Institucion 
    public void Adicionar_PInstitucion(string NombreResponsable, string PrimerApellidoResponsable, string SegundoApellidoResponsable, string CargoResponsable, string NombreInstitucion, string DireccionInstitucion, string TelefonoInstitucion, string CorreoInstitucion, string Id_Ciudad, string Estado, DateTime FechaRegistro, DateTime FechaModificacion)
    {
        try
        {
            EPInstitucionSimple epInstitucionSimple = new EPInstitucionSimple();
            epInstitucionSimple.NombreResponsable = NombreResponsable;
            epInstitucionSimple.PrimerApellidoResponsable = PrimerApellidoResponsable;
            epInstitucionSimple.SegundoApellidoResponsable = SegundoApellidoResponsable;
            epInstitucionSimple.CargoResponsable = CargoResponsable;
            epInstitucionSimple.NombreInstitucion = NombreInstitucion;
            epInstitucionSimple.DireccionInstitucion = DireccionInstitucion;
            epInstitucionSimple.TelefonoInstitucion = TelefonoInstitucion;
            epInstitucionSimple.CorreoInstitucion = CorreoInstitucion;
            epInstitucionSimple.Id_Ciudad = Id_Ciudad;
            epInstitucionSimple.Estado = Estado;
            epInstitucionSimple.FechaRegistro = FechaRegistro;
            epInstitucionSimple.FechaModificacion = FechaModificacion;
            asNetPas.Adicionar_PInstitucion(epInstitucionSimple);
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }
    public void Actualizar_PInstitucion(string Id_Institucion, string NombreResponsable, string PrimerApellidoResponsable, string SegundoApellidoResponsable, string CargoResponsable, string NombreInstitucion, string DireccionInstitucion, string TelefonoInstitucion, string CorreoInstitucion, string Id_Ciudad, string Estado, DateTime FechaRegistro, DateTime FechaModificacion)
    {
        try
        {
            EPInstitucionSimple epInstitucionSimple = new EPInstitucionSimple();
            epInstitucionSimple.Id_Institucion = Id_Institucion;
            epInstitucionSimple.NombreResponsable = NombreResponsable;
            epInstitucionSimple.PrimerApellidoResponsable = PrimerApellidoResponsable;
            epInstitucionSimple.SegundoApellidoResponsable = SegundoApellidoResponsable;
            epInstitucionSimple.CargoResponsable = CargoResponsable;
            epInstitucionSimple.NombreInstitucion = NombreInstitucion;
            epInstitucionSimple.DireccionInstitucion = DireccionInstitucion;
            epInstitucionSimple.TelefonoInstitucion = TelefonoInstitucion;
            epInstitucionSimple.CorreoInstitucion = CorreoInstitucion;
            epInstitucionSimple.Id_Ciudad = Id_Ciudad;
            epInstitucionSimple.Estado = Estado;
            epInstitucionSimple.FechaRegistro = FechaRegistro;
            epInstitucionSimple.FechaModificacion = FechaModificacion;

            asNetPas.Actualizar_PInstitucion(epInstitucionSimple);
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }
    public List<EPInstitucionCompleja> Obtener_PInstitucion()
    {
        try
        {
            List<EPInstitucionSimple> lstPInstitucionSimple = new List<EPInstitucionSimple>();
            List<EPInstitucionCompleja> lstPInstitucionCompleja = new List<EPInstitucionCompleja>();
            EPInstitucionCompleja ePInstitucionCompleja = new EPInstitucionCompleja();
            lstPInstitucionSimple = asNetPas.Obtener_PInstitucion().ToList();
            //AQUI TENDRIA QUE IR ENTIDAD CIUDAD
            //////////////////////////////////

            foreach (EPInstitucionSimple ePInstitucionSimple in lstPInstitucionSimple)
            {
                ePInstitucionCompleja = new EPInstitucionCompleja();
                //SIMULAMOS LA CIUDAD
                string Ciudad = "Cochabamba";

                ePInstitucionCompleja.Id_Institucion = ePInstitucionSimple.Id_Institucion;
                ePInstitucionCompleja.NombreResponsable = ePInstitucionSimple.NombreResponsable;
                ePInstitucionCompleja.PrimerApellidoResponsable = ePInstitucionSimple.PrimerApellidoResponsable;
                ePInstitucionCompleja.SegundoApellidoResponsable = ePInstitucionSimple.SegundoApellidoResponsable;
                ePInstitucionCompleja.CargoResponsable = ePInstitucionSimple.CargoResponsable;
                ePInstitucionCompleja.NombreInstitucion = ePInstitucionSimple.NombreInstitucion;
                ePInstitucionCompleja.DireccionInstitucion = ePInstitucionSimple.DireccionInstitucion;
                ePInstitucionCompleja.TelefonoInstitucion = ePInstitucionSimple.TelefonoInstitucion;
                ePInstitucionCompleja.CorreoInstitucion = ePInstitucionSimple.CorreoInstitucion;
                ePInstitucionCompleja.Id_Ciudad = ePInstitucionSimple.Id_Ciudad;
                ePInstitucionCompleja.NombreCiudad = Ciudad;
                ePInstitucionCompleja.Estado = ePInstitucionSimple.Estado;
                ePInstitucionCompleja.FechaRegistro = ePInstitucionSimple.FechaRegistro;
                ePInstitucionCompleja.FechaModificacion = ePInstitucionSimple.FechaModificacion;
                lstPInstitucionCompleja.Add(ePInstitucionCompleja);
            }


            return lstPInstitucionCompleja;
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }


    public List<EPInstitucionCompleja2> Obtener_PInstitucionCorta()
    {
        try
        {
            List<EPInstitucionSimple> lstPInstitucionSimple = new List<EPInstitucionSimple>();
            List<EPInstitucionCompleja2> lstPInstitucionCompleja2 = new List<EPInstitucionCompleja2>();
            EPInstitucionCompleja2 ePInstitucionCompleja2 = new EPInstitucionCompleja2();
            lstPInstitucionSimple = asNetPas.Obtener_PInstitucion().ToList();

            foreach (EPInstitucionSimple ePInstitucionSimple in lstPInstitucionSimple)
            {

                ePInstitucionCompleja2.Id_Institucion = ePInstitucionSimple.Id_Institucion;
                ePInstitucionCompleja2.NombreInstitucion = ePInstitucionSimple.NombreInstitucion;

            }

            return lstPInstitucionCompleja2;
        }
        catch (Exception Ex)
        {

            throw Ex;
        }


    }
    public EPInstitucionCompleja Obtener_PInstitucion_Id_Institucion(string Id_Institucion)
    {
        try
        {
            List<EPInstitucionSimple> lstPInstitucionSimple = new List<EPInstitucionSimple>();
            List<EPInstitucionCompleja> lstPInstitucionCompleja = new List<EPInstitucionCompleja>();
            EPInstitucionCompleja ePInstitucionCompleja = new EPInstitucionCompleja();
            EPInstitucionSimple ePInstitucionSimple = new EPInstitucionSimple();
            ePInstitucionSimple = asNetPas.Obtener_PInstitucion_Id_Institucion(Id_Institucion);
            //AQUI TENDRIA QUE IR ENTIDAD CIUDAD Y OBTENER CIUDAD
            //////////////////////////////////
            //SIMULAMOS LA CIUDAD
            string Ciudad = "Cochabamba";
            ePInstitucionCompleja.Id_Institucion = ePInstitucionSimple.Id_Institucion;
            ePInstitucionCompleja.NombreResponsable = ePInstitucionSimple.NombreResponsable;
            ePInstitucionCompleja.PrimerApellidoResponsable = ePInstitucionSimple.PrimerApellidoResponsable;
            ePInstitucionCompleja.SegundoApellidoResponsable = ePInstitucionSimple.SegundoApellidoResponsable;
            ePInstitucionCompleja.CargoResponsable = ePInstitucionSimple.CargoResponsable;
            ePInstitucionCompleja.NombreInstitucion = ePInstitucionSimple.NombreInstitucion;
            ePInstitucionCompleja.DireccionInstitucion = ePInstitucionSimple.DireccionInstitucion;
            ePInstitucionCompleja.TelefonoInstitucion = ePInstitucionSimple.TelefonoInstitucion;
            ePInstitucionCompleja.CorreoInstitucion = ePInstitucionSimple.CorreoInstitucion;
            ePInstitucionCompleja.Id_Ciudad = ePInstitucionSimple.Id_Ciudad;
            ePInstitucionCompleja.NombreCiudad = Ciudad;
            ePInstitucionCompleja.Estado = ePInstitucionSimple.Estado;
            ePInstitucionCompleja.FechaRegistro = ePInstitucionSimple.FechaRegistro;
            ePInstitucionCompleja.FechaModificacion = ePInstitucionSimple.FechaModificacion;
            return ePInstitucionCompleja;

        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }

    public EPInstitucionCompleja Obtener_PInstitucion_NombreInstitucion(string NombreInstitucion)
    {
        try
        {
            List<EPInstitucionSimple> lstPInstitucionSimple = new List<EPInstitucionSimple>();
            List<EPInstitucionCompleja> lstPInstitucionCompleja = new List<EPInstitucionCompleja>();
            EPInstitucionCompleja ePInstitucionCompleja = new EPInstitucionCompleja();
            EPInstitucionSimple ePInstitucionSimple = new EPInstitucionSimple();
            ePInstitucionSimple = asNetPas.Obtener_PInstitucion_Id_Institucion(NombreInstitucion);
            //AQUI TENDRIA QUE IR ENTIDAD CIUDAD Y OBTENER CIUDAD
            //////////////////////////////////
            //SIMULAMOS LA CIUDAD
            string Ciudad = "Cochabamba";
            ePInstitucionCompleja.Id_Institucion = ePInstitucionSimple.Id_Institucion;
            ePInstitucionCompleja.NombreResponsable = ePInstitucionSimple.NombreResponsable;
            ePInstitucionCompleja.PrimerApellidoResponsable = ePInstitucionSimple.PrimerApellidoResponsable;
            ePInstitucionCompleja.SegundoApellidoResponsable = ePInstitucionSimple.SegundoApellidoResponsable;
            ePInstitucionCompleja.CargoResponsable = ePInstitucionSimple.CargoResponsable;
            ePInstitucionCompleja.NombreInstitucion = ePInstitucionSimple.NombreInstitucion;
            ePInstitucionCompleja.DireccionInstitucion = ePInstitucionSimple.DireccionInstitucion;
            ePInstitucionCompleja.TelefonoInstitucion = ePInstitucionSimple.TelefonoInstitucion;
            ePInstitucionCompleja.CorreoInstitucion = ePInstitucionSimple.CorreoInstitucion;
            ePInstitucionCompleja.Id_Ciudad = ePInstitucionSimple.Id_Ciudad;
            ePInstitucionCompleja.NombreCiudad = Ciudad;
            ePInstitucionCompleja.Estado = ePInstitucionSimple.Estado;
            ePInstitucionCompleja.FechaRegistro = ePInstitucionSimple.FechaRegistro;
            ePInstitucionCompleja.FechaModificacion = ePInstitucionSimple.FechaModificacion;
            return ePInstitucionCompleja;

        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }

    #endregion



    #region Pasantia
    public EPSolicitud Obtener_Datos_Soilicitud_Id_Estudiante(string Id_Estudiante)
    {
        try
        {
            EPPostulacionSimple ePPostulacionSimple = new EPPostulacionSimple();
            EPInstitucionSimple ePInstitucion = new EPInstitucionSimple();
            EPModalidadSimple ePModalidadSimple = new EPModalidadSimple();
            EPPasantiaSimple ePPasantiaSimple = new EPPasantiaSimple();
            EPSolicitud ePSolicitud = new EPSolicitud();
            ePPostulacionSimple = asNetPas.Obtener_PPostulacion_Id_Estudiante(Id_Estudiante);
            ePInstitucion = asNetPas.Obtener_PInstitucion_Id_Institucion(ePPostulacionSimple.Id_Institucion);
            ePModalidadSimple = asNetPas.Obtener_PModalidad_Id_Modalidad(ePPostulacionSimple.Id_Modalidad);
            ePPasantiaSimple = asNetPas.Obtener_PPasantia_Id_Postulacion(ePPostulacionSimple.Id_Postulacion);

            ePSolicitud.CargoResposable = ePInstitucion.CargoResponsable;
            ePSolicitud.DireccionInstitucion = ePInstitucion.DireccionInstitucion;
            ePSolicitud.HorasPasantia = ePPasantiaSimple.Horas;
            ePSolicitud.NombreInstitucion = ePInstitucion.NombreInstitucion;
            ePSolicitud.NombreModalidad = ePModalidadSimple.NombreModalidad;
            ePSolicitud.NombreResposable = ePInstitucion.NombreResponsable;

            return ePSolicitud;
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }
    public void Adicionar_PPasantia(string Id_Postulacion, string Horas, string Estado, DateTime FechaRegistro, DateTime FechaModificacion)
    {
        try
        {




            EPPasantiaSimple epPasantiaSimple = new EPPasantiaSimple();
            epPasantiaSimple.Id_Postulacion = Id_Postulacion;
            epPasantiaSimple.Estado = Estado;
            epPasantiaSimple.Horas = Horas;
            epPasantiaSimple.FechaRegistro = FechaRegistro;
            epPasantiaSimple.FechaModificacion = FechaModificacion;
            asNetPas.Adicionar_PPasantia(epPasantiaSimple);



        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }

    public void Actualizar_PPasatia(string Id_Postulacion, string Id_Horario, DateTime FechaInicioPasantia, string Estado, DateTime FechaRegistro, DateTime FechaModificacion)
    {
        try
        {
            EPPasantiaSimple epPasantiaSimple = new EPPasantiaSimple();
            epPasantiaSimple.Id_Postulacion = Id_Postulacion;
            epPasantiaSimple.Horas = Id_Horario;
            epPasantiaSimple.FechaInicioPasantia = FechaInicioPasantia;
            epPasantiaSimple.Estado = Estado;
            epPasantiaSimple.FechaRegistro = FechaRegistro;
            epPasantiaSimple.FechaModificacion = FechaModificacion;

            asNetPas.Actualizar_PPasantia(epPasantiaSimple);
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }


    public void Actualizar_PPasatia_FechaInicio(string Id_Pasantia, DateTime FechaInicioPasantia, DateTime FechaModificacion)
    {
        try
        {
            EPPasantiaSimple epPasantiaSimple = new EPPasantiaSimple();
            epPasantiaSimple.Id_Pasantia = Id_Pasantia;
            epPasantiaSimple.FechaInicioPasantia = FechaInicioPasantia;
            epPasantiaSimple.FechaModificacion = FechaModificacion;
            asNetPas.Actualizar_PPasantia_FechaInicio(epPasantiaSimple);
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }
    //public List<EPPasantiaCompleja> Obtener_PPasantia()
    //{
    //    try
    //    {
    //        List<EPPasantiaSimple> lstPPasantiaSimple = new List<EPPasantiaSimple>();
    //        List<EPPasantiaCompleja> lstPPasantiaCompleja = new List<EPPasantiaCompleja>();
    //        EPPasantiaCompleja ePPasantiaCompleja = new EPPasantiaCompleja();
    //        lstPPasantiaSimple = asNetPas.Obtener_PPasantia().ToList();
    //        EPModalidadSimple ePModalidadSimple = new EPModalidadSimple();
    //        EPInstitucionSimple ePInstitucionSimple = new EPInstitucionSimple();

    //        foreach (EPPasantiaSimple ePPasantiaSimple in lstPPasantiaSimple)
    //        {



    //            SWADNetValleClient sWADNetValleClient = new SWADNetValleClient();
    //            ENEstudiante eNEstudiante = new ENEstudiante();
    //            eNEstudiante = sWADNetValleClient.Obtener_NEstudiante_Id_Estudiante(ePPasantiaSimple.Id_Estudiante);
    //            ePModalidadSimple = asNetPas.Obtener_PModalidad_Id_Modalidad(ePPasantiaSimple.Id_Modalidad);
    //            ePInstitucionSimple = asNetPas.Obtener_PInstitucion_Id_Institucion(ePPasantiaSimple.Id_Institucion);
    //            // obtener datos estudiante
    //            string Nombres = eNEstudiante.Nombres;
    //            string PrimerApellido = eNEstudiante.PrimerApellido;
    //            string SegundoApellido = eNEstudiante.SegundoApellido;



    //            ePPasantiaCompleja.Id_Pasantia = ePPasantiaSimple.Id_Pasantia;
    //            ePPasantiaCompleja.Id_Postulacion = ePPasantiaSimple.Id_Postulacion;


    //            ePPasantiaCompleja.Id_Estudiante = ePInstitucionSimple.PrimerApellidoResponsable;
    //            ePPasantiaCompleja.Nombres = ePInstitucionSimple.SegundoApellidoResponsable;
    //            ePPasantiaCompleja.PrimerApellido = ePInstitucionSimple.CargoResponsable;
    //            ePPasantiaCompleja.SegundoApellido = ePInstitucionSimple.NombreInstitucion;



    //            ePPasantiaCompleja.Id_Modalidad = ePInstitucionSimple.DireccionInstitucion;
    //            ePPasantiaCompleja.NombreModalidad = ePInstitucionSimple.TelefonoInstitucion;


    //            ePPasantiaCompleja.ID_Horario = ePInstitucionSimple.CorreoInstitucion;
    //            ePPasantiaCompleja.CantidadHoras = ePInstitucionSimple.Id_Ciudad;


    //            ePPasantiaCompleja.Id_Institucion = Ciudad;
    //            ePPasantiaCompleja.NombreInstitucion = Ciudad;



    //            ePPasantiaCompleja.FechaInicioPasantia = ePPasantiaSimple.FechaInicioPasantia;
    //            ePPasantiaCompleja.Estado = ePPasantiaSimple.Estado;
    //            ePPasantiaCompleja.FechaRegistro = ePPasantiaSimple.FechaRegistro;
    //            ePPasantiaCompleja.FechaModificacion = ePPasantiaSimple.FechaModificacion;





    //            Id_Pasantia = string.Empty;
    //            Id_Postulacion = string.Empty;
    //            Id_Estudiante = string.Empty;
    //            Nombres = string.Empty;
    //            PrimerApellido = string.Empty;
    //            SegundoApellido = string.Empty;


    //            Id_Modalidad = string.Empty;
    //            NombreModalidad = string.Empty;
    //            ID_Horario = string.Empty;
    //            CantidadHoras = string.Empty;
    //            Id_Institucion = string.Empty;
    //            NombreInstitucion = string.Empty;
    //            FechaInicioPasantia = DateTime.MinValue;
    //            Estado = string.Empty;
    //            FechaRegistro = DateTime.MinValue;
    //            FechaModificacion = DateTime.MinValue;
    //        }


    //        return lstPInstitucionCompleja;
    //    }
    //    catch (Exception Ex)
    //    {

    //        throw Ex;
    //    }
    //}
    //public EPInstitucionCompleja Obtener_PInstitucion_Id_Institucion(string Id_Institucion)
    //{
    //    try
    //    {
    //        List<EPInstitucionSimple> lstPInstitucionSimple = new List<EPInstitucionSimple>();
    //        List<EPInstitucionCompleja> lstPInstitucionCompleja = new List<EPInstitucionCompleja>();
    //        EPInstitucionCompleja ePInstitucionCompleja = new EPInstitucionCompleja();
    //        EPInstitucionSimple ePInstitucionSimple = new EPInstitucionSimple();
    //        ePInstitucionSimple = asNetPas.Obtener_PInstitucion_Id_Institucion(Id_Institucion);
    //        //AQUI TENDRIA QUE IR ENTIDAD CIUDAD Y OBTENER CIUDAD
    //        //////////////////////////////////
    //        //SIMULAMOS LA CIUDAD
    //        string Ciudad = "Cochabamba";
    //        ePInstitucionCompleja.Id_Institucion = ePInstitucionSimple.Id_Institucion;
    //        ePInstitucionCompleja.NombreResponsable = ePInstitucionSimple.NombreResponsable;
    //        ePInstitucionCompleja.PrimerApellidoResponsable = ePInstitucionSimple.PrimerApellidoResponsable;
    //        ePInstitucionCompleja.SegundoApellidoResponsable = ePInstitucionSimple.SegundoApellidoResponsable;
    //        ePInstitucionCompleja.CargoResponsable = ePInstitucionSimple.CargoResponsable;
    //        ePInstitucionCompleja.NombreInstitucion = ePInstitucionSimple.NombreInstitucion;
    //        ePInstitucionCompleja.DireccionInstitucion = ePInstitucionSimple.DireccionInstitucion;
    //        ePInstitucionCompleja.TelefonoInstitucion = ePInstitucionSimple.TelefonoInstitucion;
    //        ePInstitucionCompleja.CorreoInstitucion = ePInstitucionSimple.CorreoInstitucion;
    //        ePInstitucionCompleja.Id_Ciudad = ePInstitucionSimple.Id_Ciudad;
    //        ePInstitucionCompleja.NombreCiudad = Ciudad;
    //        ePInstitucionCompleja.Estado = ePInstitucionSimple.Estado;
    //        ePInstitucionCompleja.FechaRegistro = ePInstitucionSimple.FechaRegistro;
    //        ePInstitucionCompleja.FechaModificacion = ePInstitucionSimple.FechaModificacion;
    //        return ePInstitucionCompleja;

    //    }
    //    catch (Exception Ex)
    //    {

    //        throw Ex;
    //    }
    //}

    #endregion
    #endregion
}