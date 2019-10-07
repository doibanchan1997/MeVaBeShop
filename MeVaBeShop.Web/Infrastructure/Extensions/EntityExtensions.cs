using MeVaBeShop.Model.Models;
using MeVaBeShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeVaBeShop.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void  UpdatePostCategory(this PostCategory postCategory, PostCategoryViewModel postCategoryVm)
        {
            postCategory.PostCategoryID = postCategoryVm.PostCategoryID;
            postCategory.Name = postCategoryVm.Name;
            postCategory.MetaTitle = postCategoryVm.MetaTitle;
            postCategory.ParentID = postCategoryVm.ParentID;
            postCategory.DisplayOrder = postCategoryVm.DisplayOrder;
            postCategory.SeoTitle = postCategoryVm.SeoTitle;
            postCategory.CreatedDate = postCategoryVm.CreatedDate;
            postCategory.CreatedBy = postCategoryVm.CreatedBy;
            postCategory.ModifiedDate = postCategoryVm.ModifiedDate;
            postCategory.ModifiedBy = postCategoryVm.ModifiedBy;
            postCategory.MetaKeywords = postCategoryVm.MetaKeywords;
            postCategory.MetaDescriptions = postCategoryVm.MetaDescriptions;
            postCategory.Status = postCategoryVm.Status;
            postCategory.ShowOnHome = postCategoryVm.ShowOnHome;

        }
        public static void UpdatePost(this Post post, PostViewModel postVm)
        {
            post.PostID = postVm.PostID;
            post.Title = postVm.Title;
            post.MetaTitle = postVm.MetaTitle;
            post.Descripton = postVm.Descripton;
            post.PostImage = postVm.PostImage;
            post.PostCategoryID = postVm.PostCategoryID;
            post.Detail = postVm.Detail;
            post.CreatedDate = postVm.CreatedDate;
            post.CreatedBy = postVm.CreatedBy;
            post.ModifiedDate = postVm.ModifiedDate;
            post.ModifiedBy = postVm.ModifiedBy;
            post.MetaKeywords = postVm.MetaKeywords;
            post.MetaDescriptions = postVm.MetaDescriptions;
            post.ViewCount = postVm.ViewCount;
            post.TagID = postVm.TagID;
            post.TopHot = postVm.TopHot;
            post.Status = postVm.Status;

        } 
    }
}