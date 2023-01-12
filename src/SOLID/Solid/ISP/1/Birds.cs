namespace Solid.ISP._1;

public interface IBird
{
    public void Fly();
}

public class Starling : IBird
{
    public void Fly()
    {
        // cause the starling to fly
    }
}

public class Penguin : IBird
{
    public void Fly()
    {
        throw new Exception("Penguins cannot fly");
    }
}