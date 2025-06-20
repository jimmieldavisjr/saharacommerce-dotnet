namespace Sahara.API.Models
{
    public class Vendor
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public string StoreName { get; set; }
        public string StoreDescription { get; set; }

        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public VendorStatus Status { get; set; }

    }
}
