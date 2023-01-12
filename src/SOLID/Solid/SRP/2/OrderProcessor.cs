namespace Solid.SRP._2;

class OrderProcessor
{
    public void ProcessOrder(Order order, IRepository<Order> ordeRepository, EmailService emailService, NotificationService notificationService)
    {
        // Validate the order
        if (order.IsValid())
        {
            // Save the order to the database
            // using a repository class
            ordeRepository.Save(order);           

            // Send a confirmation email
            // using an email service
            emailService.SendConfirmationEmail(order);

            // Send a notification to the warehouse
            // using notification service
            notificationService.SendNotification(order, Departments.Warehouse);
        }
    }
}