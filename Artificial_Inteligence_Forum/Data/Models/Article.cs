namespace Artificial_Inteligence_Forum.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Article
    {
        public int Id { get; set; }

        [Required]
        public string ImageURL { get; set; }

        [Required]
        public string Heading { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int TopicId { get; set; }

        public Topic Topic { get; set; }
    }
}
