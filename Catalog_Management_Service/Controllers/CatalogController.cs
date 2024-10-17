using Catalog_Management_Service.Models;
using Catalog_Management_Service.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalog_Management_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly ICatalogRepo _repo;
        public CatalogController(ICatalogRepo repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IActionResult GetCources()
        {
            return Ok(_repo.GetCources());
        }
        [HttpPost]
        public IActionResult CreateCourse(CourseModel course)
        {
            _repo.CreateCources(course);
            return CreatedAtAction(nameof(GetCources), course);
        }
    }
}
