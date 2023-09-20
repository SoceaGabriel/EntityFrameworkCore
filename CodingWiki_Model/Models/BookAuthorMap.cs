using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Model.Models
{
    [Table("book_author_map")]
    public class BookAuthorMap
    {
        [ForeignKey("Book")]
        [Column("book_id")]
        public int BookId { get; set; }
        [ForeignKey("Author")]
        [Column("author_id")]
        public int AuthorId { get; set; }
        public Book Book { get; set; }
        public Author Author { get; set; }
    }
}
