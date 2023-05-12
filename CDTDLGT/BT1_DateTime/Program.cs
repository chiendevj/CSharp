using System;
namespace Program
{
    class BT1_DateTime
    {
        public static void Main()
        {
            // Calare Varialbe
            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2023,2,6,10,22,55);
            //int weekDay = d2.DayOfWeek;
            System.Console.WriteLine("Bay gio la: " + d2);
        }
    }
}
