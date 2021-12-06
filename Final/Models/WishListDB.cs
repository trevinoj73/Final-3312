using Microsoft.EntityFrameworkCore;
namespace WhislistASP.Models
{
    public class WishListDBContext : DbContext
    {
        public WishListDBContext ( DbContextOptions<WishListDBContext> options)
        : base (options)
        {

        }
        public DbSet<Wish> Wishes {get;set;}
    }
}