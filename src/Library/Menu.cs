using System.Collections;

namespace Library
{
    public static class Menu
    {
        public static void ShowMenu()
        {
            int n = 0;
            Dictionary<int, string> indexCards = new Dictionary<int, string>();


            Console.WriteLine("Estas son las cartas disponibles, elige dos ingresando el número que se encuentra delante:\n");
            foreach (var dicc in Card.AllCards)
            {
                foreach (var card in dicc)
                {
                    n++;
                    Console.WriteLine($"{n}- [{card.Key} {card.Value}]\n");
                    indexCards.Add(n, card.Key + " " + card.Value);
                }
            }
            Console.WriteLine("Selecciona la primer carta");
            string num = Console.ReadLine();

            int carta1Num = int.Parse(num);

            //Console.WriteLine(indexCards[carta1Num]);

            if (carta1Num <= 52)
            {
                Probability.selectedCards.Add(indexCards[carta1Num]);
            }
            else
            {
                Console.WriteLine("No tenemos una carta disponible para ese numero");
                ShowMenu();

            }

            /*

            Console.WriteLine("Selecciona la segunda carta");
            int carta2Num = int.Parse(Console.ReadLine());

            if (carta2Num <= 52)
            {
                Probability.selectedCards.Add(indexCards[carta2Num]);

            }
            else
            {
                Console.WriteLine("No tenemos una carta disponible para ese numero");
                ShowMenu();
            }
            */
        }
    }
}