namespace PAT.Providers
{
    /// <summary>
    /// Provides a testable version of DateTime.
    /// </summary>
    public class DateTimeProvider : IDateTimeProvider
    {
        /// <inheritdoc/>
        public DateTime GetUtcNow() => DateTime.UtcNow;
    }
}