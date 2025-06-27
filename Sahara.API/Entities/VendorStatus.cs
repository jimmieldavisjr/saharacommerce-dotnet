namespace Sahara.API.Entities
{
    /// <summary>
    /// Represents the current operational status of a vendor within the system.
    /// </summary>
    public enum VendorStatus
    {
        /// <summary>
        /// The vendor is awaiting administrator approval before being allowed to operate in the system.
        /// </summary>
        PendingApproval,

        /// <summary>
        /// The vendor is verified and actively operating within the system.
        /// </summary>
        Active,

        /// <summary>
        /// The vendor has temporarily closed their store, making it hidden and disabling seller operations.
        /// </summary>
        ClosedTemporarily,

        /// <summary>
        /// The vendor has temporarily closed their store for maintenance.
        /// </summary>
        UnderMaintenance,

        /// <summary>
        /// The vendor has been suspended by a system administrator due to a policy violation or manual intervention.
        /// </summary>
        Suspended,

        /// <summary>
        /// The vendor has been permanently banned by a system administrator and cannot regain access.
        /// </summary>
        Banned,

        /// <summary>
        /// The vendor account has been soft-deleted; the data remains, but login and system access are revoked.
        /// </summary>
        Deleted
    }
}
