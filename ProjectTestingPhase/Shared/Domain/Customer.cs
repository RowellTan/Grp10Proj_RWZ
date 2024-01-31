using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTestingPhase.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public string? Name { get; set; }
        public int PhoneNo { get; set; }
        public string? Destination { get; set; }
    }
}
