using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskTime.Models
{
    public class ApplicationResponse
	{
		[Key]
        [Required]
        public int AppResponseId { get; set; }
        [Required]
        public string Task { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public int EstimateTime { get; set; }
        public int TimeSpent { get; set; }
        public int TimeLeft { get; set; }
        public string Update { get; set; }
        public string LastUpdated { get; set; }


        [Required]
        public string Quadrant { get; set; }
        public bool Completed { get; set; }

        // Build Foreign Key Relationship
        [Required]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
}
}
