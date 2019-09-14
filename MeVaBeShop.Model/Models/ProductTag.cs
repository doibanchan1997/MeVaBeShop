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
        [Column(Order = 1)]
        public int TagID { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ProductID { get; set; }

        public virtual Tag Tag { get; set; }

        public virtual Product Product { get; set; }
    }
}
