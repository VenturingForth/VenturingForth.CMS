namespace VenturingForth.CMS.Application.Models.DTOs;

public sealed record CreateContentItemRequest
{
    /// <summary>
    /// The type of content item to create.
    /// </summary>
    public string Type { get; init; } = string.Empty;
    
    /// <summary>
    /// The slug of the content item.
    /// </summary>
    public string Slug { get; init; } = string.Empty;
    
    /// <summary>
    /// The title of the content item.
    /// </summary>
    public string Title { get; init; } = string.Empty;
    
    /// <summary>
    /// A text summary of the content item.
    /// </summary>
    public string Summary { get; init; } = string.Empty;
    
    /// <summary>
    /// The JSON body of the content item.
    /// Must be valid JSONB - will be parsed and validated within the application.
    /// </summary>
    public string BodyJson { get; init; } = string.Empty;
    
    /// <summary>
    /// A list of tag IDs to assign to the content item.
    /// </summary>
    public IReadOnlyList<Guid> TagIds { get; init; } = Array.Empty<Guid>();
}