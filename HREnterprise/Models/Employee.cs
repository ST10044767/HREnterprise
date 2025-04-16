using System.ComponentModel.DataAnnotations;

namespace HREnterprise.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Department { get; set; }

        public string Position { get; set; }

        public DateTime DateHired { get; set; }

        public string? ProfileImagePath { get; set; }
    }

}
