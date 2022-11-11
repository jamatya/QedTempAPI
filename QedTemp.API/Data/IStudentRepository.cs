using QedTemp.Models; 

namespace QedTemp.Data 
{
    public interface IStudentRepository 
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int id);
    }
}