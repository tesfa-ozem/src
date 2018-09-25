using System;
using System.Collections.Generic;

namespace SignalRCore.Web.Models
{
    public partial class CountyOfficers
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalId { get; set; }
        public string EmailAddress { get; set; }
        public long? WardId { get; set; }
        public long? CountyId { get; set; }
        public int Status { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public TheCounties County { get; set; }
    }
}
