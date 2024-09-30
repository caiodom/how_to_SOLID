
using DependencyInversionPrinciple;

// Sending Email notification
INotificationSender emailService = new EmailService();
NotificationService emailNotification = new NotificationService(emailService);
emailNotification.SendNotification("Hello via Email");

// Sending SMS notification
INotificationSender smsService = new SmsService();
NotificationService smsNotification = new NotificationService(smsService);
smsNotification.SendNotification("Hello via SMS");