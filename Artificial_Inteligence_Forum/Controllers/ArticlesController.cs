namespace Artificial_Inteligence_Forum.Controllers
{
    using Artificial_Inteligence_Forum.DTO_s.Articles;
    using Artificial_Inteligence_Forum.Services.Interfaces;
    using Artificial_Inteligence_Forum.Services.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [ApiController]
    [Route("[controller]")]
    public class ArticlesController : ControllerBase
    {
        private readonly ICategoryService categoryService;
        private readonly ITopicsService topicsService;
        private readonly IArticlesService articlesService;

        public ArticlesController(ICategoryService categoryService, ITopicsService topicsService, IArticlesService articlesService)
        {
            this.categoryService = categoryService;
            this.topicsService = topicsService;
            this.articlesService = articlesService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ArticleInputDTO article)
        {
            if (this.categoryService.GetCategory(article.CategoryId) == null)
            {
                this.ModelState.AddModelError(nameof(article.CategoryId), "This category does not exist.");
            }

            if (this.topicsService.GetTopic(article.TopicId) == null)
            {
                this.ModelState.AddModelError(nameof(article.TopicId), "This topic does not exist.");
            }

            var result = await this.articlesService.CreateArticleAsync(article.Id, article.ImageUrl, article.Heading, article.Content, article.TopicId, article.CategoryId);

            if (result)
            {
                return this.StatusCode(201);
            }

            return this.BadRequest();
        }

        [HttpGet]
        [Route("articlesDropdown")]
        public IEnumerable<ArticlesDropdownServiceModel> GetArticlesDropdown() 
        {
            var articles = this.articlesService.GetArticles();

            return articles;
        }

        [HttpGet]
        [Route("recentArticles")]
        public IEnumerable<RecentArticlesServiceModel> GetRecentArticles()
        {
            var articles = this.articlesService.GetRecentArticles();

            return articles;
        }
    }
}
