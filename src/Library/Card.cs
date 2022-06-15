namespace Library;
public class Card
{
    public static List<Dictionary<string, string>> AllCards = new List<Dictionary<string, string>>();
    /*
    public static Dictionary<string, string> allCardsDictionary = new Dictionary<string, string>()
    {
        {"2", "pica"},
        {"3", "pica"},
        {"4", "pica"},
        {"5", "pica"},
        {"6", "pica"},
        {"7", "pica"},
        {"8", "pica"},
        {"9", "pica"},
        {"10", "pica"},
        {"2", "diamante"},
        {"3", "diamante"},
        {"4", "diamante"},
        {"5", "diamante"},
        {"6", "diamante"},
        {"7", "diamante"},
        {"8", "diamante"},
        {"9", "diamante"},
        {"10", "diamante"},
        {"2", "trebol"},
        {"3", "trebol"},
        {"4", "trebol"},
        {"5", "trebol"},
        {"6", "trebol"},
        {"7", "trebol"},
        {"8", "trebol"},
        {"9", "trebol"},
        {"10", "trebol"},
        {"2", "corazon"},
        {"3", "corazon"},
        {"4", "corazon"},
        {"5", "corazon"},
        {"6", "corazon"},
        {"7", "corazon"},
        {"8", "corazon"},
        {"9", "corazon"},
        {"10", "corazon"},
        {"J", "pica"},
        {"Q", "pica"},
        {"K", "pica"},
        {"A", "pica"},
        {"J", "diamante"},
        {"Q", "diamante"},
        {"K", "diamante"},
        {"A", "diamante"},
        {"J", "trebol"},
        {"Q", "trebol"},
        {"K", "trebol"},
        {"A", "trebol"},
        {"J", "corazon"},
        {"Q", "corazon"},
        {"K", "corazon"},
        {"A", "corazon"}
    };
*/

    public static Dictionary<string, string> pica = new Dictionary<string, string>()
    {
        {"2", "pica"},
        {"3", "pica"},
        {"4", "pica"},
        {"5", "pica"},
        {"6", "pica"},
        {"7", "pica"},
        {"8", "pica"},
        {"9", "pica"},
        {"10", "pica"},
    };
    public static Dictionary<string, string> diamante = new Dictionary<string, string>()
    {
        {"2", "diamante"},
        {"3", "diamante"},
        {"4", "diamante"},
        {"5", "diamante"},
        {"6", "diamante"},
        {"7", "diamante"},
        {"8", "diamante"},
        {"9", "diamante"},
        {"10", "diamante"}
    };

    public static Dictionary<string, string> trebol = new Dictionary<string, string>()
    {
        {"2", "trebol"},
        {"3", "trebol"},
        {"4", "trebol"},
        {"5", "trebol"},
        {"6", "trebol"},
        {"7", "trebol"},
        {"8", "trebol"},
        {"9", "trebol"},
        {"10", "trebol"}
    };

    public static Dictionary<string, string> corazon = new Dictionary<string, string>()
    {
    {"2", "corazon"},
    {"3", "corazon"},
    {"4", "corazon"},
    {"5", "corazon"},
    {"6", "corazon"},
    {"7", "corazon"},
    {"8", "corazon"},
    {"9", "corazon"},
    {"10", "corazon"}
    };


    public static Dictionary<string, string> cartasAltasPica = new Dictionary<string, string>()
    {
        {"J", "pica"},
        {"Q", "pica"},
        {"K", "pica"},
        {"A", "pica"}

    };

    public static Dictionary<string, string> cartasAltasDiamante = new Dictionary<string, string>()
    {
        {"J", "diamante"},
        {"Q", "diamante"},
        {"K", "diamante"},
        {"A", "diamante"}

    };

    public static Dictionary<string, string> cartasAltasTrebol = new Dictionary<string, string>()
    {
        {"J", "trebol"},
        {"Q", "trebol"},
        {"K", "trebol"},
        {"A", "trebol"}

    };

    public static Dictionary<string, string> cartasAltasCorazon = new Dictionary<string, string>()
    {
        {"J", "corazon"},
        {"Q", "corazon"},
        {"K", "corazon"},
        {"A", "corazon"}
    };

    public static void AddToDiccionary()
    {
        AllCards.Add(corazon);
        AllCards.Add(pica);
        AllCards.Add(trebol);
        AllCards.Add(diamante);
        AllCards.Add(cartasAltasCorazon);
        AllCards.Add(cartasAltasDiamante);
        AllCards.Add(cartasAltasPica);
        AllCards.Add(cartasAltasTrebol);
    }

}
