using System.ComponentModel.DataAnnotations;

namespace RazorCrashDummy.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        
        public string Name { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Required]
        public string Username { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool Active { get; set; }
    }
}
