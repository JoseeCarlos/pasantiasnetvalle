using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.IO;

namespace WAPasantia.Email
{
    public class Correo
    {

        #region Email Aceptado
        public bool EnviarCorreo_A(string mail, string fullName, string pathPDF)
        {
            bool res = true;
            MailMessage mmsg = new MailMessage();
            mmsg.To.Add(mail);
            mmsg.Subject = "UNIVALLE DEPARTAMENTO DE RELACIONES INTERNACIONALES";
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
            mmsg.Body = _CreateBody(fullName);
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.From = new MailAddress("univalle.edu.bo@gmail.com");
            mmsg.Attachments.Add(new Attachment(pathPDF));
            SmtpClient cliente = new SmtpClient();
            cliente.Credentials = new NetworkCredential("univalle.edu.bo@gmail.com", "univalle12");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";
            try
            {
                cliente.Send(mmsg);
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }
        #endregion
        #region Email Rechazado
        public bool EnviarCorreo_R(string mail, string fullname, string reason)
        {
            bool res = true;
            MailMessage mmsg = new MailMessage();
            mmsg.To.Add(mail);
            mmsg.Subject = "UNIVALLE DEPARTAMENTO DE RELACIONES INTERNACIONALES";
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.Body = _CreateBody(fullname, reason);
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.From = new MailAddress("univalle.edu.bo@gmail.com");
            SmtpClient cliente = new SmtpClient();
            cliente.Credentials = new NetworkCredential("univalle.edu.bo@gmail.com", "univalle12");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";
            try
            {
                cliente.Send(mmsg);
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }
        #endregion
        #region Email Confirmar Solicitud de Pasantia
        public bool EnviarCorreo_Confirmar(string mail, string fullName)
        {
            bool res = true;
            MailMessage mmsg = new MailMessage();
            mmsg.To.Add(mail);
            mmsg.Subject = "SOLICITUD DE PRÁCTICA PROFESIONAL Y/O MODALIDAD DE TITULACIÓN";
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
            mmsg.Body = CuerpoDeLaCarta(fullName);
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.From = new MailAddress("univalle.edu.bo@gmail.com");
            SmtpClient cliente = new SmtpClient();
            cliente.Credentials = new NetworkCredential("univalle.edu.bo@gmail.com", "univalle12");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";
            try
            {
                cliente.Send(mmsg);
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }
        #endregion
        #region Email Aceptado Horas
        public bool EnviarCorreo_Horas(string mail, string fullName)
        {
            bool res = true;
            MailMessage mmsg = new MailMessage();
            mmsg.To.Add(mail);
            mmsg.Subject = "SOLICITUD DE PRÁCTICA PROFESIONAL ACEPTADA";
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
            mmsg.Body = _CreateBodyHoras(fullName);
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.From = new MailAddress("univalle.edu.bo@gmail.com");
            SmtpClient cliente = new SmtpClient();
            cliente.Credentials = new NetworkCredential("univalle.edu.bo@gmail.com", "univalle12");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";
            try
            {
                cliente.Send(mmsg);
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }
        #endregion
        #region Email Carta Aceptacion
        public bool EnviarCorreo_CartaAceptacion(string mail, string fullName, string pathPDF)
        {
            bool res = true;
            MailMessage mmsg = new MailMessage();
            mmsg.To.Add(mail);
            mmsg.Subject = "UNIVALLE CARTA DE ACEPTACIÓN";
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
            mmsg.Body = CuerpoCartaAceptacion(fullName);
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.From = new MailAddress("univalle.edu.bo@gmail.com");
            mmsg.Attachments.Add(new Attachment(pathPDF));
            SmtpClient cliente = new SmtpClient();
            cliente.Credentials = new NetworkCredential("univalle.edu.bo@gmail.com", "univalle12");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";
            try
            {
                cliente.Send(mmsg);
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }
        #endregion
        #region Cuerpo del email Aceptado
        private string _CreateBody(string fullname)
        {
            string body = string.Empty;
            using (StreamReader reader = new StreamReader(System.Web.HttpContext.Current.Server.MapPath("../Email/EmailAceptado.html")))
            {

                body = reader.ReadToEnd();

            }
            body = body.Replace("{nombre}", fullname);

            return body;

        }
        #endregion
        #region Cuerpo Email Rechazado
        private string _CreateBody(string fullname, string reason)
        {
            string body = string.Empty;
            using (StreamReader reader = new StreamReader(System.Web.HttpContext.Current.Server.MapPath("../Email/EmailRechazado.html")))
            {

                body = reader.ReadToEnd();

            }

            body = body.Replace("{nombre}", fullname);
            body = body.Replace("{motivo}", reason);
            return body;

        }
        #endregion
        #region Cuerpo Email Confirmar Solicitud de Pasantia
        private string CuerpoDeLaCarta(string fullname)
        {
            string body = string.Empty;
            using (StreamReader reader = new StreamReader(HttpContext.Current.Server.MapPath("../Email/CORREO.html")))
            {
                body = reader.ReadToEnd();
            }
            body = body.Replace("{nombre}", fullname);

            return body;

        }
        #endregion
        #region Cuerpo del Email Aceptado Horas
        private string _CreateBodyHoras(string fullname)
        {
            string body = string.Empty;
            using (StreamReader reader = new StreamReader(System.Web.HttpContext.Current.Server.MapPath("../Email/EmailHoras.html")))
            {

                body = reader.ReadToEnd();

            }
            body = body.Replace("{nombre}", fullname);

            return body;

        }
        #endregion
        #region Cuerpo del Email Carta Aceptacion
        private string CuerpoCartaAceptacion(string fullname)
        {
            string body = string.Empty;
            using (StreamReader reader = new StreamReader(System.Web.HttpContext.Current.Server.MapPath("../Email/EmailCartaAceptacion.html")))
            {

                body = reader.ReadToEnd();

            }
            body = body.Replace("{nombre}", fullname);

            return body;

        }
        #endregion
    }
}