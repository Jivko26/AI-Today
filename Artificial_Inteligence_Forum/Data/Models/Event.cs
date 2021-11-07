namespace Artificial_Inteligence_Forum.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Event
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

    }
}
