namespace Common.Exceptions
{
    public class NotFoundException : ApiException
    {
        public NotFoundException()
        {
        }

        public NotFoundException(string itemName) : base($"{itemName} not found!")
        {
        }
    }
}
