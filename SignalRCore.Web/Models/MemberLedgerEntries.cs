using System;
using System.Collections.Generic;

namespace SignalRCore.Web.Models
{
    public partial class MemberLedgerEntries
    {
        public long Id { get; set; }
        public long MemberId { get; set; }
        public DateTime PostingDate { get; set; }
        public long? TransactionTypeId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime PaymentEndDate { get; set; }
        public string ExternalDocumentNo { get; set; }
        public string DocumentNo { get; set; }
        public double Amount { get; set; }
    }
}
