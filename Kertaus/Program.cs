internal class Program
{
   private static void Main(string[] args)
   {
      var triangle = new RectangularTriangle(3, 5);
      var circle = new Circle(5);
      var circle1 = new Circle(6);

      Console.WriteLine($"Kolmion pinta-ala on {triangle.Area()}");
      Console.WriteLine($"Ympyrän pinta-ala on {circle.Area()}");
      Console.WriteLine($"Ympyrän pinta-ala on {circle1.Area()}");

      circle.IncreaseRadius();
      Console.WriteLine($"\nEnsimmäisen ympyrän pinta-ala lisäyksen jälkeen {circle.Area()}");

      Console.WriteLine($"\nYmpyröiden määrä on {Circle.total}");
      Console.WriteLine($"Kolmioiden määrä on {RectangularTriangle.total}");
      Console.WriteLine($"Muotojen määrä on {Shape.total}");


      Console.WriteLine($"\nYmpyrän ympärysmitta on {circle.GetCircumference()}");
      Console.WriteLine($"\nKolmion ympärysmitta on {triangle.GetCircumference()}");
      circle.IncreaseRadius(10);
      Console.WriteLine($"\nYmpyrön ympärysmitta, kun säteeseen lisätän 10 {circle.GetCircumference()}");
   }
}
