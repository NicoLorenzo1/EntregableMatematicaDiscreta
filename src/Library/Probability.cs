namespace Library
{
    public class Probability
    {
        public static List<string> selectedCards = new List<string>();

        public static int Factorial(int n)
        {
            {
                int fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact *= i;
                }
                return fact;
                //Console.WriteLine("\nEl Factorial de " + n + " es: " + fact);
            }
        }

        //Combinaciones donde numA es el numero del total y numB en cuanto quiero tomar las variaciones.
        public static int Combinacion(int numA, int numB)
        {
            int result = Factorial(numA) / Factorial(numA - numB) * Factorial(numB);

            return result;
        }
        public static void ColorProbability()
        {

            //int C12In4 = Combinacion(12,5);
            // int C52In5 = Combinacion(52,5);

            float colorProbability = 2 * ((Combinacion(12, 4) * 38 + Combinacion(12, 5)) + 2 * Combinacion(26, 5));

            Console.WriteLine($"La probabilidad de obtener una jugada color es {colorProbability}");
        }
    }
}