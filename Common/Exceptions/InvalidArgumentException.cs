namespace Common.Exceptions
{
    public class InvalidArgumentException: ApiException
    {
        public InvalidArgumentException(string nameOfArg, string reason) : base("Invalid parameter: {0}, reason: {1}",
            nameOfArg, reason)
        {
            
        }
    }
}