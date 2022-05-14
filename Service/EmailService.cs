using System.Net.Mail;
using Models;

namespace Service;

public class EmailService : IEmailService
{
  public async Task Send(Notification notification)
  {
    MailMessage mailMessage = new MailMessage();

    mailMessage.From = new MailAddress(notification.From);
    mailMessage.To.Add(notification.To);
    mailMessage.Subject = notification.Subject;
    mailMessage.Body = notification.Content;

    using (var smtp = new SmtpClient("smtp.gmail.com"))
    {
      smtp.EnableSsl = true; // GMail requer SSL
      smtp.Port = 587;       // porta para SSL
      smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
      smtp.UseDefaultCredentials = false; // vamos utilizar credencias especificas

      // seu usuário e senha para autenticação
      smtp.Credentials = new System.Net.NetworkCredential(Constants.EmailAddress, Constants.Senha);

      // envia o e-mail
      smtp.Send(mailMessage);
    }
  }
}