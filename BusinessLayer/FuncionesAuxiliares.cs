using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class FuncionesAuxiliares
    {
        public static void LimpiarTextbox(Control c)
        {
            foreach (Control tb in c.Controls)
            {
                if (tb is TextBox)
                {
                    tb.Text = string.Empty;
                }
            }
        }

        public static void HabilitarTextbox(Control c, bool habilitar)
        {
            foreach (Control tb in c.Controls)
            {
                if (tb is TextBox)
                {
                    tb.Enabled = habilitar;
                }
            }            
        }

        public static bool EnviarCorreo(string smtpServer, int port, string mailFrom, string mailTo, string subject, string mailBody, string user, string password)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(smtpServer);

                mail.From = new MailAddress(mailFrom);
                mail.To.Add(mailTo);
                mail.Subject = subject;
                mail.Body = mailBody;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(user, password);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);


                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje del sistema [" + ex.GetType().ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
