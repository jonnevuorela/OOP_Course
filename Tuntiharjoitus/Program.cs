namespace MyApp
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Hello World!");
         Character myCharacter = new Character();
         Character secondCharacter = new Character("Orc");
         myCharacter.Move(10);
         myCharacter.Stats();
         secondCharacter.Stats();

         Paladin myPaladin = new Paladin();
         myPaladin.Move(100);
         myPaladin.Stats();
         myPaladin.Heal();
      }
   }
}
