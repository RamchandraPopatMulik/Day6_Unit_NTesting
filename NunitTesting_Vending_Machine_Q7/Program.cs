namespace NunitTesting_Vending_Machine_Q7
{
    internal class MonthPayment
    {
        public static int Principal, Year;
        public static double Interest;

        public MonthPayment(int principal, int year, double interest)
        {
            Principal = principal;
            Year = year;
            Interest = interest;

        }
        public static void calculatePaymnet()
        {
            Console.WriteLine("Please Enter Your Principal : ");
            int principal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Your Year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Your Interest : ");
            double interest = Convert.ToDouble(Console.ReadLine());

            int Month = 12 * year;
            double Rate = interest / (12 * 100);
            double Payment = (principal * Rate) / (1 - Math.Pow((1 + Rate), -Month));
            Console.WriteLine("Monthly EMI is : " + Payment);
        }


        static void Main(string[] args)
        {
            MonthPayment.calculatePaymnet();
        }
    }
}