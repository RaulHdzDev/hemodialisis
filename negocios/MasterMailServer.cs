using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talent.negocios
{
    class MasterMailServer
    {
        private SmtpClient smtpClient;
        protected string senderMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected void inicializarSmtpCliente()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
        }

        public void enviarMail(string asunto, string cuerpo, List<string> correodestinatario)
        {
            var mensajeCorreo = new MailMessage();
            try
            {
                mensajeCorreo.From = new MailAddress(senderMail);
                foreach (string mail in correodestinatario)
                {
                    mensajeCorreo.To.Add(mail);
                }
                mensajeCorreo.Subject = asunto;
                mensajeCorreo.Body = cuerpo;
                mensajeCorreo.Priority = MailPriority.Normal;
                smtpClient.Send(mensajeCorreo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mensajeCorreo.Dispose();
                smtpClient.Dispose();
            }
        }
    }
}
