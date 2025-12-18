namespace Sahara.API.Entities
{
    /// <summary>
    /// Represents the current operational status for an Administrator within the system.
    /// </summary>
    public enum AdminStatus
    {
        /// <summary>
        /// The admin is currently active within the system.
        /// </summary>
        Active,

        /// <summary>
        /// The admin has been soft-deleted from within the system.
        /// </summary>
        Deleted
    }
}
