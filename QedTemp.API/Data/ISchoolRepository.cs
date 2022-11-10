using QedTemp.Models;

namespace QedTemp.Data
{
    public interface ISchoolRepository
    {
        IEnumerable<School> GetAllSchools();
        School GetSchoolById(int id);    
    }
}