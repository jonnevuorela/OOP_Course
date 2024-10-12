public class Vehicle
{

   private string model;
   private string make;

   public string Model { get => model; }
   public string Make { get => make; }

   public Vehicle()
   {
      make = "Toyota";
      model = "Supra";
   }

   public void Accelerate()
   {
      Console.WriteLine("Accelerate");
   }

   public void Brake()
   {
      Console.WriteLine("Brake");
   }
}

