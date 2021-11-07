namespace Artificial_Inteligence_Forum.Data.Seeding
{
    using Artificial_Inteligence_Forum.Data.Models;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    internal class CategorySeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            await dbContext.Categories.AddAsync(new Category
            {
                Name = "AI & Government"
            });

            await dbContext.Categories.AddAsync(new Category
            {
                Name = "AI & Society"
            });

            await dbContext.Categories.AddAsync(new Category
            {
                Name = "AI Forum News"
            });

            await dbContext.Categories.AddAsync(new Category
            {
                Name = "AI Strategy"
            });

            await dbContext.Categories.AddAsync(new Category
            {
                Name = "AI Technology"
            });

            await dbContext.Categories.AddAsync(new Category
            {
                Name = "AI Bussines and Economy"
            });

            await dbContext.Categories.AddAsync(new Category
            {
                Name = "International AI News"
            });
        }
    }
}
