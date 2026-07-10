namespace VenturingForth.CMS.Application.Interfaces;

public interface IContentAuthoringService
{
    /// <summary>
    /// Creates a new content item asynchronously.
    /// </summary>
    Task<Result<ContentItemResponse>> CreateAsync(CreateContentItemRequest request, CancellationToken ct);

    /// <summary>
    /// Publishes an existing content item asynchronously.
    /// </summary>
    Task<Result<ContentItemResponse>> PublishAsync(Guid contentItemId, CancellationToken ct);
    
    /// <summary>
    /// Unpublishes an existing content item asynchronously.
    /// Can be considered a soft delete.
    /// </summary>
    Task ArchiveAsync(Guid contentItemId, CancellationToken ct);
    
    /// <summary>
    /// Assign tags to an existing content item asynchronously.
    /// </summary>
    Task<Result<ContentItemResponse>> AssignTagsAsync(Guid contentItemId, IReadOnlyList<Guid> tagIds, CancellationToken ct);
}