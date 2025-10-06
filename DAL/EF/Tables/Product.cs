using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        [ForeignKey("Seller")]
        public int SellerId { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public bool isDeleted { get; set; }

        public virtual User Seller { get; set; }
    }
}
