namespace Solid.DIP._2;

public interface IDatabase
{
    IList<Order> LoadOrders(int customerController);
}