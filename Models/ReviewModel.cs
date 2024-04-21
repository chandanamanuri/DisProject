using System.ComponentModel.DataAnnotations;

namespace DisProject.Models
{
    public class ReviewModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string BookTitle { get; set; }
        public string ReviewText { get; set; }
    }
}