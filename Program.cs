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
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("sqrt {0} = {1}",
                    i,Math.Sqrt(i));
            }
            Console.ReadKey();
        }
    }
}
