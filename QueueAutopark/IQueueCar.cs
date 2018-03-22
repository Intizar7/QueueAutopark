using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAutopark
{
   public interface IQueueCar
    {
        void Insert(Car c);
        Car Remove();
        Car Peek();
        Boolean IsEmpty();
    }
}
