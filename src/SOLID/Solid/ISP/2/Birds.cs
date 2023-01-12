namespace Solid.ISP._2;

public interface IBird
{
    public void Move();
}

public class Starling : IBird
{
    public void Move()
    {
        // cause the starling to move by flying
    }
}

public class Penguin : IBird
{
    public void Move()
    {
        // cause the penguin to move by walking or swimming
    }
}