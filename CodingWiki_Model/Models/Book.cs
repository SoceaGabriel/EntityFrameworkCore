using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Model.Models
{
    [Table("books")]
    public class Book
    {
        [Key]
        [Column("book_id")]
        public int BookId { get; set; }
        [MaxLength(20)]
        [Required]
        [Column("isbn")]
        public string ISBN { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("price")]
        public decimal Price { get; set; }
        [NotMapped]
        public string PriceRange { get; set; }
        public BookDetail BookDetail { get; set; }
        [ForeignKey("Publisher")]
        [Column("publisher_id")]
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public List<BookAuthorMap> BookAuthorMap { get; set; }
    }
}
