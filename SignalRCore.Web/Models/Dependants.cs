using System;
using System.Collections.Generic;

namespace SignalRCore.Web.Models
{
    public partial class Dependants
    {
        public long Id { get; set; }
        public string BirthCertificateNo { get; set; }
        public long PrincipalId { get; set; }

        public People IdNavigation { get; set; }
        public Principals Principal { get; set; }
    }
}
