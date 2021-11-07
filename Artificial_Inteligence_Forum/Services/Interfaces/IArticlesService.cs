namespace Artificial_Inteligence_Forum.Services.Interfaces
{
    using System;
    using System.Threading.Tasks;

    public interface IArticlesService
    {
        public Task<bool> CreateArticleAsync(int id, string heading, string content, int topicId, int categoryId, string userId);
    }
}
