using System;

namespace hello_console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime[] dates = { new DateTime(2020, 2, 2), new DateTime(2020, 2, 3) };
            Console.WriteLine(countWorkDays(new DateTime(2020, 2, 4), new DateTime(2020, 2, 1), dates));

        }



        private static int countWorkDays(DateTime start, DateTime end, DateTime[] weekEnd)
        {
            int count;
            if (start > end)
            {
                throw new Exception("Start date must be earlier end date");
            }
            else
            {
                count = end.Day - start.Day + 1;
                foreach (var day in weekEnd)
                {
                    if (day >= start && day <= end)
                    {
                        if (count == 0)
                        {
                            throw new Exception("Weekends must be not more then work days");
                        }
                        count--;
                    }
                }
            }

            return count;
        }

    }
}
