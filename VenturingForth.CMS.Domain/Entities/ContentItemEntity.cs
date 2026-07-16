namespace VenturingForth.CMS.Domain.Entities;

public sealed class ContentItemEntity
{
    public Guid Id { get; set; }
    public Guid SiteId { get; set; }
    public ContentType Type { get; set; }
}