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

            bool new_car_inserted = false;

            foreach (var car in list)
            {

                // yeni arabanın bekleme süresi güncel var olan arabanın bekleme süresinden kısa ise önüne ekle
                if (NewCarHasLessWaitTime(new_car,car) && ! new_car_inserted)
                {

                    temp_list.Add(new_car);
                    new_car_inserted = true;

                }

                temp_list.Add(car);

            }

            if(!new_car_inserted)
                temp_list.Add(new_car);

            list = temp_list;

        }

        private bool NewCarHasLessWaitTime(Car new_car, Car car)
        {
            return new_car.WaitingPeriod < car.WaitingPeriod;
        }
    }
}