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
        protected int totalWaitingPeriod = 0;
        protected int grandTotalWaitingPeriod = 0;

        public virtual void Insert(Car new_car)
        {
            // eklenecek aracın toplam bekleme süresi:
            // başlangış bekleme süresi + o ana kadarki toplam bekleme süresi
            new_car.WaitingPeriod = new_car.InitialWaitingPeriod + totalWaitingPeriod;
            totalWaitingPeriod = new_car.WaitingPeriod;
            grandTotalWaitingPeriod += totalWaitingPeriod;
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

        public int getTotalWaitingPeriod()
        {
            return grandTotalWaitingPeriod;
        }
    }
}
