using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MeVaBeShop.Model.Models
{
    public class ProductTag
    {
        [Key]
        [Column(Order = 1, TypeName = "varchar")]
        [MaxLength(50)]
        public string TagID { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ProductID { get; set; }

        public virtual Tag Tag { get; set; }

        public virtual Product Product { get; set; }
    }
}
