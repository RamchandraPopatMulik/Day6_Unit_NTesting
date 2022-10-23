namespace NunitTesting_Vending_Machine_Q7
{
    internal class DecimalToBinary
    {
        public static int Num;

        public DecimalToBinary(int num)
        {
            Num = num;
        }
        public static void convertDecimaltoBinary()
        {
            Console.WriteLine("Please Enter Your Number:");
            int Num = Convert.ToInt32(Console.ReadLine());
            string result = "";
            while (Num > 0)
            {
                int r = Num % 2;
                result = Convert.ToString(r) + result;
                Num /= 2;
            }
            Console.WriteLine("Conversion Of Decimal to Binary is :" + result);
        }
        static void Main(string[] args)
        {
            DecimalToBinary.convertDecimaltoBinary();
        }

    }
}