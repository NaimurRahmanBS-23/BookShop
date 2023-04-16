using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string Language  { get; set; }
        public string BookDetails { get; set; }
       // public byte[] Image { get; set; }
    }
}
