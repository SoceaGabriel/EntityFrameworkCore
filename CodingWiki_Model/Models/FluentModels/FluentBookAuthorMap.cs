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
    public class FluentBookAuthorMap
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }
    }
}
