namespace Artificial_Inteligence_Forum.DTO_s.Articles
{

    public class ArticleInputDTO
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public string Heading { get; set; }

        public string Content { get; set; }

        public int TopicId { get; set; }

        public int CategoryId { get; set; }

    }
}
