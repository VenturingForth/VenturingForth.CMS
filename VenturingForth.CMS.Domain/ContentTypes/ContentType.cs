using System.Text.Json;

namespace VenturingForth.CMS.Domain.ContentTypes;

public abstract class ContentType
{
    private static readonly List<ContentType> All = new();
    
    public string Name { get; }
    public string Value { get; }

    protected ContentType(string name, string value)
    {
        Name = name;
        Value = value;
        All.Add(this);
    }

    public static readonly ContentType Page = new PageContentType();
    public static readonly ContentType Post = new PostContentType();

    /// <summary>
    /// Validates the JSONB Body against the expected shape of the content type.
    /// </summary>
    public abstract void ValidateBody(JsonDocument body);

    public static ContentType FromValue(string value)
    {
        var match = All.FirstOrDefault(x => x.Value == value);
        if (match is null)
        {
            throw new UnknownContentTypeException(value);
        }
        return match;
    }
    
    public sealed override bool Equals(object? obj) =>
        obj is ContentType other && Value == other.Value;
    
    public sealed override int GetHashCode() => Value.GetHashCode();
    
    public override string ToString() => Value;
}