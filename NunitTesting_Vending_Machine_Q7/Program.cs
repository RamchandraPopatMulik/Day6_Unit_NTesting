namespace NunitTesting_Vending_Machine_Q7
{
    internal class VendingMachine
    {
        public int Number;

        public VendingMachine( int number)
        {
            Number = number;
        }
        
        public void calculateChange()
        {
            int thousand = 0;
            int fiveHundred = 0;
            int hundred = 0;
            int fifty = 0;
            int ten = 0;
            int five = 0;
            int two = 0;
            int one = 0;
            if (Number >= 1000)
            {
                while (Number >= 1000)
                {
                    Number = Number - 1000;
                    thousand++;
                }
                Console.WriteLine("1000 Rupees Notes :" + thousand);
            }
            if (Number >= 500)
            {
                while (Number >= 500)
                {
                    Number = Number - 500;
                    fiveHundred++;
                }
                Console.WriteLine("500 Rupees Notes :" + fiveHundred);
            }
            if (Number >= 100)
            {
                while (Number >= 100)
                {
                    Number = Number - 100;
                    hundred++;
                }
                Console.WriteLine("100 Rupees Notes :" + hundred);
            }
            if (Number >= 50)
            {
                while (Number >= 50)
                {
                    Number = Number - 50;
                    fifty++;
                }
                Console.WriteLine("50 Rupees Notes :" + fifty);
            }
            if (Number >= 10)
            {
                while (Number >= 10)
                {
                    Number = Number - 10;
                    ten++;
                }
                Console.WriteLine("1000 Rupees Notes :" + ten);
            }
            if (Number >= 5)
            {
                while (Number >= 5)
                {
                    Number = Number - 5;
                    five++;
                }
                Console.WriteLine("1000 Rupees Notes :" + five);
            }

            if (Number >= 5)
            {
                while (Number >= 5)
                {
                    Number = Number - 5;
                    five++;
                }
                Console.WriteLine("1000 Rupees Notes :" + five);
            }
            if (Number >= 2)
            {
                while (Number >= 2)
                {
                    Number = Number - 2;
                    two++;
                }
                Console.WriteLine("1000 Rupees Notes :" + two);
            }
            if (Number >= 1)
            {
                while (Number >= 1)
                {
                    Number = Number - 1;
                    one++;
                }
                Console.WriteLine("1000 Rupees Notes :" + one);
            }
        }
        
        static void Main(String []args)
        {
            Console.WriteLine("Please Enter Number of Rupees  :");
            int n=Convert.ToInt32 (Console.ReadLine());

            VendingMachine vendingMachine = new VendingMachine(n);
            vendingMachine.calculateChange();
        }
    }
}