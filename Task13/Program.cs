using System;

namespace Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string a = Console.ReadLine();

            if (a.Length < 3)
                Console.WriteLine("В числе нет третьей цифры");
            else
                Console.WriteLine(a[2]);

            Console.ReadLine();
        }
    }
}
