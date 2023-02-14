using SolidPrinciples.Models;
namespace SolidPrinciples.Interfaces;
internal interface IStudentRepository
{
    void AddStudent(Student student);
    void EditStudent(Student student);
    void DeleteStudent(Student student);

    bool Subscrible(Course course);
    bool Unsubcrible(Course course);

    IList<Student> GetAllStudents();
    IList<Student> GetStudents(Course course);
}