using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAutopark
{
    public class PrioritizedQueue : QueueCar
    {
        
        public override void Insert(Car new_car)
        {

            List<Car> temp_list = new List<Car>();
            int temp_total_waiting_period = 0;
            int temp_grand_total_waiting_period = 0;
            bool new_car_inserted = false;

            foreach (var car in list)
            {
                // yeni arabanın bekleme süresi güncel var olan arabanın bekleme süresinden kısa ise önüne ekle
                if (NewCarHasLessWaitTime(new_car,car) && ! new_car_inserted)
                {
                    new_car.WaitingPeriod = new_car.InitialWaitingPeriod + temp_total_waiting_period;
                    temp_total_waiting_period = new_car.WaitingPeriod;
                    temp_grand_total_waiting_period += temp_total_waiting_period;
                    temp_list.Add(new_car);
                    new_car_inserted = true;
                }

                car.WaitingPeriod = car.InitialWaitingPeriod + temp_total_waiting_period;
                temp_total_waiting_period = car.WaitingPeriod;
                temp_grand_total_waiting_period += temp_total_waiting_period;
                temp_list.Add(car);
            }

            if (!new_car_inserted)
            {
                new_car.WaitingPeriod = new_car.InitialWaitingPeriod + temp_total_waiting_period;
                temp_total_waiting_period = new_car.WaitingPeriod;
                grandTotalWaitingPeriod += temp_total_waiting_period;
                temp_list.Add(new_car);
            }

            list = temp_list;
            totalWaitingPeriod = temp_total_waiting_period;
            grandTotalWaitingPeriod = temp_grand_total_waiting_period;
        }

        private bool NewCarHasLessWaitTime(Car new_car, Car car)
        {
            return new_car.InitialWaitingPeriod < car.InitialWaitingPeriod;
        }
    }
}