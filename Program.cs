using System;

namespace CodeWars
{
    public class CustomMath
    {
        public static int multiply(int a, int b)
        {
            return a*b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double res = CustomMath.multiply(1, 2);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
