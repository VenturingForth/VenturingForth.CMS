using System.Text.Json;

namespace VenturingForth.CMS.Domain.ContentTypes;

/// <summary>
/// Represents a page content type, usually containing static or generic information.
/// </summary>
public sealed class PageContentType : ContentTypeBase
{
    public PageContentType() : base(nameof(Page), "page") { }

    public override void ValidateBody(JsonDocument body)
    {
        throw new NotImplementedException();
    }
}