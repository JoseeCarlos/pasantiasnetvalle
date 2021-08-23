using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WAPasantia.Reportes;
using WAPasantia.SWLNPasantia;

namespace WAPasantia.WebForm
{
    public partial class PReportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ReportG_Click(object sender, EventArgs e)
        {

            SWLNPasantiaClient cl = new SWLNPasantiaClient();
            List<PasantiasCompleja>ls= cl.ObtenerPasantias().ToList();
            List<CiudadCom> lc = cl.ObtenerCiudad().ToList();
            List<FacultadCom> lf = cl.ObtenerFacultas().ToList();
            List<Reporte1> listR = new List<Reporte1>();
            Reporte1 r = null;

            var result = from pa in ls
                         join ci in lc on pa.IdSedeAcademica equals ci.IdSedeAcademica
                         join fa in lf on pa.IdEstudiante equals fa.IdEstudiante
                         group pa by new
                         {
                             ci.NombreSede,
                             fa.NombreFacultad
                         } into g
                         select new
                         {
                             todo = g.Key,
                             total = g.Count()
                         };


            foreach (var item in result)
            {
                r = new Reporte1(item.todo.NombreSede, item.todo.NombreFacultad, item.total);
                listR.Add(r);

            }
            DataTable dt = ConvertToDataTable<Reporte1>(listR);
            dg1.DataSource = dt;
            dg1.DataBind();

            ReportDocument rp = new ReportDocument();
            rp.Load(Server.MapPath("../Reportes/ReporteGeneral.rpt"));
            rp.Database.Tables["Reporte"].SetDataSource(dt);
            rp.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "person information");


        }

        protected void ReportGFECHA_Click(object sender, EventArgs e)
        {
            if (txtyear.Text != "")
            {
                int year = int.Parse(txtyear.Text);
                DateTime primerDia = new DateTime(year, 1, 1);
                DateTime ultimoDIa = primerDia.AddYears(1).AddTicks(-1);
                SWLNPasantiaClient cl = new SWLNPasantiaClient();
                List<PasantiasCompleja> ls = cl.ObtenerPasantiasFecha(primerDia,ultimoDIa).ToList();
                List<CiudadCom> lc = cl.ObtenerCiudad().ToList();
                List<FacultadCom> lf = cl.ObtenerFacultas().ToList();
                List<Reporte1> listR = new List<Reporte1>();
                Reporte1 r = null;

                var result = from pa in ls
                             join ci in lc on pa.IdSedeAcademica equals ci.IdSedeAcademica
                             join fa in lf on pa.IdEstudiante equals fa.IdEstudiante
                             group pa by new
                             {
                                 ci.NombreSede,
                                 fa.NombreFacultad
                             } into g
                             select new
                             {
                                 todo = g.Key,
                                 total = g.Count()
                             };


                foreach (var item in result)
                {
                    r = new Reporte1(item.todo.NombreSede, item.todo.NombreFacultad, item.total);
                    listR.Add(r);

                }
                DataTable dt = ConvertToDataTable<Reporte1>(listR);
                dg1.DataSource = dt;
                dg1.DataBind();


                ReportDocument rp = new ReportDocument();

                rp.Load(Server.MapPath("../Reportes/RGeneralFecha.rpt"));
                rp.Database.Tables["Reporte"].SetDataSource(dt);
                rp.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "person information");
            }


        }

        protected void ReportFac_Click(object sender, EventArgs e)
        {
            if (cbFacultad1.Text != "")
            {

                SWLNPasantiaClient cl = new SWLNPasantiaClient();

                List<PasantiasCompleja> ls = cl.ObtenerPasantias().ToList();
                List<CiudadCom> lc = cl.ObtenerCiudad().ToList();
                List<FacultadCom> lf = cl.ObtenerFacultasFa(cbFacultad1.Text).ToList();
                List<Reporte1> listR = new List<Reporte1>();
                Reporte1 r = null;

                var result = from pa in ls
                             join ci in lc on pa.IdSedeAcademica equals ci.IdSedeAcademica
                             join fa in lf on pa.IdEstudiante equals fa.IdEstudiante
                             group pa by new
                             {
                                 ci.NombreSede,
                                 fa.NombreFacultad,
                                 pa.NombreModalidad,
                                 fa.NombeCarrera,
                             } into g
                             select new
                             {
                                 todo = g.Key,
                                 total = g.Count()
                             };


                foreach (var item in result)
                {
                    r = new Reporte1(item.todo.NombreSede, item.todo.NombreFacultad, item.total,item.todo.NombeCarrera,item.todo.NombreModalidad);
                    listR.Add(r);

                }
                DataTable dt = ConvertToDataTable<Reporte1>(listR);
                dg1.DataSource = dt;
                dg1.DataBind();
                ReportDocument rp = new ReportDocument();
                rp.Load(Server.MapPath("../Reportes/ReporteFacultad.rpt"));
                rp.Database.Tables["Reporte"].SetDataSource(dt);
                rp.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "person information");

            }
        }

        protected void ReporteFacFecha_Click(object sender, EventArgs e)
        {
            if (CbFacultad2.Text != "")
            {
                if (txtyear2.Text != "")
                {
                    string facultad = CbFacultad2.Text;
                    int year = int.Parse(txtyear2.Text);
                    DateTime primerDia = new DateTime(year, 1, 1);
                    DateTime ultimoDIa = primerDia.AddYears(1).AddTicks(-1);

                    SWLNPasantiaClient cl = new SWLNPasantiaClient();

                    List<PasantiasCompleja> ls = cl.ObtenerPasantiasFecha(primerDia,ultimoDIa).ToList();
                    List<CiudadCom> lc = cl.ObtenerCiudad().ToList();
                    List<FacultadCom> lf = cl.ObtenerFacultasFa(CbFacultad2.Text).ToList();
                    List<Reporte1> listR = new List<Reporte1>();
                    Reporte1 r = null;

                    var result = from pa in ls
                                 join ci in lc on pa.IdSedeAcademica equals ci.IdSedeAcademica
                                 join fa in lf on pa.IdEstudiante equals fa.IdEstudiante
                                 group pa by new
                                 {
                                     ci.NombreSede,
                                     fa.NombreFacultad,
                                     pa.NombreModalidad,
                                     fa.NombeCarrera
                                 } into g
                                 select new
                                 {
                                     todo = g.Key,
                                     total = g.Count()
                                 };


                    foreach (var item in result)
                    {
                        r = new Reporte1(item.todo.NombreSede, item.todo.NombreModalidad, item.total,item.todo.NombeCarrera,item.todo.NombreFacultad);
                        listR.Add(r);

                    }
                    DataTable dt = ConvertToDataTable<Reporte1>(listR);
                    dg1.DataSource = dt;
                    dg1.DataBind();

                    ReportDocument rp = new ReportDocument();
                    rp.Load(Server.MapPath("../Reportes/RFacultadFecha.rpt"));
                    rp.Database.Tables["Reporte"].SetDataSource(dt);
                    rp.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "person information");
                }

            }

        }
        public DataTable ConvertToDataTable<T>(IList<Reporte1> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));

            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            }

            foreach (Reporte1 item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }
            return table;
        }
    }
}