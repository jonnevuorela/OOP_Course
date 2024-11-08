public class Shaman : Enemy
{
   public Shaman(float health, float speed) : base(health, speed)
   {
   }
   public void Heal()
   {
      this.Health += 5;
   }
}
