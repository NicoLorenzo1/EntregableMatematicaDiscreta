namespace Library
{
    public class Probability
    {
        public static Dictionary<int, string> selectedCards = new Dictionary<int, string>();
        public static List<string> posiciones = new List<string>();
        /*
        public static float Factorial(int n)
        {
            {
                int fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact *= i;
                }
                Console.WriteLine("El Factorial de " + n + " es: " + fact);
                return fact;
                
            }
            
        }
        */

        public static double Factorial(int n)
        {
            
            if((n== 0) || (n==1))
            {
                return 1;
            }
            else
            {
                return n * Factorial(n-1);
            }

        }

        //Combinaciones donde numA es el numero del total y numB en cuanto quiero tomar las variaciones.
        public static double Combinacion(int numA, int numB)
        {
            double result = (Factorial(numA) / (Factorial(numA - numB) * Factorial(numB)));

            return result;
        }
        public static void ColorProbability()
        {

            //int C12In4 = Combinacion(12,5);
            // int C52In5 = Combinacion(52,5);
            //float primeraSuma = 2*(((Combinacion(12,4)*38)/(Combinacion(52,5))) + (Combinacion(12,5)/Combinacion(52,5)));
            //float segundaSuma = 2*((Combinacion(26,5)/Combinacion(52,5)));

            double colorProbability = 2 * (((Combinacion(12, 4) * 38) + Combinacion(12, 5)) + Combinacion(26, 5));
            colorProbability = colorProbability*(Combinacion(52,5));

            //float colorProbability = primeraSuma + segundaSuma;

            Console.WriteLine($"La probabilidad de obtener una jugada color es {colorProbability}");
        }
    }
}