namespace Solid.OCP._2;

public class DataFileProcessor
{
    public DataFileProcessor(IFileProcessor fileProcessor, string filePath)
    {
        fileProcessor.ProcessFile(filePath);
    }
}