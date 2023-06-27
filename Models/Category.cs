using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MySQLStoreAPI.Models
{
    [Table("Category")] 
    [Comment("Category table data")] 
    public class Category
    {
        [Key] 
        public int CategoryId { get; set; }

        [Column("CategoryName", TypeName = "varchar(64)", Order = 1)] 
        [Required]
        public string CategoryName { get; set; }

        [Column(Order = 2)]
        [Required]
        public int CategoryStatus { get; set; }

    }
}