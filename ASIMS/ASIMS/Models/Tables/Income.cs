using System;
using System.Collections.Generic;

namespace ASIMS.Models
{
    public partial class Income
    {
        public string Vno { get; set; }
        public int? Vnumber { get; set; }
        public float? Vincome { get; set; }

        public virtual Vehicle VnoNavigation { get; set; }
    }
}
