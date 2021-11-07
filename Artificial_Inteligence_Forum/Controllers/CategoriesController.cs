namespace Artificial_Inteligence_Forum.Controllers
{
    using Artificial_Inteligence_Forum.DTO_s.Articles;
    using Artificial_Inteligence_Forum.Services.Interfaces;
    using Artificial_Inteligence_Forum.Services.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Threading.Tasks;


    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public IEnumerable<CategoryServiceModel> Get()
        {
            return this.categoryService.GetCategoriesAsync();
        }
    }
}
