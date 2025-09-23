using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class Cart
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Buyer")]
        public int BuyerId { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }

        public virtual User Buyer { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
