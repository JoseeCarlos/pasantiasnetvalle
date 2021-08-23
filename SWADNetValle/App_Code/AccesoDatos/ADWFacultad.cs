using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADWFacultad
/// </summary>
public class ADWFacultad
{
    public ADWFacultad()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public DTONFacultad Obtener_NFacultad_Id_Facultad(string Id_Facultad)
    {
        DTONFacultad dtoNFacultad = new DTONFacultad();
        try
        {
            Database DBSWADNETVALLE = SBaseDatos.BDSWADNETValle;
            DbCommand dbCommand = DBSWADNETVALLE.GetStoredProcCommand("NFacultad_O_Id_Facultad");
            DBSWADNETVALLE.AddInParameter(dbCommand, "Id_Facultad", DbType.String, Id_Facultad);
            DBSWADNETVALLE.LoadDataSet(dbCommand, dtoNFacultad, "WFacultad");
        }
        catch (Exception ex)
        {

            throw;
        }
        return dtoNFacultad;
    }
    public DTONFacultad Obtener_NFacultad()
    {
        DTONFacultad dtoNFacultad = new DTONFacultad();
        try
        {
            Database DBSWADNETVALLE = SBaseDatos.BDSWADNETValle;
            DbCommand dbCommand = DBSWADNETVALLE.GetStoredProcCommand("NFacultad_O");
            DBSWADNETVALLE.LoadDataSet(dbCommand, dtoNFacultad, "WFacultad");
        }
        catch (Exception ex)
        {

            throw;
        }
        return dtoNFacultad;
    }

    public List<Facultad> ObetenerFacultad()
    {
        List<Facultad> pas = new List<Facultad>();
        Facultad p = null;
        Database BDSWADNETPAS = SBaseDatos.BDSWADNETValle;
        DbCommand cmd = null;

        try
        {
            cmd = BDSWADNETPAS.GetStoredProcCommand("ReporteFacultad");
            

            using (IDataReader dr = BDSWADNETPAS.ExecuteReader(cmd))
            {
                while (dr.Read())
                {
                    p = new Facultad(int.Parse(dr[0].ToString()), dr[1].ToString());
                    pas.Add(p);
                }

                dr.Close();
            }




        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {


        }

        return pas;

    }
    public List<Facultad> ObetenerFacultadFa(string facultad)
    {
        List<Facultad> pas = new List<Facultad>();
        Facultad p = null;
        Database BDSWADNETPAS = SBaseDatos.BDSWADNETValle;
        DbCommand cmd = null;

        try
        {
            cmd = BDSWADNETPAS.GetStoredProcCommand("ReporteFacultadFa");
            BDSWADNETPAS.AddInParameter(cmd, "facultad", DbType.String, facultad);

            using (IDataReader dr = BDSWADNETPAS.ExecuteReader(cmd))
            {
                while (dr.Read())
                {
                    p = new Facultad(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString());
                    pas.Add(p);
                }

                dr.Close();
            }




        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {


        }

        return pas;

    }
}