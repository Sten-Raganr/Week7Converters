using System;

namespace Week7Converters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IF u want convert celsius into farenheit type (A)." +
                "IF u want convert farenheit into celsius type (B). ");
            string userchoise;
            bool correctans = false;
            while (!correctans)
            {
                userchoise = Console.ReadLine().ToLower();
                if (userchoise == "a")
                {
                    Farencal();
                    correctans = true;
                }
                else if (userchoise == "b")
                {
                    Celsiuscal();
                    correctans = true;
                }
                else
                {
                    Console.WriteLine("Type A or B !!!!!!!!!!!!!");
                }

            }   
        }
        public static void Farencal()
        {
            Console.WriteLine("Enter Celsius:");
            double userinput = double.Parse(Console.ReadLine());
            double faren = (userinput * 9) / 5 + 32;
            Console.WriteLine($"Farenheit: {faren}.");

        }
        public static void Celsiuscal()
        {
            Console.WriteLine("Enter Farenheit:");
            double userinput = double.Parse(Console.ReadLine());
            double celc = (userinput -32) * 5 /9;
            Console.WriteLine($"Celsius: {celc}.");
        }

    }
}
