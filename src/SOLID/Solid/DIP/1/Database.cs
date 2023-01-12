namespace Solid.DIP._1;

public class Database : IDatabase
{
    public IList<Order> FetchOrders(int customerId)
    {
        return new List<Order>();
    } 
}