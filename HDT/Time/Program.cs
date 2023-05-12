using System;

namespace Program
{
    class Time_Test
    {
        public static void Main()
        {
            // Input + Daclare 
            Time t1 = new Time(23,59,59);
            Time t2 = new Time(0,0,0);

            // Output
            // NextSecond()
            System.Console.WriteLine(t1.toString());
            System.Console.WriteLine(t1.nextSecond().toString());
            // PreviousSecond()
            System.Console.WriteLine(t2.toString());
            System.Console.WriteLine(t2.previousSecond().toString());
            // AddSecond()
            System.Console.WriteLine($"Gio ban dau: {t2.toString()}");
            System.Console.WriteLine($"Gio sau khi thay doi: {t2.addSecond().toString()}");
            // LessSecond()
            System.Console.WriteLine($"Gio ban dau: {t2.toString()}");
            System.Console.WriteLine($"Gio sau khi thay doi: {t2.lessSecond().toString()}");

        }
    }
}