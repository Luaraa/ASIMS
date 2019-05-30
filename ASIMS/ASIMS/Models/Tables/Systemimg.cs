using System;
using System.Collections.Generic;

namespace ASIMS.Models
{
    public partial class Systemimg
    {
        public string Sno { get; set; }
        public string Vno { get; set; }
        public string Sname { get; set; }
        public string Spath { get; set; }

        public virtual Vehicle VnoNavigation { get; set; }
    }
}
