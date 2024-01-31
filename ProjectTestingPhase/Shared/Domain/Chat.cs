using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTestingPhase.Shared.Domain
{
    public class Chat : BaseDomainModel
    {
        public string? Message { get; set; }
        public string? Sender { get; set; }
        public string? Reciever { get; set; }

    }
}
