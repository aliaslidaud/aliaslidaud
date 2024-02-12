using System.Diagnostics;

namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ordersCount = int.Parse(Console.ReadLine());
            double singleOrderPrice = 0;
            double ordersTotal = 0;

            for (int i = 0; i < ordersCount; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int daysInMonth = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                singleOrderPrice = daysInMonth * pricePerCapsule * capsulesCount;
                ordersTotal += singleOrderPrice;
                Console.WriteLine($"The price for the coffee is: ${singleOrderPrice:f2}");
            }
            Console.WriteLine($"Total: ${ordersTotal:f2}");
        }
    }
}