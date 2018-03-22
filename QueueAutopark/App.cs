using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAutopark
{
    class App
    {

        static Random r = new Random();
        static List<Car> carList = new List<Car>();

        public static void run()
        {
            int carsize = r.Next(10, 20);

            for (int i = 0; i < carsize; i++)
            {

                Car new_car = new Car();
                new_car.WaitingPeriod = r.Next(10, 300);
                new_car.CarNumber = Numerator.getNo();

                carList.Add(new_car);

            }
        }
        public static string getCarListOutput()
        {
            String output = "";

            foreach (var car in carList)
            {
                output += "Araç: " + car.CarNumber + " Bekleme Süresi: " + car.WaitingPeriod + Environment.NewLine;
            }

            return output;
        }

        public static string getTotalCarsOutput()
        {
            return "Toplam araç: " + carList.Count();
        }
    }
}
