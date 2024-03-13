namespace CalculatorConsole
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            double a = 7;
            double b = 10;

            var result = Matematics.Add(a, b);
            Console.WriteLine(result);
        }
    }
}
