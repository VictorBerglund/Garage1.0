using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0
{
    class Menu
    {
        public static void menu()
        {
            int c = 0;

            do
               {
                   try
                    {

                        Console.Clear();
                        Scene.title();
                        Console.WriteLine("How many slots do you want in the garage?");
                        Console.Write("> ");
                        c = int.Parse(Console.ReadLine());
                        if (c <= 0)
                        {
                            Console.WriteLine("There has to be at least 1 slot in the garage");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Ivalid input bitch");
                    }
            } while (c <= 0);

            var garage = new Garage<Vehicle>(c);

            while (true)
            {
                Console.Clear();
                Scene.title();
                Console.WriteLine("\n Welcome to the Garage"
                    + "\nPress 1 to add a vehicles to it"
                    + "\nPress 2 to take out a vehicle from your garage"
                    + "\nPress 3 to view your garage"
                    + "\nPress 4 to search"
                    + "\nPress 0 to exit");
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
                        Creation.menu(garage);
                        break;

                    case '2':
                        Remove.FromArray(garage);
                        break;

                    case '3':
                        ViewGarage.Show(garage, c);
                        break;

                    case '4':
                        Searching.ForSugerMan();
                        break;
                    case 't':
                        TestGarage.test(garage, c);
                        break;

                    case '0':
                        return;
                }
            }
        }
    }
}
