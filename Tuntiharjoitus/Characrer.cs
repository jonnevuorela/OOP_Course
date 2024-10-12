public class Character
{
   private string name;

   private int level;

   private int exp;

   public Character()
   {
      this.name = "Unknown";
      this.level = 1;
      this.exp = 0;
   }

   public Character(string name)
   {
      this.name = name;
      this.level = 1;
      this.exp = 0;
   }

   public void Move(int steps)
   {
      Console.WriteLine("Charater - Move()");
   }

   public void Stats()
   {
      Console.WriteLine("name: " + name + " level: " + level + " experience: " + exp);
   }
}
