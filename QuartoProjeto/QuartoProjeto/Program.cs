using System;
using System.Globalization;

namespace QuartoProjeto {
    internal class Program {
        static void Main(string[] args) {
            /*
            string original = "abcde FGHIJ ABC abc DEFG ";
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");
            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
            */

            /*
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d1.ToLongTimeString());
            Console.WriteLine(d1.ToShortDateString());
            Console.WriteLine(d1.ToShortTimeString());
            Console.WriteLine(d1.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine(d1.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            DateTime d2 = new DateTime(2021, 10, 25);
            DateTime d3 = new DateTime(2021, 10, 25, 20, 45, 3);
            DateTime d4 = new DateTime(2021, 10, 25, 20, 45, 3, 500);
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;
            DateTime d7 = DateTime.Parse("2000-08-15");
            DateTime d8 = DateTime.Parse("15/08/2000");
            DateTime d9 = DateTime.Parse("15/08/2000 13:05:58");
            DateTime d10 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d11 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
            */

            /*
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            TimeSpan t6 = TimeSpan.FromDays(1.5);
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t11 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);
            */

            /*
            DateTime d = new DateTime(2001, 8, 15);
            TimeSpan t = new TimeSpan(3, 4, 5, 7, 11);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
            Console.WriteLine("14) ToLongDateString: " + d.ToLongDateString());
            Console.WriteLine("15) ToLongTimeString: " + d.ToLongTimeString());
            Console.WriteLine("16) ToShortDateString: " + d.ToShortDateString());
            Console.WriteLine("17) ToShortTimeString: " + d.ToShortTimeString());
            Console.WriteLine("18) ToString: " + d.ToString());
            Console.WriteLine("19) ToString('yyyy-MM-dd HH:mm:ss'): " + d.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine("20) AddHours: " + d.AddHours(3));
            Console.WriteLine("21) AddMinutes: " + d.AddMinutes(3));
            Console.WriteLine("22) AddSeconds: " + d.AddSeconds(3));
            Console.WriteLine("23) AddMilliseconds: " + d.AddMilliseconds(3));
            Console.WriteLine("25) AddDays: " + d.AddDays(3));
            Console.WriteLine("26) AddMonths: " + d.AddMonths(3));
            Console.WriteLine("27) AddYears: " + d.AddYears(3));
            Console.WriteLine("28) Subtract: " + d.Subtract(new DateTime(2001, 8, 12)));
            Console.WriteLine("29) CompareTo: " + d.CompareTo(new DateTime(2001, 8, 12)));
            Console.WriteLine("30) Equals: " + d.Equals(new DateTime(2001, 8, 12)));
            Console.WriteLine("31) TimeSpanSubtract: " + d.Subtract(t));
            //e etc
            */

            /*
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Ticks: " + t.Ticks);

            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

            TimeSpan t4 = new TimeSpan(1, 30, 10);
            TimeSpan t5 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t4.Add(t5);
            TimeSpan dif = t4.Subtract(t5);
            TimeSpan mult = t4.Multiply(2.0);
            TimeSpan div = t4.Divide(2.0);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
            */

            /*
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 Kind: " + d3.Kind);
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());
            */

            /*
            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); //cuidado com o ToString direto garantir com o universaltime
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
            */
        }
    }
}