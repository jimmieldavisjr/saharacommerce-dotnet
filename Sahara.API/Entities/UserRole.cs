namespace Sahara.API.Entities
{
    /// <summary>
    /// Represents the account role type of a system user.
    /// </summary>
    public enum UserRole
    {
        /// <summary>
        /// A customer who purchases products.
        /// </summary>
        Customer,
        
        /// <summary>
        /// A vendor who sells products.
        /// </summary>
        Vendor,         

        /// <summary>
        /// An administrator who manages customer and vendor account operations.
        /// </summary>
        Admin
    }
}
