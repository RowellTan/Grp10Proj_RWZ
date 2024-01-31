using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTestingPhase.Shared.Domain
{
    public class Car : BaseDomainModel
    {
        public string? CarType { get; set; }
        public string? CarStatus { get; set; }
        public virtual Driver? Driver { get; set; }
        public int? DriverId { get; set; }
    }
}
