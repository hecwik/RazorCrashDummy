using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorCrashDummy.Models
{
    public class Shift
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Starting time")]
        public DateTime StartTime { get; set; }
        [Display(Name = "End time")]
        public DateTime EndTime { get; set; }
        public DateTime Added { get; set; } = DateTime.UtcNow.AddHours(2);
        [Display(Name = "User")]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        [Display(Name = "Location")]
        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
}
