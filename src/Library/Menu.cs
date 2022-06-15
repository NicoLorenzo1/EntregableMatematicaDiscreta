using System.Collections;

namespace Library
{
    public static class Menu
    {
        public static void ShowMenu()
        {
            int n = 0;
            List<string> listString = new List<string>();
            ArrayList arrayList = new ArrayList();
            Dictionary<int, string> searchDicc = new Dictionary<int, string>();
            Console.WriteLine("Estas son las cartas disponibles, elige dos ingresando el número que se encuentra delante:\n");
            foreach (var list in Card.AllCards)
            {
                foreach (var card in list)
                {
                    n++;
                    Console.WriteLine($"{n}- [{card.Key} {card.Value}]\n");
                    //arrayList.Add("en la posicion" + n);
                    //arrayList.Add(card.Key + card.Value);
                    listString.Add(card.Key.ToString());
                    listString.Add(card.Value.ToString());

                    //arrayList.Add(card.Value);
                }
            }
            Console.WriteLine("Selecciona la primer carta");
            int carta1Num = int.Parse(Console.ReadLine());

            if (carta1Num <= 52)
            {
                int spos1 = arrayList.IndexOf(carta1Num);
                //string spos2 = arrayList.;

                Probability.posiciones.Add(listString.ElementAt(0));
                Probability.posiciones.Add(listString.ElementAt(1));


            }
            /*
            else
            {
                Console.WriteLine("No temeos una carta disponible para ese numero");
            }

            Console.WriteLine("Selecciona la segunda carta");
            int carta2Num = int.Parse(Console.ReadLine());

            if (carta2Num <= 52)
            {
                Probability.selectedCards.Add(Card.AllCards.ElementAt(carta2Num - 1));
            }
            else
            {
                Console.WriteLine("No temeos una carta disponible para ese numero");
            }*/
            // Console.WriteLine(Probability.selectedCards);
            //Console.WriteLine(Probability.selectedCards.ElementAt(1).ContainsKey("5"));

            /*
                        foreach (var dicc in Probability.selectedCards)
                        {
                            foreach (var carta in dicc)
                            {
                                Console.WriteLine(carta.Key + carta.Value);
                            }
                        }
                        */
            foreach (var item in Probability.posiciones)
            {
               // Console.WriteLine(item);
            }
            /*
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            */
        }
    }
}