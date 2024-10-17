using Catalog_Management_Service.Context;
using Catalog_Management_Service.Models;

namespace Catalog_Management_Service.Repositories
{
    public class CatalogRepo : ICatalogRepo
    {
        private readonly CataloDbContext _context;
        public CatalogRepo(CataloDbContext context)
        {
            _context = context;
        }
        public void CreateCources(CourseModel course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public void DeleteCources(int id)
        {
            throw new NotImplementedException();
        }

        public List<CourseModel> GetCources()
        {
            return _context.Courses.ToList();
        }

        public void UpdateCources(CourseModel course)
        {
            throw new NotImplementedException();
        }
    }
}
