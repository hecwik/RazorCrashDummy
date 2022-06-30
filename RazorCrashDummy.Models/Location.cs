using System.ComponentModel.DataAnnotations;

namespace RazorCrashDummy.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }


    }
}
