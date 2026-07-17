using VenturingForth.CMS.Application.Models.Enums;

namespace VenturingForth.CMS.Application.Models.DTOs;

public sealed record ContentItemResponse
{
    /// <summary>
    /// The unique identifier of the content item in the database.
    /// </summary>
    public Guid Id { get; init; }
    
    /// <summary>
    /// The type of content item.
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
    /// The published status of the content item.
    /// Options are: Draft, Published, Archived.
    /// </summary>
    public PublishedStatus Status { get; init; }
    
    /// <summary>
    /// The DateTime the content item was published.
    /// </summary>
    public DateTime? PublishedAt { get; init; }
    
    /// <summary>
    /// A list of tags to assign to the content item.
    /// </summary>
    public IReadOnlyList<string> TagIds { get; init; } = Array.Empty<string>();
    
    /// <summary>
    /// The data transfer object (DTO) containing the body of the content item.
    /// </summary>
    public ContentBodyDto Body { get; init; } = null!;
}