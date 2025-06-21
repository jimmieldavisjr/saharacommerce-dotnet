namespace Sahara.API.Models
{
    public enum VendorStatus
    {
        PendingApproval,      // Awaiting admin approval
        Active,               // Active vendor account
        ClosedTemporarily,    // Temporarily closed by vendor
        UnderMaintenance,     // Vendor marked shop as under maintenance
        Suspended,            // Temporarily suspended by admin
        Banned,               // Permanently banned by admin
        Deleted               // Soft-deleted by vendor
    }
}
