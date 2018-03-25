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

        static NormalQueue queue = new NormalQueue();
        static PrioritizedQueue pqueue = new PrioritizedQueue();

        public static void run()
        {
            // check if algorithm was already runned
            if (creation_done)
                return;

            // get random car size between 10 and 20
            int carsize = r.Next(10, 20);

            // create car objects and add list after updating each as many as "carsize"
            for (int i = 0; i < carsize; i++)
            {

                Car new_car = new Car();
                Car xnew_car = new Car();
                xnew_car.InitialWaitingPeriod = new_car.InitialWaitingPeriod = r.Next(10, 300);
                xnew_car.CarNumber = new_car.CarNumber = Numerator.getNo();

                queue.Insert(new_car);
                pqueue.Insert(xnew_car);

            }

            // set the algorith is runned
            creation_done = true;
        }

        internal static string getPrioritizedTotalWaitingPeriodTime()
        {
            return pqueue.getTotalWaitingPeriod().ToString();
        }

        internal static string getNormalTotalWaitingPeriodTime()
        {
            return queue.getTotalWaitingPeriod().ToString();
        }

        public static string getCarListOutput(List<Car> list)
        {
            String output = "";

            foreach (var car in list)
            {
                output += "Araç: " + car.CarNumber + " - BB: "+car.InitialWaitingPeriod+" - TB: " + car.WaitingPeriod + Environment.NewLine;
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

        public static string getTotalCars()
        {
            return queue.Count().ToString();
        }
    }
}
