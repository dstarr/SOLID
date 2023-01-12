namespace Solid.DIP._1;

public class Order
{
    public Order(Guid id, string customerEmail, string customerName)
    {
        Id = id;
        CustomerEmail = customerEmail;
        CustomerName = customerName;
    }

    public Guid Id { get; init; }

    public string CustomerEmail { get; init; } 
    
    public string CustomerName { get; init; }

    public bool IsValid()
    {
        // internal check to see if I am valid
        return true;
    }
}