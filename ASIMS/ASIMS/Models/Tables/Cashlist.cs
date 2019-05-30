using System;
using System.Collections.Generic;

namespace ASIMS.Models
{
    public partial class Cashlist
    {
        public string Vno { get; set; }
        public int? Vnumber { get; set; }

        public virtual Vehicle VnoNavigation { get; set; }
    }
}
