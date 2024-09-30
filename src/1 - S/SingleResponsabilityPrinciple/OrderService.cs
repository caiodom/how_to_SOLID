namespace SingleResponsabilityPrinciple;

public class OrderService(OrderValidator validator, OrderItemValidator itemValidator, OrderCalculator calculator, OrderRepository repository, EmailService emailService)
{
    public void ProcessOrder(Order order)
    {
        validator.Validate(order);
        order.Items.ForEach(item=>itemValidator.Validate(item));   
        calculator.CalculateTotal(order);
        repository.Save(order);
        emailService.SendConfirmationEmail(order.CustomerEmail);
    }
}
