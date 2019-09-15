using MeVaBeShop.Data.Infrastructure;
using MeVaBeShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeVaBeShop.Data.Repositories
{
    public interface IProductCategoryRepository
    {
        ICollection<ProductCategory> GetByAlias(string alias);
    }
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>
    {
       
        public ProductCategoryRepository(IDbFactory dbFactory)
            : base (dbFactory)
        {

        }
    }
}
