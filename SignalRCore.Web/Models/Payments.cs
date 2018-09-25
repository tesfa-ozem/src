using System;
using System.Collections.Generic;

namespace SignalRCore.Web.Models
{
    public partial class Payments
    {
        public long Id { get; set; }
        public string PaymentMode { get; set; }
        public string PaymentType { get; set; }
        public string MemberNo { get; set; }
        public string PhoneNo { get; set; }
        public string AccountNo { get; set; }
        public string CardNo { get; set; }
        public decimal? Amount { get; set; }
        public int? Status { get; set; }
        public string DocumentNo { get; set; }
        public string Description { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
