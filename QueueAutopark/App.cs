using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAutopark
{
    class App
    {
        static bool creation_done = false;

        static Random r = new Random();
        static List<Car> carList = new List<Car>();

        static NormalQueue queue = new NormalQueue();
        static PrioritizedQueue pqueue = new PrioritizedQueue();

        public static void run()
        {
            if (creation_done)
                return;

            int carsize = r.Next(10, 20);

            for (int i = 0; i < carsize; i++)
            {

                Car new_car = new Car();
                new_car.WaitingPeriod = r.Next(10, 300);
                new_car.CarNumber = Numerator.getNo();

                queue.Insert(new_car);
                pqueue.Insert(new_car);

            }

            creation_done = true;
        }

        public static string getCarListOutput(List<Car> list)
        {
            String output = "";

            foreach (var car in list)
            {
                output += "Araç: " + car.CarNumber + " Bekleme Süresi: " + car.WaitingPeriod + Environment.NewLine;
            }

            return output;
        }

        internal static string getNormalCarListOutput()
        {
            return getCarListOutput(queue.GetList());
        }

        internal static string getPrioritizedCarListOutput()
        {
            return getCarListOutput(pqueue.GetList());
        }

        public static string getTotalCarsOutput()
        {
            return "Toplam araç: " + queue.Count();
        }
    }
}
