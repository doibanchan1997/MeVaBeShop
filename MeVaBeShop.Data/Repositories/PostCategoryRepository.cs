﻿using MeVaBeShop.Data.Infrastructure;
using MeVaBeShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeVaBeShop.Data.Repositories
{
    public interface IPostCategoryRepository : IRepository<PostCategory>
    {

    }
    public class PostCategoryRepository : RepositoryBase<PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
