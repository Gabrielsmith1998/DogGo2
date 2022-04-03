using System.ComponentModel.DataAnnotations;

namespace DogGo2.Models
{
    public class Dog
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Hmmm... You should really add a Name...")]
        [MaxLength(35)]
        public string Name { get; set; }
        [Required]
        public int OwnerId { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 4)]
        public string Breed { get; set; }
        public string Notes { get; set; }
        public string ImageUrl { get; set; }
        public Owner Owner { get; set; }
    }
}
