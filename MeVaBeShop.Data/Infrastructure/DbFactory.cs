
namespace MeVaBeShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private MeVaBeShopDbContext dbContext;

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
