namespace Solid.DIP._1;

public interface IDatabase
{
    public IList<Order> FetchOrders(int customerId);
}