using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Model.Models
{
    [Table("book_detail")]
    public class BookDetail
    {
        [Key]
        [Column("book_detail_id")]
        public int BookDetailId { get; set; }
        [Column("number_of_chapters")]
        public int NumberOfChapters { get; set; }
        [Column("number_of_pages")]
        public int NumberOfPages { get; set; }
        [Column("weight")]
        public double Weight { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
