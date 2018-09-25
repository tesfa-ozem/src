using System;
using System.Collections.Generic;

namespace SignalRCore.Web.Models
{
    public partial class Facility
    {
        public long Id { get; set; }
        public string FacilityName { get; set; }
        public string FacilityAddress { get; set; }
        public int? Kephlevel { get; set; }
        public int? FacilityCategory { get; set; }
        public int? OperationStatus { get; set; }
        public bool? HasBeds { get; set; }
        public bool? Open24hrs { get; set; }
        public bool? OpenWeekends { get; set; }
        public bool? OpenPublicholidays { get; set; }
        public int? FacilityOwnerCategory { get; set; }
        public string FacilityOwner { get; set; }
        public string FacilityLongitude { get; set; }
        public string FacilityLatitude { get; set; }
        public int? WardId { get; set; }
    }
}
