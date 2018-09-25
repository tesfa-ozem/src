using System;
using System.Collections.Generic;

namespace SignalRCore.Web.Models
{
    public partial class RemmittancePlans
    {
        public RemmittancePlans()
        {
            RemmittanceMatrices = new HashSet<RemmittanceMatrices>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public int Status { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public long CorporateId { get; set; }

        public ICollection<RemmittanceMatrices> RemmittanceMatrices { get; set; }
    }
}
