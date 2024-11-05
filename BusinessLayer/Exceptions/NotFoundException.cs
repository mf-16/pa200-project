namespace BusinessLayer.Exceptions;

public class NotFoundException : Exception
{
    protected string EntityName { get; }
    protected int Key { get; }

    public NotFoundException(string entityName, int key)
        : base($"{entityName} with key {key} was not found.")
    {
        EntityName = entityName;
        Key = key;
    }

    public NotFoundException(string entityName, int key, string message)
        : base(message)
    {
        EntityName = entityName;
        Key = key;
    }

    public NotFoundException(string entityName, int key, string message, Exception innerException)
        : base(message, innerException)
    {
        EntityName = entityName;
        Key = key;
    }
}
