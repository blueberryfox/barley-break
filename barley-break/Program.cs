using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barley_break
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleGameUI consoleGameUI1 = new ConsoleGameUI(new Game2(1, 2, 3, 4, 5, 6, 7, 8, 0));
            ConsoleGameUI consoleGameUI2 = new ConsoleGameUI(new Game3(1, 2, 3, 0));

            consoleGameUI1.Play();
            consoleGameUI2.Play();
            
            Console.ReadKey();
        }

        
    }
}
