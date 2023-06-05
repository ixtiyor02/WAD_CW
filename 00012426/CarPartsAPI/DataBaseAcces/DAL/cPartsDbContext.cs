using Microsoft.EntityFrameworkCore;
using OnlineStoreAPI.Models;

namespace OnlineStoreAPI.DAL
{
    public class cPartsDbContext:DbContext
    {
        public cPartsDbContext(DbContextOptions<cPartsDbContext> options):base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<cPart> CPart { get; set; }
    }
}
