namespace Harjoitus_2_Jonne_Vuorela
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("\n------------------------------------------------------------------");
			Console.WriteLine($"\n1. Tämän päivän päivämäärä on: {DateString()}");

			Console.WriteLine("\n------------------------------------------------------------------");
			Console.WriteLine("\n2. Syötä ympyrän säde senttimetreinä, josta lasketaan pinta-ala");
			if (!float.TryParse(Console.ReadLine(), out float radius))
			{
				Console.WriteLine("Huono");
			}
			else
			{
				Console.WriteLine($"Ympyrän pinta-ala ≈ {CircleArea(radius)}cm^2");
			}

			Console.WriteLine("\n------------------------------------------------------------------");
			Console.WriteLine("\n3. Syötä luku joka tarkistetaan, että onko se jaollinen kahdella.");
			if (!int.TryParse(Console.ReadLine(), out int input))
			{
				Console.WriteLine("Huono");
			}
			else
			{
				if (DivisibleByTwo(input) == true)
				{ Console.WriteLine("Luku on jaollien kahdella"); }
				else if (DivisibleByTwo(input) == false)
				{
					Console.WriteLine("Luku ei ole jaollinen kahdella");
				}
				else
				{
					Console.WriteLine("Jotain meni pieleen");
				}
			}


		}

		static string DateString() => DateTime.Today.ToShortDateString();

		static float CircleArea(float radius)
		{
			float circleArea = (float)Math.Round((float)Math.PI * (float)Math.Pow(radius, 2));
			return circleArea;
		}

		static bool DivisibleByTwo(int input)
		{
			if (input % 2 == 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}

