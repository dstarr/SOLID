namespace Solid.SRP._1;

class OrderProcessor
{
    public void ProcessOrder(Order order)
    {
        // Validate the order
        if (order.IsValid())
        {
            // Save the order to the database
            order.Save();

            // Send a confirmation email
            SendConfirmationEmail(order.CustomerEmail);

            // Send a notification to the warehouse
            SendWarehouseNotification(order);
        }
    }

    private void SendConfirmationEmail(string email)
    {
        // Code to send email
    }

    private void SendWarehouseNotification(Order order)
    {
        // Code to send notification
    }
}