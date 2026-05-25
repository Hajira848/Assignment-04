using System;
using System.ComponentModel.DataAnnotations;

namespace Application_08.Models
{
    public class ToDoTask
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        public bool IsCompleted { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}