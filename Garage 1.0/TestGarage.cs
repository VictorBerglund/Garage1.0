using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0
{
    class TestGarage
    {
        public static string test(Garage<Vehicle> garage,int c)
        {
            Car car = new Car();
            car.RegNr = "123abc";
            car.Colour = "Blue";
            car.NbrOFSeats = 5;
            car.FuelType = "Gasole";
            car.TypOfEngine = "V8";
            car.TypOfModel = "Combie";
            car.Brand = "BMW";
            car.WheelDrive = "Front";

            Airplane aplane = new Airplane();
            aplane.RegNr = "456def";
            aplane.Colour = "White";
            aplane.NbrOFSeats = 65;
            aplane.FuelType = "Infants";
            aplane.TypOfEngine = "Jet";
            aplane.TypOfModel = "Private";
            aplane.WingSpan = 50;

            Tank tank = new Tank();
            tank.RegNr = "789ghi";
            tank.Colour = "Olive";
            tank.NbrOFSeats = 3;
            tank.FuelType = "Disel";
            tank.TypOfEngine = "Tractor";
            tank.TypOfModel = "Scout";
            tank.Caliber = 50;

            garage.AddToArray(car);
            garage.AddToArray(aplane);
            garage.AddToArray(tank);

            return car.Stats() + aplane.Stats() + tank.Stats();
        }
    }
}
