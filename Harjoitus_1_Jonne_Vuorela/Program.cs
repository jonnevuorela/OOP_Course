using System.Globalization;
namespace Harjoitus_1_Jonne_Vuorela;

class Program
{
   static void Main(string[] args)
   {
   start:
      //1. printtaa tiedot
      string name = "Jonne Vuorela";
      string studentTag = "R54T23S";
      Console.WriteLine("1.\n" + name + "\n" + studentTag);

      string inputString;

      //2. stringin muunto 1
      Console.WriteLine("\n------------------------------------");
      Console.WriteLine("\n2. Anna muunnettava sana, joka muutetaan isoiksi kirjaimiski.");
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
      Console.WriteLine("\n------------------------------------");
      Console.WriteLine("\n3. Anna muunnettava sana, joka muutetaan pieniksi kirjaimiksi");
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
      Console.WriteLine("\n------------------------------------");
      Console.WriteLine("\n4. Syötä luku josta vähennetään 10: ");
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
      Console.WriteLine("\n------------------------------------");
      Console.WriteLine("\n5. Syötä syntymävuosi: ");
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
      Console.WriteLine("\n------------------------------------");
      Console.WriteLine("\n6. Kirjoita lause: ");
      bool valid;
      int wordCount;
      while (true) // pyörittää looppia niin kauvan, että saadaan käypä input
      {
         inputString = Console.ReadLine();
         if (string.IsNullOrWhiteSpace(inputString)) //whitespace handling
         {
            Console.WriteLine("Lause puuttuu. Yritä uudelleen: ");
         }
         else
         {
            if (SplitSentence(out wordCount, out valid, out inputString, inputString))
            //wordCount antaa vastauksen kohtaan 7.
            //valid muuttuja oikeuttaa etenemisen kohtaan 7. ja 8.
            //vastaanottaa metodista tyhjän stringin(inputString), mikäli input on huono
            {
               break;
            }
         }
      }
      //jos 6. kohdan input on käypä
      if (valid)
      {
         ///7. Tulosta lauseen sanojen määrä
         Console.WriteLine("\n------------------------------------");
         Console.WriteLine("\n7. Lauseessa on " + CountWords(wordCount) + " sanaa.");
         //tätä kohdassa 7. ei taidettua hakea, mutta tässä tulee ihan siisti data pipeline

         //8. Muuntaa lauseen sanojen ekat kirjaimet
         Console.WriteLine("\n------------------------------------");
         Console.WriteLine("\n8. lauseen sanojen alkukirjaimet isoiksi");
         AlterSentence(inputString);
      }

      //9. Kysy käyttäjältä lukua, kunnes syötetään luku 10
      Console.WriteLine("\n------------------------------------");
      Console.WriteLine("\n9. Syötä oikea luku jatkaaksesi: ");
      while (true) // pyörittää looppia niin kauvan, että saadaan käypä input
      {
         inputString = Console.ReadLine();
         if (string.IsNullOrWhiteSpace(inputString)) //whitespace handling
         {
            Console.WriteLine("Luku puuttuu. Yritä uudelleen: ");
         }
         else
         {
            if (GetRightNumber(out inputString, inputString)) //vastaanottaa metodista tyhjän stringin, mikäli input on huono 
            {

               break;
            }
         }
      }
      //10. Otetaan syötetyn luvun kertoma
      Console.WriteLine("\n------------------------------------");
      Console.WriteLine("\n10. Syötä kokonaisluku, josta otetaan kertoma: ");
      while (true) // pyörittää looppia niin kauvan, että saadaan käypä input
      {
         inputString = Console.ReadLine();
         if (string.IsNullOrWhiteSpace(inputString)) //whitespace handling
         {
            Console.WriteLine("Luku puuttuu. Yritä uudelleen: ");
         }
         else
         {
            if (FactorialNumber(out inputString, inputString)) //vastaanottaa metodista tyhjän stringin, mikäli input on huono 
            {

               break;
            }
         }
      }

      int select;
      bool inSwitch = true;
      while (inSwitch)
      {
         Console.WriteLine("\n------------------------------------");
         Console.WriteLine("\n11. Valitse toiminto");
         Console.WriteLine("0: Ohita valinta.");
         Console.WriteLine("1: Muunna sanan kirjaimet isoiksi.");
         Console.WriteLine("2: Muunna sanan kirjaimet pieniksi.");
         Console.WriteLine("3: Pilko lause sanoiksi.");

         if (int.TryParse(Console.ReadLine(), out select))
         {
            switch (select)
            {
               case 0:
                  {
                     inSwitch = false;
                     break;
                  }
               case 1:
                  {
                     Console.WriteLine("\n------------------------------------");
                     Console.WriteLine("\nAnna muunnettava sana, joka muutetaan isoiksi kirjaimiski.");
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
                     break;
                  }
               case 2:
                  {
                     Console.WriteLine("\n------------------------------------");
                     Console.WriteLine("\nAnna muunnettava sana, joka muutetaan pieniksi kirjaimiksi");
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
                     break;

                  }
               case 3:
                  {
                     Console.WriteLine("\n------------------------------------");
                     Console.WriteLine("\nKirjoita lause: ");
                     while (true) // pyörittää looppia niin kauvan, että saadaan käypä input
                     {
                        inputString = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(inputString)) //whitespace handling
                        {
                           Console.WriteLine("Lause puuttuu. Yritä uudelleen: ");
                        }
                        else
                        {
                           if (SplitSentence(out wordCount, out valid, out inputString, inputString))
                           //wordCount antaa vastauksen kohtaan 7.
                           //valid muuttuja oikeuttaa etenemisen kohtaan 7. ja 8.
                           //vastaanottaa metodista tyhjän stringin(inputString), mikäli input on huono
                           {
                              break;
                           }
                        }
                     }
                     break;
                  }


            }
         }
         else
         {
            Console.WriteLine("Syöttö ei kelpaa. Yritä uudelleen.");
            select = int.Parse(Console.ReadLine());
         }
      }

