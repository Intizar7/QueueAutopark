using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAutopark
{
   public abstract class QueueCar
    {
        protected List<Car> list = new List<Car>();

        public virtual void Insert(Car new_car)
        {
            list.Add(new_car);
        }

        public bool IsEmpty()
        {
            return list.Count == 0;
        }

        public Car Peek()
        {
            return list[0];
        }

        public Car Remove()
        {
            Car del = list[0];

            list.RemoveAt(0);

            return del;
        }

        public List<Car> GetList()
        {
            return list;
        }

        public int Count()
        {
            return list.Count;
        }
    }
}
