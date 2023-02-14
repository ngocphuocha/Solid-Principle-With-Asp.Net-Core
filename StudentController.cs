using SolidPrinciples.Interfaces;
using SolidPrinciples.Models;

namespace SolidPrinciples
{
    internal class StudentController
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public bool Save(Student student)
        {
            _studentRepository.AddStudent(student);
            return true;
        }

        public bool Delete(Student student)
        {
            _studentRepository.DeleteStudent(student);
            return true;
        }
    }
}
