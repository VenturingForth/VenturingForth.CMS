using System.Text.Json;

namespace VenturingForth.CMS.Domain.ContentTypes;

/// <summary>
/// Represents a post content type, usually containing an article or video content.
/// </summary>
public sealed class PostContentType : ContentTypeBase 
{
    public PostContentType() : base(nameof(Post), "post") { }

    public override void ValidateBody(JsonDocument body)
    {
        throw new NotImplementedException();
    }
}