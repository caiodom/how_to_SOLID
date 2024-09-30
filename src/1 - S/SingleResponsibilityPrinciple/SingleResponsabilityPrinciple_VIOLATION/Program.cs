using SingleResponsabilityPrinciple_VIOLATION.Models;
using SingleResponsabilityPrinciple_VIOLATION.Services;

var order = new Order
{
    CustomerEmail = "customer@example.com",
    Items = new List<OrderItem>
            {
                new OrderItem { ProductName = "Product 1", Price = 10.00m, Quantity = 2 },
                new OrderItem { ProductName = "Product 2", Price = 15.00m, Quantity = 1 }
            }
};


OrderService orderService = new OrderService();
orderService.ProcessOrder(order);


Console.WriteLine($"Order total: {order.Total}");