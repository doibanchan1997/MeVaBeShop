using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeVaBeShop.Web.Models
{
    public class PostCategoryViewModel
    {
        public int PostCategoryID { get; set; }

       
        public string Name { get; set; }

        
        public string MetaTitle { get; set; }

        public int? ParentID { get; set; }

        public int? DisplayOrder { get; set; }

        
        public string SeoTitle { get; set; }

        public DateTime? CreatedDate { get; set; }

        
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

       
        public string ModifiedBy { get; set; }

        
        public string MetaKeywords { get; set; }

        
        public string MetaDescriptions { get; set; }

         
        public bool Status { get; set; }

        public bool? ShowOnHome { get; set; }

        public virtual ICollection<PostViewModel> Posts { get; set; }
    }
}