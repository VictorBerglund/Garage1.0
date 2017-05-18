using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0
{
    class Remove
    {

       public static string FromArray(Garage<Vehicle> garage)
        {

            Console.Clear();
            Scene.title();
            int k = -1;

            for (int i = 0; i < garage.ToArray().Length; i++)
            {
                Console.WriteLine("\nSlot number: " + (i+1) + " " +  garage.ToArray()[i].Stats());
            }

            do
            {
                Console.WriteLine("\nType the slot number of the vehicle you whant to remove");
                Console.Write("> ");
                try
                {
                    k = int.Parse(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Invalid input");
                }
            } while (k < 1);

            int idxrem = k;
            if(k < 1 || k > garage.ToArray().Length)
            {
                Console.WriteLine("Det är bara och starta om dumstrut");
            }
            else
            {
                garage.RemoveFromArray(idxrem);
            }

            Console.ReadKey();
            return "";
        }
    }
}
