namespace Artificial_Inteligence_Forum.DTO_s.Articles
{
    using System;
    using System.Collections.Generic;

    public class ArticleInputDTO
    {
        public int Id { get; set; }

        public string Heading { get; set; }

        public string Content { get; set; }

        public int TopicId { get; set; }

        public string UserId { get; set; }

        public int CategoryId { get; set; }

    }
}
