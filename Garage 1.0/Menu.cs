﻿using System;
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
            int c = int.Parse(Console.ReadLine());
            var garage = new Garage<Vehicle>(c); 
            
           
            while (true)
            {
                Console.Clear();
                Scene.title();
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
                        Console.Clear();
                        Scene.title();
                        Console.WriteLine("What vehicle do you whant to add?" 
                            + "\n1 to add a car"
                            + "\n2 to add a Airplane"
                            + "\n3 to add a Buss"
                            + "\n4 to add a Boat"
                            + "\n5 to add a Tank"
                            + "\n6 to add a Motorcycle");

                        char i = char.Parse(Console.ReadLine());
                        switch (i)
                        {
                            case '1':
                                Creation.AddCar(garage);
                                break;
                            case '2':
                                Creation.AddAirplane(garage);
                                break;
                            case '3':
                                Creation.AddBoat(garage);
                                break;
                            case '4':
                                Creation.AddBuss(garage);
                                break;
                            case '5':
                                Creation.AddTank(garage);
                                break;
                            case '6':
                                Creation.AddMotorcycle(garage);
                                break;
                        }
                        break;

                    case '2':
                        break;

                    case '3':
                        Console.Clear();
                        Scene.title();
                        foreach (var item in garage)
                        {
                            Console.WriteLine(item.Stats());
                        }
                        Console.ReadKey();
                        break;

                    case '0':
                        return;
                }
            }
        }
    }
}
