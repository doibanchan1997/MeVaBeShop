using MeVaBeShop.Data.Infrastructure;
using MeVaBeShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeVaBeShop.Data.Repositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory>
    {
       
    }
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
       
        public ProductCategoryRepository(IDbFactory dbFactory)
            : base (dbFactory)
        {

        }

        
    }
}
