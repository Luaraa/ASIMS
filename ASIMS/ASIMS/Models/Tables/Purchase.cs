using System;
using System.Collections.Generic;

namespace ASIMS.Models
{
    public partial class Purchase
    {
        public string Pno { get; set; }
        public string Vno { get; set; }
        public string Sno { get; set; }
        public float? PcostPrice { get; set; }
        public int? Pnumber { get; set; }
        public DateTime? PrecordDate { get; set; }

        public virtual Suppler SnoNavigation { get; set; }
        public virtual Vehicle VnoNavigation { get; set; }
    }
}
