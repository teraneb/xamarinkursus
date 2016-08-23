using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp.Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //int myint = 0;
            //while (myint < 10)
            //{
            //    Console.Write(myint);
            //    myint = myint+1;
            //}
            //Console.WriteLine();
            //Console.ReadKey();

            //     +
            //   /   \
            //  4     +
            //      /  \
            //     1    2

            //Expression expr = new PlusExpression(
            //    left: 4.0.ToExpression(),
            //    right: new PlusExpression(
            //        left: new ConstantExpression(1),
            //        right: new ConstantExpression(2)));

            var expr = new ConstantExpression<int>(10);

            Console.Write(expr.ToString());

            Console.Write(" = ");

            Console.WriteLine(expr.Evaluate());

            Console.ReadKey();
        }
    }
}
