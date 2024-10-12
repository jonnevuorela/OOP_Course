class Mammal
{
   private string name;

   public string Name
   {
      get => name;
   }


   public Mammal()
   {
      this.name = "";
   }

   public Mammal(string name)
   {
      this.name = name;
   }
   public void Eat()
   {
      if (string.IsNullOrEmpty(name))
      {
         Console.WriteLine("\nMammal eats");
      }
      else
      {
         Console.WriteLine("\n" + name + " eats");
      }

   }
   public void Sleep()
   {
      if (string.IsNullOrEmpty(name))
      {
         Console.WriteLine("\nMammal sleeps");
      }
      else
      {
         Console.WriteLine("\n" + name + " sleeps");
      }

   }
   public void Sleep(int time)
   {
      Sleep();
      Console.WriteLine("For " + time + " minutes.");
   }
}
