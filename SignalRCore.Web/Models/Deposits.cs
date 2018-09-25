using System;
using System.Collections.Generic;

namespace SignalRCore.Web.Models
{
    public partial class Deposits
    {
        public long Id { get; set; }
        public double Balance { get; set; }
        public string CreatedBy { get; set; }
        public string DocumentNo { get; set; }
        public string AccountNo { get; set; }
        public string ModifiedBy { get; set; }
        public string PhoneNumber { get; set; }
        public int ResultCode { get; set; }
        public string CheckoutRequestId { get; set; }
        public string ResultDesc { get; set; }
        public string MerchantRequestId { get; set; }
        public DateTime TransactionDate { get; set; }
        public bool SentToJournal { get; set; }
        public string Comment { get; set; }
        public double Amount { get; set; }
        public int TransactionStatus { get; set; }
        public int Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string ReceiptNo { get; set; }
        public string TerminalId { get; set; }
        public string Zone { get; set; }
        public string CountyName { get; set; }
        public string Span { get; set; }
        public string Description { get; set; }
    }
}
