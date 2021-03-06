namespace Library
{
    public class Probability
    {

        public static int count;
        public static List<string> posiciones = new List<string>();


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
            double result = Factorial(numA) / (Factorial(numA - numB) * Factorial(numB));
            return result;
        }

        //Metodo que se encarga de calcular la probabilidad de color a partir de las dos cartas que recibe por parametro.
        public static double ColorProbability(string cardToCalculate1, string cardToCalculate2)
        {
            

            string[] splitCard1 = cardToCalculate1.Split(" ");
            string[] splitCard2 = cardToCalculate2.Split(" ");

            string paloC1 = splitCard1[1];
            string paloC2 = splitCard2[1]; 
            double colorProbability = 0;


            
            if(paloC1 != paloC2)
            {
                
                colorProbability = (2 * ((Combinacion(12, 4) * 38) + Combinacion(12, 5))/Combinacion(50, 5) + 2 * Combinacion(13, 5)/Combinacion(50, 5))*100;
                return ReducirNumero(colorProbability);        
            }
            else
            {
                colorProbability = ( 2 * (Combinacion(13, 5) / Combinacion(50, 5)) + (Combinacion(11,3)*Combinacion(39,2))/Combinacion(50,5) + (Combinacion(11,4)*39)/Combinacion(50,5) +( Combinacion(11,5) / Combinacion(50,5)))*100;
                
                return ReducirNumero(colorProbability);
            }
        }

        //Metodo que se encarga de verificar cual es la cantidad de casos que nos sirven dependiendo de la carta que le pasemos. 
        //verifica cuantas cartas con el mismo palo quedan en el mazo
        public static void GenerateStatics(string card1, string card2)
        {
            double colorProbability = ColorProbability(card1, card2);
            double escaleraProbability = EscaleraProbability(card1,card2);
            double fullProbability = FullProbability(card1,card2);
            Console.WriteLine($"Probabilidad de obtener juegos con las cartas [{card1}] y [{card2}] son: \n Color: {colorProbability} % \n  Escalera: {escaleraProbability} %  \n  Full {fullProbability}");
        }


        public static double FullProbability(string cardToCalculate1, string cardToCalculate2)
        {
            
            string[] splitCard1 = cardToCalculate1.Split(" ");
            string[] splitCard2 = cardToCalculate2.Split(" ");
            string numC1 = splitCard1[0];
            string numC2 = splitCard2[0];
            double resultFull = 0;
            //Esta es la cuenta para cuando las dos primeras cartas tienen distinto valor
            if (numC1 != numC2)
            {
                resultFull = (2*(Combinacion(3,2)*Combinacion(3,1)*Combinacion(44,2)) + (Combinacion(3,2) * Combinacion(3,2) * Combinacion(44,1)))/Combinacion(50,2) + (11 * Combinacion(4,3) * Combinacion(4,2))/Combinacion(50,5);
                
                return ReducirNumero(resultFull);
            }
            else
            {
                resultFull = ((2 * Combinacion(26, 5)) / Combinacion(50, 5) + 11*Combinacion(4,3) * Combinacion(4,2)/Combinacion(50,5) + Combinacion(2,1) * Combinacion(12,2)*4 * Combinacion(47,2)/Combinacion(50,5) + Combinacion(12,3)*Combinacion(47,2)/ Combinacion(50,5))*100;
                return ReducirNumero(resultFull);
            }
        
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
            string paloC1 = splitCard1[1];
            string paloC2 = splitCard2[1];
            
            int ni = 0; // ni = no iguales para saber que los numeros de input no son iguales
            int s1 = 0; // s1 = para saber que solo el primero es igual
            int s2 = 0; // s2 = para saber que el segundo es igual
            int di = 0; // di = dos iguales, para saber que los dos pertenecientes a la escalera

            //Primero hago un foreach para saber si las dos cartas de inicio sirven para hacer una escalera,
            // si no son asi se sigue el codigo al otro foreach
        
            foreach (var card in escaleraReal)
            {
                if((numC1 == card || numC2 == card) && (paloC1 == paloC2))//cuando son distinto valor y igual palo 
                {
                    di ++;
                    if (di == 2)
                    {
                        escaleraProbability = ((3 / Combinacion(50,5)) + (Combinacion(47,2)/Combinacion(50,5)))* 100;
                        return ReducirNumero(escaleraProbability);
                    }
                }
                else if((numC1 == card || numC2 == card) && (paloC1 != paloC2) )// cuando son distinto palo y pertenecen a una escalera
                {
                    if(numC1 == numC2)//  Esto es para cuando son de valor igual
                    {
                        escaleraProbability = ((2/Combinacion(50,5)) + (2*46/Combinacion(50,5)))*100; //  Esto es para cuando son de valor igual
                        return ReducirNumero(escaleraProbability);
                    }
                    s2++;
                    if(s2 == 2)// Esto para cuando son de valor distinto
                    {
                        escaleraProbability = ((2/Combinacion(50,5)) + (2*46/Combinacion(50,5)))*100; 
                        return ReducirNumero(escaleraProbability);

                    }

                }
            }

            foreach (var card in escaleraReal)
            {
                if(numC1 != card && numC2 != card)
                {
                    ni ++;
                    if(ni == 5)
                    {
                        escaleraProbability = (4/ Combinacion(50,5))*100; // para cuando los dos primeros no sirven 
                        return ReducirNumero(escaleraProbability);
                    }  
                }
                else if((numC1 == card && numC2 != card) || (numC1 != card && numC2 == card))
                {
                    s1 ++;
                    if(s1 == 1)
                    {
                        escaleraProbability =  ((3/Combinacion(50,5) ) +  46/Combinacion(50,5))*100 ; //para cuando tenemos una que sirve y otra no.
                        return ReducirNumero(escaleraProbability);
                    }
                    
                }
                
            }
            return escaleraProbability;
        
        }

        public static double ReducirNumero(double numero)
        {
            string numeroStr = numero.ToString();
            string strNew ="";
            
            for (int i = 0; i < 7; i++)  // todo esto del for es para escribir la probabilidad 
            {
                strNew +=numeroStr[i];
            }
            double result = Convert.ToDouble(strNew);
            return result;
        }
    }
}