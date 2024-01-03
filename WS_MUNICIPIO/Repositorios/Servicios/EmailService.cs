using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace WS_MUNICIPIO.Repositorios.Servicios
{
    public class EmailService : IIdentityMessageService
    {
        private SmtpClient _cliente = new SmtpClient();
        private string _servidor;
        private int _puerto;
        private string _usuario;
        private string _clave;
        private string _correoERP;
        private string _displayName;
        public EmailService()
        {
            _servidor = ConfigurationManager.AppSettings["ERP_MAIL_HOST"];
            _usuario = ConfigurationManager.AppSettings["ERP_MAIL_USER"];
            _clave = ConfigurationManager.AppSettings["ERP_MAIL_PASS"];
            _correoERP = ConfigurationManager.AppSettings["ERP_MAIL"];
            _displayName = ConfigurationManager.AppSettings["ERP_MAIL_DISPLAY_NAME"];
            string strPuerto = ConfigurationManager.AppSettings["ERP_MAIL_PORT"];
            if (!int.TryParse(strPuerto, out _puerto))
            {
                throw new SmtpException("Error en puerto, configuracion App.config");
            }

            _cliente.Host = _servidor;
            _cliente.Port = _puerto;
            _cliente.UseDefaultCredentials = false;
            _cliente.Credentials = new NetworkCredential(_usuario, _clave);
            _cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            _cliente.EnableSsl = false;
        }
        public EmailService(string usuario, string correoOrigen, string alias, string password)
        {
            _servidor = ConfigurationManager.AppSettings["ERP_MAIL_HOST"];
            _usuario = usuario;
            _clave = password;
            _correoERP = correoOrigen;
            _displayName = alias;

            string strPuerto = ConfigurationManager.AppSettings["ERP_MAIL_PORT"];
            if (!int.TryParse(strPuerto, out _puerto))
            {
                throw new SmtpException("Error en puerto, configuracion App.config");
            }

            _cliente.Host = _servidor;
            _cliente.Port = _puerto;
            _cliente.UseDefaultCredentials = false;
            _cliente.Credentials = new NetworkCredential(_usuario, _clave);
            _cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            _cliente.EnableSsl = false;
        }
        public Task SendAsync(IdentityMessage message)
        {
            return Enviar(message.Destination
                , message.Subject
                , message.Body);
        }

        private Task Enviar(string destinatario, string asunto, string contenido)
        {
            return Enviar(destinatario, asunto, contenido, null, null);
        }
        public Task Enviar(
          string destinatario
        , string asunto
        , string contenido
        , List<Attachment> adjuntos
        , string remitente)
        {
            return Enviar(destinatario, asunto, contenido, adjuntos, remitente, null);
        }


        public Task Enviar(
              string destinatario
            , string asunto
            , string contenido
            , List<Attachment> adjuntos
            , string remitente
            , string cc)
        {
            try
            {
                string vt_remitente = remitente;
                string vt_cc = cc;

                if (string.IsNullOrEmpty(vt_remitente))
                {
                    vt_remitente = _correoERP;
                }

                MailAddress correoDestinatario = new MailAddress(destinatario);
                MailAddress correoRemitente = new MailAddress(vt_remitente, _displayName);

                MailMessage msg = new MailMessage();
                msg.IsBodyHtml = true;

                if (adjuntos != null)
                {
                    foreach (Attachment adjunto in adjuntos)
                    {
                        msg.Attachments.Add(adjunto);
                    }
                }

                msg.Subject = asunto;
                msg.Body = contenido;
                msg.From = correoRemitente;
                if (!string.IsNullOrEmpty(vt_cc))
                {
                    msg.CC.Add(vt_cc);
                }
                msg.To.Add(correoDestinatario);

                return _cliente.SendMailAsync(msg);
            }
            catch (Exception exc)
            {
                throw new SmtpException(exc.Message);
            }
        }
    }
}