using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MeVaBeShop.Model.Models
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostID { get; set; }

        [StringLength(250)]
        [Required]
        public string Title { get; set; }

        [StringLength(250)]
        [Required]
        public string MetaTitle { get; set; }

        [StringLength(250)]
        public string Descripton { get; set; }

        [StringLength(250)]
        public string PostImage { get; set; }

        public int? PostCategoryID { get; set; }
        
        [Column(TypeName ="ntext")]
        public string Detail { get; set; }

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

        public DateTime? TopHot { get; set; }

        public int? ViewCount { get; set; }

        public int? TagID { get; set; }

        public virtual PostCategory PostCategory { get; set; }

        public virtual ICollection<PostTag> PostTags { get; set; }
    }
}
