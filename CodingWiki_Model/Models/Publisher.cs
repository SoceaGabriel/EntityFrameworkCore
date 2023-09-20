using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Model.Models
{
    [Table("publisher")]
    public class Publisher
    {
        [Key]
        [Column("publisher_id")]
        public int PublisherId { get; set; }
        [Required]
        [Column("name")]
        public string Name { get; set; }
        [Column("location")]
        public string Location { get; set; }
        public List<Book> Books { get; set; }
    }
}
