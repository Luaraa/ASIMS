using System;
using System.Collections.Generic;

namespace ASIMS.Models
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            Market = new HashSet<Market>();
            Purchase = new HashSet<Purchase>();
            Shopingcart = new HashSet<Shopingcart>();
            Systemimg = new HashSet<Systemimg>();
        }

        public string Vno { get; set; }
        public string Vname { get; set; }
        public string Vtype { get; set; }
        public string Vcolour { get; set; }
        public DateTime? Vdate { get; set; }
        public float? Vprice { get; set; }

        public virtual Cashlist Cashlist { get; set; }
        public virtual Income Income { get; set; }
        public virtual Infoofvehicle Infoofvehicle { get; set; }
        public virtual ICollection<Market> Market { get; set; }
        public virtual ICollection<Purchase> Purchase { get; set; }
        public virtual ICollection<Shopingcart> Shopingcart { get; set; }
        public virtual ICollection<Systemimg> Systemimg { get; set; }
    }
}
