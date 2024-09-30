namespace SingleResponsabilityPrinciple.Services;
public class EmailService
{
    public void SendConfirmationEmail(string customerEmail)
    {
        Console.WriteLine($"Confirmation email sent to {customerEmail}.");
    }
}



