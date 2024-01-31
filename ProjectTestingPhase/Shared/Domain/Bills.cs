using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTestingPhase.Shared.Domain
{
    public class Bills : BaseDomainModel
    {
        public double Distance { get; set; }
        public double Amount { get; set; }
        public virtual Booking? Booking { get; set; }
        public int BookingId { get; set; }
    }
}
