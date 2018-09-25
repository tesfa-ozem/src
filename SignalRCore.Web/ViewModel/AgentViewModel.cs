using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRCore.Web.ViewModel
{
    public class AgentViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string SUBCOUNTY { get; set; }
        public string WARD { get; set; }
        public string VILLAGE { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string TerminalId { get; set; }
        public string PhoneNumber { get; set; }

        public string IdNumber { get; set; }
        public DateTime DateRegistered { get; set; }
    }

}
