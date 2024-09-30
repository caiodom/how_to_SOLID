using DependencyInversionPrinciple_VIOLATION;

// Creating NotificationService directly depending on EmailService
NotificationService notificationService = new NotificationService();

// Sending Email Notification
notificationService.SendEmail("Hello via Email");

// Sending SMS Notification
notificationService.SendSms("Hello via SMS");