using QedTemp.Models;

namespace QedTemp.Data 
{
    public class MockStudentRepository : IStudentRepository
    {
   
    public IEnumerable<Student> GetAllStudents()
        {
            var students = new List<Student>{
                new Student { EnrolmentId = 1, FamilyName = "Doe", GivenName = "Jane", DateOfBirth = new DateTime(2015,10,10), Age = 7, RollClass = "", Gender = "F", YearLevel = "3A", EnrolmentStatus = "Active"  },
                new Student { EnrolmentId = 2, FamilyName = "Doe", GivenName = "John", DateOfBirth = new DateTime(2016,11,11), Age = 6, RollClass = "", Gender = "M", YearLevel = "4B", EnrolmentStatus = "Active"  },
                new Student { EnrolmentId = 3, FamilyName = "Case", GivenName = "Mike", DateOfBirth = new DateTime(2017,12,12), Age = 5, RollClass = "", Gender = "M", YearLevel = "5C", EnrolmentStatus = "Active" }
            };

            return students;
        }

        public Student GetStudentById(int id)
        {
            return  new Student { EnrolmentId = id, FamilyName = "Doe", GivenName = "M", DateOfBirth = new DateTime(2014,02,02), Age = 8, RollClass = "", Gender = "M", YearLevel = "6C", EnrolmentStatus = "Active" };
        }
    }
}