public class Item
{
   private float price;
   private string name;

   public Item()
   {
      this.price = 0;
      this.name = "Unknown";

   }

   public Item(string name)
   {
      this.price = 0;
      this.name = name;

   }

   public void Use()
   {
      Console.WriteLine("Use");
   }
}
