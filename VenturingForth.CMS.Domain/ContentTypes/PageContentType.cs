using System.Text.Json;

namespace VenturingForth.CMS.Domain.ContentTypes;

public sealed class PageContentType : ContentTypeBase
{
    public PageContentType() : base(nameof(Page), "page") { }

    public override void ValidateBody(JsonDocument body)
    {
        throw new NotImplementedException();
    }
}