using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTestingPhase.Shared.Domain
{
    public class Booking : BaseDomainModel
    {
        public DateTime Time { get; set; }
        public string? Location { get; set; }
        public virtual Customer? Customer { get; set; }
        public int CustomerId { get; set; }
        public virtual Car? Car { get; set; }
        public int CarId { get; set; }
    }
}
