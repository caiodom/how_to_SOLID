using SingleResponsabilityPrinciple;

var items = new List<OrderItem>
        {
            new OrderItem("Product 1", 10.00m, 2),
            new OrderItem("Product 2", 15.00m, 1)
        };

var order = new Order("customer@example.com", items);


var orderValidator = new OrderValidator();
var orderItemValidator = new OrderItemValidator();
var orderCalculator = new OrderCalculator();
var orderRepository = new OrderRepository();
var emailService = new EmailService();


var orderService = new OrderService(orderValidator, orderItemValidator, orderCalculator, orderRepository, emailService);
orderService.ProcessOrder(order);


Console.WriteLine($"Order total: {order.Total}");