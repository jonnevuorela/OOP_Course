public abstract class Shape
{
   public static int total;

   public Shape()
   {
   }

   public abstract double Area();

   public abstract void Draw();

   public abstract int GetPoints();

   public static double DegToRad(double deg)
   {
      double rad = deg * (Math.PI / 180);
      return rad;
   }
}

public interface ICircumference
{
   public double GetCircumference();

}

public class Circle : Shape, ICircumference
{
   private double radius;

   public static int total;

   public double Radius
   {
      get
      {
         return this.radius;
      }
      set
      {
         this.radius = value;
      }
   }



   public Circle(double radius)
   {
      this.radius = radius;
      total++;
      Shape.total++;
   }

   public void IncreaseRadius()
   {
      this.radius = this.radius + 1;
   }

   public void IncreaseRadius(double ammount)
   {
      this.radius = this.radius + ammount;
   }


   public override double Area()
   {
      double area = Math.PI * Math.Pow(this.radius, 2);
      return area;
   }

   public override void Draw()
   {
   }
   public double GetCircumference()
   {
      double circumference = (2 * Math.PI) * this.radius;
      return circumference;
   }

   public override int GetPoints()
   {
      throw new NotImplementedException();
   }
}

public class RectangularTriangle : Shape, ICircumference
{
   private double width;
   private double height;

   public static int total;

   public double Width
   {
      get
      {
         return this.width;
      }
      set
      {
         this.width = value;
      }
   }
   public double Height
   {
      get
      {
         return this.height;
      }
      set
      {
         this.height = value;
      }
   }

   public RectangularTriangle(double width, double height)
   {
      this.width = width;
      this.height = height;
      total++;
      Shape.total++;
   }

   public override double Area()
   {
      double area = (this.width * this.height) * 0.5;
      return area;
   }

   public override void Draw()
   {
   }

   public override int GetPoints()
   {
      return 3;
   }

   public double GetCircumference()
   {
      double hypotenusa = Math.Sqrt(Math.Pow(this.width, 2) + Math.Pow(this.height, 2));
      double circumference = this.width + this.height + hypotenusa;
      return circumference;

   }
}
