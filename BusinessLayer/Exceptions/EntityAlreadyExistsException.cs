namespace BusinessLayer.Exceptions;

public class EntityAlreadyExistsException : Exception
{
    protected string EntityName { get; }

    public EntityAlreadyExistsException(string entityName)
        : base($"{entityName} already exists")
    {
        EntityName = entityName;
    }

    public EntityAlreadyExistsException(string entityName, string message)
        : base(message)
    {
        EntityName = entityName;
    }

    public EntityAlreadyExistsException(string entityName, string message, Exception innerException)
        : base(message, innerException)
    {
        EntityName = entityName;
    }
}
