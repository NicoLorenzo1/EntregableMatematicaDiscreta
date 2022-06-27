using System.Collections;

namespace Library
{
    public class Menu
    {
        public static void ShowMenu()
        {
            int n = 0;

            Console.WriteLine("Estas son las cartas disponibles, elige dos ingresando el número que se encuentra delante:\n");
            foreach (var card in Card.allCards)
            {
                n++;
                Console.WriteLine($"{n}- {card}\n");
            }

            //Enviar la primer carta a elegir
            Console.WriteLine("Selecciona la primer carta");
           
            
        
            string num = Console.ReadLine();
            int carta1Num = int.Parse(num);
            // chequea que el numero que elige el usuario no sea mayor a 52 y menor a 0
            if (carta1Num > 52 || carta1Num < 0 || carta1Num == 0)
            {
                Console.WriteLine("No tenemos una carta disponible para ese numero");
                ShowMenu();        
            }            
                
        
            //Enviar la segunda carta a elegir
            Console.WriteLine("Selecciona la segunda carta");
           
           
            int carta2Num = int.Parse(Console.ReadLine());
            // chequea que el numero que elige el usuario no sea mayor a 52 y menor a 0
            if ( carta2Num > 52  || carta2Num < 0 || carta2Num == 0)
            {
                Console.WriteLine("No tenemos una carta disponible para ese numero");
                ShowMenu();
            }

            //Asigno cuales son las cartas que quiero remover a partir de sus posiciones.
            string selectedCard1 = Card.allCards.ElementAt(carta1Num - 1);
            string selectedCard2 = Card.allCards.ElementAt(carta2Num - 1);

            Card.DeletedSelectedCards(selectedCard1);
            Card.DeletedSelectedCards(selectedCard1);

            Probability.GenerateStatics(selectedCard1, selectedCard2);
        }
    }
}