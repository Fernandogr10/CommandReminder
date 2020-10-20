using System.ComponentModel.DataAnnotations;

namespace CommandReminder.Models
{
    public class Command
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
        public string Platform { get; set; }
    }
}
