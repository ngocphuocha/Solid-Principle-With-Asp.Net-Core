namespace SolidPrinciples;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student() { Id = 1, Name = "Phuoc Tran" };

        Course dotnetCousrse = new Course() { Id = 1, Name = "ASP.Net Core" };

        StudentRepository studentRepository = new StudentRepository();

        studentRepository.AddStudent(student);
        studentRepository.Subscrible(dotnetCousrse);

        Console.WriteLine("Add new {0} to course {1}", student.Name,
        dotnetCousrse.Name
        );
    }
}
