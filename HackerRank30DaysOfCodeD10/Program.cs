using System;

namespace HackerRank30DaysOfCodeD10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            var reminder = 0;
            var count = 0;
            var max = 0;

            while (n > 0)
            {
                reminder = n % 2;
                n /= 2;

                if (reminder == 1)
                {
                    count++;
                    max = Math.Max(max, count);
                }
                else
                {
                    count = 0;
                }
            }
            Console.WriteLine(max);
        }
    }
}
