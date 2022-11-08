using System;

namespace Toy_Sop_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double trip = double.Parse(Console.ReadLine());
            int puzzlesCount = int.Parse(Console.ReadLine());
            int dollsCount = int.Parse(Console.ReadLine());
            int bearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());

            double totalPrice = (puzzlesCount * 2.60) + (dollsCount * 3.0) + (bearsCount * 4.10) + (minionsCount * 8.20) + (trucksCount * 2.0);
            
            double totalOrders = puzzlesCount + dollsCount + bearsCount + minionsCount + trucksCount;
            double discount = 0.25;
            double rent = 0.1;
            double sumAfterDicountAndRent = (totalPrice - (totalPrice * discount)) - ((totalPrice - (totalPrice * discount)) * rent);
            double sumAfterRent = totalPrice - (totalPrice * rent);

            if (totalOrders >= 50)
            {
                Console.WriteLine($"Yes! {sumAfterDicountAndRent - trip:f2} lv left.");
            }
            else
            {
                if (sumAfterRent > trip)
                    Console.WriteLine($"Not enough money! {sumAfterRent - trip:f2} lv needed.");
                else
                    Console.WriteLine($"Not enough money! {trip - sumAfterRent:f2} lv needed.");
            }
                

        }
    }
}
