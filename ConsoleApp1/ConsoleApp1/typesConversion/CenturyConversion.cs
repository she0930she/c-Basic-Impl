using System;

namespace ConsoleApp1.typesConversion
{
    public class CenturyConversion
    {
        private int Century { get; set; }
        private int Years { get; set; }
        private long Days { get; set; }
        private long Hours { get; set; }
        private long Minutes { get; set; }
        private long Seconds { get; set; }
        private long Milliseconds { get; set; }
        private long Microseconds { get; set; }
        private long Nanoseconds { get; set; }

        public void CenturyConversionDetail(int century)
        {
            Century = century;
            Years = 100 * Century;
            Days = 365 * Years;
            Hours = 24 * Days;
            Minutes = 60 * Hours;
            Seconds = 60 * Minutes;
            Milliseconds = (long) Math.Pow(10, 3) * Seconds;
            Microseconds = (long) Math.Pow(10, 3) * Milliseconds;
            Nanoseconds = (long) Math.Pow(10, 3) * Microseconds;
            
            Console.WriteLine($"Century: {Century}");
            Console.WriteLine($"Years: {Years}");
            Console.WriteLine($"Days: {Days}");
            Console.WriteLine($"Hours: {Hours}");
            Console.WriteLine($"Minutes: {Minutes}");
            Console.WriteLine($"Seconds: {Seconds}");
            Console.WriteLine($"Milliseconds: {Milliseconds}");
            Console.WriteLine($"Microseconds: {Microseconds}");
            Console.WriteLine($"Nanoseconds: {Nanoseconds}");

        }
    }
}