      LotteryNumbers();

      Console.WriteLine("\n------------------------------------");
      Console.WriteLine("\nPalataanko alkuun? y/n");
      string restart;
      do
      {
         restart = Console.ReadLine();
      }
      while (restart != "y" && restart != "n" && restart != "Y" && restart != "N");
      if (restart == "y" || restart == "Y")
      { goto start; }
      else
      {
         Console.WriteLine("Ohjelma sulkeutuu...");
      }
   }
   static void LotteryNumbers()
   {
      Console.WriteLine("\n------------------------------------");
      Console.WriteLine("\nExtra. Lottonumerot ovat: ");
      int[] numbers = new int[7];
      for (int number = 0; number <= 6; number++)
      {
         int pick;
         do
         {
            pick = new Random().Next(0, 101);//valitaan random numero eri muuttujalle ennen listaan lisöystä
         }
         while (numbers.Contains(pick)); // 🔄valitsee uuden numeron jos numero löytyy listasta.
         numbers[number] = pick; // lisätään satunnaisesti valittu lottonumero listaan
      }
      foreach (int index in numbers)//tulostetaan jokainen listan numero
      {
         Console.Write($"{index}" + " ");
      }
   }
   static bool FactorialNumber(out string inputString, string numberString)
   {
      string answer;
      if (!int.TryParse(numberString, out int number))
      {
         answer = "Vastausta ei voitu käsitellä, yritä uudelleen: ";
         Console.WriteLine(answer);
         inputString = "";  //välitä tyhjä string, triggeroidakseen uusi inputin kuuntelu.
         return false;
      }
      else
      {
         int[] numbers = new int[number]; //array kokoa syötetty numero
         numbers[0] = 1;
         for (int i = 1; i < number;)
         {
            numbers[i] = numbers[i - 1] * (i + 1);
            i++;
         }
         Console.WriteLine("Luvun " + number + " kertoma on: ");
         Console.WriteLine(numbers[number - 1]);
         inputString = numberString;
         return true;
      }

   }
   static bool GetRightNumber(out string inputString, string numberString)
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
         while (number != 10)
         {
            if (number < 10)
            {
               answer = "Syötetty numero on liian pieni.";
               Console.WriteLine(answer);
               inputString = "";
               return false;
            }
            else if (number > 10)
            {
               answer = "Syötetty numero on liian suuri.";
               Console.WriteLine(answer);
               inputString = "";
               return false;
            }
         }
         inputString = numberString;
         return true;
      }
   }

   static void AlterSentence(string inputString)
   {
      string alteredSentence = new CultureInfo("fi-FI", false).TextInfo.ToTitleCase(inputString);
      Console.WriteLine(alteredSentence);
   }
   static int CountWords(int wordCount)
   {
      return wordCount;
   }
   static bool SplitSentence(out int wordCount, out bool valid, out string inputString, string inputSentence)
   {
      string answer;
      string[] words = inputSentence.Split(" ");
      if (words.Length == 0)
      {
         answer = "Lauseessa ei ole sanoja, yritä uudelleen: ";
         Console.WriteLine(answer);
         inputString = "";
         valid = false;
         wordCount = 0;
         return false;
      }
      else
      {
         for (int i = 0; i < words.Length;)
         {
            Console.WriteLine(i + 1 + ": " + words[i]);
            i++;
         }
         inputString = inputSentence;
         valid = true;
         wordCount = words.Length;
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
