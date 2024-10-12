public class Person
{
   private string name;
   private int yearOfBirth;
   private int age;

   public Person(string name, int year)
   {
      this.name = name;
      this.yearOfBirth = year;
      this.age = DateTime.Now.Year - year;
   }

   public string Name { get => name; }
   public int YearOfBirth { get => yearOfBirth; }
   public int Age { get => age; }
}
