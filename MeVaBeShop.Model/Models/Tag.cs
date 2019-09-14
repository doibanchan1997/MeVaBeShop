using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MeVaBeShop.Model.Models
{
    public class Tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TagID { get; set; }


        [StringLength(50)]
        public string TagName { get; set; }

        [StringLength(50)]
        [Column(TypeName ="varchar")]
        public string Type { get; set; }

        public virtual ICollection<PostTag> PostTags { get; set; }

        public virtual ICollection<ProductTag> ProductTags { get; set; }
    }
}
