namespace Logical_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======Day of week=======");
            DayOfWeek.WeekDay();

            Console.WriteLine("\n======Decimal to Binary=======");
            DecimalToBinary.DecimalBinary();

            Console.WriteLine("\n======Swap Nibbles=======");
            Console.WriteLine("Enter a Number to Swap: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nSwapped Number is: {0}", SwapNibble.swapNibbles(x));

            Console.WriteLine("\n======Vending Machine=======");
            Console.WriteLine("Enter amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            VendingMachine.countCurrency(amount);

            Console.WriteLine("\n======Square Root=======");
            SquareRoot.Squrt();

            Console.WriteLine("\n======Monthly Payment=======");
            MonthlyPayment.MPayment();

            Console.WriteLine("\n======Temprature Conversion=======");
            TempratureConversion.TempConv();

          
        }
    }
}