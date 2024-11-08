public class Orc : Enemy
{
   public Orc() : base(50f, 2)
   {
   }
   public override void Hits()
   {
      Console.WriteLine("Orc HIT");
      base.Hits();
   }
   public void Run(float speed)
   {
      this.Speed = speed;
   }
}
