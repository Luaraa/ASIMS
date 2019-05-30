using System;
using System.Collections.Generic;

namespace ASIMS.Models
{
    public partial class Infoofvehicle
    {
        public string Vno { get; set; }
        public string Irank { get; set; }
        public string Ibrand { get; set; }
        public string Iconstruction { get; set; }
        public string Idisplacement { get; set; }
        public string Ispeedbox { get; set; }
        public string Ination { get; set; }
        public int? Iseatnum { get; set; }
        public string Ienergy { get; set; }
        public string IairInlet { get; set; }
        public string IdriveMode { get; set; }
        public string Inote { get; set; }

        public virtual Vehicle VnoNavigation { get; set; }
    }
}
