class Program
{
   private static void Main(string[] args)
   {
      // 1. Person
      InputPerson();

      // 2. Mammal
      Console.WriteLine("\n⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺");
      Console.WriteLine("2. Mammal");
      var mammal = new Mammal();
      var mammal1 = new Mammal("Mörri");
      var dog = new Dog();
      var dog1 = new Dog("Sevi");
      mammal.Eat();
      mammal1.Eat();
      dog.Eat();
      dog1.Eat();
      dog1.Eat(EnergyCalculator.Pork(100));
      dog1.Eat(EnergyCalculator.Pork(1));
      dog1.Eat(EnergyCalculator.Pork(1000));
      dog.Sleep();
      dog1.Sleep(120);


   }

   static void InputPerson()
   {
      string name = "";
      int year;
      string inputYear = "";
      Console.WriteLine("\n⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺⎺");
      Console.WriteLine("1. Syötä henkilön tiedot");
      while (string.IsNullOrWhiteSpace(name))
      {
         Console.Write("Nimi: ");
         name = Console.ReadLine();
      }
      while (!Int32.TryParse(inputYear, out year) || string.IsNullOrWhiteSpace(inputYear))
      {
         Console.Write("\nSyntymävuosi: ");
         inputYear = Console.ReadLine();
      }
      var person = new Person(name, year);
      Console.WriteLine("\nHenkilön tiedot\nNimi: " + person.Name + "\nIkä: " + person.Age + "\n");

      Console.WriteLine("\nPress enter to continue...");
      Console.ReadLine();
   }
}

class EnergyCalculator
{
   public static int Pork(int weight)//paino grammoina
   {
      //100g sianlihaa sisältää 243kcal
      float porkEnergy = 2.43f;
      float energy = (weight * porkEnergy);
      return (int)Math.Round(energy);
   }

}
