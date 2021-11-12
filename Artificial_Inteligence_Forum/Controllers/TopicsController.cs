namespace Artificial_Inteligence_Forum.Controllers
{
    using Artificial_Inteligence_Forum.Services.Interfaces;
    using Artificial_Inteligence_Forum.Services.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;


    [ApiController]
    [Route("[controller]")]
    public class TopicsController : ControllerBase
    {
        private readonly ITopicsService topicsService;

        public TopicsController(ITopicsService topicsService)
        {
            this.topicsService = topicsService;
        }

        [HttpGet]
        public IEnumerable<TopicServiceModel> Get()
        {
            return this.topicsService.GetTopics();
        }
    }
}
