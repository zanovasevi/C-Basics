using System;

namespace proba
{
    class Program
    {
        static void Main(string[] args)
        {
            double dogs = double.Parse(Console.ReadLine());
            double cats = double.Parse(Console.ReadLine());

            double dogFood = 2.50;
            double catFood = 4.00;

            double total = dogs * dogFood + cats * catFood;
            Console.WriteLine($"{total} lv.");
        }
    }
}
