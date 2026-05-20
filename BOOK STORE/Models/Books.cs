using System.ComponentModel.DataAnnotations;

namespace BOOK_STORE.Models
{
    public class Books
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Book Title")]
        public string BookTitle { get; set; }
        [Display(Name = "Book Description")]
        public string BookDescription { get; set; }
        [Required]
        public string Author { get; set; }
        
    }
}
