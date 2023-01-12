namespace Solid.LSP._1;

public class Bird
{
    public void Fly()
    {
        // cause the bird to fly
    }
}

public class Starling : Bird
{
    public new void Fly()
    {
        // cause the starling to fly
    }
}

public class Penguin : Bird
{
    public new void Fly()
    {
        throw new Exception("Penguins cannot fly");
    }
}