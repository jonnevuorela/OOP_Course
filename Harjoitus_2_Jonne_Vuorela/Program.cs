namespace Harjoitus_2_Jonne_Vuorela
{
   using System;
   internal class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("\n------------------------------------------------------------------");
         Console.WriteLine($"\n1. Tämän päivän päivämäärä on: {DateString()}");

         Console.WriteLine("\n------------------------------------------------------------------");
         Console.WriteLine("\n2. Syötä ympyrän säde senttimetreinä, josta lasketaan pinta-ala");
         Console.WriteLine($"Ympyrän säde on ≈ {CircleArea(AskFloat())}cm^2");

         Console.WriteLine("\n------------------------------------------------------------------");
         Console.WriteLine("\n3. Syötä luku joka tarkistetaan, että onko se jaollinen kahdella.");
         Console.WriteLine(DivisibleByTwo(AskInt()));

         Console.WriteLine("\n------------------------------------------------------------------");
         Console.WriteLine("\n4. Syötä kokonaisluku jolle näytetään kymmenen kertotaulua.");
         Multiplication(AskInt());

         Console.WriteLine("\n------------------------------------------------------------------");
         Console.WriteLine("\n5. Kuinka monta fibonacci lukua haluat?.");
         Fibonacci(AskInt());

         Console.WriteLine("\n------------------------------------------------------------------");
         Console.WriteLine("\n6. Arvotaan 100 lukua väliltä 0-100 ja lasketaan montako lukua on väliltä 0-50.");
         Console.WriteLine(RandomNumber());

         Console.WriteLine("\n------------------------------------------------------------------");
         Console.WriteLine("\n7. Arvaa luku. (1-200)");
         GuessingGame();

         Console.WriteLine("\n------------------------------------------------------------------");
         Console.WriteLine("\n Extra tehtävä");
         Extra();
      }
      static void Extra()
      {
         int[] numbers = new int[10];
         for (int index = 0; index < numbers.Length; index++)
         {
            int number;
            do
            {
               number = new Random().Next(1, 20);
            }
            while (numbers.Contains(number));
            numbers[index] = number;
         }
         Console.WriteLine("Arvottu lista.");
         for (int i = 0; i < numbers.Length; i++)
         {
            Console.WriteLine($"{i + 1}. {numbers[i]}");
         }

         //Peak user experience
         Console.WriteLine("Paina enter, järjestääksesi lista.");
         Console.ReadLine();
         // bubble sort XOR swapilla
         for (int index = 0; index < numbers.Length - 1; index++)
         {
            for (int i = 0; i < numbers.Length - 1 - index; i++)
            {
               if (numbers[i] > numbers[i + 1])
               {
                  numbers[i] ^= numbers[i + 1];
                  numbers[i + 1] ^= numbers[i];
                  numbers[i] ^= numbers[i + 1];
               }
            }
         }

         // Järjestelty lista
         Console.WriteLine("Järjestetty lista.");
         for (int i = 0; i < numbers.Length; i++)
         {
            Console.WriteLine($"{i + 1}. {numbers[i]}");
         }
      }

      static void GuessingGame()
      {
         int answer = new Random().Next(1, 200);
         int guess = 0;
         while (guess != answer)
         {
            Console.WriteLine("\nSyötä arvauksesi.");
            guess = AskInt();
            if (guess < answer)
            {
               Console.WriteLine("Numero on suurempi...");
            }
            else if (guess > answer)
            {
               Console.WriteLine("Numero on pienempi...");
            }
            else
            {
               Console.WriteLine("Oikea vastaus!");
               break;
            }
         }
      }

      static int RandomNumber()
      {
         int result = 0;
         for (int i = 0; i <= 100; i++)
         {
            int random = new Random().Next(0, 100);
            if (random <= 50)
            {
               result++;
            }
         }
         Console.WriteLine("Lukuja arvottu, joiden arvo oli alle 50.");
         return result;
      }

      static void Fibonacci(int input)
      {
         int[] fibonacci = new int[input + 1];
         fibonacci[0] = 0;
         fibonacci[1] = 1;
         for (int i = 2; i <= input; i++)
         {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
         }
         Console.WriteLine("Fibonacci luvut");
         for (int i = 0; i <= input; i++)
         {
            Console.Write($"{fibonacci[i]}, ");
         }

      }

      //Metodi toistuvalle syötön tarkistukselle
      static int AskInt()
      {
         if (!int.TryParse(Console.ReadLine(), out int input))
         {
            throw new InvalidOperationException("Virheellinen syöttö, syötä kokonaisluku");
         }
         else
         {
            return input;
         }
      }

      static float AskFloat()
      {
         if (!float.TryParse(Console.ReadLine(), out float input))
         {
            throw new InvalidOperationException("Virheellinen syöttö, syötä kokonaisluku");
         }
         else
         {
            return input;
         }
      }

      static string DateString() => DateTime.Today.ToShortDateString(); //oneliner ykköskohtaan

      static float CircleArea(float radius)
      {
         float circleArea = (float)Math.Round((float)Math.PI * (float)Math.Pow(radius, 2)); //matematiikkaa syötölle
         return circleArea;
      }

      static string DivisibleByTwo(int input)
      {
         if (input % 2 == 0) // tarkistetaan syötön jakojäännös
         {
            return "Luku on jaollinen kahdella";
         }
         else
         {
            return "Luku ei ole jaollinen kahdella";
         }
      }

      static void Multiplication(int input)
      {
         int multiplicator = 1;
         while (multiplicator < 11) //while kertoja alle 11
         {
            int number = input * multiplicator; //math
            Console.WriteLine($"{input} x {multiplicator} = {number}");
            multiplicator++; //kertojasta suurempi joka iteraatiolla
         }
      }
   }
}

