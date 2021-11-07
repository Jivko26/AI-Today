namespace Artificial_Inteligence_Forum.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Topic
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Article> Articles { get; set; } = new List<Article>();
    }
}
