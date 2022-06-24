namespace Library
{
    public class Probability
    {

        public static int count;
        //public static Dictionary<int, string> selectedCards = new Dictionary<int, string>();
        public static List<string> posiciones = new List<string>();

        //public static float Factorial(int n)

        public static List<string> selectedCards = new List<string>();

        public static double Factorial(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        //Combinaciones donde numA es el numero del total y numB en cuanto quiero tomar las variaciones.
        public static double Combinacion(int numA, int numB)
        {
            double result = (Factorial(numA) / ((Factorial(numA - numB) * Factorial(numB))));
            return result;
        }

        //Metodo que se encarga de calcular la probabilidad de color a partir de las dos cartas que recibe por parametro.
        public static double ColorProbability(string cardToCalculate1, string cardToCalculate2)
        {
            int favCases = 0;

            string[] splitCard1 = cardToCalculate1.Split(" ");
            string[] splitCard2 = cardToCalculate2.Split(" ");

            string paloC1 = splitCard1[1];
            string paloC2 = splitCard2[1]; 
            int cartasRestantes = 38; // Por ahora es 38 ya que no se conoce bien su funcionamiento, discutir profe
            int palosRestantes = 1;


            foreach (var element in Card.allCards)
            {
                if(paloC1 != paloC2)
                {
                    if (element.Contains(paloC1) /*|| element.Contains(paloC2)*/) // Es lo mismo poner un solo palo porque la cuenta que se hace se multiplican por 2 los valores, si se ponen los dos palos se multiplicarian por 4 
                    {
                    favCases++; // En teoria si mis calculos no me fallan deben ser siempre 12 a no ser que se repita el mismo palo 
                    Console.WriteLine(favCases);
                    palosRestantes = 2;
                    }
                }
                else
                {
                    favCases = 11;
                    palosRestantes = 3;
                }
            }
            //double colorProbability = 2 * ((((Combinacion(favCases, 4) * 38) + Combinacion(favCases, 5)) + Combinacion(26, 5)en teoria esta cambia si son iguales)/Combinacion(50, 5));
            double colorProbability = 2 * ((Combinacion(favCases, 4) * cartasRestantes) + Combinacion(favCases, 5))/Combinacion(50, 5) + palosRestantes * Combinacion(26, 5)/Combinacion(50, 5);
            return colorProbability;
        }

        //Metodo que se encarga de calcular la probabilidad de que salga poker, separa el string recibido y a partir de lo que busca (numeros en este caso) calcula las probabilidades.
        public static double PokerProbability(string cardToCalculate1, string cardToCalculate2)
        {
            int favCases = 0;

            string[] splitCard1 = cardToCalculate1.Split(" ");
            string[] splitCard2 = cardToCalculate2.Split(" ");
            string numC1 = splitCard1[0];
            string numC2 = splitCard2[0];


            foreach (var element in Card.allCards)
            {
                if (element.Contains(numC1) || element.Contains(numC2))
                {
                    favCases++;
                }
            }

            double pokerProbability = Combinacion(favCases, 4);
            return pokerProbability;
        }

        //Metodo que se encarga de verificar cual es la cantidad de casos que nos sirven dependiendo de la carta que le pasemos. 
        //verifica cuantas cartas con el mismo palo quedan en el mazo
        public static void GenerateStatics(string card1, string card2)
        {
            double colorProbability = ColorProbability(card1, card2);
            double pokerProbability = PokerProbability(card1, card2);
            double escaleraProbability = EscaleraProbability(card1,card2);
            Console.WriteLine($"Probabilidad de obtener juegos con las cartas [{card1}] y [{card2}] son: \n Color: {colorProbability} \n Poker: {pokerProbability} \n  Escalera: {escaleraProbability}");
        }

        public static double EscaleraProbability(string cardToCalculate1, string cardToCalculate2)
        {
            
            List<string> escaleraReal = new List<string>()
            {
                "10","K","Q","J","A"
            };
            double escaleraProbability = 0;
            string[] splitCard1 = cardToCalculate1.Split(" ");
            string[] splitCard2 = cardToCalculate2.Split(" ");
            string numC1 = splitCard1[0];
            string numC2 = splitCard2[0];



            foreach (var card in escaleraReal)
            {
                if(numC1 != card && numC2 != card)
                {
                    escaleraProbability = 4/ Combinacion(50,2)*100;
                }
                
            }
            return escaleraProbability;
        
        }

    }
}