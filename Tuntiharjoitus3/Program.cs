namespace Program
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Character warrior = new Warrior();
         warrior.Move();
         warrior.Hit();
         warrior.Jump();
         warrior.Attack();

      }
   }
}
