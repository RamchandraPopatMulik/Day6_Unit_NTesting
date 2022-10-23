namespace NunitTesting_Vending_Machine_Q7
{
    internal class IntegerToBinary
    {
        public static int Num;
        public IntegerToBinary(int num)
        {
            Num = num;
        }
        public static void convertIntegerToBinary()
        {
            Console.WriteLine("Please Enter Your Number :");
            int Num = Convert.ToInt32(Console.ReadLine());

            int result = ((Num & 0x0f) << 4 | (Num & 0x0f) >> 4);
            Console.WriteLine("Decimal Number by Swapping Nipple is : " + result);

            if (result == 0)
            {
                Console.WriteLine("Number is Power Of 2");
            }
            while (result != 0)
            {
                if (result % 2 != 0)
                {
                    Console.WriteLine("Number is Power Of 2");
                    break;
                }
                result = result / 2;
            }
            if (result == 2)
            {
                Console.WriteLine("The Number is Power Of 2");
            }

        }
        static void Main(string[] args)
        {
            IntegerToBinary.convertIntegerToBinary();
        }
    }
}