using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class Program
    {
        public class PrimeGenerator: knownPrimes
        {
            this.Type  =  
        }
        public static async Task MainAsync()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Task t1 = Task.Delay(1000);
            Task t2 = Task.Delay(1000);
            Task t3 = Task.Delay(3000);

            await Task.WhenAll(t1, t2, t3);
            await Task.WhenAny(t1, t2, t3);


            stopWatch.Stop();
            double seconds = stopWatch.Elapsed.TotalSeconds;
            Console.WriteLine("Seconds taken: " + seconds);
        }

        static void Main(string[] args)
        {
            MainAsync().Wait();

            //Dyreart art = new Dyreart("csf", 2, 2);
            //Console.WriteLine(art.Talk());



            //var person = new People("Terane");
            //person.NameChanged += Person_NameChanged;

            //person.Name = "Anders";
            //person.Name = "Søren";

            List<People> people = new List<People>()
            {
                new People("Terane", "Lui", new Dyreart("dog", 4, 2)),
                new People("Hans", "Hr. Fisk", new Dyreart("Fisk", 0, 2)),
                new People("Søren", "Adr", new Dyreart("Edderkop", 8, 6))
            };

            //List<People> result = people.FilterOut(person => person.GetPetEyes() > 2);
            List<People> result = people.FilterOut(person => person.Name == "Egon");

            //foreach (People person in result)
            //{
            //    Console.WriteLine("Name: " + person.Name);
            //}
            Console.ReadKey();
        }

        private static void Person_NameChanged(object sender, string name)
        {
            Console.WriteLine("Name changed: " + name);
        }

        public static void FirstProgram101()
        {
            System.Console.WriteLine("Hej med dig");
            System.Console.WriteLine("Det er min første opgave");
        }

        public static void SumTwoNumbers102()
        { 
            System.Console.WriteLine(12 + 13);
        }

        public static void DivisitionOfTwoNumbers103()
        {
            System.Console.WriteLine(24 / 5);
            
        }

        public static void MultipleOperationsAndPrecedence104()
        {
            System.Console.WriteLine(-1 + 3 * 5);
            System.Console.WriteLine((24 + 5) % 7);
            System.Console.WriteLine(15 + -4 *6 / 11);
            System.Console.WriteLine(2 + 10 / 6 * - 7 % 2);
        }

        public static void MultiplyIfNotZero202()
        {
            int x, y;
                Console.WriteLine("enter x:");
            x = System.Convert.ToInt32(System.Console.ReadLine());

            if (x != 0)
            {
                Console.WriteLine("enter y:");
                y = System.Convert.ToInt32(System.Console.ReadLine());
                Console.WriteLine("the product of {0} and {1} is {2}", x, y, x * y);
            }
            if (x == 0)
                Console.Write("0");
        }

        public static void DivideIfNotZero203()
        {
            Console.WriteLine("Opgave:DivideIfNotZero203");

            int number1, number2;

            Console.Write("Enter the first number:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number:");
            number2 = Convert.ToInt32(Console.ReadLine());

            if (number2 != 0)
            {
                Console.WriteLine("The result for {0} / {1} is {2}",
                number1, number2, number1/number2);
            }
            if (number2 == 0)
                Console.WriteLine("No result");
        }

        public static void DivideZeroElse204()
        {
            Console.WriteLine("Opgave:DivideZeroElse204");
            int number1, number2;

            Console.Write("Enter the first number:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number:");
            number2 = Convert.ToInt32(Console.ReadLine());            

            if (number2 != 0)
            {
                Console.WriteLine("The result for {0} / {1} is {2}", number1, number2, number1 / number2);
            }
            else
                Console.WriteLine("No result");
        }

        public static void Greatest()
        {
            Console.WriteLine("Opgave: Greatest of three numbers 2.05");
            int number1, number2, number;

            Console.Write("Enter the number 1:");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number 2:");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number 3:");
            number1 = Convert.ToInt32(Console.ReadLine());

            //if (number1 > number2 && number1 >)
        }

        public static void CharOpgave()
        {
            Console.Write("Enter first letter:");
            char letter = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter second letter:");
            char letter2 = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter third letter:");
            char letter3 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("{0}{1}{2}", letter3, letter2, letter);
        }
    }
}
