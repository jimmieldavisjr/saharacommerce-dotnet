namespace Sahara.API.Entities
{
    /// <summary>
    /// Represents the visibility status of a product within the system.
    /// </summary>
    public enum ProductStatus
    {
        /// <summary>
        /// Product is published and visible to customers.
        /// </summary>
        Active,

        /// <summary>
        /// Product is unpublished and hidden from customer view.
        /// </summary>
        Inactive
    }
}
