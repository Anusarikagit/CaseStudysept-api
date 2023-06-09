using System.ComponentModel.DataAnnotations;

namespace CaseStudysept.Models
{
    public class Tasks
    {

        [Required]

        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime TargetDate { get; set; }
        [Required]
        public TasksStatus Status { get; set; }
        [Required]
        public PriorityType Priority { get; set; }
        public string Tags { get; set; }
        public int AssignTo { get; set; }


    }
    public enum TasksStatus { YetToStart, InProgress, Closed }
    public enum PriorityType { High, Normal, Low }


}

    
