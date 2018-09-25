using System;
using System.Collections.Generic;

namespace SignalRCore.Web.Models
{
    public partial class Counties
    {
        public int Id { get; set; }
        public long? Objectid { get; set; }
        public long? Id1 { get; set; }
        public string CountyNam { get; set; }
        public long? ConstCode { get; set; }
        public string Constituen { get; set; }
        public long? CountyCod { get; set; }
        public double? ShapeLeng { get; set; }
        public double? ShapeArea { get; set; }
    }
}
