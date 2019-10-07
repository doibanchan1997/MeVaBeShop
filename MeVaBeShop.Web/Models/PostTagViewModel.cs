using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeVaBeShop.Web.Models
{
    public class PostTagViewModel
    {
        
        public int TagID { get; set; }

       
        public int PostID { get; set; }

        public virtual TagViewModel Tag { get; set; }

        public virtual PostViewModel Post { get; set; }
    }
}