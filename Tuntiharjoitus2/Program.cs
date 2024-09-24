namespace MyApp
{
   internal class Program
   {
      static void Main(string[] args)
      {

         Spaceship space = new Spaceship();
         TieFighter tie = new TieFighter();

         Console.WriteLine("spaceship default");
         space.Accelerate();
         Console.WriteLine("tiefighter");
         tie.Accelerate();

         Console.WriteLine("spaceship default second time");
         space.Accelerate();
         Console.WriteLine("tiefighter second time");
         tie.Accelerate();

         Console.WriteLine("spaceship default third time");
         space.Accelerate();
         Console.WriteLine("tiefighter third time");
         tie.Accelerate();

         Console.WriteLine(space.Acceleration);
         Console.WriteLine(tie.Acceleration);

      }
   }
}
