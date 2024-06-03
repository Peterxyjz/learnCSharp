using StudentManagerV7.Entities;

namespace StudentManagerV7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student() { Id = "SE1", Name = "An" };
            Student s2 = new Student() { Id = "SE2", Name = "Binh", Yob = 2004, Gpa = 8.9 };
            Console.WriteLine("s1: " + s1);
            Console.WriteLine("s2: " + s2);

        }
    }
}
