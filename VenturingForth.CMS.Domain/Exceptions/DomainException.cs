namespace VenturingForth.CMS.Domain;

/// <summary>
/// Base class for all domain exceptions and business-rule violations.
/// </summary>
public abstract class DomainException : Exception
{
    protected DomainException(string message) : base(message) { }
}