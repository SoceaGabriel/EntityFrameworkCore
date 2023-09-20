using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Model.Models
{
    [Table("sub_category")]
    public class SubCategory
    {
        [Key]
        [Column("sub_category_id")]
        public int SubCategoryId { get; set; }
        [Column("sub_category_name")]
        [MaxLength(50)]
        [Required]
        public string SubCategoryName { get; set; }
    }
}
