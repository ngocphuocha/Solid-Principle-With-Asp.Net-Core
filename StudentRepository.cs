using SolidPrinciples.Interfaces;
namespace SolidPrinciples;

internal class StudentRepository : IStudentRepository
{
    public void AddStudent(Student student)
    {
        Console.WriteLine("Add student");
    }

    public void DeleteStudent(Student student)
    {
        Console.WriteLine("Delete student");
    }

    public void EditStudent(Student student)
    {
        Console.WriteLine("edit student");
    }

    public IList<Student> GetAllStudents()
    {
        return new List<Student>();
    }

    public IList<Student> GetStudents(Course course)
    {
        // Get student by course
        return new List<Student>();
    }

    public bool Subscrible(Course course)
    {
        Console.WriteLine("Subscrible success");
        return true; // Subscrible success
    }

    public bool Unsubcrible(Course course)
    {
        Console.WriteLine("Unsubscrible success");
        return true; // Unsubcrible success
    }
}