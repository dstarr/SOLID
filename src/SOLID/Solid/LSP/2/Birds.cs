namespace Solid.LSP._2;

public class Bird
{
    public void Move()
    {
        // cause the bird to move
    }
}

public class Starling : Bird
{
    public new void Move()
    {
        // cause the starling to move by flying
    }
}

public class Penguin : Bird
{
    public new void Move()
    {
        // cause the penguin to move by walking or swimming
    }
}