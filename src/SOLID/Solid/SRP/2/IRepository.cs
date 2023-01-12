namespace Solid.SRP._2;

internal interface IRepository<T>
{
    public void Save(T entity);
}