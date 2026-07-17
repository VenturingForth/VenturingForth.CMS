using System.Text.Json;

namespace VenturingForth.CMS.Domain.ContentTypes;

public abstract class ContentTypeBase
{
    private static readonly List<ContentTypeBase> All = new();
    
    public string Name { get; }
    public string Value { get; }

    protected ContentTypeBase(string name, string value)
    {
        Name = name;
        Value = value;
        All.Add(this);
    }

    public static readonly ContentTypeBase Page = new PageContentType();
    public static readonly ContentTypeBase Post = new PostContentType();

    /// <summary>
    /// Validates the JSONB Body against the expected shape of the content type.
    /// </summary>
    public abstract void ValidateBody(JsonDocument body);

    public static ContentTypeBase FromValue(string value)
    {
        var match = All.FirstOrDefault(x => x.Value == value);
        if (match is null)
        {
            throw new UnknownContentTypeException(value);
        }
        return match;
    }
    
    public sealed override bool Equals(object? obj) =>
        obj is ContentTypeBase other && Value == other.Value;
    
    public sealed override int GetHashCode() => Value.GetHashCode();
    
    public override string ToString() => Value;
}