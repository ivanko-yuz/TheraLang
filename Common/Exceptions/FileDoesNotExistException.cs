namespace Common.Exceptions
{
    public class FileDoesNotExistException: ApiException
    {
        public FileDoesNotExistException(string filePath) : base($"{filePath} does not exist")
        {}
    }
}