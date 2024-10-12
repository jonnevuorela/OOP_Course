class Dog : Mammal
{
   private int energy;

   public Dog() : base()
   {
      Console.WriteLine("A dog without name was constructed.");
   }

   public Dog(string name) : base(name)
   {
      Console.WriteLine("A dog with name was constructed. Its name is " + name + "!");
   }

   public new void Eat()
   {
      if (string.IsNullOrEmpty(Name))
      {
         Console.WriteLine("Dog eats");
      }
      else
      {
         Console.WriteLine(Name + " eats");
      }
   }

   public void Eat(int energy)
   {
      Eat();
      this.energy += energy;
      Console.WriteLine(energy + " calories.");
      Console.WriteLine("Energy: " + this.energy + "\n");
   }
}
