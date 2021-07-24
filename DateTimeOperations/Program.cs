using System;

namespace DateTimeOperations
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("DateTime examples: ");
            DateTime d1 = DateTime.Now;

            Console.WriteLine($"1) Date -> {d1.Date}");
            Console.WriteLine($"2) Day -> {d1.Day}");
            Console.WriteLine($"3) DayOfWeek -> {d1.DayOfWeek}");
            Console.WriteLine($"4) DayOfYear -> {d1.DayOfYear}");
            Console.WriteLine($"5) Hour -> {d1.Hour}");
            Console.WriteLine($"6) Kind -> {d1.Kind}");
            Console.WriteLine($"7) Millisecond -> {d1.Millisecond}");
            Console.WriteLine($"8) Minute -> {d1.Minute}");
            Console.WriteLine($"9) Month -> {d1.Month}");
            Console.WriteLine($"10) Second -> {d1.Second}");
            Console.WriteLine($"11) Ticks -> {d1.Ticks}");
            Console.WriteLine($"12) TimeOfDay -> {d1.TimeOfDay}");
            Console.WriteLine($"13) Year -> {d1.Year}");

            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Format - DateTime -> String:");
            DateTime d2 = DateTime.Now;

            string s1 = d2.ToLongDateString();
            string s2 = d2.ToLongTimeString();
            string s3 = d2.ToShortDateString();
            string s4 = d2.ToShortTimeString();
            string s5 = d2.ToString();
            string s6 = d2.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d2.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine($"ToLongDateString -> {s1}");
            Console.WriteLine($"ToLongTimeString -> {s2}");
            Console.WriteLine($"ToShortDateString -> {s3}");
            Console.WriteLine($"ToShortTimeString -> {s4}");
            Console.WriteLine($"ToString() -> {s5}");
            Console.WriteLine($"ToString(yyyy - MM - dd HH: mm:ss) -> {s6}");
            Console.WriteLine($"ToString(yyyy - MM - dd HH: mm:ss.fff) -> {s7}");

            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Format - DateTime -> String:");
            DateTime d3 = DateTime.Now;

            DateTime x = DateTime.Now;

            DateTime y1 = x.AddDays(3);
            DateTime y2 = x.AddHours(3);
            DateTime y3 = x.AddMilliseconds(3);
            DateTime y4 = x.AddMinutes(3);
            DateTime y5 = x.AddMonths(3);
            DateTime y6 = x.AddSeconds(3);
            DateTime y7 = x.AddTicks(3);
            DateTime y8 = x.AddYears(3);

            TimeSpan t1 = y5.Subtract(x);

            Console.WriteLine($"DateTime Now -> {x}");
            Console.WriteLine($"AddDays -> {y1}");
            Console.WriteLine($"AddHours -> {y2}");
            Console.WriteLine($"AddMilliseconds -> {y3}");
            Console.WriteLine($"AddMinutes -> {y4}");
            Console.WriteLine($"AddMonths -> {y5}");
            Console.WriteLine($"AddSeconds -> {y6}");
            Console.WriteLine($"AddTicks -> {y7}");
            Console.WriteLine($"AddYears -> {y8}");
            Console.WriteLine($"Subtract (y5 - x) -> {t1}");
        }
    }
}
