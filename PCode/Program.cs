using System;

namespace PCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your personal code :");
            int usercode = Int32.Parse(Console.ReadLine());
            foreach (int number in usercode) ;
        }
    }
}
