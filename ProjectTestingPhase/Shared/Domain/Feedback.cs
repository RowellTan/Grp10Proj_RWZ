using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTestingPhase.Shared.Domain
{
    public class Feedback : BaseDomainModel
    {
        public string? Comment { get; set; }
        public virtual Booking? Booking { get; set; }
        public int BookingId { get; set; }
    }
}
