using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world!");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} ^ 2 = {1}, {0}^3 = {2}",
                    i, i * i, i * i * i);
            }

        }
    }
}
