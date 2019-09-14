using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MeVaBeShop.Model.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }

        [MaxLength(250)]
        [Required]
        public string CustomerName { get; set; }

        [MaxLength(250)]
        [Required]
        public string CustomerAddress { get; set; }

        [MaxLength(50)]
        [Required]
        public string CustomerEmail { get; set; }

        [MaxLength(12)]
        [Required]
        public string CustomerMobile { get; set; }


        [MaxLength(500)]
        public string CustomerMessage { get; set; }

        public DateTime? CreateDate { get; set; }

        [MaxLength(50)]
        public string CreateBy { get; set; }

        [MaxLength(250)]
        public string PaymentMethod { get; set; }

        [MaxLength(50)]
        public string PaymentStatus { get; set; }

        [Required]
        public bool Status { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
