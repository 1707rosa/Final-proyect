using System;
using System.ComponentModel.DataAnnotations;

namespace GoalTrackingApp.Models
{
    public class Goal
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; }
    }
}
