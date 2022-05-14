using Models;
using Service;

var remetente = Constants.EmailAddress;
var destinatario = "user@domain.com";
var evento = "Bootcamp Reserva";

IEmailService mailService = new EmailService();

// var mensagem = new AniversarioNotification(
//   "",
//   "",
//   "");

// var mensagem = new CobrancaNotification(
//   "",
//   "",
//   "");

var mensagem = new EventoNotification(
  remetente, destinatario, evento, DateTime.Now);

await mailService.Send(mensagem);
