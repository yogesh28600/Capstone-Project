using Catalog_Management_Service.Models;
using Microsoft.EntityFrameworkCore;

namespace Catalog_Management_Service.Context
{
    public class CataloDbContext :DbContext
    {
        public CataloDbContext(DbContextOptions<CataloDbContext> options):base(options)
        {
            
        }
        public DbSet<CourseModel> Courses { get; set; }
    }
}
