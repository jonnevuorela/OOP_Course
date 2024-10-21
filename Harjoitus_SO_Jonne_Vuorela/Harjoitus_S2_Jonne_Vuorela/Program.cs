internal class Program
{
   private static void Main(string[] args)
   {
      // nimeäminen on vaikeaa
      var luokka = new Class();
   start:
      int select = 0;
      bool valid = AskValidSelection(out select);
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
               Console.WriteLine("\nSyötä oppilaan nimi.");
               string name = Console.ReadLine();
               var newStudent = new Student(name);
               luokka.AddToClass(newStudent);
               goto start;
            case 2:
               Console.WriteLine("\nSyötä oppilaan nimi.");
               string sName = Console.ReadLine();
               if (!string.IsNullOrWhiteSpace(sName))
               {
                  if (!luokka.Students.Exists(x => x.Name == sName))
                  {
                     Console.WriteLine("Oppilasta ei löytynyt.");
                  }
                  else
                  {
                     Student sStudent = luokka.Students.Find(x => x.Name == sName);
                     sStudent.AddCourse();
                  }
               }
               goto start;
            case 3:
               Console.WriteLine("\nSyötä oppilaan nimi.");
               string aName = Console.ReadLine();
               if (!string.IsNullOrWhiteSpace(aName))
               {
                  if (!luokka.Students.Exists(x => x.Name == aName))
                  {
                     Console.WriteLine("Oppilasta ei löytynyt.");
                  }
                  else
                  {
                     Student aStudent = luokka.Students.Find(x => x.Name == aName);
                     float avg = aStudent.Average;
                     Console.WriteLine("⌈‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾⌉");
                     Console.WriteLine($" Oppilaan {aStudent.Name} ka. on {avg}");
                     Console.WriteLine("⌊⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⌋\n");
                  }
               }
               goto start;
            case 4:
               Console.WriteLine("\nSyötä oppilaan nimi.");
               string cName = Console.ReadLine();
               if (!string.IsNullOrWhiteSpace(cName))
               {
                  if (!luokka.Students.Exists(x => x.Name == cName))
                  {
                     Console.WriteLine("Oppilasta ei löytynyt.");
                  }
                  else
                  {
                     Student cStudent = luokka.Students.Find(x => x.Name == cName);
                     cStudent.ListCourses();
                  }
               }
               goto start;
         }
      }
   end:;

   }

   // Metodissa tarkastetaan, onko käyttäjän syöttämä valinta käypä.
   // palauttaa true vain jos valinta on välillä 0-3
   static bool AskValidSelection(out int select)
   {
      Console.WriteLine("⌈‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾⌉");
      Console.WriteLine("⎮ Select a function.           ⎮");
      Console.WriteLine("⎮ 1: Lisää oppilas.            ⎮");
      Console.WriteLine("⎮ 2: Lisää kurssi oppilaalle   ⎮");
      Console.WriteLine("⎮ 3: Tarkasta oppilaan ka.     ⎮");
      Console.WriteLine("⎮ 4: Tarkasta oppilaan kurssit.⎮");
      Console.WriteLine("⎮ 0: Poistu ohjelmasta         ⎮");
      Console.WriteLine("⌊⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⌋\n");
      var input = Console.ReadLine();
      bool success = Int32.TryParse(input, out select);
      if (!success)
      {
         Console.WriteLine("Please input a number.");
         input = Console.ReadLine();
      }
      else
      {
         if (select <= 4 && select >= 0)
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
public class Class
{
   private List<Student> students;
   public List<Student> Students
   {
      get
      {
         return students;
      }
   }
   public Class()
   {
      this.students = new List<Student>();
   }

   public void AddToClass(Student student)
   {
      students.Add(student);
      Console.WriteLine("Oppilas lisätty.\n");
   }

}
public class Student : Class
{
   private String name;
   public String Name
   {
      get
      {
         return name;
      }
   }
   private List<Course> courses;
   public List<Course> Courses
   {
      get
      {
         return courses;
      }
   }
   private float average;
   public float Average
   {
      get
      {
         return average;
      }
   }

   public Student(string name)
   {
      this.name = name;
      this.courses = new List<Course>();
      this.average = 0;
   }

   // privaatti metodi, jota kutsutaan vain luokan sisällä
   // kurssin lisäyksen yhteydessä.
   private void CalculateAverage(out float average)
   {
      int total = 0;
      for (int i = 0; i < courses.Count; i++)
      {
         total += courses[i].Grade;
      }
      average = total / courses.Count;
   }

   public void AddCourse()
   {
      Console.WriteLine("Syötä kurssin nimi.");
      string nName = Console.ReadLine();
      Console.WriteLine("Anna kurssin arvosana");
   redo:
      string input = Console.ReadLine();
      if (!Int32.TryParse(input, out int nGrade))
      {
         Console.WriteLine("Virheellinen syöttö. Yritä uudelleen.");
         goto redo;
      }
      else
      {
         var newCourse = new Course(nName, nGrade);
         courses.Add(newCourse);
         CalculateAverage(out average);
         Console.WriteLine("Kurssi lisätty.\n");
      }
   }

   public void ListCourses()
   {
      Console.WriteLine("⌈‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾⌉");
      Console.WriteLine($" Oppilaan {this.name} kurssit.");
      for (int i = 0; i < courses.Count; i++)
      {
         Console.WriteLine($" {i + 1}. Kurssi");
         Console.WriteLine($" Kurssin nimi: {courses[i].Name}");
         Console.WriteLine($" Kurssin arvosana: {courses[i].Grade}\n");
      }
      Console.WriteLine("⌊⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⎽⌋\n");
   }

}
public class Course
{
   private string name;
   public string Name
   {
      get
      {
         return name;
      }
   }
   private int grade;
   public int Grade
   {
      get
      {
         return grade;
      }
   }
   public Course(string name, int grade)
   {
      this.name = name;
      this.grade = grade;

   }


}
