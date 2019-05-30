using System;
using System.Collections.Generic;

namespace ASIMS.Models
{
    public partial class Address
    {
        public Address()
        {
            Staffinfo = new HashSet<Staffinfo>();
            Suppler = new HashSet<Suppler>();
        }

        public string Ano { get; set; }
        public string Anation { get; set; }
        public string Aprovince { get; set; }
        public string Acity { get; set; }
        public string County { get; set; }

        public virtual ICollection<Staffinfo> Staffinfo { get; set; }
        public virtual ICollection<Suppler> Suppler { get; set; }
    }
}
