namespace Artificial_Inteligence_Forum.Services.Implementations
{
    using Artificial_Inteligence_Forum.Data;
    using Artificial_Inteligence_Forum.Data.Models;
    using Artificial_Inteligence_Forum.Services.Interfaces;
    using Artificial_Inteligence_Forum.Services.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ArticlesService : IArticlesService
    {
        private readonly ApplicationDbContext dbContext;

        public ArticlesService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> CreateArticleAsync(int id, string image, string heading, string content,  int topicId, int categoryId)
        {
            var article = new Article
            {
                Id = id,
                ImageURL = image,
                Heading = heading,
                Content = content,
                CreatedOn = DateTime.UtcNow,
                TopicId = topicId,
                CategoryId = categoryId,
            };

            await dbContext.Articles.AddAsync(article);
            await dbContext.SaveChangesAsync();

            return true;
        }

        public IEnumerable<ArticlesDropdownServiceModel> GetArticles() 
        {
            var articles = this.dbContext.Articles
            .Select(a => new ArticlesDropdownServiceModel
            {
                Id = a.Id,
                Heading = a.Heading,
            }).ToList();

            return articles;
        }

        public IEnumerable<RecentArticlesServiceModel> GetRecentArticles()
            => this.dbContext.Articles
            .OrderByDescending(a => a.CreatedOn)
            .Take(4)
            .Select(a => new RecentArticlesServiceModel
            {
                Id = a.Id,
                Image = a.ImageURL,
                Heading = a.Heading
            }).ToList();
    }
}
