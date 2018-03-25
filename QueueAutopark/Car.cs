using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAutopark
{
   public class Car
    {
        public int CarNumber { get; set; }
        public int InitialWaitingPeriod { get; set; }
        public int WaitingPeriod { get; set; }
    }
}
