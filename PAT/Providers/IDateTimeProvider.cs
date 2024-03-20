namespace PAT.Providers;

/// <summary>
/// Provides a testable version of Datetime.
/// </summary>
public interface IDateTimeProvider
{
    /// <summary>
    /// Gets the current UTC date and time.
    /// </summary>
    /// <returns></returns>
    DateTime GetUtcNow();
}