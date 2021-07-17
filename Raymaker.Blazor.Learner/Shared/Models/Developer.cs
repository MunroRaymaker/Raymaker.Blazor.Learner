using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Raymaker.Blazor.Learner.Shared.Models
{
    public class Developer
    {
        public int Id { get; set; }
        
        [Required]
        public string FirstName { get; set; }

        [Required, StringLength(10, ErrorMessage = "Lastname can only be 10 characters long!")]
        public string LastName { get; set; }
        
        [Required, EmailAddress]
        public string Email { get; set; }

        [Range(typeof(decimal), "0", "25", ErrorMessage = "No more than 25 years of experience allowed.")]
        public decimal Experience { get; set; }

        public Team Team { get; set; }
    }
}