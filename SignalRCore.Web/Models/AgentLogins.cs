using System;
using System.Collections.Generic;

namespace SignalRCore.Web.Models
{
    public partial class AgentLogins
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public bool? Valid { get; set; }
        public DateTime? LoginDate { get; set; }
    }
}
