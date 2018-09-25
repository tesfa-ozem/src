using System;
using System.Collections.Generic;

namespace SignalRCore.Web.Models
{
    public partial class ClientSetup
    {
        public int Id { get; set; }
        public string ClientCode { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public decimal MinContribution { get; set; }
        public decimal MaxContribution { get; set; }
        public decimal ActivationAmount { get; set; }
        public decimal TotalSubscriptionAmount { get; set; }
        public decimal CardReplacementFee { get; set; }
        public bool NotifyViaSms { get; set; }
        public bool NotificationOnActivation { get; set; }
        public bool NotificationOnPayment { get; set; }
        public bool NotificationOnVisit { get; set; }
        public bool NotificationOnDischarge { get; set; }
        public int PaymentPlansInstallments { get; set; }
        public bool SpecialistsCovered { get; set; }
        public bool NotificationOnCardReady { get; set; }
        public bool NotificationOnCardCollected { get; set; }
        public bool FingerPrintAuthentification { get; set; }
        public bool AgentCanReceiveCash { get; set; }
        public int AgeException { get; set; }
        public int MaximumNoofDependents { get; set; }
        public bool FacialAuthentification { get; set; }
        public bool OpticalAuthentification { get; set; }
        public bool VoiceAuthentification { get; set; }
    }
}
