using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0
{
    class Searching
    {
        public static void ForSugerMan()
        {
            while(true)
            {
                Console.Clear();
                Scene.title();
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
                        break;

                    case '0':
                        return;
                }
            }
        }
    }
}
