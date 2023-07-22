// Models/Employee.cs
using System;

namespace ProjectManagementAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; } 
        public string Department { get; set; }

        public ICollection<Project> Projects { get; set; } = new List<Project>();
    }
}
