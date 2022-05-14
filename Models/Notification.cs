namespace Models;

public abstract class Notification
{
  public string From { get; set; }
  public string To { get; set; }
  public string Subject { get; set; }
  public string Content { get; set; }
}