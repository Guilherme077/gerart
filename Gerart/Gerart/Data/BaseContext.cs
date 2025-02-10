using Gerart.Models;
using Microsoft.EntityFrameworkCore;
namespace Gerart.Data
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {
        }

        public DbSet<ProductModel> Products { get; set; }
    }
}
