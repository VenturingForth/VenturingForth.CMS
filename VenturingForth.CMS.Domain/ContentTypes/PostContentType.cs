using System.Text.Json;

namespace VenturingForth.CMS.Domain.ContentTypes;

public sealed class PostContentType : ContentTypeBase 
{
    public PostContentType() : base(nameof(Post), "post") { }

    public override void ValidateBody(JsonDocument body)
    {
        throw new NotImplementedException();
    }
}