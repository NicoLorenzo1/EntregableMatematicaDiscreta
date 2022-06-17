using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Card.AddToDiccionary();
            //Console.WriteLine(Probability.Combinacion(12, 4));
            //Console.WriteLine(Probability.Factorial(12));
            //Console.WriteLine(Probability.Factorial(12 - 4));
            //Console.WriteLine(Probability.Factorial(4));
            Menu.ShowMenu();
            
            Probability.ColorProbability();
        }
    }
}