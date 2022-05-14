namespace Models;
public class EventoNotification : Notification
{
  public EventoNotification(string from, string to, string tipoEvento, DateTime horario)
  {
    this.Subject = $"Você foi conviado para o Evento {tipoEvento} - {horario}";
    this.From = from;
    this.To = to;
    this.Content = $@"O evento {tipoEvento} irá ocorrer no seguinte horário {horario}.
    Contamos com a sua presença!";
  }
}