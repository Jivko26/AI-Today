namespace Artificial_Inteligence_Forum.Services.Interfaces
{
    using Artificial_Inteligence_Forum.Data.Models;
    using Artificial_Inteligence_Forum.Services.Models;

    using System.Collections.Generic;

    public interface ITopicsService
    {
        Topic GetTopic(int id);
        IEnumerable<TopicServiceModel> GetTopics();
    }
}
