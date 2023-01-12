namespace Solid.DIP._1;

public class CustomerController
{
    public IList<Order> GetOrders(int customerId)
    {
        IDatabase db = new Database();

        return db.FetchOrders(customerId);
    }
}