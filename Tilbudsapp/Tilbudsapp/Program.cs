using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tilbudsapp
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Tryk på 1 for at søge tilbud vi varenavn.  eller tryk på 2 for at søge efter kampanier");

            System.ConsoleKey Pressedkey = Console.ReadKey(true).Key;
            if (Pressedkey == System.ConsoleKey.D1 || Pressedkey == System.ConsoleKey.NumPad1)
            {
                Console.WriteLine("Please Wait");
                Handler.søgetilbud();
                
            }


            else if (Pressedkey == System.ConsoleKey.D2 || Pressedkey == System.ConsoleKey.NumPad2)
            {
                Console.WriteLine("Please Wait");
                Handler.søgekampagne();
            }


            else
            {
                Console.WriteLine("Wrong Key");
            }

        }
    }
}
