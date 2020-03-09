namespace Common.Exceptions
{
    public class InvalidRequestParameterException : ApiException
    {
        public InvalidRequestParameterException(string message, params object[] args) : base(message, args)
        {
        }
    }
}