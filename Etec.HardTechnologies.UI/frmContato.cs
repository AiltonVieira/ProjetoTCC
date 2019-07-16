using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;


namespace Etec.HardTechnologies.UI
{
    public partial class frmContato : Form
    {
        public frmContato()
        {
            InitializeComponent();
        }

        private MailMessage Email;
        Stopwatch Stop = new Stopwatch();
        SmtpClient client;
        string userstate = "Enviando...";

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Email = new MailMessage();
            Email.To.Add(new MailAddress(txtPara.Text));
            Email.CC.Add(new MailAddress(txtCC.Text));
            Email.Subject = txtAssunto.Text;
            Email.From = new MailAddress(txtEmail.Text);
            Email.IsBodyHtml = true;
            Email.Body = txtMensagem.Text;
            Email.BodyEncoding = Encoding.UTF8;
            Email.Priority = MailPriority.Normal;
            Email.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            
            if (cmbPorta.Text == "hotmail")
            {
                SmtpClient cliente = new SmtpClient("smtp.live.com", 587);
                using (cliente)
                {
                    cliente.Credentials = new NetworkCredential(txtEmail.Text, txtSenha.Text);
                    cliente.EnableSsl = true;
                    cliente.Send(Email);
                    cliente.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                    cliente.SendAsync(Email, userstate);
                }
            }
            else
            {
                SmtpClient clientegmail = new SmtpClient("smtp.gmail.com", 587);
                using (clientegmail)
                {
                    clientegmail.Credentials = new NetworkCredential(txtEmail.Text, txtSenha.Text);
                    clientegmail.EnableSsl = true;
                    clientegmail.Send(Email);
                    clientegmail.SendAsync(Email, userstate);
                }

            }

        }

        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show(string.Format("{0} envio cancelado.", e.UserState), "Mensagem", MessageBoxButtons.OK);
            }
            if (e.Error != null)
            {
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Mensagem", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Sua mensagem foi enviada com sucesso.", "Mensagem", MessageBoxButtons.OK);
            }
                
        }

        private void frmContato_Load(object sender, EventArgs e)
        {

        }
    }
}
