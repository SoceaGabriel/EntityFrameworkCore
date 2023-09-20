using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Model.Models
{
    [Table("genres")]
    public class Genre
    {
        [Key]
        [Column("genre_id")]
        public int GenreId { get; set; }
        [Column("name")]
        [Required]
        public string GenreName { get; set; }
        [Column("display_order")]
        public int DisplayOrder { get; set; }
    }
}
