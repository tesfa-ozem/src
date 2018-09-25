using System;
using System.Collections.Generic;

namespace SignalRCore.Web.Models
{
    public partial class People
    {
        public long Id { get; set; }
        public int Status { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string IdentificationType { get; set; }
        public string IdentificationNo { get; set; }
        public string MemberType { get; set; }
        public string EmailAddress { get; set; }
        public string PhysicalAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Signature { get; set; }
        public string LeftThumb { get; set; }
        public string RightThumb { get; set; }
        public string PhotoImage { get; set; }
        public string TerminalId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }
        public string MemberNo { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string MaritalStatus { get; set; }
        public double NhifNo { get; set; }
        public string Occupation { get; set; }
        public string PinNo { get; set; }
        public string CardUid { get; set; }
        public long? WardId { get; set; }
        public bool? CardPrinted { get; set; }
        public DateTime? CardPrintDate { get; set; }
        public string OldMemberNo { get; set; }

        public Dependants Dependants { get; set; }
        public Principals Principals { get; set; }
        public Spouses Spouses { get; set; }
    }
}
