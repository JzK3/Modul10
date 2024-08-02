namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter a first integer value - ");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("Enter a second integer value - ");
                    int y = int.Parse(Console.ReadLine());
                    if (Int32.MaxValue >= x && Int32.MaxValue <= y) { throw new Exception(); }
                    Calculator calculator = new Calculator();
                    int result = calculator.Calculate(x, y);
                    Console.WriteLine($"Summ of {x} and {y} = {result}");
                    Thread.Sleep(2000);
                }
                catch (Exception) { Console.WriteLine("Entered a incorrect value! \r\nEnter a integer value "); }
            }
        }
    }
}
