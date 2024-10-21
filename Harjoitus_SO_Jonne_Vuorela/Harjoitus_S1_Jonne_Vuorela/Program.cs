internal class Program
{
   private static void Main(string[] args)
   {
      var library = new Library();
      bool valid;
   start:
      int select = 0;
      valid = AskValidSelection(out select);
      if (!valid)
      {
         goto start;
      }
      else
      {
         switch (select)
         {
            case 0:
               goto end;
            case 1:
               library.Add(NewBook(library.Books));
               goto start;
            case 2:
               library.Remove(Int32.Parse(Console.ReadLine()));
               goto start;
            case 3:
               library.ListAll();
               Console.WriteLine("Press enter to continue...");
               Console.ReadLine();
               goto start;
         }
      }
   end:;
   }

   // Metodi joka kysyy tiedot uudelle kirjalle,
   // mikäli isbn on uniikki, metodi palauttaa uuden kirjan
   static Book NewBook(List<Book> books)
   {
      Console.WriteLine("\nEnter name of the book.");
      string nName = Console.ReadLine();

      Console.WriteLine("\nEnter name of the writer.");
      string nWriter = Console.ReadLine();

      Console.WriteLine("\nEnter ISBN of the book.");
      int nIsbn = Int32.Parse(Console.ReadLine());

      if (books.Any(book => book.Isbn == nIsbn))
      {
         Console.WriteLine("The book already exists.");
         return null;
      }
      else
      {
         var newBook = new Book(nName, nWriter, nIsbn);
         return newBook;

      }
   }

   // Metodissa tarkastetaan, onko käyttäjän syöttämä valinta käypä.
   // palauttaa true vain jos valinta on välillä 0-3
   static bool AskValidSelection(out int select)
   {
      Console.WriteLine("⌈‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾⌉");
      Console.WriteLine("⎮ Select a function.         ⎮");
      Console.WriteLine("⎮ 1: Add book to the library.⎮");
      Console.WriteLine("⎮ 2: Remove book by ISBN.    ⎮");
      Console.WriteLine("⎮ 3: List all books.         ⎮");
      Console.WriteLine("⎮ 0: Exit program            ⎮");
      Console.WriteLine("⌊⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⌋\n");
      var input = Console.ReadLine();
      bool success = Int32.TryParse(input, out select);
      if (!success)
      {
         Console.WriteLine("Please input a number.");
         input = Console.ReadLine();
      }
      else
      {
         if (select <= 3 && select >= 0)
         {
            return true;
         }
         else
         {
            Console.WriteLine("Selection is not valid.");
            input = Console.ReadLine();
         }
      }
      return false;

   }
}


public class Library
{
   private List<Book> books;

   public Library()
   {
      this.books = new List<Book>();
   }

   public List<Book> Books { get => books; }

   public void Add(Book book)
   {
      books.Add(book);
      Console.WriteLine("Book added");
   }

   public void Remove(int isbn)
   {
      if (books.Any(book => book.Isbn == isbn))
      {
         books.Remove(books.Find(book => book.Isbn == isbn));
         Console.WriteLine("Book was removed");
      }
      else
      {
         Console.WriteLine("The book does not exist.");
      }
   }

   public void ListAll()
   {
      Console.WriteLine("Books in library");
      Console.WriteLine("⌈‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾⌉");
      for (int i = 0; i < books.Count; i++)
      {
         Console.WriteLine($"\n  {i + 1}. Book");
         Console.WriteLine($"  Title: {books[i].Name}");
         Console.WriteLine($"  Writer: {books[i].Writer}");
         Console.WriteLine($"  ISBN: {books[i].Isbn}");
      }
      Console.WriteLine("⌊⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⌋\n");
   }
}

public class Book
{
   private string name;
   public string Name
   {
      get
      {
         return name;
      }
   }

   private string writer;
   public string Writer
   {
      get
      {
         return writer;
      }
   }

   private int isbn;
   public int Isbn
   {
      get
      {
         return isbn;
      }
   }

   public Book(string name, string writer, int isbn)
   {
      this.name = name;
      this.writer = writer;
      this.isbn = isbn;
   }
}
