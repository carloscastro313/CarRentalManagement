namespace CarRentalManagement.Shared.Domain
{
    public class Customer : BaseDomainModal
    {
        public string TaxId { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}