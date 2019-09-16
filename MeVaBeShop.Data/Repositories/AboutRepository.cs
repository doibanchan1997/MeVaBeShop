using MeVaBeShop.Data.Infrastructure;
using MeVaBeShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeVaBeShop.Data.Repositories
{
    public interface IAboutRepository : IRepository<About>
    {

    }
    public class AboutRepository : RepositoryBase<About>, IAboutRepository
    {
        public AboutRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
