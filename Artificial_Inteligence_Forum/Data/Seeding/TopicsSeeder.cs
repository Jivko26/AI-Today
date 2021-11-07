namespace Artificial_Inteligence_Forum.Data.Seeding
{
    using Artificial_Inteligence_Forum.Data.Models;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    internal class TopicsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Topics.Any())
            {
                return;
            }

            await dbContext.Topics.AddAsync(new Topic
            {
                Name = "AI Day"
            });

            await dbContext.Topics.AddAsync(new Topic
            {
                Name = "Media Release"
            });

            await dbContext.Topics.AddAsync(new Topic
            {
                Name = "Newsletter"
            });

            await dbContext.Topics.AddAsync(new Topic
            {
                Name = "Research Report"
            });
        }
    }
}
