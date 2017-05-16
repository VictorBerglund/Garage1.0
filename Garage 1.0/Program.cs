using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Scene.load();
            System.Threading.Thread.Sleep(3000);
            Menu.menu();
        }
    }
}
