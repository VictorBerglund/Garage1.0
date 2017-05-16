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
            Console.Clear();
            Scene.title();
            Console.WriteLine("How many slots do you want in the garage?");
           
            while (true)
            {
                Console.WriteLine("\n Welcome to the Garage"
                    + "\nPress 1 to add a vehicles to it"
                    + "\nPress 2 to take out a vehicle from your garage"
                    + "\nPress 3 to view your garage"
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
                        Console.WriteLine("What vehicle do you whant to add?" 
                            + "\n1 to add a car"
                            + "\n2 to add a Airplane"
                            + "\n3 to add a Buss"
                            + "\n4 to add a Boat"
                            + "\n5 to add a Tank");

                        char i = char.Parse(Console.ReadLine());
                        switch (i)
                        {
                            case '1':
                                break;
                        }
                        break;

                    case '2':
                        break;

                    case '3':
                        break;

                    case '0':
                        return;
                }
            }
        }
    }
}
