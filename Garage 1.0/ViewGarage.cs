using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0
{
    class ViewGarage
    {
        public static void Show(Garage<Vehicle> garage, int c)
        {
            while (true)
            {
                Console.Clear();
                Scene.title();

                Console.WriteLine("Press 1 to view all the vehicles in the garage"
                    + "\nPress 2 to see what kinds of vehicles are in the garage"
                    + "\nPress 0 to go back");
                Console.Write("> ");

                char input = ' ';

                try
                {
                    input = Console.ReadLine()[0];
                }
                catch
                {
                    Console.Clear();
                    Scene.title();
                    Console.WriteLine("Please enter input");
                }

                switch (input)
                {
                    case '1':
                        Console.Clear();
                        Scene.title();
                        Console.WriteLine("There are " + c + " slots in the garage");
                        foreach (var item in garage)
                        {
                            Console.WriteLine(item.Stats());
                        }
                        Console.ReadKey();
                        break;

                    case '2':
                        ShowType(garage, c);
                        break;

                    case '0':
                        return;
                }
            }
        }

        static void ShowType(Garage<Vehicle> garage, int c)
        {
            Console.Clear();
            Scene.title();

            int car = 0;
            int aplane = 0;
            int mc = 0;
            int buss = 0;
            int boat = 0;
            int tank = 0;

            for (int i = 0; i < garage.ToArray().Length; i++)
            {
                if (garage.ToArray()[i].GetType() == typeof(Car))
                {
                    car++;
                }
                else if (garage.ToArray()[i].GetType() == typeof(Airplane))
                {
                    aplane++;
                }
                else if (garage.ToArray()[i].GetType() == typeof(Buss))
                {
                    buss++;
                }
                else if (garage.ToArray()[i].GetType() == typeof(Boat))
                {
                    boat++;
                }
                else if (garage.ToArray()[i].GetType() == typeof(Motorcycle))
                {
                    mc++;
                }
                else if (garage.ToArray()[i].GetType() == typeof(Tank))
                {
                    tank++;
                }
            }
            Console.WriteLine("There are:"
            + "\n" + car + " Cars"
            + "\n" + aplane + " Airplanes"
            + "\n" + buss + " Busses"
            + "\n" + boat + " Boats"
            + "\n" + mc + " Motorcycles"
            + "\n" + tank + " Tanks"
            + "\nIn the garage");

            Console.ReadKey();
        }
    }
}
