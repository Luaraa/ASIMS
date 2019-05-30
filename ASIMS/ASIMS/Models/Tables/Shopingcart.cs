using System;
using System.Collections.Generic;

namespace ASIMS.Models
{
    public partial class Shopingcart
    {
        public int Cno { get; set; }
        public string Uno { get; set; }
        public string Vno { get; set; }

        public virtual User UnoNavigation { get; set; }
        public virtual Vehicle VnoNavigation { get; set; }
    }
}
