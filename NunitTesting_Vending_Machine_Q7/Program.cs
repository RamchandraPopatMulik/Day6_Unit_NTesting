namespace NunitTesting_Vending_Machine_Q7
{
    internal class SquareNumber
    {
        public static int Number;
        public SquareNumber(int number)
        {
            Number = number;
        }
        public static void calculateSquareRoot()
        {
            Console.WriteLine("Please Enter Your Number :");
            int number = Convert.ToInt32(Console.ReadLine());

            double square = Math.Sqrt(number);
            Console.WriteLine("SquareRoot Of Number is : " + square);
        }

        static void Main(string[] args)
        {
            SquareNumber.calculateSquareRoot();
        }
    }
}