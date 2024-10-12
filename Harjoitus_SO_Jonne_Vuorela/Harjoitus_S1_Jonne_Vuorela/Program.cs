internal class Program
{
   private static void Main(string[] args)
   {
      var library = new Library();
      Book book = new Book("kiikaa", "k.k.Kiika", 100);
      var book1 = new Book("kookoo", "j.j.joojoo", 200);
   }
}

class Library
{
   private List<Book> books = new List<Book>();

   public void Add(Book book)
   {
      books.Add(book);
   }

   public void Remove(int isbn)
   {
      books.Remove(books.Find())
   }

   public void ListAll()
   {
      Console.WriteLine("Books in library");
      Console.WriteLine("⌈‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾⌉");
      for (int i = 0; i < books.Count; i++)
      {
         Console.WriteLine($"\n  {i + 1}. Book");
         Console.WriteLine($"  Title: {books[i].Name}");
         Console.WriteLine($"  Writer: {books[i].Writer}");
         Console.WriteLine($"  ISBN: {books[i].Isbn}");
      }
      Console.WriteLine("⌊⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⌋\n");
   }
}

class Book
{
   private string name;
   public string Name { get => name; }

   private string writer;
   public string Writer { get => writer; }

   private int isbn;
   public int Isbn { get => isbn; }

   public Book(string name, string writer, int isbn)
   {
      this.name = name;
      this.writer = writer;
      this.isbn = isbn;
   }
}
