namespace SingleResponsabilityPrinciple_VIOLATION;

public class OrderService
{
        public void ProcessOrder(Order order)
        {
            // Order validation
            if (order.Items == null || order.Items.Count == 0)
            {
                throw new InvalidOperationException("Order must contain at least one item.");
            }

            if (order.CustomerEmail == null || !order.CustomerEmail.Contains("@"))
            {
                throw new InvalidOperationException("Invalid customer email.");
            }

            // Total calculation
            decimal total = 0;
            foreach (var item in order.Items)
            {
                total += item.Price * item.Quantity;
            }
            order.Total = total;

            // Saving to database
            SaveOrderToDatabase(order);

            // Sending confirmation email
            SendConfirmationEmail(order.CustomerEmail);
        }

        private void SaveOrderToDatabase(Order order)
        {
            Console.WriteLine("Order saved to the database.");
        }

        private void SendConfirmationEmail(string customerEmail)
        {
            Console.WriteLine($"Confirmation email sent to {customerEmail}.");
        }
    }

   
