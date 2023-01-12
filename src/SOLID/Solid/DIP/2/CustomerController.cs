namespace Solid.DIP._2;

public class CustomerController
{
    private readonly IDatabase _database;

    public CustomerController(IDatabase database)
    {
        _database = database;
    }

    public IList<Order> GetOrders(int customerId)
    {
        return _database.LoadOrders(customerId);
        
    }
}
