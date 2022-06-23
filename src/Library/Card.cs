namespace Library
{
    //Clase que se encarga de manejar las cartas
    public class Card
    {
        //Lista con todas las cartas del mazo.
        public static List<string> allCards = new List<string>()
        {
            "2 pica",
            "3 pica",
            "4 pica",
            "5 pica",
            "6 pica",
            "7 pica",
            "8 pica",
            "9 pica",
            "10 pica",
            "J pica",
            "Q pica",
            "K pica",
            "A pica",
            "2 diamante",
            "3 diamante",
            "4 diamante",
            "5 diamante",
            "6 diamante",
            "7 diamante",
            "8 diamante",
            "9 diamante",
            "10 diamante",
            "J diamante",
            "Q diamante",
            "K diamante",
            "A diamante",
            "2 trebol",
            "3 trebol",
            "4 trebol",
            "5 trebol",
            "6 trebol",
            "7 trebol",
            "8 trebol",
            "9 trebol",
            "10 trebol",
            "J trebol",
            "Q trebol",
            "K trebol",
            "A trebol",
            "2 corazon",
            "3 corazon",
            "4 corazon",
            "5 corazon",
            "6 corazon",
            "7 corazon",
            "8 corazon",
            "9 corazon",
            "10 corazon",
            "J corazon",
            "Q corazon",
            "K corazon",
            "A corazon",
        };

        //Metodo que elimina la carta pasada por parametro y la añade en la lista "selectedCards".
        public static void DeletedSelectedCards(string card)
        {
            allCards.Remove(card);
            Probability.selectedCards.Add(card);
        }


        //Metodo que saca 5 cartas aleatorias del mazo, las borra y las agrega en la lista "selectedCards" para tener conocimiento de ellas.
        public static void AleatoryCards()
        {
            while (Probability.selectedCards.Count < 5)
            {
                Random random = new Random();
                int numero = random.Next(0, 51);

                string cardToSelect = allCards.ElementAt(numero);
                if (!Probability.selectedCards.Contains(cardToSelect))
                {
                    DeletedSelectedCards(cardToSelect);
                }
            }
        }
    }
}