using SolidPrinciples.Models;
namespace SolidPrinciples.Interfaces;

internal interface ICourseRepository
{
    void AddCourse(Course course);
    void EditCourse(Course course);
    void DeleteCourse(Course course);

    IList<Course> GetAllCourses();
    IList<Course> GetAllCourses(Student student);
}