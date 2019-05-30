using System;
using System.Collections.Generic;

namespace ASIMS.Models
{
    public partial class Market
    {
        public string Mno { get; set; }
        public string Vno { get; set; }
        public int? Number { get; set; }
        public string Sno { get; set; }
        public string Uno { get; set; }
        public DateTime? RecordDate { get; set; }
        public int? Pflag { get; set; }

        public virtual Staffinfo SnoNavigation { get; set; }
        public virtual User UnoNavigation { get; set; }
        public virtual Vehicle VnoNavigation { get; set; }
    }
}
