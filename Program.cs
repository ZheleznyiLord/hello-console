using System;

namespace hello_console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime[] dates = { new DateTime(2020, 2, 2), new DateTime(2020, 2, 3) };
            Console.WriteLine(countWorkDays(new DateTime(2020, 2, 1), new DateTime(2020, 2, 5), dates));
        }



        private static int countWorkDays(DateTime start, DateTime end, DateTime[] weekEnd)
        {
            int count = 0;
            if (start > end)
            {
                throw new Exception("Start date must be earlier end date");
            }
            else
            {
                for (; start<=end; start = start.AddDays(1) )
                {
                    if (!Array.Exists(weekEnd, date=>date==start))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

    }
}
