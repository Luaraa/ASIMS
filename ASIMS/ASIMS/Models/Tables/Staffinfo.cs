using System;
using System.Collections.Generic;

namespace ASIMS.Models
{
    public partial class Staffinfo
    {
        public Staffinfo()
        {
            Market = new HashSet<Market>();
        }

        public string Sno { get; set; }
        public string Spassword { get; set; }
        public string Stype { get; set; }
        public string Sname { get; set; }
        public string Ssex { get; set; }
        public int? Sage { get; set; }
        public string Saddress { get; set; }
        public string Sacademic { get; set; }
        public float? Sperformance { get; set; }
        public int? CarNum { get; set; }

        public virtual Address SaddressNavigation { get; set; }
        public virtual ICollection<Market> Market { get; set; }
    }
}
