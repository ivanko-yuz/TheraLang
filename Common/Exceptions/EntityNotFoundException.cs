namespace Common.Exceptions
{
    public class EntityNotFoundException : ApiException
    {
        public EntityNotFoundException(string message, params object[] args) : base(string.Format(message, args))
        {
        }

        public EntityNotFoundException(string entityName, object entityId) : base("{0} with id {1} not found",
            entityName, entityId)
        {
        }
    }
}