using Catalog_Management_Service.Models;

namespace Catalog_Management_Service.Repositories
{
    public interface ICatalogRepo
    {
        public List<CourseModel> GetCources();
        public void UpdateCources(CourseModel course);
        public void DeleteCources(int id);
        public void CreateCources(CourseModel course);
    }
}
