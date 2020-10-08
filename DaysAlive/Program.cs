using System;

namespace DaysAlive
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayTimer = true;

            while (displayTimer == true)
            {
                displayTimer = LifeSpan();
            }
        }

        private static bool LifeSpan()
        {
            try
            {
                Console.Write("Write your birthday YYYY-MM-DD: ");
                DateTime myBirthday = Convert.ToDateTime(Console.ReadLine());
                TimeSpan daysLeft = DateTime.Now.Subtract(myBirthday);
                var result = daysLeft.Days;

                var year = DateTime.Now.Year - myBirthday.Year;
                var month = DateTime.Now.Month - myBirthday.Month;
                var day = DateTime.Now.Day - myBirthday.Day;

                Console.WriteLine("\n------------------------------------------");
                Console.WriteLine($"\nYou are {year} years, {month} months and {-day} days old");

                Console.WriteLine("\n------------------------------------------");
                Console.WriteLine("\nYou have lived {0} days", result);

                Console.Write("\nHours alive: ");
                Console.Write(daysLeft.TotalHours.ToString().Substring(0, 6));

                Console.Write("\n\nMinutes alive: ");
                Console.Write(daysLeft.TotalMinutes.ToString().Substring(0, 8));

                int days1K = 1000 - result;
                int days5K = 5000 - result;
                int days10K = 10000 - result;
                int days20K = 20000 - result;
                int days30K = 30000 - result;
                int days50K = 50000 - result;

                DateTime today = DateTime.Now;
                var flippo1K = today.AddDays(days1K);
                var flippo5K = today.AddDays(days5K);
                var flippo10K = today.AddDays(days10K);
                var flippo20K = today.AddDays(days20K);
                var flippo30K = today.AddDays(days30K);
                var flippo50K = today.AddDays(days50K);

                Console.WriteLine("\n\n------------------------------------------");
                Console.WriteLine("\nYou became 1K days old in:");
                Console.WriteLine(flippo1K.ToLongDateString());

                Console.WriteLine("\nYou became 5K days old in:");
                Console.WriteLine(flippo5K.ToLongDateString());

                Console.WriteLine("\nYou became 10K days old in:");
                Console.WriteLine(flippo10K.ToLongDateString());

                Console.WriteLine("\nYou became 20K days old in:");
                Console.WriteLine(flippo20K.ToLongDateString());

                Console.WriteLine("\nYou became 30K days old in:");
                Console.WriteLine(flippo30K.ToLongDateString());

                Console.WriteLine("\nYou would be 50K days old in:");
                Console.WriteLine(flippo50K.ToLongDateString());

                Console.WriteLine();
                Console.WriteLine("   _______      ");
                Console.WriteLine("  /   12  \\    ");
                Console.WriteLine(" |    |    |    ");
                Console.WriteLine(" |9   |   3|    ");
                Console.WriteLine(" |     \\   |   ");
                Console.WriteLine("  \\___6___/    ");

                Console.ReadLine();
                return false; 

            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }
            return true;
        }
    }
}
