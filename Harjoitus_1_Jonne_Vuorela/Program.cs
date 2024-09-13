using System.Globalization;
namespace Harjoitus_1_Jonne_Vuorela;

class Program
{
    static void Main(string[] args)
    {
        string name = "Jonne Vuorela";
        string studentTag = "R54T23S";
        Console.WriteLine(name + "\n" + studentTag);

        Console.WriteLine("Anna muunnettava sana.");
        string inputWord = Console.ReadLine();
        if (inputWord == "" || inputWord == " ")
        {
            Console.WriteLine("Sana puuttuu");
            inputWord = Console.ReadLine();
        }
        else if (inputWord != null)
        {
            AlterString(inputWord);
        }



    }
    static void AlterString(string word)
    {
        TextInfo uword = new CultureInfo("fi-FI", false).TextInfo;
        Console.WriteLine("Muunnettu sana: " + uword.ToUpper(word));

    }
}
