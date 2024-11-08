internal class Program
{
   private static void Main(string[] args)
   {
      var monster = new Monster();
      var orc = new Orc();
      var shaman = new Shaman(150f, 1f);

      Enemy.CountOfCharacters();

      monster.Name = "Ragnaros";
      orc.Name = "Garrosh";
      shaman.Name = "Thrall";

      monster.Stats();
      orc.Stats();
      shaman.Stats();
      monster.Hits();
      orc.Hits();
      shaman.Hits();

      shaman.Heal();
      orc.Run(3);

      shaman.Stats();
      orc.Stats();

      float shamanDamage = shaman.GetBaseDamage();
      Console.WriteLine($"shaman damage {shamanDamage}");

      shaman.Jump();
   }
}
