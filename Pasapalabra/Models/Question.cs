using System.ComponentModel.DataAnnotations;

namespace Pasapalabra.Models
{
    public class Question
    {
        public int Id { get; set; }

        [Required]
        [StringLength(1)]
        public string Letter { get; set; }

        [Required]
        [StringLength(50)]
        public string ContainsOrStartsWithLetter { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        [StringLength(30)]
        public string RightAnswer { get; set; }

        public bool? IsCorrect { get; set; }
    }
}