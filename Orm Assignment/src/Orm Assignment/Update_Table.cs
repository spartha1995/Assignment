using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Orm_Assignment
{
    public class Update_Table
    {
        [Key]
        public int UpdateId { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
        public int Foreign_Id { get; set; }
        [ForeignKey("Foreign_Id")]
        public Product_Table Product { get; set; }
    }
}
