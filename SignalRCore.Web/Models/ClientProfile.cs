using System;
using System.Collections.Generic;

namespace SignalRCore.Web.Models
{
    public partial class ClientProfile
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string ClientCode { get; set; }
        public string Business { get; set; }
        public string Mediaurl { get; set; }
        public string Country { get; set; }
        public string Currency { get; set; }
        public string DefaultCode { get; set; }
        public string Language { get; set; }
        public DateTime? Datecreated { get; set; }
        public DateTime? DateModified { get; set; }
        public bool? Isactive { get; set; }
        public bool? IsDeleted { get; set; }
        public int? CreatedUserId { get; set; }
        public int? ModifiedUserId { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
    }
}
