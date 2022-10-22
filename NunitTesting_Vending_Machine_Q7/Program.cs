namespace NunitTesting_Vending_Machine_Q7
{
    internal class Temperature
    {
        public static int Value;
        public Temperature(int value)
        {
            Value = value;
        }

        public static void temperatureConversion()
        {
            Console.WriteLine("Please Enter Value : ");
            int value = Convert.ToInt32(Console.ReadLine());

            switch (value)
            {
                case 1:
                    Console.WriteLine("Please Enter the Value to Convert Tempearture into Celcius: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int result1 = (a * 9 / 5) + 32;
                    Console.WriteLine("Celcius Value is:" + result1);
                    break;
                case 2:
                    Console.WriteLine("Please Enter the Value to Convert Tempearture into Fahrenheit: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    int result2 = (b - 32) * 5 / 9;
                    Console.WriteLine("Fahrenheit Value is:" + result2);
                    break;

            }
        }
        static void Main(string[] args)
        {
            Temperature.temperatureConversion();
        }
    }
}