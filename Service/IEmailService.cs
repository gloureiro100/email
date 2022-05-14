using Models;

namespace Service;
public interface IEmailService
{
  Task Send(Notification notification);
}