namespace Sahara.API.Entities
{
    public enum CustomerStatus
    {
        Active,      // Actively using the platform
        Suspended,   // Temporarily restricted
        Banned,      // Permanently banned
        Deleted      // Self-deleted account (soft delete)
    }
}