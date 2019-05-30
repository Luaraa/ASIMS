using System;
using System.Collections.Generic;

namespace ASIMS.Models
{
    public partial class User
    {
        public User()
        {
            Market = new HashSet<Market>();
            Shopingcart = new HashSet<Shopingcart>();
        }

        public string Uno { get; set; }
        public string Upassword { get; set; }
        public string Uname { get; set; }
        public string Uphone { get; set; }
        public string Uaddress { get; set; }

        public virtual ICollection<Market> Market { get; set; }
        public virtual ICollection<Shopingcart> Shopingcart { get; set; }
    }
}
