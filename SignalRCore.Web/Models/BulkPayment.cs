namespace SignalRCore.Web.Models
{
    public class BulkPayment
    {
        public long Id { get; set; }
        public int Status { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string IdentificationNo { get; set; }
        public string PhoneNumber { get; set; }
    }
}