using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MeVaBeShop.Model.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }

        [StringLength(10)]
        [Required]
        public string ProductCode { get; set; }

        [StringLength(250)]
        [Required]
        public string ProductName { get; set; }

        [StringLength(250)]
        [Required]
        public string MetaTitle { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(250)]

        public string ProductImage { get; set; }

        [Column(TypeName ="xml")]
        [MaxLength(500)]
        public string Image { get; set; }

        [Column(TypeName ="xml")]
        [MaxLength(500)]
        public string MoreImages { get; set; }

        [Required]
        public int Price { get; set; }

        public int? PromotionPrice { get; set; }

        public bool? IncludeVAT { get; set; }

        public int? Quantity { get; set; }

        public int? CategoryID { get; set; }

        [Column(TypeName ="ntext")]
        public string Detail { get; set; }

        public int? Warranty { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }


        [StringLength(250)]
        public string MetaKeywords { get; set; }

        [StringLength(250)]
        public string MetaDescriptions { get; set; }

        [Required]
        public bool Status { get; set; }


        [Column(TypeName ="date")]
        public DateTime? TopHot { get; set; }

        public int? ViewCounts { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual ICollection<ProductTag> ProductTags { get; set; }



    }
}
