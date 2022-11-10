using QedTemp.Models;

namespace QedTemp.Data
{
    public class MockSchoolRepository : ISchoolRepository
    {
        public IEnumerable<School> GetAllSchools()
        {
            var schools = new List<School>{
                new School { Id = 2, Name = "Forest Lake State School", Type = "Public", Ranking = 50},
                new School { Id = 3, Name = "Sherwood State School", Type = "Public", Ranking = 8},
                new School { Id = 4, Name = "Corinda High School", Type = "Public", Ranking = 15},
                new School { Id = 5, Name = "St. Aidens Girls School", Type = "Private", Ranking = 5}
            };

            return schools;
        }

        public School GetSchoolById(int id)
        {
            return new School { Id = id, Name = "Brisbane High School", Type = "Private", Ranking = 10};
        }
    }
}
