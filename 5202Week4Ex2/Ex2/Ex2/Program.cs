using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Task 1*/
            Console.ForegroundColor = ConsoleColor.White;
            int start = 76;
            int finish = 46;
            Console.WriteLine("Display the odd numbers from 76 to 46");
            while(start >= finish)
            {
                if(start % 2 != 0)
                    Console.WriteLine(start);
                start--;
            }
            Console.WriteLine("Task 1 end...");
            Console.ReadLine();

            /*Task 2*/
            Console.Write("Please enter a character: ");
            string char1 = Console.ReadLine();
            Console.Write($"Please enter the nuymber of times you would like to display {char1}: ");
            int num1 = int.Parse(Console.ReadLine());

            for(int i = 0; i <= num1; i++)
            {
                Console.Write(char1);
            }
            Console.WriteLine("\nTask 2 end...");
            Console.ReadLine();



            /*Task 3*/
            Console.Write("Please enter a symbol to use: ");
            string symbol = Console.ReadLine();
            Console.Write("Please enter the height of the rectangle: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Please enter the width of the rectangle: ");
            int w = int.Parse(Console.ReadLine());

            for(int i = 0; i < h; i++)//deals with the height of the rectangle
            {
                for(int j = 0; j< w; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nTask 3 end...");
            Console.ReadLine();
        }  
    }
}
