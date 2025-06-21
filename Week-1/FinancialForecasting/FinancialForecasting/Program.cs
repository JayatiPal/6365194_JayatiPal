using System;

namespace FinancialForecasting
{
    class Program
    {
        static double FutureValue(double initialValue, double growthRate, int periods)
        {
            if (periods == 0)
                return initialValue;
            else
                return FutureValue(initialValue, growthRate, periods - 1) * (1 + growthRate);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter initial value:");
            double initial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter growth rate (e.g., 0.05 for 5%):");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number of periods:");
            int periods = Convert.ToInt32(Console.ReadLine());

            double forecast = FutureValue(initial, rate, periods);
            Console.WriteLine($"Forecasted value after {periods} periods: {forecast:F2}");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
