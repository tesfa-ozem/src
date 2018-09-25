using System;
using System.Collections.Generic;

namespace SignalRCore.Web.Models
{
    public partial class ImageData
    {
        public long Id { get; set; }
        public string PhotoImage { get; set; }
        public string Signature { get; set; }
        public string LeftThumbprint { get; set; }
        public string RightThumbprint { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public ImageData IdNavigation { get; set; }
        public ImageData InverseIdNavigation { get; set; }
    }
}
