namespace EvaluationList.Core.FileHandler;

public interface IFileHandler
{
    protected List<T> ReadData<T>(string filePath);
    protected void WriteData<T>(string filePath, List<T> data);
}