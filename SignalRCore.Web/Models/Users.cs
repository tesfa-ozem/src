using System;
using System.Collections.Generic;

namespace SignalRCore.Web.Models
{
    public partial class Users
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Subcounty { get; set; }
        public string Ward { get; set; }
        public string Village { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string TerminalId { get; set; }
        public string PhoneNumber { get; set; }
        public string IdNumber { get; set; }
        public DateTime? DateRegistered { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
