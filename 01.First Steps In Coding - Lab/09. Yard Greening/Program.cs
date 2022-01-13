using System;

namespace proba
{
    class Program
    {
        static void Main(string[] args)
        {
            double kvm = double.Parse(Console.ReadLine());
            double price = kvm * 7.61;
            double priceWithDiscount = price - (price * 0.18);
            double discount = price * 0.18;
            Console.WriteLine($"The final price is: {priceWithDiscount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
