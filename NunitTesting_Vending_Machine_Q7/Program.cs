namespace NunitTesting_Vending_Machine_Q7
{
    internal class DayOfWeek
    {
        public static int Date, Month, Year;

        public DayOfWeek(int date, int month, int year)
        {
            Date = date;
            Month = month;
            Year = year;
        }
        public static void findDayOfWeek()
        {
            Console.Write("Enter Date : ");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Month : ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Year : ");
            int year = Convert.ToInt32(Console.ReadLine());

            int x = 0, y0 = 0, m0 = 0, d0;
            y0 = year - (14 - month) / 12;
            x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            m0 = month + 12 * ((14 - month) / 12) - 2;
            d0 = (date + x + 31 * m0 / 12) % 7;

            switch (d0)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Thuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }
        }
        static void Main(string[] args)
        {
            DayOfWeek.findDayOfWeek();
        }
    }
}