namespace VenturingForth.CMS.Domain;

public sealed class UnknownContentTypeException : DomainException
{
    /// <summary>
    /// This exception is thrown when an unknown content type is encountered.
    /// </summary>
    public UnknownContentTypeException(string contentType) : 
        base($"{contentType} is not a recognised content type.") { }
}
