using System;
using System.Collections.Generic;

namespace SignalRCore.Web.Models
{
    public partial class Principals
    {
        public Principals()
        {
            Dependants = new HashSet<Dependants>();
            Spouses = new HashSet<Spouses>();
        }

        public long Id { get; set; }
        public string NationalId { get; set; }

        public People IdNavigation { get; set; }
        public ICollection<Dependants> Dependants { get; set; }
        public ICollection<Spouses> Spouses { get; set; }
    }
}
