namespace remove.Entities
{
    /// <summary>
    /// Represents the current operational status of a customer within the system.
    /// </summary>
    public enum CustomerStatus
    {
        /// <summary>
        /// The customer is active and has full access to the system.
        /// </summary>
        Active,

        /// <summary>
        /// The customer is temporarily suspended and cannot use the system.
        /// </summary>
        Suspended,

        /// <summary>
        /// The customer is permanently banned from accessing the system.
        /// </summary>
        Banned
    }
}