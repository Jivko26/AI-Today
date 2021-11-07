namespace Artificial_Inteligence_Forum.Services.Implementations
{
    using Artificial_Inteligence_Forum.Data;
    using Artificial_Inteligence_Forum.Data.Models;
    using Artificial_Inteligence_Forum.Services.Interfaces;
    using Artificial_Inteligence_Forum.Services.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class TopicsService : ITopicsService
    {
        private readonly ApplicationDbContext data;

        public TopicsService(ApplicationDbContext dbContext)
            => this.data = dbContext;

        public Topic GetTopic(int id)
            => this.data.Topics
            .Find(id);

        public IEnumerable<TopicServiceModel> GetTopics()
            => this.data.Topics
            .Select(t => new TopicServiceModel
            {
                Id = t.Id,
                Name = t.Name,
            })
            .ToList();
    }
}
