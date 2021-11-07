namespace Artificial_Inteligence_Forum.Services.Implementations
{
    using Artificial_Inteligence_Forum.Data;
    using Artificial_Inteligence_Forum.Data.Models;
    using Artificial_Inteligence_Forum.Services.Interfaces;
    using Artificial_Inteligence_Forum.Services.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext data;

        public CategoryService(ApplicationDbContext dbContext)
            => this.data = dbContext;

        public Category GetCategory(int id)
            => this.data.Categories
            .Where(c => c.Id == id)
            .FirstOrDefault();


        IEnumerable<CategoryServiceModel> ICategoryService.GetCategoriesAsync()
            => this.data.Categories
            .Select(c => new CategoryServiceModel
            {
                Id = c.Id,
                Name = c.Name,
            })
            .ToList();
    }
}
