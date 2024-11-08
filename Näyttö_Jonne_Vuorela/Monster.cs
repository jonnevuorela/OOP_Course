public class Monster : Enemy
{
   public Monster() : base(200f)
   {
   }
   public override void Hits()
   {
      Console.WriteLine("Monster HIT");
   }
}
