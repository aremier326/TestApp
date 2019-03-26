using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            int counter = new int();
            for (int i = 0; i < 10; i++)
            {
                counter++;
                Console.WriteLine(counter);
            }
            Console.WriteLine("Here is value of the counter: {0}", counter);
        }
    }
}
