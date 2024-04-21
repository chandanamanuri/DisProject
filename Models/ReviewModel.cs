using System.ComponentModel.DataAnnotations;

namespace DisProject.Models
{
    public class Review
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Content is required")]
        public string Content { get; set; }
    }
}
