using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeVaBeShop.Web.Models
{
    public class PostViewModel
    {
        public int PostID { get; set; }

       
        public string Title { get; set; }

       
        public string MetaTitle { get; set; }

       
        public string Descripton { get; set; }

       
        public string PostImage { get; set; }

        public int? PostCategoryID { get; set; }

       
        public string Detail { get; set; }

        public DateTime? CreatedDate { get; set; }

        
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        
        public string ModifiedBy { get; set; }

        
        public string MetaKeywords { get; set; }

       
        public string MetaDescriptions { get; set; }

        
        public bool Status { get; set; }

        public DateTime? TopHot { get; set; }

        public int? ViewCount { get; set; }

        public int? TagID { get; set; }

        public virtual PostCategoryViewModel PostCategory { get; set; }

        public virtual ICollection<PostTagViewModel> PostTags { get; set; }
    }
}