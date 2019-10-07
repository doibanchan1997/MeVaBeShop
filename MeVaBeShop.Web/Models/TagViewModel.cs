using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeVaBeShop.Web.Models
{
    public class TagViewModel
    {
        public int TagID { get; set; }


    
        public string TagName { get; set; }

       
        public string Type { get; set; }

        public virtual ICollection<PostTagViewModel> PostTags { get; set; }

        public virtual ICollection<ProductTagViewModel> ProductTags { get; set; }
    }
}