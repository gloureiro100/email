namespace Models;
public class AniversarioNotification : Notification
{
  public AniversarioNotification(string from, string to, string nomeAniversariante)
  {
    this.Subject = $"Feliz Aniversário {nomeAniversariante} !!!";
    this.From = from;
    this.To = to;
    this.Content = $@"
    Feliz Aniversário {nomeAniversariante} !!!
    Parabéns por mais um ano de vida!";
  }
}