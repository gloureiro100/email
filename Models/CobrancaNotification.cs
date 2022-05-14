namespace Models;

public class CobrancaNotification : Notification
{
  public CobrancaNotification(string from, string to, string devedor)
  {
    this.Subject = $"Pague o que Deve {devedor} !!!";
    this.From = from;
    this.To = to;
    this.Content = $@"
      Boa Tarde, {devedor}.
      Venho por meio desta informar que você está devendo R$ 1.000.000,00 para o Gabriel.
    ";
  }
}