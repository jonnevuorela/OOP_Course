public class Enemy : IJump
{
   private float health;
   private float speed;
   private float baseDamage;
   private string name;
   private static int countOfCharacters;
   private int level;



   public string Name
   {
      get
      {
         return this.name;
      }
      set
      {
         this.name = value;      //???

      }
   }
   public float Health
   {
      get
      {
         return this.health;
      }
      set
      {
         this.health = value;
      }
   }
   public float Speed
   {
      get
      {
         return this.speed;
      }
      set
      {
         this.speed = value; //???
      }
   }

   public Enemy(float health)
   {
      countOfCharacters++;
      this.baseDamage = 100;
      this.health = health;
   }
   public Enemy(float health, float speed)
   {
      countOfCharacters++;
      this.baseDamage = 100;
      this.health = health;
      this.speed = speed;
   }


   public virtual void Hits()
   {
      Console.WriteLine("General HIT");
   }
   public float GetBaseDamage()
   {
      return baseDamage;
   }
   public void Stats()
   {
      Console.WriteLine($"{name} Stats\nHealth: {health}\nSpeed: {speed}\nDamage: {baseDamage}\nLevel: {level}\n");
   }
   static public void CountOfCharacters()
   {
      Console.WriteLine(countOfCharacters);
   }
   private void LevelUp()
   {

   }

   public void Jump()
   {
      Console.WriteLine($"{name} jumps.");
   }
}
interface IJump
{
   void Jump();
}
