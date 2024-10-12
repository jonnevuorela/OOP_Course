namespace MyApp
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Vehicle supra = new Vehicle();
         supra.Accelerate();
         supra.Brake();
         Console.WriteLine("Make: " + supra.Make);
         Console.WriteLine("Model: " + supra.Model);
      }
   }
}
