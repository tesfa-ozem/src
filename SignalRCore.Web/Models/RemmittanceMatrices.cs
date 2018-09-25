using System;
using System.Collections.Generic;

namespace SignalRCore.Web.Models
{
    public partial class RemmittanceMatrices
    {
        public long Id { get; set; }
        public long PlanId { get; set; }
        public long DestinationCorporateId { get; set; }
        public decimal Amount { get; set; }
        public int Status { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public RemmittancePlans Plan { get; set; }
    }
}
