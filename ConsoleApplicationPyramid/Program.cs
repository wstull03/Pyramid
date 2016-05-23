using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationPyramid
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the number of rows in your pyramid");
            int numberOfRows = int.Parse(Console.ReadLine());

            int column = 1;
            for (int row = 1; row < numberOfRows+1; row++)
            {
                do
                {
                    if (column > (numberOfRows - row) && column < (numberOfRows + row))
                    {
                        Console.Write("*");
                        column++;
                    }
                    else
                    {
                        Console.Write(" ");
                        column++;
                    }
                    
                }
                while (column < (numberOfRows*2));
                column = 1;
                Console.WriteLine();
            }

        }
    }
}
