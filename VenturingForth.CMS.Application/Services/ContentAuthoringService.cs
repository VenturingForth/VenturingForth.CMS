using VenturingForth.CMS.Application.Interfaces;

namespace VenturingForth.CMS.Application;

public sealed class ContentAuthoringService : IContentAuthoringService
{
    /// <inheritdoc/>
    public async Task<Result<ContentItemResponse>> CreateAsync(CreateContentItemRequest request, CancellationToken ct)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public async Task<Result<ContentItemResponse>> PublishAsync(Guid contentItemId, CancellationToken ct)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public async Task ArchiveAsync(Guid contentItemId, CancellationToken ct)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public async Task<Result<ContentItemResponse>> AssignTagsAsync(Guid contentItemId, IReadOnlyList<Guid> tagIds,
        CancellationToken ct)
    {
        throw new NotImplementedException();
    }
}