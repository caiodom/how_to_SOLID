
namespace DependencyInversionPrinciple_VIOLATION;

// Notification service depends directly on concrete classes (EmailService, SmsService)
public class NotificationService
{
    private EmailService _emailService;
    private SmsService _smsService;

    public NotificationService()
    {
        _emailService = new EmailService(); // Direct dependency
        _smsService = new SmsService(); // Direct dependency
    }

    public void SendEmail(string message)
    {
        _emailService.SendEmail(message);
    }

    public void SendSms(string message)
    {
        _smsService.SendSms(message);
    }
}
