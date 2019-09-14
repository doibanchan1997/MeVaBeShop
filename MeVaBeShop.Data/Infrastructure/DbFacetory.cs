using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MeVaBeShop.Data.Infrastructure
{
    public class DbFacetory : Disposable, IDbFactory
    {
        MeVaBeShopDbContext dbContext;
        public MeVaBeShopDbContext Init()
        {
            return dbContext ?? (dbContext = new MeVaBeShopDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
