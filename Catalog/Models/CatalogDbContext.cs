using Microsoft.EntityFrameworkCore;

namespace Catalog.Models
{
    public class CatalogDbContext
    {
        public CatalogDbContext(DbContextOptions<CatalogDbContext> options) :base(options)
        {
        
        }
    }
}
