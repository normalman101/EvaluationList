namespace EvaluationList.Core.FileHandler;

public interface IFileHandler
{
    protected T ReadData<T>(string filePath);
    protected bool WriteData<T>(string filePath, T data);
}