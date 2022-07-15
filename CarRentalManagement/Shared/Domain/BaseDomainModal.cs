namespace CarRentalManagement.Shared.Domain
{
    public abstract class BaseDomainModal
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
    }
}
