using VenturingForth.CMS.Domain;

namespace VenturingForth.CMS.Application.Models;

/// <summary>
/// The application service boundary result type.
/// </summary>
public sealed class Result<T>
{
    public bool IsSuccess { get; }
    public T? Value { get; }
    public DomainException? Error { get; }

    private Result(bool isSuccess, T? value, DomainException? error)
        => (IsSuccess, Value, Error) = (isSuccess, value, error);
    
    public static Result<T> Success(T? value) => new(true, value, null);
    public static Result<T> Failure(DomainException error) => new (false, default, error);
}