namespace Artificial_Inteligence_Forum.Services.Interfaces
{
    using Artificial_Inteligence_Forum.Services.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IArticlesService
    {
        public Task<bool> CreateArticleAsync(int id, string image, string heading, string content, int topicId, int categoryId);

        public IEnumerable<ArticlesDropdownServiceModel> GetArticles();

        public IEnumerable<RecentArticlesServiceModel> GetRecentArticles();
    }
}
