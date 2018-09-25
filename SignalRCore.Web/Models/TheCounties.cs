using System;
using System.Collections.Generic;

namespace SignalRCore.Web.Models
{
    public partial class TheCounties
    {
        public TheCounties()
        {
            CountyOfficers = new HashSet<CountyOfficers>();
            TheSubCounties = new HashSet<TheSubCounties>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string ContactEmail { get; set; }
        public int Status { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public ICollection<CountyOfficers> CountyOfficers { get; set; }
        public ICollection<TheSubCounties> TheSubCounties { get; set; }
    }
}
