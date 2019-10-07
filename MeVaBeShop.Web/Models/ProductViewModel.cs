using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeVaBeShop.Web.Models
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }

       
        public string ProductCode { get; set; }

        
        public string ProductName { get; set; }

        
        public string MetaTitle { get; set; }

        
        public string Description { get; set; }

       

        public string ProductImage { get; set; }

        
        public string Image { get; set; }

        
        public string MoreImages { get; set; }

        
        public int Price { get; set; }

        public int? PromotionPrice { get; set; }

        public bool? IncludeVAT { get; set; }

        public int? Quantity { get; set; }

        public int? CategoryID { get; set; }

        
        public string Detail { get; set; }

        public int? Warranty { get; set; }

        public DateTime? CreatedDate { get; set; }

        
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        
        public string ModifiedBy { get; set; }


        
        public string MetaKeywords { get; set; }

        
        public string MetaDescriptions { get; set; }

       
        public bool Status { get; set; }


        
        public DateTime? TopHot { get; set; }

        public int? ViewCounts { get; set; }

        public virtual ProductCategoryViewModel ProductCategory { get; set; }

        public virtual ICollection<OrderDetailViewModel> OrderDetails { get; set; }

        public virtual ICollection<ProductTagViewModel> ProductTags { get; set; }
    }
}