using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0
{
    class Searching
    {
        public static void ForSugerMan(Garage<Vehicle> garage)
        {
            while(true)
            {
                Console.Clear();
                Scene.title();
                Console.WriteLine("Press 1 to search by regestartion number"
                + "\nPress 0 to go back");

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
                        SearchReg(garage);
                        break;

                    case '0':
                        return;
                }
            }
        }

        static void SearchReg(Garage<Vehicle> garage)
        {
            Console.WriteLine("Type in the Reg number you whant to search for: ");
            Console.Write("> ");
            string rgSearch = Console.ReadLine();

            foreach (var Vehicle in garage.SearchRegNr(rgSearch))
            {
                Console.WriteLine(Vehicle.Stats());
            }
            Console.ReadKey();
        }
    }
}
