namespace Task2
{
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Logger = new Logger();
                    var calculator = new Calculator(Logger);
                    Console.Write("Enter a first integer value - ");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("Enter a second integer value - ");
                    int y = int.Parse(Console.ReadLine());
                    if (Int32.MaxValue >= x && Int32.MaxValue <= y) { throw new Exception(); }
                    var result = calculator.Calculate(x, y);
                    Console.WriteLine(result);
                }
                catch (Exception)
                {
                    Logger.Error("ERROR!!! VALUE IS INCORRECT");
                }
            }
        }
    }
}
