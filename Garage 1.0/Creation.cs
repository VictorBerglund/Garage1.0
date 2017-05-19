using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0
{
    class Creation
    {

        public static void menu(Garage<Vehicle> garage)
        {
            Console.Clear();
            Scene.title();
            Console.WriteLine("What vehicle do you whant to add?"
                + "\n1 to add a car"
                + "\n2 to add a Airplane"
                + "\n3 to add a Boat"
                + "\n4 to add a Buss"
                + "\n5 to add a Tank"
                + "\n6 to add a Motorcycle"
                + "\n0 to exit");

            char i = char.Parse(Console.ReadLine());
            switch (i)
            {
                case '1':
                    AddCar(garage);
                    break;
                case '2':
                    AddAirplane(garage);
                    break;
                case '3':
                    AddBoat(garage);
                    break;
                case '4':
                    AddBuss(garage);
                    break;
                case '5':
                    AddTank(garage);
                    break;
                case '6':
                    AddMotorcycle(garage);
                    break;
            }
        }

        public static string AddCar(Garage<Vehicle> garage)
        {
            
            Car car = new Car();
            Console.WriteLine("What is the Registration Number of the Car?");
            Console.Write("> ");
            car.RegNr = Console.ReadLine();

            Console.Clear();
            Scene.title();
            Console.WriteLine("What Colour is the Car?");
            Console.Write("> ");
            car.Colour = Console.ReadLine();
            
            car.NbrOFSeats = EnvisInmat();

            Console.Clear();
            Scene.title();
            Console.WriteLine("What fuel does the car use?");
            Console.Write("> ");
            car.FuelType = Console.ReadLine();

            Console.Clear();
            Scene.title();
            Console.WriteLine("What engine does the car have?");
            Console.Write("> ");
            car.TypOfEngine = Console.ReadLine();

            Console.Clear();
            Scene.title();
            Console.WriteLine("What brand is the car?");
            Console.Write("> ");
            car.Brand = Console.ReadLine();

            Console.Clear();
            Scene.title();
            Console.WriteLine("What model is the car?");
            Console.Write("> ");
            car.TypOfModel = Console.ReadLine();

            Console.Clear();
            Scene.title();
            Console.WriteLine("What is the driving wheels on the car?");
            Console.Write("> ");
            car.WheelDrive = Console.ReadLine();

            Console.Clear();
            Scene.title();
            Console.WriteLine(car.Stats());
            Console.ReadKey();

            garage.AddToArray(car);
            
            return car.Stats();
        }

        public static string AddAirplane(Garage<Vehicle> garage)
        {
            Airplane aplane = new Airplane();

            Console.WriteLine("What is the Registration Number of the Airplane?");
            Console.Write("> ");
            aplane.RegNr = Console.ReadLine();

            Console.Clear();
            Scene.title();
            Console.WriteLine("What Colour is the airplane?");
            Console.Write("> ");
            aplane.Colour = Console.ReadLine();
 
            aplane.NbrOFSeats = EnvisInmat();

            Console.Clear();
            Scene.title();
            Console.WriteLine("What fuel does the airplane use?");
            Console.Write("> ");
            aplane.FuelType = Console.ReadLine();

            Console.Clear();
            Scene.title();
            Console.WriteLine("What engine does the airplane have?");
            Console.Write("> ");
            aplane.TypOfEngine = Console.ReadLine();

            Console.Clear();
            Scene.title();
            Console.WriteLine("What model is the airplane?");
            Console.Write("> ");
            aplane.TypOfModel = Console.ReadLine();

            bool y = true;
            while (y)
            {
                try
                {
                    Console.Clear();
                    Scene.title();
                    Console.WriteLine("What is the wingspan?");
                    Console.Write("> ");
                    aplane.WingSpan = int.Parse(Console.ReadLine());
                    y = false;

                }
                catch
                {
                    Console.Clear();
                    Scene.title();
                    Console.WriteLine("Please enter a number");
                    Console.ReadKey();
                    y = true;
                }

            }

            Console.Clear();
            Scene.title();
            Console.WriteLine(aplane.Stats());
            Console.ReadKey();

            garage.AddToArray(aplane);

            return aplane.Stats();
        }

        public static string AddBuss(Garage<Vehicle> garage)
        {
            Buss buss = new Buss();

            Console.WriteLine("What is the Registration Number of the Buss?");
            Console.Write("> ");
            buss.RegNr = Console.ReadLine();

            Console.Clear();
            Scene.title();
            Console.WriteLine("What Colour is the Buss?");
            Console.Write("> ");
            buss.Colour = Console.ReadLine();
            buss.NbrOFSeats = EnvisInmat();

            Console.Clear();
            Scene.title();
            Console.WriteLine("What fuel does the buss use?");
            Console.Write("> ");
            buss.FuelType = Console.ReadLine();

            Console.Clear();
            Scene.title();
            Console.WriteLine("What engine does the buss have?");
            Console.Write("> ");
            buss.TypOfEngine = Console.ReadLine();

            Console.Clear();
            Scene.title();
            Console.WriteLine("What model is the buss?");
            Console.Write("> ");
            buss.TypOfModel = Console.ReadLine();

            bool y = true;
            Console.Clear();
            Scene.title();

            while (y)
            {
                try
                {
                    Console.Clear();
                    Scene.title();
                    Console.WriteLine("What is the Price of a fair?");
                    Console.Write("> ");
                    buss.FairPrice = int.Parse(Console.ReadLine());
                    y = false;

                }
                catch
                {
                    Console.Clear();
                    Scene.title();
                    Console.WriteLine("Please enter a number");
                    Console.ReadKey();
                    y = true;
                }
            }

            Console.Clear();
            Scene.title();
            Console.WriteLine(buss.Stats());
            Console.ReadKey();

            garage.AddToArray(buss);

            return buss.Stats();
        }

        public static string AddBoat(Garage<Vehicle> garage)
        {
            Boat boat = new Boat();

            Console.WriteLine("What is the Registration Number of the boat?");
            Console.Write("> ");
            boat.RegNr = Console.ReadLine();

            Console.Clear();
            Scene.title();
            Console.WriteLine("What Colour is the boat?");
            Console.Write("> ");
            boat.Colour = Console.ReadLine();


            boat.NbrOFSeats = EnvisInmat();

            Console.Clear();
            Scene.title();
            Console.WriteLine("What fuel does the boat use?");
            Console.Write("> ");
            boat.FuelType = Console.ReadLine();

            Console.Clear();
            Scene.title();
            Console.WriteLine("What engine does the boat have?");
            Console.Write("> ");
            boat.TypOfEngine = Console.ReadLine();

            Console.Clear();
            Scene.title();
            Console.WriteLine("What model is the boat?");
            Console.Write("> ");
            boat.TypOfModel = Console.ReadLine();

            bool y = true;
            Console.Clear();
            Scene.title();
            while (y)
            {
                try
                {
                    Console.Clear();
                    Scene.title();
                    Console.WriteLine("What is the legnth of the boat?");
                    Console.Write("> ");
                    boat.Length = int.Parse(Console.ReadLine()); 
                    y = false;

                }
                catch
                {
                    Console.Clear();
                    Scene.title();
                    Console.WriteLine("Please enter a number");
                    Console.ReadKey();
                    y = true;
                }

            }


            Console.Clear();
            Scene.title();
            Console.WriteLine(boat.Stats());
            Console.ReadKey();

            garage.AddToArray(boat);

            return boat.Stats();
        }

        public static string AddMotorcycle(Garage<Vehicle> garage)
        {
            Motorcycle mc = new Motorcycle();

            Console.WriteLine("What is the Registration Number of the motorcycle?");
            Console.Write("> ");
            mc.RegNr = Console.ReadLine();

            Console.Clear();
            Scene.title();
            Console.WriteLine("What Colour is the motorcycle?");
            Console.Write("> ");
            mc.Colour = Console.ReadLine();

            mc.NbrOFSeats = EnvisInmat();

            Console.Clear();
            Scene.title();
            Console.WriteLine("What fuel does the motorcycle use?");
            Console.Write("> ");
            mc.FuelType = Console.ReadLine();

            Console.Clear();
            Scene.title();
            Console.WriteLine("What engine does the motorcycle have?");
            Console.Write("> ");
            mc.TypOfEngine = Console.ReadLine();

            Console.Clear();
            Scene.title();
            Console.WriteLine("What model is the motorcycle?");
            Console.Write("> ");
            mc.TypOfModel = Console.ReadLine();

            bool y = true;
            while (y)
            {
                try
                {
                    Console.Clear();
                    Scene.title();
                    Console.WriteLine("What is the cc?");
                    Console.Write("> ");
                    mc.CC = int.Parse(Console.ReadLine());
                    y = false;

                }
                catch
                {
                    Console.Clear();
                    Scene.title();
                    Console.WriteLine("Please enter a number");
                    Console.ReadKey();
                    y = true;
                }

            }

            Console.Clear();
            Scene.title();
            Console.WriteLine(mc.Stats());
            Console.ReadKey();

            garage.AddToArray(mc);

            return mc.Stats();
        }

        public static string AddTank(Garage<Vehicle> garage)
        {
            Tank tank = new Tank();

            Console.WriteLine("What is the Registration Number of the Tank?");
            Console.Write("> ");
            tank.RegNr = Console.ReadLine();

            Console.Clear();
            Scene.title();
            Console.WriteLine("What Colour is the tank?");
            Console.Write("> ");
            tank.Colour = Console.ReadLine();

            Console.Clear();
            Scene.title();
            Console.WriteLine("How many seats are there in the tank?");
            Console.Write("> ");
            tank.NbrOFSeats = EnvisInmat();

            Console.Clear();
            Scene.title();
            Console.WriteLine("What fuel does the tank use?");
            Console.Write("> ");
            tank.FuelType = Console.ReadLine();

            Console.Clear();
            Scene.title();
            Console.WriteLine("What engine does the tank have?");
            Console.Write("> ");
            tank.TypOfEngine = Console.ReadLine();

            Console.Clear();
            Scene.title();
            Console.WriteLine("What model is the tank?");
            Console.Write("> ");
            tank.TypOfModel = Console.ReadLine();

            bool y = true;
            Console.Clear();
            Scene.title();
            while (y)
            {
                try
                {
                    Console.Clear();
                    Scene.title();
                    Console.WriteLine("What is the caliber?");
                    Console.Write("> ");
                    tank.Caliber = int.Parse(Console.ReadLine());
                    y = false;

                }
                catch
                {
                    Console.Clear();
                    Scene.title();
                    Console.WriteLine("Please enter a number");
                    Console.ReadKey();
                    y = true;
                }

            }

            Console.Clear();
            Scene.title();
            Console.WriteLine(tank.Stats());
            Console.ReadKey();

            garage.AddToArray(tank);

            return tank.Stats();
        }

        public  static int EnvisInmat()
        {
            bool y = true;
            int x = 0;
            Console.Clear();
            Scene.title();
            while (y)
            {
                try
                {
                    Console.Clear();
                    Scene.title();
                    Console.WriteLine("How many seats are there?");
                    Console.Write("> ");
                    x = int.Parse(Console.ReadLine());
                    y = false;
                    
                }
                catch
                {
                    Console.Clear();
                    Scene.title();
                    Console.WriteLine("Please enter a number");
                    Console.ReadKey();
                    y = true;
                }

            }
            return x;
        }
    }
}