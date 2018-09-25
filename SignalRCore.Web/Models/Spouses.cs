using System;
using System.Collections.Generic;

namespace SignalRCore.Web.Models
{
    public partial class Spouses
    {
        public long Id { get; set; }
        public string NationalId { get; set; }
        public long PrincipalId { get; set; }

        public People IdNavigation { get; set; }
        public Principals Principal { get; set; }
    }
}
