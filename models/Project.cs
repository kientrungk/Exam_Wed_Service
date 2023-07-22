// File: Models/Project.cs
using System.Collections.Generic;

namespace ProjectManagementAPI.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation property để lưu danh sách nhân viên tham gia vào dự án
        public ICollection<Employee> Employees { get; set; }
    }
}
