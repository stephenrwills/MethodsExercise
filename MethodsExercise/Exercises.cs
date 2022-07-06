using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    public class Exercises
    {
        public static void Exercise1()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your pet's name?");
            var pet = Console.ReadLine();

            Console.WriteLine("What is your favorite park?");
            var park = Console.ReadLine();

            Console.WriteLine("What is your favorite day of the week?");
            var dayOfTheWeek = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            var favoriteBand = Console.ReadLine();

            Console.WriteLine($"Hi my name is {name} and on {dayOfTheWeek} I can be found in {park} walking {pet}, listening to {favoriteBand}");
        }

        public static void Exercise2()
        {
            var result = Add(10, 20);
            Console.WriteLine(result);
            Console.WriteLine();

            var difference = Subtract(15, 19);
            Console.WriteLine(difference);
            Console.WriteLine();

            var product = Multiply(10, 20);
            Console.WriteLine(product);
            Console.WriteLine();

            var quotient = Divide(10, 2);
            Console.WriteLine(quotient);
            Console.WriteLine();
        }

        public static int Multiply(params int[] numbers)
        {
            int result = 0;
            
            foreach (var x in numbers)
            {
                result *= x;
            }
            return result;
        }

            

        public static int Add(params int[] numbers)
        {
            int result = 0;

            foreach (var x in numbers)
            {
                result += x;
            }
            return result;


        }

        public static int Divide(int x, int y)
        {
            return x / y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}
