using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int myint = 0;
            while (myint < 10)
            {
                Console.Write(myint);
                myint = myint+1;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
