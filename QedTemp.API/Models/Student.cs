namespace QedTemp.Models 
{
    public class Student 
    {        
        public int? EnrolmentId { get; set; }
        public string? FamilyName { get; set; }
        public string? GivenName { get; set; }        
        public DateTime DateOfBirth { get; set; }
        public int? Age { get; set; }
        public string? RollClass { get; set; }
        public string? Gender { get; set; }
        public string? YearLevel { get; set; }
        public string? EnrolmentStatus { get; set; }

    }
}