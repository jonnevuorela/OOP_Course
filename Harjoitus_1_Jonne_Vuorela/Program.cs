using System.Globalization;
namespace Harjoitus_1_Jonne_Vuorela;

class Program
{
    static void Main(string[] args)
    {
        //1. printtaa tiedot
        string name = "Jonne Vuorela";
        string studentTag = "R54T23S";
        Console.WriteLine("1.\n" + name + "\n" + studentTag);

        string inputString;

        //2. stringin muunto 1
        Console.WriteLine("2. Anna muunnettava sana, joka muutetaan isoiksi kirjaimiski.");
        while (true) // pyörittää looppia niin kauvan, että saadaan käypä input
        {
            inputString = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputString)) //whitespace handling
            {
                Console.WriteLine("Sana puuttuu. Yritä uudelleen: ");
            }
            else
            {
                UpperString(inputString);
                break;
            }
        }

        //3. stringin muunto 2
        Console.WriteLine("3. Anna muunnettava sana, joka muutetaan pieniksi kirjaimiksi");
        while (true) // pyörittää looppia niin kauvan, että saadaan käypä input
        {
            inputString = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputString)) //whitespace handling
            {
                Console.WriteLine("Sana puuttuu. Yritä uudelleen: ");
            }
            else
            {
                LowerString(inputString);
                break;
            }
        }

        //4. String to int muunnos
        Console.WriteLine("4. Syötä luku josta vähennetään 10: ");
        while (true) // pyörittää looppia niin kauvan, että saadaan käypä input
        {
            inputString = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputString)) //whitespace handling
            {
                Console.WriteLine("Luku puuttuu. Yritä uudelleen: ");
            }
            else
            {
                if (SubstractString(out inputString, inputString)) //vastaanottaa metodista tyhjän stringin, mikäli input on huono 
                {

                    break;
                }
            }
        }

        //5. ikä vuoden lasku
        Console.WriteLine("5. Syötä syntymävuosi: ");
        while (true) // pyörittää looppia niin kauvan, että saadaan käypä input
        {
            inputString = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputString)) //whitespace handling
            {
                Console.WriteLine("Vuosi puuttuu. Yritä uudelleen: ");
            }
            else
            {
                if (CalculateYear(out inputString, inputString))//vastaanottaa metodista tyhjän stringin, mikäli input on huono
                {
                    break;
                }
            }
        }

        //6. Lausen string split array
        Console.WriteLine("6. Kirjoita lause: ");
        while (true) // pyörittää looppia niin kauvan, että saadaan käypä input
        {
            inputString = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputString)) //whitespace handling
            {
                Console.WriteLine("Lause puuttuu. Yritä uudelleen: ");
            }
            else
            {
                if (SplitSentence(out inputString, inputString))//vastaanottaa metodista tyhjän stringin, mikäli input on huono
                {
                    break;
                }
            }
        }




    }
    static bool SplitSentence(out string inputString, string inputSentence)
    {
        string answer;
        string[] words = inputSentence.Split(" ");
        if (words.Length == 0)
        {
            answer = "Lauseessa ei ole sanoja, yritä uudelleen: ";
            Console.WriteLine(answer);
            inputString = "";
            return false;
        }
        else
        {
            for (int i = 0; 1 < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            inputString = inputSentence;
            return true;
        }
    }
    static bool CalculateYear(out string inputString, string yearString)
    {
        string answer;
        if (!float.TryParse(yearString, out float year))
        {
            answer = "Vastausta ei voitu käsitellä, yritä uudelleen: ";
            Console.WriteLine(answer);
            inputString = "";  //välitä tyhjä string, triggeroidakseen uusi inputin kuuntelu.
            return false;
        }
        else
        {
            year = year + 50; //maths
            inputString = "vuosi jolloin täytät viisikymmentä (50) on: " + year.ToString();
            Console.WriteLine(inputString);
            return true;
        }
    }

    static bool SubstractString(out string inputString, string numberString)
    {
        string answer;
        if (!float.TryParse(numberString, out float number)) //tarkistetaan saadaanko inputista vastaus
        {
            answer = "Vastausta ei voitu käsitellä, yritä uudelleen: ";
            Console.WriteLine(answer);
            inputString = ""; //välitä tyhjä string, triggeroidakseen uusi inputin kuuntelu.
            return false;
        }
        else
        {
            number = number - 10; //math
            inputString = "vastaus on: " + number.ToString(); //inputStringistä tulikin "outputString"
            Console.WriteLine(inputString);
            return true;
        }
    }
    static void LowerString(string word)
    {
        Console.WriteLine("Muunnettu sana: " + new CultureInfo("fi-FI", false).TextInfo.ToLower(word));
    }
    static void UpperString(string word)
    {
        Console.WriteLine("Muunnettu sana: " + new CultureInfo("fi-FI", false).TextInfo.ToUpper(word));

    }
}
