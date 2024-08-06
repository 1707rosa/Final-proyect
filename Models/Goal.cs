using System;
using System.ComponentModel.DataAnnotations;

namespace GoalTrackingApp.Models
{
    public class Goal
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public GoalStatus Status { get; set; }
    }

    public enum GoalStatus
    {
        Iniciada,
        EnProceso,
        Completada
    }
}
