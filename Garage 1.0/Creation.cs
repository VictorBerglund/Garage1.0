using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0
{
    class Creation
    {
    public static string AddCar()
        {
            Console.Clear();
            Car car = new Car();
            Console.WriteLine("What is the Registration Number of the Car?");
            Console.Write("> ");
            car.RegNr = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("What Colour is the Car?");
            Console.Write("> ");
            car.Colour = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("How many seats are there in the car?");
            Console.Write("> ");
            car.NbrOFSeats = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("What fuel does the car use?");
            Console.Write("> ");
            car.FuelType = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("What engine does the car have?");
            Console.Write("> ");
            car.TypOfEngine = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("What brand is the car?");
            Console.Write("> ");
            car.Brand = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("What model is the car?");
            Console.Write("> ");
            car.TypOfModel = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("What is the driving wheels on the car?");
            Console.Write("> ");
            car.WheelDrive = Console.ReadLine();

            Console.WriteLine(car.Stats());

            return car.Stats();
        }
    }
}
