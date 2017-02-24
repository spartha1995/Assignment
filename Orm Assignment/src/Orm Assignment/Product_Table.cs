using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Orm_Assignment
{
    public class Product_Table
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
        [Url]
        [Required]
        public string HomePageUrl { get; set; }
        public List<Update_Table> Update { get; set; }
    }
}
