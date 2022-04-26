using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackrabbitPromotionSoftware
{
    class Reservation
    {
        public Reservation()
        {

        }
        public Reservation(Customer c, DateTime D, int p)
        {
            res_Customer = c;
            res_Time = D;
            party_size = p;

        }
        Customer res_Customer { get; set; }
        DateTime res_Time     { get; set; }
        int      party_size   { get; set; }

    }
}
