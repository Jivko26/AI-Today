namespace Artificial_Inteligence_Forum.Services.Implementations
{
    using Artificial_Inteligence_Forum.Data;
    using Artificial_Inteligence_Forum.Data.Models;
    using Artificial_Inteligence_Forum.Services.Interfaces;
    using System;
    using System.Threading.Tasks;

    public class ArticlesService : IArticlesService
    {
        private readonly ApplicationDbContext dbContext;

        public ArticlesService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> CreateArticleAsync(int id, string heading, string content,  int topicId, int categoryId, string userId)
        {
            var article = new Article
            {
                Id = id,
                Heading = heading,
                Content = content,
                CreatedOn = DateTime.UtcNow,
                TopicId = topicId,
                CategoryId = categoryId,
                AuthorId = userId,
            };

            await dbContext.Articles.AddAsync(article);
            await dbContext.SaveChangesAsync();

            return true;
        }
    }
}
