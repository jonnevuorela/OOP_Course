public class Spaceship
{
   private float speed;
   private float health;
   private float acceleration;

   public float Acceleration
   {
      get
      {
         return this.acceleration;
      }
      set
      {
         if (value < 10 && value > 0)
         {

            this.acceleration = value;
         }
      }
   }


   public Spaceship()
   {
      this.speed = 10;
      this.health = 100;
      this.acceleration = 0.1f;
   }

   public Spaceship(float acc)
   {
      this.speed = 10;
      this.health = 100;
      this.acceleration = acc;
   }


   public void Accelerate()
   {
      this.speed += this.acceleration;
      Console.WriteLine($"Accelerate method. speed: {this.speed}");
   }

}
