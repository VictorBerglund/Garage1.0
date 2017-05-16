using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0
{
    class Scene
    {
        public static void load()
        {

            Console.WriteLine("> Loading");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("> Loading.");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("> Loading..");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("> Loading...");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("> Done");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            title();
            picture();
        }

        public static void title()
        {
            Console.WriteLine("                         **************************");
            Console.WriteLine("                         *     THE GRARGE 1.0     *");
            Console.WriteLine("                         **************************");
            Console.WriteLine("\n");
        }

        public static void picture()
        {
            Console.WriteLine("                             _            ");
            Console.WriteLine("                          -=\\`\\         ");
            Console.WriteLine("                    /\\_______\\_\\__                             __/__");
            Console.WriteLine("  _____           -=\\c`\"\"\"\"\"\"\"   \"`)                     _____/____| ");
            Console.WriteLine(" /|_||_\\`.__          `~~~~~~/ /~~`            _________/_____\\____\\___ ");
            Console.WriteLine("(   _     __\\            -==/ /                \\             < < <      | ");
            Console.WriteLine("=`-(_)--(_)-'              '-'            ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("                                     .--------------------------,");
            Console.WriteLine("                                    /| _ .---. .---. .---. .---.|");
            Console.WriteLine("                   ,                |J||||___| |___| |___| |___||");
            Console.WriteLine("                .-/c-.,::           |=|||=======================|");
            Console.WriteLine("                (_)'==(_)           [_|j||(o)\\________|(o)\\___]");
        }
    }
}
