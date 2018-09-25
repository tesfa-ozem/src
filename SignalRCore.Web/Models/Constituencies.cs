using System;
using System.Collections.Generic;

namespace SignalRCore.Web.Models
{
    public partial class Constituencies
    {
        public int Id { get; set; }
        public long? Objectid { get; set; }
        public string CountyNam { get; set; }
        public double? ConstCode { get; set; }
        public string Constituen { get; set; }
        public double? CountyAss { get; set; }
        public string CountyA1 { get; set; }
        public double? RegistCen { get; set; }
        public string Registrati { get; set; }
        public double? CountyCod { get; set; }
        public double? ShapeLeng { get; set; }
        public double? ShapeArea { get; set; }
    }
}
